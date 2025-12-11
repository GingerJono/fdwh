-- =============================================
-- ULTIMATES Stored Procedures
-- Purpose: CRUD operations for Ultimate Premium tracking
-- Author: Claude
-- Date: 2025-12-11
-- =============================================

-- =============================================
-- SP: Get Ultimate Premium Snapshot (Current Latest)
-- Returns: Current snapshot of all Ultimate Premium data
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spGetUltimatePremiumSnapshot]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spGetUltimatePremiumSnapshot]
GO

CREATE PROCEDURE [Ultimates].[spGetUltimatePremiumSnapshot]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        UltimatePremiumID,
        UpdateID,
        Class,
        ReservingClass,
        YOA,
        DistributionChannel,
        Currency,
        UltimateGrossPremium,
        UltimateNetPremium,
        UltimateRIPs,
        UltimatePC,
        CreatedDate,
        CreatedBy,
        LastUpdatedDate,
        LastUpdatedBy
    FROM [Ultimates].[vwUltimatePremiumSnapshot]
    ORDER BY Class, YOA, ReservingClass, DistributionChannel, Currency
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumSnapshot] created'
GO

-- =============================================
-- SP: Get Ultimate Premium by Class/YOA
-- Returns: Current snapshot filtered by Class and YOA for editing
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spGetUltimatePremiumByClassYOA]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spGetUltimatePremiumByClassYOA]
GO

CREATE PROCEDURE [Ultimates].[spGetUltimatePremiumByClassYOA]
    @Class NVARCHAR(100),
    @YOA INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        UltimatePremiumID,
        UpdateID,
        Class,
        ReservingClass,
        YOA,
        DistributionChannel,
        Currency,
        UltimateGrossPremium,
        UltimateNetPremium,
        UltimateRIPs,
        UltimatePC,
        CreatedDate,
        CreatedBy,
        LastUpdatedDate,
        LastUpdatedBy
    FROM [Ultimates].[vwUltimatePremiumSnapshot]
    WHERE Class = @Class
        AND YOA = @YOA
    ORDER BY ReservingClass, DistributionChannel, Currency
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumByClassYOA] created'
GO

-- =============================================
-- SP: Get Ultimate Premium History by Class/YOA
-- Returns: All historical updates for a Class/YOA with aggregated sums
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spGetUltimatePremiumHistoryByClassYOA]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spGetUltimatePremiumHistoryByClassYOA]
GO

CREATE PROCEDURE [Ultimates].[spGetUltimatePremiumHistoryByClassYOA]
    @Class NVARCHAR(100),
    @YOA INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Get all historical updates grouped by UpdateID
    -- Show sum of all combos for each update
    SELECT
        UpdateID,
        Class,
        YOA,
        COUNT(*) AS RecordCount,
        SUM(UltimateGrossPremium) AS TotalUltimateGrossPremium,
        SUM(UltimateNetPremium) AS TotalUltimateNetPremium,
        SUM(UltimateRIPs) AS TotalUltimateRIPs,
        SUM(UltimatePC) AS TotalUltimatePC,
        MAX(CreatedDate) AS UpdateDate,
        MAX(COALESCE(LastUpdatedBy, CreatedBy)) AS UpdatedBy
    FROM [Ultimates].[UltimatePremium]
    WHERE Class = @Class
        AND YOA = @YOA
    GROUP BY UpdateID, Class, YOA
    ORDER BY UpdateID DESC
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumHistoryByClassYOA] created'
GO

-- =============================================
-- SP: Get Ultimate Premium History Detail by UpdateID
-- Returns: Detailed records for a specific UpdateID
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spGetUltimatePremiumHistoryDetail]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spGetUltimatePremiumHistoryDetail]
GO

CREATE PROCEDURE [Ultimates].[spGetUltimatePremiumHistoryDetail]
    @UpdateID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        UltimatePremiumID,
        UpdateID,
        Class,
        ReservingClass,
        YOA,
        DistributionChannel,
        Currency,
        UltimateGrossPremium,
        UltimateNetPremium,
        UltimateRIPs,
        UltimatePC,
        CreatedDate,
        CreatedBy,
        LastUpdatedDate,
        LastUpdatedBy
    FROM [Ultimates].[UltimatePremium]
    WHERE UpdateID = @UpdateID
    ORDER BY ReservingClass, DistributionChannel, Currency
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumHistoryDetail] created'
GO

