-- =============================================
-- Currency Split and EU Split Feature
-- Renames columns for clarity and adds EU split selection
-- =============================================

-- =============================================
-- PART 1: PREMIUM TABLE CHANGES
-- =============================================

-- 1a. Rename SplitSelection to CcySplitSelection
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'SplitSelection')
   AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'CcySplitSelection')
BEGIN
    EXEC sp_rename 'Ultimates.Premium.SplitSelection', 'CcySplitSelection', 'COLUMN';
    PRINT 'Renamed SplitSelection to CcySplitSelection in Premium table';
END
GO

-- 1b. Add CcySplitSelection if it doesn't exist (for fresh installs)
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'CcySplitSelection')
BEGIN
    ALTER TABLE Ultimates.Premium ADD CcySplitSelection VARCHAR(20) NULL DEFAULT 'Manual';
    PRINT 'Added CcySplitSelection column to Premium table';
END
GO

-- 1c. Add EUSplitSelection column
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.Premium') AND name = 'EUSplitSelection')
BEGIN
    ALTER TABLE Ultimates.Premium ADD EUSplitSelection VARCHAR(20) NULL DEFAULT 'Manual';
    PRINT 'Added EUSplitSelection column to Premium table';
END
GO

-- 1d. ManualEUSplit is now obsolete at Premium level (handled per currency)
-- We'll leave it for backwards compatibility but it won't be used

-- =============================================
-- PART 2: PREMIUMCCY TABLE - RENAME EXISTING SPLIT COLUMNS
-- =============================================

-- 2a. Rename SelectedSplit to SelectedCcySplit
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SelectedSplit')
   AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SelectedCcySplit')
BEGIN
    EXEC sp_rename 'Ultimates.PremiumCcy.SelectedSplit', 'SelectedCcySplit', 'COLUMN';
    PRINT 'Renamed SelectedSplit to SelectedCcySplit';
END
GO

-- 2b. Rename ManualSplit to ManualCcySplit
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'ManualSplit')
   AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'ManualCcySplit')
BEGIN
    EXEC sp_rename 'Ultimates.PremiumCcy.ManualSplit', 'ManualCcySplit', 'COLUMN';
    PRINT 'Renamed ManualSplit to ManualCcySplit';
END
GO

-- 2c. Rename PlanSplit to PlanCcySplit
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'PlanSplit')
   AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'PlanCcySplit')
BEGIN
    EXEC sp_rename 'Ultimates.PremiumCcy.PlanSplit', 'PlanCcySplit', 'COLUMN';
    PRINT 'Renamed PlanSplit to PlanCcySplit';
END
GO

-- 2d. Rename WrittenSplit to WrittenCcySplit
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'WrittenSplit')
   AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'WrittenCcySplit')
BEGIN
    EXEC sp_rename 'Ultimates.PremiumCcy.WrittenSplit', 'WrittenCcySplit', 'COLUMN';
    PRINT 'Renamed WrittenSplit to WrittenCcySplit';
END
GO

-- 2e. Rename SignedSplit to SignedCcySplit
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SignedSplit')
   AND NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SignedCcySplit')
BEGIN
    EXEC sp_rename 'Ultimates.PremiumCcy.SignedSplit', 'SignedCcySplit', 'COLUMN';
    PRINT 'Renamed SignedSplit to SignedCcySplit';
END
GO

-- =============================================
-- PART 3: PREMIUMCCY TABLE - ADD NEW COLUMNS (for fresh installs)
-- =============================================

