-- Windowpane NOCs (Notice of Cancellations) Stored Procedure
-- This procedure retrieves a list of policies with outstanding premiums
-- that are approaching or past their settlement due date

CREATE PROC [Windowpane].[spNOCList]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ProcessingMonth BIGINT = (SELECT MAX(Processing_Month) FROM reporting.Policy_Full_As_At)

    DROP TABLE IF EXISTS #Pols
    SELECT pfa.Policy_Reference,
           pfa.Assured_Name,
           pfa.Line_Underwriter_Initials,
           pfa.Policy_Status_Description,
           pfa.Inception_Date,
           pfa.Settlement_Due_Date,
           pfa.EPI_Settlement_Currency,
           pfa.Actual_Estimated_Premium,
           pfa.Broking_Company_Name,
           pfa.Broker_Contact_Name
    INTO #Pols
    FROM reporting.Policy_Full_As_At pfa
    WHERE pfa.Processing_Month = @ProcessingMonth
      AND pfa.class = 'PL'
      AND pfa.Line_Status_Code IN ('S','L','U','I','C')

    DROP TABLE IF EXISTS #USMs
    SELECT *
    INTO #USMs
    FROM reporting.USM_As_At ua
    WHERE ua.Underwriting_Reference IN (SELECT Policy_Reference FROM #Pols)
      AND ua.Processing_Month = 202512

    DROP TABLE IF EXISTS #PolsWithUSMs
    SELECT *,
           USMPremPremCcy = ISNULL((SELECT SUM(u.USMPrem) FROM #USMs u WHERE u.Underwriting_Reference = p.policy_reference AND u.Sett_Ccy = p.EPI_Settlement_Currency ),0),
           USMPremOtherCcy = ISNULL((SELECT SUM(u.USMPrem) FROM #USMs u WHERE u.Underwriting_Reference = p.policy_reference AND u.Sett_Ccy <> p.EPI_Settlement_Currency),0)
    INTO #PolsWithUSMs
    FROM #Pols p

    SELECT *
    FROM #PolsWithUSMs
    WHERE USMPremPremCcy + USMPremOtherCcy < 100
      AND Settlement_Due_Date < DATEADD(DAY,30,GETDATE())
    ORDER BY Settlement_Due_Date ASC
END
GO