-- =============================================
-- SP: Upsert Ultimate Premium
-- Inserts a new version for each record
-- Always creates new records for audit trail
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spUpsertUltimatePremium]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spUpsertUltimatePremium]
GO

CREATE PROCEDURE [Ultimates].[spUpsertUltimatePremium]
    @Class NVARCHAR(100),
    @ReservingClass NVARCHAR(100),
    @YOA INT,
    @DistributionChannel NVARCHAR(10),
    @Currency NVARCHAR(10),
    @UltimateGrossPremium DECIMAL(18,2),
    @UltimateNetPremium DECIMAL(18,2),
    @UltimateRIPs DECIMAL(18,2),
    @UltimatePC DECIMAL(18,2),
    @LastUpdatedBy NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Always insert a new record for audit trail
    -- This creates a new UpdateID automatically
    INSERT INTO [Ultimates].[UltimatePremium]
    (
        Class,
        ReservingClass,
        YOA,
        DistributionChannel,
        Currency,
        UltimateGrossPremium,
        UltimateNetPremium,
        UltimateRIPs,
        UltimatePC,
        CreatedDate,
        CreatedBy,
        LastUpdatedDate,
        LastUpdatedBy
    )
    VALUES
    (
        @Class,
        @ReservingClass,
        @YOA,
        @DistributionChannel,
        @Currency,
        @UltimateGrossPremium,
        @UltimateNetPremium,
        @UltimateRIPs,
        @UltimatePC,
        GETDATE(),
        @LastUpdatedBy,
        GETDATE(),
        @LastUpdatedBy
    )

    -- Return the new UpdateID
    SELECT SCOPE_IDENTITY() AS NewUpdateID
END
GO

PRINT 'Procedure [Ultimates].[spUpsertUltimatePremium] created'
GO

-- =============================================
-- SP: Get List of Classes with Ultimate Premium data
-- Returns: Distinct classes for navigation
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spGetUltimatePremiumListClasses]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spGetUltimatePremiumListClasses]
GO

CREATE PROCEDURE [Ultimates].[spGetUltimatePremiumListClasses]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT
        Class,
        COUNT(DISTINCT YOA) AS YOACount,
        COUNT(*) AS RecordCount,
        MAX(LastUpdatedDate) AS LastUpdatedDate
    FROM [Ultimates].[vwUltimatePremiumSnapshot]
    GROUP BY Class
    ORDER BY Class
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumListClasses] created'
GO

-- =============================================
-- SP: Get List of Class/YOA combinations
-- Returns: All Class/YOA combinations for navigation
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spGetUltimatePremiumListClassYOA]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spGetUltimatePremiumListClassYOA]
GO

CREATE PROCEDURE [Ultimates].[spGetUltimatePremiumListClassYOA]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Class,
        YOA,
        RecordCount,
        TotalUltimateGrossPremium,
        TotalUltimateNetPremium,
        TotalUltimateRIPs,
        TotalUltimatePC,
        LastUpdatedDate,
        LastUpdatedBy
    FROM [Ultimates].[vwUltimatePremiumSummaryByClassYOA]
    ORDER BY Class, YOA DESC
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumListClassYOA] created'
GO

-- =============================================
-- SP: Get List of YOAs for a specific Class
-- Returns: YOAs for a class for filtering
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spGetUltimatePremiumYOAsByClass]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spGetUltimatePremiumYOAsByClass]
GO

CREATE PROCEDURE [Ultimates].[spGetUltimatePremiumYOAsByClass]
    @Class NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT
        YOA,
        COUNT(*) AS RecordCount,
        SUM(UltimateGrossPremium) AS TotalUltimateGrossPremium,
        MAX(LastUpdatedDate) AS LastUpdatedDate
    FROM [Ultimates].[vwUltimatePremiumSnapshot]
    WHERE Class = @Class
    GROUP BY YOA
    ORDER BY YOA DESC
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumYOAsByClass] created'
GO

PRINT '=== Ultimates Stored Procedures created successfully ==='
GO
