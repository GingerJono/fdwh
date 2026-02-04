-- =============================================
-- Add Currency Split Selection Feature
-- Adds Plan/Written/Signed split columns and SplitSelection to Ultimates.Premium table
-- =============================================

-- =============================================
-- 1. Add new columns to Ultimates.Premium table
-- =============================================
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'SplitSelection')
BEGIN
    ALTER TABLE Ultimates.Premium ADD SplitSelection VARCHAR(20) NULL DEFAULT 'Manual';
    PRINT 'Added SplitSelection column';
END
GO

-- Plan Split Columns
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'PlanSplitGBP')
BEGIN
    ALTER TABLE Ultimates.Premium ADD PlanSplitGBP DECIMAL(18,4) NULL;
    PRINT 'Added PlanSplitGBP column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'PlanSplitUSD')
BEGIN
    ALTER TABLE Ultimates.Premium ADD PlanSplitUSD DECIMAL(18,4) NULL;
    PRINT 'Added PlanSplitUSD column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'PlanSplitCAD')
BEGIN
    ALTER TABLE Ultimates.Premium ADD PlanSplitCAD DECIMAL(18,4) NULL;
    PRINT 'Added PlanSplitCAD column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'PlanSplitEUR')
BEGIN
    ALTER TABLE Ultimates.Premium ADD PlanSplitEUR DECIMAL(18,4) NULL;
    PRINT 'Added PlanSplitEUR column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'PlanSplitJPY')
BEGIN
    ALTER TABLE Ultimates.Premium ADD PlanSplitJPY DECIMAL(18,4) NULL;
    PRINT 'Added PlanSplitJPY column';
END
GO

-- Written Split Columns
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'WrittenSplitGBP')
BEGIN
    ALTER TABLE Ultimates.Premium ADD WrittenSplitGBP DECIMAL(18,4) NULL;
    PRINT 'Added WrittenSplitGBP column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'WrittenSplitUSD')
BEGIN
    ALTER TABLE Ultimates.Premium ADD WrittenSplitUSD DECIMAL(18,4) NULL;
    PRINT 'Added WrittenSplitUSD column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'WrittenSplitCAD')
BEGIN
    ALTER TABLE Ultimates.Premium ADD WrittenSplitCAD DECIMAL(18,4) NULL;
    PRINT 'Added WrittenSplitCAD column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'WrittenSplitEUR')
BEGIN
    ALTER TABLE Ultimates.Premium ADD WrittenSplitEUR DECIMAL(18,4) NULL;
    PRINT 'Added WrittenSplitEUR column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'WrittenSplitJPY')
BEGIN
    ALTER TABLE Ultimates.Premium ADD WrittenSplitJPY DECIMAL(18,4) NULL;
    PRINT 'Added WrittenSplitJPY column';
END
GO

-- Signed Split Columns
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'SignedSplitGBP')
BEGIN
    ALTER TABLE Ultimates.Premium ADD SignedSplitGBP DECIMAL(18,4) NULL;
    PRINT 'Added SignedSplitGBP column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'SignedSplitUSD')
BEGIN
    ALTER TABLE Ultimates.Premium ADD SignedSplitUSD DECIMAL(18,4) NULL;
    PRINT 'Added SignedSplitUSD column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'SignedSplitCAD')
BEGIN
    ALTER TABLE Ultimates.Premium ADD SignedSplitCAD DECIMAL(18,4) NULL;
    PRINT 'Added SignedSplitCAD column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'SignedSplitEUR')
BEGIN
    ALTER TABLE Ultimates.Premium ADD SignedSplitEUR DECIMAL(18,4) NULL;
    PRINT 'Added SignedSplitEUR column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'SignedSplitJPY')
BEGIN
    ALTER TABLE Ultimates.Premium ADD SignedSplitJPY DECIMAL(18,4) NULL;
    PRINT 'Added SignedSplitJPY column';
END
GO

-- =============================================
-- 2. Update spGetLatestUltimatePremiumByClassRsvClassYOA to return new columns
-- =============================================
CREATE OR ALTER PROCEDURE [Ultimates].[spGetLatestUltimatePremiumByClassRsvClassYOA]
    @Class VARCHAR(50),
    @ReservingClass VARCHAR(50),
    @YOA INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 1
        Class,
        ReservingClass,
        YOA,
        Version,
        Selection,
        GrossNetEntry,
        ManualGrossPremiumGBP,
        ManualNetPremiumGBP,
        ManualDeductions,
        ManualSplitGBP,
        ManualSplitUSD,
        ManualSplitCAD,
        ManualSplitEUR,
        ManualSplitJPY,
        ManualEUSplit,
        -- New Split Selection
        ISNULL(SplitSelection, 'Manual') AS SplitSelection,
        -- Plan Splits
        PlanSplitGBP,
        PlanSplitUSD,
        PlanSplitCAD,
        PlanSplitEUR,
        PlanSplitJPY,
        -- Written Splits
        WrittenSplitGBP,
        WrittenSplitUSD,
        WrittenSplitCAD,
        WrittenSplitEUR,
        WrittenSplitJPY,
        -- Signed Splits
        SignedSplitGBP,
        SignedSplitUSD,
        SignedSplitCAD,
        SignedSplitEUR,
        SignedSplitJPY,
        -- Audit
        DateUpdated,
        UpdatedBy,
        UpdateComments
    FROM Ultimates.Premium
    WHERE Class = @Class
      AND ReservingClass = @ReservingClass
      AND YOA = @YOA
    ORDER BY Version DESC;
END
GO

