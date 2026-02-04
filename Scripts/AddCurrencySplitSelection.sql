-- =============================================
-- Add Currency Split Selection Feature (CORRECTED)
-- Split percentages are stored per-currency in PremiumCcy table
-- SplitSelection stored in Premium table
-- =============================================

-- =============================================
-- 1. Add SplitSelection column to Ultimates.Premium table
-- =============================================
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'SplitSelection')
BEGIN
    ALTER TABLE Ultimates.Premium ADD SplitSelection VARCHAR(20) NULL DEFAULT 'Manual';
    PRINT 'Added SplitSelection column to Premium table';
END
GO

-- =============================================
-- 2. Add Split columns to Ultimates.PremiumCcy table
-- =============================================
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SelectedSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD SelectedSplit DECIMAL(18,4) NULL;
    PRINT 'Added SelectedSplit column to PremiumCcy table';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'ManualSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD ManualSplit DECIMAL(18,4) NULL;
    PRINT 'Added ManualSplit column to PremiumCcy table';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'PlanSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD PlanSplit DECIMAL(18,4) NULL;
    PRINT 'Added PlanSplit column to PremiumCcy table';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'WrittenSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD WrittenSplit DECIMAL(18,4) NULL;
    PRINT 'Added WrittenSplit column to PremiumCcy table';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SignedSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD SignedSplit DECIMAL(18,4) NULL;
    PRINT 'Added SignedSplit column to PremiumCcy table';
END
GO

-- =============================================
-- 3. Update spGetLatestUltimatePremiumByClassRsvClassYOA
--    Returns Premium record with SplitSelection
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
        ManualEUSplit,
        ISNULL(SplitSelection, 'Manual') AS SplitSelection,
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
-- 4. Update spUpsertUltimatePremium
--    Saves Premium record with SplitSelection
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
    @ManualEUSplit DECIMAL(18,4) = NULL,
    @SplitSelection VARCHAR(20) = 'Manual'
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
        ManualEUSplit,
        SplitSelection,
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
        @ManualEUSplit,
        @SplitSelection,
        GETUTCDATE(),
        @UpdatedBy,
        @UpdateComments
    );
END
GO

-- =============================================
-- 5. Update spGetLatestUltimatePremium (list view)
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