-- CcySplit columns (if they don't exist)
IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SelectedCcySplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD SelectedCcySplit DECIMAL(18,4) NULL;
    PRINT 'Added SelectedCcySplit column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'ManualCcySplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD ManualCcySplit DECIMAL(18,4) NULL;
    PRINT 'Added ManualCcySplit column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'PlanCcySplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD PlanCcySplit DECIMAL(18,4) NULL;
    PRINT 'Added PlanCcySplit column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'WrittenCcySplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD WrittenCcySplit DECIMAL(18,4) NULL;
    PRINT 'Added WrittenCcySplit column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SignedCcySplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD SignedCcySplit DECIMAL(18,4) NULL;
    PRINT 'Added SignedCcySplit column';
END
GO

-- =============================================
-- PART 4: PREMIUMCCY TABLE - ADD EU SPLIT COLUMNS
-- =============================================

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SelectedEUSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD SelectedEUSplit DECIMAL(18,4) NULL;
    PRINT 'Added SelectedEUSplit column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'ManualEUSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD ManualEUSplit DECIMAL(18,4) NULL;
    PRINT 'Added ManualEUSplit column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'PlanEUSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD PlanEUSplit DECIMAL(18,4) NULL;
    PRINT 'Added PlanEUSplit column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'WrittenEUSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD WrittenEUSplit DECIMAL(18,4) NULL;
    PRINT 'Added WrittenEUSplit column';
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('Ultimates.PremiumCcy') AND name = 'SignedEUSplit')
BEGIN
    ALTER TABLE Ultimates.PremiumCcy ADD SignedEUSplit DECIMAL(18,4) NULL;
    PRINT 'Added SignedEUSplit column';
END
GO

-- =============================================
-- PART 5: UPDATE STORED PROCEDURES
-- =============================================

-- 5a. spGetLatestUltimatePremiumByClassRsvClassYOA
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
        ISNULL(CcySplitSelection, 'Manual') AS CcySplitSelection,
        ISNULL(EUSplitSelection, 'Manual') AS EUSplitSelection,
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

-- 5b. spUpsertUltimatePremium
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
    @CcySplitSelection VARCHAR(20) = 'Manual',
    @EUSplitSelection VARCHAR(20) = 'Manual'
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
        CcySplitSelection,
        EUSplitSelection,
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
        @CcySplitSelection,
        @EUSplitSelection,
        GETUTCDATE(),
        @UpdatedBy,
        @UpdateComments
    );
END
GO

-- 5c. spGetLatestUltimatePremium (list view)
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
        ISNULL(p.CcySplitSelection, 'Manual') AS CcySplitSelection,
        ISNULL(p.EUSplitSelection, 'Manual') AS EUSplitSelection
    FROM Ultimates.Premium p
    INNER JOIN LatestVersions lv
        ON p.Class = lv.Class
        AND p.ReservingClass = lv.ReservingClass
        AND p.YOA = lv.YOA
        AND p.Version = lv.LatestVersion
    ORDER BY p.Class, p.ReservingClass, p.YOA DESC;
END
GO