-- =============================================
-- 3. Update spUpsertUltimatePremium to handle new columns
-- =============================================
CREATE OR ALTER PROCEDURE [Ultimates].[spUpsertUltimatePremium]
    @Class VARCHAR(50),
    @ReservingClass VARCHAR(50),
    @YOA INT,
    @Version INT,
    @Selection VARCHAR(20),
    @GrossNetEntry VARCHAR(20),
    @UpdatedBy VARCHAR(100),
    @UpdateComments VARCHAR(MAX) = NULL,
    @ManualGrossPremiumGBP DECIMAL(18,4) = NULL,
    @ManualNetPremiumGBP DECIMAL(18,4) = NULL,
    @ManualDeductions DECIMAL(18,4) = NULL,
    @ManualSplitGBP DECIMAL(18,4) = NULL,
    @ManualSplitUSD DECIMAL(18,4) = NULL,
    @ManualSplitCAD DECIMAL(18,4) = NULL,
    @ManualSplitEUR DECIMAL(18,4) = NULL,
    @ManualSplitJPY DECIMAL(18,4) = NULL,
    @ManualEUSplit DECIMAL(18,4) = NULL,
    -- New Split Selection parameter
    @SplitSelection VARCHAR(20) = 'Manual',
    -- Plan Splits
    @PlanSplitGBP DECIMAL(18,4) = NULL,
    @PlanSplitUSD DECIMAL(18,4) = NULL,
    @PlanSplitCAD DECIMAL(18,4) = NULL,
    @PlanSplitEUR DECIMAL(18,4) = NULL,
    @PlanSplitJPY DECIMAL(18,4) = NULL,
    -- Written Splits
    @WrittenSplitGBP DECIMAL(18,4) = NULL,
    @WrittenSplitUSD DECIMAL(18,4) = NULL,
    @WrittenSplitCAD DECIMAL(18,4) = NULL,
    @WrittenSplitEUR DECIMAL(18,4) = NULL,
    @WrittenSplitJPY DECIMAL(18,4) = NULL,
    -- Signed Splits
    @SignedSplitGBP DECIMAL(18,4) = NULL,
    @SignedSplitUSD DECIMAL(18,4) = NULL,
    @SignedSplitCAD DECIMAL(18,4) = NULL,
    @SignedSplitEUR DECIMAL(18,4) = NULL,
    @SignedSplitJPY DECIMAL(18,4) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Ultimates.Premium (
        Class,
        ReservingClass,
        YOA,
        Version,
        Selection,
        GrossNetEntry,
        ManualGrossPremiumGBP,
        ManualNetPremiumGBP,
        ManualDeductions,
        ManualSplitGBP,
        ManualSplitUSD,
        ManualSplitCAD,
        ManualSplitEUR,
        ManualSplitJPY,
        ManualEUSplit,
        SplitSelection,
        PlanSplitGBP,
        PlanSplitUSD,
        PlanSplitCAD,
        PlanSplitEUR,
        PlanSplitJPY,
        WrittenSplitGBP,
        WrittenSplitUSD,
        WrittenSplitCAD,
        WrittenSplitEUR,
        WrittenSplitJPY,
        SignedSplitGBP,
        SignedSplitUSD,
        SignedSplitCAD,
        SignedSplitEUR,
        SignedSplitJPY,
        DateUpdated,
        UpdatedBy,
        UpdateComments
    )
    VALUES (
        @Class,
        @ReservingClass,
        @YOA,
        @Version,
        @Selection,
        @GrossNetEntry,
        @ManualGrossPremiumGBP,
        @ManualNetPremiumGBP,
        @ManualDeductions,
        @ManualSplitGBP,
        @ManualSplitUSD,
        @ManualSplitCAD,
        @ManualSplitEUR,
        @ManualSplitJPY,
        @ManualEUSplit,
        @SplitSelection,
        @PlanSplitGBP,
        @PlanSplitUSD,
        @PlanSplitCAD,
        @PlanSplitEUR,
        @PlanSplitJPY,
        @WrittenSplitGBP,
        @WrittenSplitUSD,
        @WrittenSplitCAD,
        @WrittenSplitEUR,
        @WrittenSplitJPY,
        @SignedSplitGBP,
        @SignedSplitUSD,
        @SignedSplitCAD,
        @SignedSplitEUR,
        @SignedSplitJPY,
        GETUTCDATE(),
        @UpdatedBy,
        @UpdateComments
    );
END
GO

-- =============================================
-- 4. Update spGetLatestUltimatePremium (list view) to return new columns
-- =============================================
CREATE OR ALTER PROCEDURE [Ultimates].[spGetLatestUltimatePremium]
AS
BEGIN
    SET NOCOUNT ON;

    WITH LatestVersions AS (
        SELECT
            Class,
            ReservingClass,
            YOA,
            MAX(Version) AS LatestVersion
        FROM Ultimates.Premium
        GROUP BY Class, ReservingClass, YOA
    )
    SELECT
        p.Class,
        p.ReservingClass,
        p.YOA,
        p.Version,
        p.Selection,
        p.GrossNetEntry,
        p.DateUpdated,
        p.UpdatedBy,
        p.UpdateComments,
        ISNULL(p.SplitSelection, 'Manual') AS SplitSelection
    FROM Ultimates.Premium p
    INNER JOIN LatestVersions lv
        ON p.Class = lv.Class
        AND p.ReservingClass = lv.ReservingClass
        AND p.YOA = lv.YOA
        AND p.Version = lv.LatestVersion
    ORDER BY p.Class, p.ReservingClass, p.YOA DESC;
END
GO

PRINT 'Currency Split Selection feature database changes completed successfully.';
GO
