-- =============================================
-- Ultimates FX Rate Sets
-- Creates tables and data for FX rate sets used in currency conversions
-- =============================================

-- Create FX Rate Sets table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FxRateSets' AND schema_id = SCHEMA_ID('Ultimates'))
BEGIN
    CREATE TABLE [Ultimates].[FxRateSets]
    (
        [FxRateSetID] INT IDENTITY(1,1) NOT NULL,
        [RateSetName] NVARCHAR(100) NOT NULL,
        [RateSetDescription] NVARCHAR(500) NULL,
        [EffectiveDate] DATE NULL,
        [IsActive] BIT NOT NULL DEFAULT 1,
        [CreatedDate] DATETIME2 NOT NULL DEFAULT GETDATE(),
        CONSTRAINT [PK_FxRateSets] PRIMARY KEY CLUSTERED ([FxRateSetID] ASC),
        CONSTRAINT [UQ_FxRateSets_Name] UNIQUE ([RateSetName])
    )
END
GO

-- Create FX Rates table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'FxRates' AND schema_id = SCHEMA_ID('Ultimates'))
BEGIN
    CREATE TABLE [Ultimates].[FxRates]
    (
        [FxRateID] INT IDENTITY(1,1) NOT NULL,
        [FxRateSetID] INT NOT NULL,
        [FromCurrency] NVARCHAR(10) NOT NULL,
        [ToCurrency] NVARCHAR(10) NOT NULL,
        [Rate] DECIMAL(18,8) NOT NULL,
        CONSTRAINT [PK_FxRates] PRIMARY KEY CLUSTERED ([FxRateID] ASC),
        CONSTRAINT [FK_FxRates_FxRateSets] FOREIGN KEY ([FxRateSetID]) REFERENCES [Ultimates].[FxRateSets]([FxRateSetID]),
        CONSTRAINT [UQ_FxRates_SetFromTo] UNIQUE ([FxRateSetID], [FromCurrency], [ToCurrency])
    )
END
GO

-- Insert FX Rate Sets
SET IDENTITY_INSERT [Ultimates].[FxRateSets] ON;

MERGE INTO [Ultimates].[FxRateSets] AS Target
USING (VALUES
    (1, 'Q3 2025 Close', 'Q3 2025 Quarter Close Rates', '2025-09-30', 1),
    (2, 'Q2 2025 Close', 'Q2 2025 Quarter Close Rates', '2025-06-30', 1),
    (3, 'Q1 2025 Close', 'Q1 2025 Quarter Close Rates', '2025-03-31', 1),
    (4, 'Q4 2024 Close', 'Q4 2024 Quarter Close Rates', '2024-12-31', 1)
) AS Source ([FxRateSetID], [RateSetName], [RateSetDescription], [EffectiveDate], [IsActive])
ON Target.[FxRateSetID] = Source.[FxRateSetID]
WHEN MATCHED THEN
    UPDATE SET
        [RateSetName] = Source.[RateSetName],
        [RateSetDescription] = Source.[RateSetDescription],
        [EffectiveDate] = Source.[EffectiveDate],
        [IsActive] = Source.[IsActive]
WHEN NOT MATCHED THEN
    INSERT ([FxRateSetID], [RateSetName], [RateSetDescription], [EffectiveDate], [IsActive])
    VALUES (Source.[FxRateSetID], Source.[RateSetName], Source.[RateSetDescription], Source.[EffectiveDate], Source.[IsActive]);

SET IDENTITY_INSERT [Ultimates].[FxRateSets] OFF;
GO

