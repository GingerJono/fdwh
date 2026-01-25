USE [Dale_Sandbox]
GO

-- =========================================================
-- spUpsertUltimatePremium (Updated with Manual Entry Fields)
-- (insert-only by design)
-- =========================================================
ALTER PROCEDURE [Ultimates].[spUpsertUltimatePremium]
    @Class          VARCHAR(20),
    @ReservingClass VARCHAR(20),
    @YOA            INT,
    @Version        INT,

    @Selection      VARCHAR(10),
    @GrossNetEntry  VARCHAR(5),

    @UpdatedBy      VARCHAR(100),
    @UpdateComments VARCHAR(500) = NULL,

    -- Manual Entry Fields (GBP values)
    @ManualGrossPremiumGBP DECIMAL(17,2) = NULL,
    @ManualNetPremiumGBP   DECIMAL(17,2) = NULL,
    @ManualDeductions      DECIMAL(9,6)  = NULL,

    -- Currency Split Percentages
    @ManualSplitGBP DECIMAL(9,6) = NULL,
    @ManualSplitUSD DECIMAL(9,6) = NULL,
    @ManualSplitCAD DECIMAL(9,6) = NULL,
    @ManualSplitEUR DECIMAL(9,6) = NULL,
    @ManualSplitJPY DECIMAL(9,6) = NULL
AS
BEGIN
    SET NOCOUNT ON

    INSERT INTO Ultimates.Premium
    (
        Class,
        ReservingClass,
        YOA,
        Version,
        Selection,
        GrossNetEntry,
        DateUpdated,
        UpdatedBy,
        UpdateComments,
        ManualGrossPremiumGBP,
        ManualNetPremiumGBP,
        ManualDeductions,
        ManualSplitGBP,
        ManualSplitUSD,
        ManualSplitCAD,
        ManualSplitEUR,
        ManualSplitJPY
    )
    VALUES
    (
        @Class,
        @ReservingClass,
        @YOA,
        @Version,
        @Selection,
        @GrossNetEntry,
        SYSUTCDATETIME(),
        @UpdatedBy,
        @UpdateComments,
        @ManualGrossPremiumGBP,
        @ManualNetPremiumGBP,
        @ManualDeductions,
        @ManualSplitGBP,
        @ManualSplitUSD,
        @ManualSplitCAD,
        @ManualSplitEUR,
        @ManualSplitJPY
    )
END
GO

-- =========================================================
-- SQL to add Manual Entry columns to Ultimates.Premium table
-- Run this FIRST before executing the ALTER PROCEDURE above
-- =========================================================

/*
ALTER TABLE Ultimates.Premium
ADD
    ManualGrossPremiumGBP DECIMAL(17,2) NULL,
    ManualNetPremiumGBP   DECIMAL(17,2) NULL,
    ManualDeductions      DECIMAL(9,6)  NULL,
    ManualSplitGBP        DECIMAL(9,6)  NULL,
    ManualSplitUSD        DECIMAL(9,6)  NULL,
    ManualSplitCAD        DECIMAL(9,6)  NULL,
    ManualSplitEUR        DECIMAL(9,6)  NULL,
    ManualSplitJPY        DECIMAL(9,6)  NULL;
*/