-- =============================================
-- 6. Update spUpsertUltimatePremiumCurrency
--    Now includes Split columns
-- =============================================
CREATE OR ALTER PROCEDURE [Ultimates].[spUpsertUltimatePremiumCurrency]
    @Class VARCHAR(50),
    @ReservingClass VARCHAR(50),
    @YOA INT,
    @Version INT,
    @Currency VARCHAR(10),
    -- Selected
    @SelectedGGWP DECIMAL(18,4) = NULL,
    @SelectedDeductions DECIMAL(18,4) = NULL,
    @SelectedGNWP DECIMAL(18,4) = NULL,
    @SelectedEU DECIMAL(18,4) = NULL,
    @SelectedSplit DECIMAL(18,4) = NULL,
    -- Manual
    @ManualGGWP DECIMAL(18,4) = NULL,
    @ManualDeductions DECIMAL(18,4) = NULL,
    @ManualGNWP DECIMAL(18,4) = NULL,
    @ManualEU DECIMAL(18,4) = NULL,
    @ManualSplit DECIMAL(18,4) = NULL,
    -- Plan
    @PlanGGWP DECIMAL(18,4) = NULL,
    @PlanDeductions DECIMAL(18,4) = NULL,
    @PlanGNWP DECIMAL(18,4) = NULL,
    @PlanEU DECIMAL(18,4) = NULL,
    @PlanSplit DECIMAL(18,4) = NULL,
    -- Written
    @WrittenGGWP DECIMAL(18,4) = NULL,
    @WrittenDeductions DECIMAL(18,4) = NULL,
    @WrittenGNWP DECIMAL(18,4) = NULL,
    @WrittenEU DECIMAL(18,4) = NULL,
    @WrittenSplit DECIMAL(18,4) = NULL,
    -- Signed
    @SignedGGWP DECIMAL(18,4) = NULL,
    @SignedDeductions DECIMAL(18,4) = NULL,
    @SignedGNWP DECIMAL(18,4) = NULL,
    @SignedEU DECIMAL(18,4) = NULL,
    @SignedSplit DECIMAL(18,4) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if record exists
    IF EXISTS (
        SELECT 1 FROM Ultimates.PremiumCcy
        WHERE Class = @Class
          AND ReservingClass = @ReservingClass
          AND YOA = @YOA
          AND Version = @Version
          AND Currency = @Currency
    )
    BEGIN
        -- Update existing record
        UPDATE Ultimates.PremiumCcy
        SET
            SelectedGGWP = @SelectedGGWP,
            SelectedDeductions = @SelectedDeductions,
            SelectedGNWP = @SelectedGNWP,
            SelectedEU = @SelectedEU,
            SelectedSplit = @SelectedSplit,
            ManualGGWP = @ManualGGWP,
            ManualDeductions = @ManualDeductions,
            ManualGNWP = @ManualGNWP,
            ManualEU = @ManualEU,
            ManualSplit = @ManualSplit,
            PlanGGWP = @PlanGGWP,
            PlanDeductions = @PlanDeductions,
            PlanGNWP = @PlanGNWP,
            PlanEU = @PlanEU,
            PlanSplit = @PlanSplit,
            WrittenGGWP = @WrittenGGWP,
            WrittenDeductions = @WrittenDeductions,
            WrittenGNWP = @WrittenGNWP,
            WrittenEU = @WrittenEU,
            WrittenSplit = @WrittenSplit,
            SignedGGWP = @SignedGGWP,
            SignedDeductions = @SignedDeductions,
            SignedGNWP = @SignedGNWP,
            SignedEU = @SignedEU,
            SignedSplit = @SignedSplit
        WHERE Class = @Class
          AND ReservingClass = @ReservingClass
          AND YOA = @YOA
          AND Version = @Version
          AND Currency = @Currency;
    END
    ELSE
    BEGIN
        -- Insert new record
        INSERT INTO Ultimates.PremiumCcy (
            Class,
            ReservingClass,
            YOA,
            Version,
            Currency,
            SelectedGGWP,
            SelectedDeductions,
            SelectedGNWP,
            SelectedEU,
            SelectedSplit,
            ManualGGWP,
            ManualDeductions,
            ManualGNWP,
            ManualEU,
            ManualSplit,
            PlanGGWP,
            PlanDeductions,
            PlanGNWP,
            PlanEU,
            PlanSplit,
            WrittenGGWP,
            WrittenDeductions,
            WrittenGNWP,
            WrittenEU,
            WrittenSplit,
            SignedGGWP,
            SignedDeductions,
            SignedGNWP,
            SignedEU,
            SignedSplit
        )
        VALUES (
            @Class,
            @ReservingClass,
            @YOA,
            @Version,
            @Currency,
            @SelectedGGWP,
            @SelectedDeductions,
            @SelectedGNWP,
            @SelectedEU,
            @SelectedSplit,
            @ManualGGWP,
            @ManualDeductions,
            @ManualGNWP,
            @ManualEU,
            @ManualSplit,
            @PlanGGWP,
            @PlanDeductions,
            @PlanGNWP,
            @PlanEU,
            @PlanSplit,
            @WrittenGGWP,
            @WrittenDeductions,
            @WrittenGNWP,
            @WrittenEU,
            @WrittenSplit,
            @SignedGGWP,
            @SignedDeductions,
            @SignedGNWP,
            @SignedEU,
            @SignedSplit
        );
    END
END
GO

-- =============================================
-- 7. Create/Update procedure to get PremiumCcy records
-- =============================================
CREATE OR ALTER PROCEDURE [Ultimates].[spGetPremiumCcy]
    @Class VARCHAR(50),
    @ReservingClass VARCHAR(50),
    @YOA INT,
    @Version INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Class,
        ReservingClass,
        YOA,
        Version,
        Currency,
        -- Selected
        SelectedGGWP,
        SelectedDeductions,
        SelectedGNWP,
        SelectedEU,
        ISNULL(SelectedSplit, 0) AS SelectedSplit,
        -- Manual
        ManualGGWP,
        ManualDeductions,
        ManualGNWP,
        ManualEU,
        ISNULL(ManualSplit, 0) AS ManualSplit,
        -- Plan
        PlanGGWP,
        PlanDeductions,
        PlanGNWP,
        PlanEU,
        ISNULL(PlanSplit, 0) AS PlanSplit,
        -- Written
        WrittenGGWP,
        WrittenDeductions,
        WrittenGNWP,
        WrittenEU,
        ISNULL(WrittenSplit, 0) AS WrittenSplit,
        -- Signed
        SignedGGWP,
        SignedDeductions,
        SignedGNWP,
        SignedEU,
        ISNULL(SignedSplit, 0) AS SignedSplit
    FROM Ultimates.PremiumCcy
    WHERE Class = @Class
      AND ReservingClass = @ReservingClass
      AND YOA = @YOA
      AND Version = @Version
    ORDER BY Currency;
END
GO

PRINT 'Currency Split Selection feature database changes completed successfully.';
GO
