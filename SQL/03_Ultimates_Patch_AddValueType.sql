-- =============================================
-- ULTIMATES Database Patch: Add ValueType Field
-- Purpose: Add ValueType field to track entry method
-- Author: Claude
-- Date: 2025-12-12
-- =============================================

USE [YourDatabaseName]
GO

-- Add ValueType column to UltimatePremium table
IF NOT EXISTS (SELECT * FROM sys.columns
               WHERE object_id = OBJECT_ID(N'[Ultimates].[UltimatePremium]')
               AND name = 'ValueType')
BEGIN
    ALTER TABLE [Ultimates].[UltimatePremium]
    ADD [ValueType] NVARCHAR(20) NOT NULL DEFAULT 'Value'
    CONSTRAINT [CHK_UltimatePremium_ValueType]
        CHECK ([ValueType] IN ('Written', 'Signed', 'Plan', 'Value'))

    PRINT 'Column [ValueType] added to [Ultimates].[UltimatePremium]'
END
ELSE
BEGIN
    PRINT 'Column [ValueType] already exists in [Ultimates].[UltimatePremium]'
END
GO

-- Update all existing records to 'Value' (default)
UPDATE [Ultimates].[UltimatePremium]
SET [ValueType] = 'Value'
WHERE [ValueType] IS NULL OR [ValueType] = ''
GO

PRINT 'Existing records updated to ValueType = ''Value'''
GO

-- Recreate the snapshot view to include ValueType
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

PRINT 'View [Ultimates].[vwUltimatePremiumSnapshot] recreated with ValueType'
GO

PRINT '=== Patch completed successfully ==='
GO
