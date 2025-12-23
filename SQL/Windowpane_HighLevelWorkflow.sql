-- Windowpane High-Level Workflow Stored Procedure
-- This procedure retrieves a comprehensive policy listing with status indicators
-- for various workflow stages filtered by Inception Month and Class

ALTER PROC [Windowpane].[spHighLevelWorkflow]
    @InceptionMonth DATE,
    @Class          NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ProcessingMonth BIGINT = (
        SELECT MAX(Processing_Month)
        FROM dale_reporting.reporting.Policy_Full_As_At
    )

    DROP TABLE IF EXISTS #Pols
    SELECT pfa.Policy_Reference,
           pfa.Assured_Name,
           pfa.Line_Underwriter_Initials,
           pfa.Inception_Date,
           pfa.Expiry_Date,
           pfa.EPI_Settlement_Currency,
           pfa.Actual_Estimated_Premium,
           pfa.Broker_Pseudonym,
           pfa.Broker_Number,
           pfa.Broking_Company_Name,
           pfa.Broker_Contact_Name,
           pfa.Renewed_From_Line_Id,
           pfa.Reporting_Line_Percent,
           pfa.Limit_Currency,
           pfa.Limit,
           pfa.Excess,
           pfa.Policy_Status_Description,
           pfa.Technical_Premium_Percent,
           pfa.Rate_Pct_Gross,
           pfa.Consortium_Code,
           pfa.Consortium_Line_Percent,
           comp.Companion_Name,
           comp.Written_Line_Pct,
           comp.Signed_Line_Pct,
           pfa.Settlement_Due_Date,
           0 AS USMPrem,
           0 AS RiskID,
           pfa.ProgReference
    INTO #Pols
    FROM dale_reporting.reporting.Policy_Full_As_At pfa
    LEFT OUTER JOIN Dale_Reporting.reporting.Policy_Companion comp
        ON pfa.Line_Id = comp.Line_ID
       AND pfa.Processing_Month = comp.ProcessingMonth
    WHERE pfa.Processing_Month = @ProcessingMonth
      AND pfa.Line_Status_Code IN ('S','L','U','I','C')
      AND DATEFROMPARTS(YEAR(pfa.Inception_Date), MONTH(pfa.Inception_Date), 1) = @InceptionMonth
      AND pfa.Class = @Class

    ----------------------------------------------------------------
    -- USMPrem update
    ----------------------------------------------------------------
    UPDATE p
    SET p.USMPrem = u.TotalUSMPrem
    FROM #Pols p
    INNER JOIN (
        SELECT ua.Underwriting_Reference,
               SUM(ua.USMPrem) AS TotalUSMPrem
        FROM dale_reporting.reporting.USM_As_At ua
        WHERE ua.Processing_Month = @ProcessingMonth
        GROUP BY ua.Underwriting_Reference
    ) u ON u.Underwriting_Reference = p.Policy_Reference

    ----------------------------------------------------------------
    -- RiskID update
    ----------------------------------------------------------------
    UPDATE p
    SET p.RiskID = r.RiskID
    FROM #Pols p
    INNER JOIN (
        SELECT PROGRAMME,
               MAX(RISK_ID) AS RiskID
        FROM Dale_Ndex_SideLoad_UAT.sideload.RiskIdMap
        GROUP BY PROGRAMME
    ) r ON r.PROGRAMME = p.ProgReference

    SELECT *
    FROM #Pols
    ORDER BY Policy_Reference
END
GO
