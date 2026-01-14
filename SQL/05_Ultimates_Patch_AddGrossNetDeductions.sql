-- =============================================
-- ULTIMATES Schema Patch: Add GrossNet and Deductions
-- Purpose:
--   1. Add GrossNet column to track whether Premium is Gross or Net
--   2. Rename UltimateGrossPremium to UltimatePremium
--   3. Add Deductions column (percentage)
--   4. Update related stored procedures and views
-- Author: Claude
-- Date: 2025-01-14
-- =============================================

USE [DaleSandbox]
GO

PRINT '=== Starting Ultimates GrossNet/Deductions Migration ==='
GO

-- =============================================
-- STEP 1: Add GrossNet column
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[Ultimates].[UltimatePremium]') AND name = 'GrossNet')
BEGIN
    ALTER TABLE [Ultimates].[UltimatePremium]
    ADD [GrossNet] NVARCHAR(10) NOT NULL DEFAULT 'Gross'
    CONSTRAINT [CHK_UltimatePremium_GrossNet] CHECK ([GrossNet] IN ('Gross', 'Net'))

    PRINT 'Added GrossNet column to [Ultimates].[UltimatePremium]'
END
ELSE
BEGIN
    PRINT 'GrossNet column already exists'
END
GO

-- =============================================
-- STEP 2: Add Deductions column
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[Ultimates].[UltimatePremium]') AND name = 'Deductions')
BEGIN
    ALTER TABLE [Ultimates].[UltimatePremium]
    ADD [Deductions] DECIMAL(5,4) NULL  -- Store as decimal (e.g., 0.15 for 15%)

    PRINT 'Added Deductions column to [Ultimates].[UltimatePremium]'
END
ELSE
BEGIN
    PRINT 'Deductions column already exists'
END
GO

-- =============================================
-- STEP 3: Rename UltimateGrossPremium to UltimatePremium
-- =============================================
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[Ultimates].[UltimatePremium]') AND name = 'UltimateGrossPremium')
AND NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[Ultimates].[UltimatePremium]') AND name = 'UltimatePremium')
BEGIN
    EXEC sp_rename '[Ultimates].[UltimatePremium].[UltimateGrossPremium]', 'UltimatePremium', 'COLUMN'

    PRINT 'Renamed UltimateGrossPremium to UltimatePremium'
END
ELSE
BEGIN
    PRINT 'Column rename not needed (UltimatePremium already exists or UltimateGrossPremium missing)'
END
GO

-- =============================================
-- STEP 4: Update Snapshot View
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[Ultimates].[vwUltimatePremiumSnapshot]'))
BEGIN
    DROP VIEW [Ultimates].[vwUltimatePremiumSnapshot]
    PRINT 'Dropped existing view [Ultimates].[vwUltimatePremiumSnapshot]'
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
        up.GrossNet,
        up.UltimatePremium,
        up.UltimateNetPremium,
        up.Deductions,
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

PRINT 'Recreated view [Ultimates].[vwUltimatePremiumSnapshot]'
GO

-- =============================================
-- STEP 5: Update Summary View
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[Ultimates].[vwUltimatePremiumSummaryByClassYOA]'))
BEGIN
    DROP VIEW [Ultimates].[vwUltimatePremiumSummaryByClassYOA]
    PRINT 'Dropped existing view [Ultimates].[vwUltimatePremiumSummaryByClassYOA]'
END
GO

CREATE VIEW [Ultimates].[vwUltimatePremiumSummaryByClassYOA]
AS
    SELECT
        snapshot.Class,
        snapshot.YOA,
        COUNT(*) AS RecordCount,
        SUM(snapshot.UltimatePremium) AS TotalUltimatePremium,
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

PRINT 'Recreated view [Ultimates].[vwUltimatePremiumSummaryByClassYOA]'
GO

PRINT '=== Ultimates GrossNet/Deductions Migration Completed Successfully ==='
GO