-- Insert FX Rates
-- Q3 2025 Close Rates (FxRateSetID = 1)
-- Base conversions to GBP and USD
MERGE INTO [Ultimates].[FxRates] AS Target
USING (VALUES
    -- GBP to other currencies
    (1, 'GBP', 'GBP', 1.00000000),
    (1, 'GBP', 'USD', 1.28500000),
    (1, 'GBP', 'EUR', 1.16800000),
    (1, 'GBP', 'JPY', 188.50000000),
    (1, 'GBP', 'AUD', 1.92000000),
    (1, 'GBP', 'CAD', 1.72000000),
    (1, 'GBP', 'CHF', 1.11000000),

    -- USD to other currencies
    (1, 'USD', 'USD', 1.00000000),
    (1, 'USD', 'GBP', 0.77821011),
    (1, 'USD', 'EUR', 0.90894942),
    (1, 'USD', 'JPY', 146.69902913),
    (1, 'USD', 'AUD', 1.49416342),
    (1, 'USD', 'CAD', 1.33852140),
    (1, 'USD', 'CHF', 0.86381323),

    -- EUR to other currencies
    (1, 'EUR', 'EUR', 1.00000000),
    (1, 'EUR', 'GBP', 0.85616438),
    (1, 'EUR', 'USD', 1.10020548),
    (1, 'EUR', 'JPY', 161.38561644),
    (1, 'EUR', 'AUD', 1.64383562),
    (1, 'EUR', 'CAD', 1.47260274),
    (1, 'EUR', 'CHF', 0.95034247),

    -- JPY to other currencies
    (1, 'JPY', 'JPY', 1.00000000),
    (1, 'JPY', 'GBP', 0.00530504),
    (1, 'JPY', 'USD', 0.00681760),
    (1, 'JPY', 'EUR', 0.00619718),
    (1, 'JPY', 'AUD', 0.01018519),
    (1, 'JPY', 'CAD', 0.00912454),
    (1, 'JPY', 'CHF', 0.00588785),

    -- AUD to other currencies
    (1, 'AUD', 'AUD', 1.00000000),
    (1, 'AUD', 'GBP', 0.52083333),
    (1, 'AUD', 'USD', 0.66916667),
    (1, 'AUD', 'EUR', 0.60833333),
    (1, 'AUD', 'JPY', 98.17708333),
    (1, 'AUD', 'CAD', 0.89583333),
    (1, 'AUD', 'CHF', 0.57812500),

    -- CAD to other currencies
    (1, 'CAD', 'CAD', 1.00000000),
    (1, 'CAD', 'GBP', 0.58139535),
    (1, 'CAD', 'USD', 0.74709302),
    (1, 'CAD', 'EUR', 0.67906977),
    (1, 'CAD', 'JPY', 109.59302326),
    (1, 'CAD', 'AUD', 1.11627907),
    (1, 'CAD', 'CHF', 0.64534884),

    -- CHF to other currencies
    (1, 'CHF', 'CHF', 1.00000000),
    (1, 'CHF', 'GBP', 0.90090090),
    (1, 'CHF', 'USD', 1.15765766),
    (1, 'CHF', 'EUR', 1.05225225),
    (1, 'CHF', 'JPY', 169.81981982),
    (1, 'CHF', 'AUD', 1.72972973),
    (1, 'CHF', 'CAD', 1.54954955),

    -- Q2 2025 Close Rates (FxRateSetID = 2) - Slightly different rates
    (2, 'GBP', 'GBP', 1.00000000),
    (2, 'GBP', 'USD', 1.27200000),
    (2, 'GBP', 'EUR', 1.15500000),
    (2, 'GBP', 'JPY', 185.30000000),
    (2, 'GBP', 'AUD', 1.89000000),
    (2, 'GBP', 'CAD', 1.69500000),
    (2, 'GBP', 'CHF', 1.09500000),

    (2, 'USD', 'USD', 1.00000000),
    (2, 'USD', 'GBP', 0.78616352),
    (2, 'USD', 'EUR', 0.90801887),
    (2, 'USD', 'JPY', 145.67610063),
    (2, 'USD', 'AUD', 1.48584906),
    (2, 'USD', 'CAD', 1.33270440),
    (2, 'USD', 'CHF', 0.86083491),

    -- Q1 2025 Close Rates (FxRateSetID = 3)
    (3, 'GBP', 'GBP', 1.00000000),
    (3, 'GBP', 'USD', 1.29800000),
    (3, 'GBP', 'EUR', 1.18200000),
    (3, 'GBP', 'JPY', 191.20000000),
    (3, 'GBP', 'AUD', 1.95000000),
    (3, 'GBP', 'CAD', 1.74500000),
    (3, 'GBP', 'CHF', 1.12500000),

    (3, 'USD', 'USD', 1.00000000),
    (3, 'USD', 'GBP', 0.77043344),
    (3, 'USD', 'EUR', 0.91060708),
    (3, 'USD', 'JPY', 147.30508474),
    (3, 'USD', 'AUD', 1.50231244),
    (3, 'USD', 'CAD', 1.34449152),
    (3, 'USD', 'CHF', 0.86671127),

    -- Q4 2024 Close Rates (FxRateSetID = 4)
    (4, 'GBP', 'GBP', 1.00000000),
    (4, 'GBP', 'USD', 1.26500000),
    (4, 'GBP', 'EUR', 1.14800000),
    (4, 'GBP', 'JPY', 182.50000000),
    (4, 'GBP', 'AUD', 1.87000000),
    (4, 'GBP', 'CAD', 1.68000000),
    (4, 'GBP', 'CHF', 1.08500000),

    (4, 'USD', 'USD', 1.00000000),
    (4, 'USD', 'GBP', 0.79051383),
    (4, 'USD', 'EUR', 0.90751976),
    (4, 'USD', 'JPY', 144.26877470),
    (4, 'USD', 'AUD', 1.47826087),
    (4, 'USD', 'CAD', 1.32806324),
    (4, 'USD', 'CHF', 0.85770751)
) AS Source ([FxRateSetID], [FromCurrency], [ToCurrency], [Rate])
ON Target.[FxRateSetID] = Source.[FxRateSetID]
   AND Target.[FromCurrency] = Source.[FromCurrency]
   AND Target.[ToCurrency] = Source.[ToCurrency]