-- 5d. spUpsertUltimatePremiumCurrency
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
    @SelectedCcySplit DECIMAL(18,4) = NULL,
    @SelectedEUSplit DECIMAL(18,4) = NULL,
    -- Manual
    @ManualGGWP DECIMAL(18,4) = NULL,
    @ManualDeductions DECIMAL(18,4) = NULL,
    @ManualGNWP DECIMAL(18,4) = NULL,
    @ManualEU DECIMAL(18,4) = NULL,
    @ManualCcySplit DECIMAL(18,4) = NULL,
    @ManualEUSplit DECIMAL(18,4) = NULL,
    -- Plan
    @PlanGGWP DECIMAL(18,4) = NULL,
    @PlanDeductions DECIMAL(18,4) = NULL,
    @PlanGNWP DECIMAL(18,4) = NULL,
    @PlanEU DECIMAL(18,4) = NULL,
    @PlanCcySplit DECIMAL(18,4) = NULL,
    @PlanEUSplit DECIMAL(18,4) = NULL,
    -- Written
    @WrittenGGWP DECIMAL(18,4) = NULL,
    @WrittenDeductions DECIMAL(18,4) = NULL,
    @WrittenGNWP DECIMAL(18,4) = NULL,
    @WrittenEU DECIMAL(18,4) = NULL,
    @WrittenCcySplit DECIMAL(18,4) = NULL,
    @WrittenEUSplit DECIMAL(18,4) = NULL,
    -- Signed
    @SignedGGWP DECIMAL(18,4) = NULL,
    @SignedDeductions DECIMAL(18,4) = NULL,
    @SignedGNWP DECIMAL(18,4) = NULL,
    @SignedEU DECIMAL(18,4) = NULL,
    @SignedCcySplit DECIMAL(18,4) = NULL,
    @SignedEUSplit DECIMAL(18,4) = NULL
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
            SelectedCcySplit = @SelectedCcySplit,
            SelectedEUSplit = @SelectedEUSplit,
            ManualGGWP = @ManualGGWP,
            ManualDeductions = @ManualDeductions,
            ManualGNWP = @ManualGNWP,
            ManualEU = @ManualEU,
            ManualCcySplit = @ManualCcySplit,
            ManualEUSplit = @ManualEUSplit,
            PlanGGWP = @PlanGGWP,
            PlanDeductions = @PlanDeductions,
            PlanGNWP = @PlanGNWP,
            PlanEU = @PlanEU,
            PlanCcySplit = @PlanCcySplit,
            PlanEUSplit = @PlanEUSplit,
            WrittenGGWP = @WrittenGGWP,
            WrittenDeductions = @WrittenDeductions,
            WrittenGNWP = @WrittenGNWP,
            WrittenEU = @WrittenEU,
            WrittenCcySplit = @WrittenCcySplit,
            WrittenEUSplit = @WrittenEUSplit,
            SignedGGWP = @SignedGGWP,
            SignedDeductions = @SignedDeductions,
            SignedGNWP = @SignedGNWP,
            SignedEU = @SignedEU,
            SignedCcySplit = @SignedCcySplit,
            SignedEUSplit = @SignedEUSplit
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
            SelectedCcySplit,
            SelectedEUSplit,
            ManualGGWP,
            ManualDeductions,
            ManualGNWP,
            ManualEU,
            ManualCcySplit,
            ManualEUSplit,
            PlanGGWP,
            PlanDeductions,
            PlanGNWP,
            PlanEU,
            PlanCcySplit,
            PlanEUSplit,
            WrittenGGWP,
            WrittenDeductions,
            WrittenGNWP,
            WrittenEU,
            WrittenCcySplit,
            WrittenEUSplit,
            SignedGGWP,
            SignedDeductions,
            SignedGNWP,
            SignedEU,
            SignedCcySplit,
            SignedEUSplit
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
            @SelectedCcySplit,
            @SelectedEUSplit,
            @ManualGGWP,
            @ManualDeductions,
            @ManualGNWP,
            @ManualEU,
            @ManualCcySplit,
            @ManualEUSplit,
            @PlanGGWP,
            @PlanDeductions,
            @PlanGNWP,
            @PlanEU,
            @PlanCcySplit,
            @PlanEUSplit,
            @WrittenGGWP,
            @WrittenDeductions,
            @WrittenGNWP,
            @WrittenEU,
            @WrittenCcySplit,
            @WrittenEUSplit,
            @SignedGGWP,
            @SignedDeductions,
            @SignedGNWP,
            @SignedEU,
            @SignedCcySplit,
            @SignedEUSplit
        );
    END
END
GO

-- 5e. spGetPremiumCcy
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
        ISNULL(SelectedCcySplit, 0) AS SelectedCcySplit,
        ISNULL(SelectedEUSplit, 0) AS SelectedEUSplit,
        -- Manual
        ManualGGWP,
        ManualDeductions,
        ManualGNWP,
        ManualEU,
        ISNULL(ManualCcySplit, 0) AS ManualCcySplit,
        ISNULL(ManualEUSplit, 0) AS ManualEUSplit,
        -- Plan
        PlanGGWP,
        PlanDeductions,
        PlanGNWP,
        PlanEU,
        ISNULL(PlanCcySplit, 0) AS PlanCcySplit,
        ISNULL(PlanEUSplit, 0) AS PlanEUSplit,
        -- Written
        WrittenGGWP,
        WrittenDeductions,
        WrittenGNWP,
        WrittenEU,
        ISNULL(WrittenCcySplit, 0) AS WrittenCcySplit,
        ISNULL(WrittenEUSplit, 0) AS WrittenEUSplit,
        -- Signed
        SignedGGWP,
        SignedDeductions,
        SignedGNWP,
        SignedEU,
        ISNULL(SignedCcySplit, 0) AS SignedCcySplit,
        ISNULL(SignedEUSplit, 0) AS SignedEUSplit
    FROM Ultimates.PremiumCcy
    WHERE Class = @Class
      AND ReservingClass = @ReservingClass
      AND YOA = @YOA
      AND Version = @Version
    ORDER BY Currency;
END
GO

PRINT 'Currency Split and EU Split feature database changes completed successfully.';
GO
