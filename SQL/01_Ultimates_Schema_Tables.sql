-- =============================================
-- ULTIMATES Schema and Tables
-- Purpose: Track underwriter selections of Ultimate Premium data
-- Author: Claude
-- Date: 2025-12-11
-- =============================================

-- Create Schema
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'Ultimates')
BEGIN
    EXEC('CREATE SCHEMA Ultimates')
END
GO

-- =============================================
-- Updates Table: Tracks batch updates
-- Each edit session creates one Updates record
-- Multiple UltimatePremium records reference the same UpdateID
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[Updates]') AND type in (N'U'))
BEGIN
    CREATE TABLE [Ultimates].[Updates]
    (
        [UpdateID] INT IDENTITY(1,1) NOT NULL,
        [UpdateDate] DATETIME2 NOT NULL DEFAULT GETDATE(),
        [UpdatedBy] NVARCHAR(100) NOT NULL,
        [Comments] NVARCHAR(500) NULL,

        CONSTRAINT [PK_Updates] PRIMARY KEY CLUSTERED ([UpdateID] ASC)
    )

    PRINT 'Table [Ultimates].[Updates] created successfully'
END
ELSE
BEGIN
    PRINT 'Table [Ultimates].[Updates] already exists'
END
GO

-- =============================================
-- Main Table: UltimatePremium
-- Stores all versions/updates of Ultimate Premium data
-- Fully audited with UpdateID tracking (FK to Updates table)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[UltimatePremium]') AND type in (N'U'))
BEGIN
    CREATE TABLE [Ultimates].[UltimatePremium]
    (
        -- Primary Key
        [UltimatePremiumID] INT IDENTITY(1,1) NOT NULL,

        -- Audit/Version Tracking (FK to Updates table)
        [UpdateID] INT NOT NULL,

        -- Business Keys (Resolution Level)
        [Class] NVARCHAR(100) NOT NULL,
        [ReservingClass] NVARCHAR(100) NOT NULL,
        [YOA] INT NOT NULL,
        [DistributionChannel] NVARCHAR(10) NOT NULL, -- 'EU' or 'LNDN'
        [Currency] NVARCHAR(10) NOT NULL,

        -- Value Type (how the value is set)
        [ValueType] NVARCHAR(20) NOT NULL DEFAULT 'Value', -- 'Written', 'Signed', 'Plan', 'Value'

        -- Ultimate Premium Fields
        [UltimateGrossPremium] DECIMAL(18,2) NULL,
        [UltimateNetPremium] DECIMAL(18,2) NULL,
        [UltimateRIPs] DECIMAL(18,2) NULL, -- Reinstatement Premiums
        [UltimatePC] DECIMAL(18,2) NULL, -- Profit Commission

        -- Constraints
        CONSTRAINT [PK_UltimatePremium] PRIMARY KEY CLUSTERED ([UltimatePremiumID] ASC),
        CONSTRAINT [FK_UltimatePremium_Updates] FOREIGN KEY ([UpdateID]) REFERENCES [Ultimates].[Updates]([UpdateID]),
        CONSTRAINT [CHK_UltimatePremium_DistributionChannel] CHECK ([DistributionChannel] IN ('EU', 'LNDN')),
        CONSTRAINT [CHK_UltimatePremium_ValueType] CHECK ([ValueType] IN ('Written', 'Signed', 'Plan', 'Value'))
    )

    -- Indexes for common queries
    CREATE NONCLUSTERED INDEX [IX_UltimatePremium_ClassYOA]
        ON [Ultimates].[UltimatePremium]([Class], [YOA])
        INCLUDE ([ReservingClass], [DistributionChannel], [Currency])

    CREATE NONCLUSTERED INDEX [IX_UltimatePremium_UpdateID]
        ON [Ultimates].[UltimatePremium]([UpdateID] DESC)

    CREATE NONCLUSTERED INDEX [IX_UltimatePremium_YOA]
        ON [Ultimates].[UltimatePremium]([YOA])

    PRINT 'Table [Ultimates].[UltimatePremium] created successfully'
END
ELSE
BEGIN
    PRINT 'Table [Ultimates].[UltimatePremium] already exists'
END
GO

-- =============================================
-- Snapshot View: Current/Latest Version
-- Shows the most recent UpdateID for each unique combination
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[Ultimates].[vwUltimatePremiumSnapshot]'))
BEGIN
    DROP VIEW [Ultimates].[vwUltimatePremiumSnapshot]
END
GO

CREATE VIEW [Ultimates].[vwUltimatePremiumSnapshot]
AS
    SELECT
        up.UltimatePremiumID,
        up.UpdateID,
        up.Class,
        up.ReservingClass,
        up.YOA,
        up.DistributionChannel,
        up.Currency,
        up.ValueType,
        up.UltimateGrossPremium,
        up.UltimateNetPremium,
        up.UltimateRIPs,
        up.UltimatePC,
        u.UpdateDate,
        u.UpdatedBy
    FROM [Ultimates].[UltimatePremium] up
    INNER JOIN [Ultimates].[Updates] u ON up.UpdateID = u.UpdateID
    INNER JOIN (
        -- Get the latest UpdateID for each unique combination
        SELECT
            Class,
            ReservingClass,
            YOA,
            DistributionChannel,
            Currency,
            MAX(UpdateID) AS MaxUpdateID
        FROM [Ultimates].[UltimatePremium]
        GROUP BY Class, ReservingClass, YOA, DistributionChannel, Currency
    ) latest
        ON up.Class = latest.Class
        AND up.ReservingClass = latest.ReservingClass
        AND up.YOA = latest.YOA
        AND up.DistributionChannel = latest.DistributionChannel
        AND up.Currency = latest.Currency
        AND up.UpdateID = latest.MaxUpdateID
GO

PRINT 'View [Ultimates].[vwUltimatePremiumSnapshot] created successfully'
GO

-- =============================================
-- Summary View by Class/YOA
-- Aggregates snapshot data by Class and YOA
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[Ultimates].[vwUltimatePremiumSummaryByClassYOA]'))
BEGIN
    DROP VIEW [Ultimates].[vwUltimatePremiumSummaryByClassYOA]
END
GO

CREATE VIEW [Ultimates].[vwUltimatePremiumSummaryByClassYOA]
AS
    SELECT
        snapshot.Class,
        snapshot.YOA,
        COUNT(*) AS RecordCount,
        SUM(snapshot.UltimateGrossPremium) AS TotalUltimateGrossPremium,
        SUM(snapshot.UltimateNetPremium) AS TotalUltimateNetPremium,
        SUM(snapshot.UltimateRIPs) AS TotalUltimateRIPs,
        SUM(snapshot.UltimatePC) AS TotalUltimatePC,
        MAX(snapshot.UpdateDate) AS LastUpdatedDate,
        MAX(snapshot.UpdatedBy) AS LastUpdatedBy,
        (SELECT COUNT(DISTINCT up.UpdateID)
         FROM [Ultimates].[UltimatePremium] up
         WHERE up.Class = snapshot.Class AND up.YOA = snapshot.YOA) AS UpdateCount
    FROM [Ultimates].[vwUltimatePremiumSnapshot] snapshot
    GROUP BY snapshot.Class, snapshot.YOA
GO

PRINT 'View [Ultimates].[vwUltimatePremiumSummaryByClassYOA] created successfully'
GO

PRINT '=== Ultimates Schema and Tables created successfully ==='
GO