WHEN MATCHED THEN
    UPDATE SET [Rate] = Source.[Rate]
WHEN NOT MATCHED THEN
    INSERT ([FxRateSetID], [FromCurrency], [ToCurrency], [Rate])
    VALUES (Source.[FxRateSetID], Source.[FromCurrency], Source.[ToCurrency], Source.[Rate]);
GO

-- Create view for easy access to FX rates
IF OBJECT_ID('[Ultimates].[vwFxRates]', 'V') IS NOT NULL
    DROP VIEW [Ultimates].[vwFxRates];
GO

CREATE VIEW [Ultimates].[vwFxRates]
AS
SELECT
    rs.[FxRateSetID],
    rs.[RateSetName],
    rs.[RateSetDescription],
    rs.[EffectiveDate],
    rs.[IsActive],
    r.[FromCurrency],
    r.[ToCurrency],
    r.[Rate]
FROM
    [Ultimates].[FxRateSets] rs
    INNER JOIN [Ultimates].[FxRates] r ON rs.[FxRateSetID] = r.[FxRateSetID]
WHERE
    rs.[IsActive] = 1;
GO

-- Create stored procedure to get FX rates for a specific rate set
IF OBJECT_ID('[Ultimates].[spGetFxRates]', 'P') IS NOT NULL
    DROP PROCEDURE [Ultimates].[spGetFxRates];
GO

CREATE PROCEDURE [Ultimates].[spGetFxRates]
    @FxRateSetID INT = NULL,
    @RateSetName NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- If RateSetName is provided, get the ID
    IF @RateSetName IS NOT NULL AND @FxRateSetID IS NULL
    BEGIN
        SELECT @FxRateSetID = FxRateSetID
        FROM [Ultimates].[FxRateSets]
        WHERE RateSetName = @RateSetName;
    END

    -- If neither provided, get the most recent active rate set
    IF @FxRateSetID IS NULL
    BEGIN
        SELECT TOP 1 @FxRateSetID = FxRateSetID
        FROM [Ultimates].[FxRateSets]
        WHERE IsActive = 1
        ORDER BY EffectiveDate DESC;
    END

    -- Return rates for the selected rate set
    SELECT
        r.[FxRateID],
        r.[FxRateSetID],
        rs.[RateSetName],
        rs.[RateSetDescription],
        rs.[EffectiveDate],
        r.[FromCurrency],
        r.[ToCurrency],
        r.[Rate]
    FROM
        [Ultimates].[FxRates] r
        INNER JOIN [Ultimates].[FxRateSets] rs ON r.[FxRateSetID] = rs.[FxRateSetID]
    WHERE
        r.[FxRateSetID] = @FxRateSetID;
END
GO

-- Create stored procedure to get all active rate sets
IF OBJECT_ID('[Ultimates].[spGetFxRateSets]', 'P') IS NOT NULL
    DROP PROCEDURE [Ultimates].[spGetFxRateSets];
GO

CREATE PROCEDURE [Ultimates].[spGetFxRateSets]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        [FxRateSetID],
        [RateSetName],
        [RateSetDescription],
        [EffectiveDate],
        [IsActive]
    FROM
        [Ultimates].[FxRateSets]
    WHERE
        [IsActive] = 1
    ORDER BY
        [EffectiveDate] DESC;
END
GO
