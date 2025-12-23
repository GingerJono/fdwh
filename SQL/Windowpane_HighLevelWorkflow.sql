-- Windowpane High-Level Workflow Stored Procedure
-- This procedure retrieves a comprehensive policy listing with status indicators
-- for various workflow stages (Technical Premium, Rate, Consortium, Companion, Settlement)

CREATE PROC [Windowpane].[spHighLevelWorkflow]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ProcessingMonth BIGINT = (SELECT MAX(Processing_Month) FROM dale_reporting.reporting.Policy_Full_As_At)

    DROP TABLE IF EXISTS #USMs
    SELECT *
    INTO #USMs
    FROM dale_reporting.reporting.USM_As_At ua
    WHERE ua.Processing_Month = @ProcessingMonth

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
           ISNULL((SELECT SUM(u.USMPrem) FROM #USMs u WHERE u.Underwriting_Reference = pfa.Policy_Reference), 0) AS USMPrem,
           (SELECT TOP 1 rim.RISK_ID
            FROM Dale_Ndex_SideLoad.sideload.RiskIdMap rim
            WHERE pfa.ProgReference = rim.PROGRAMME
            ORDER BY rim.RISK_ID DESC) AS RiskID,
           pfa.Class,
           pfa.Year_Of_Account
    INTO #Pols
    FROM dale_reporting.reporting.Policy_Full_As_At pfa
    LEFT OUTER JOIN Dale_Reporting.reporting.Policy_Companion comp
        ON pfa.Line_Id = comp.Line_ID AND pfa.Processing_Month = comp.ProcessingMonth
    WHERE pfa.Processing_Month = @ProcessingMonth
      AND pfa.Line_Status_Code IN ('S','L','U','I','C')

    SELECT *
    FROM #Pols p
    ORDER BY p.Inception_Date DESC
END
GO
