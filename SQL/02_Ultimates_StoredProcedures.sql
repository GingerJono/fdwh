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
        UpdateDate,
        UpdatedBy
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
        UpdateDate,
        UpdatedBy
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
        up.UpdateID,
        up.Class,
        up.YOA,
        COUNT(*) AS RecordCount,
        SUM(up.UltimateGrossPremium) AS TotalUltimateGrossPremium,
        SUM(up.UltimateNetPremium) AS TotalUltimateNetPremium,
        SUM(up.UltimateRIPs) AS TotalUltimateRIPs,
        SUM(up.UltimatePC) AS TotalUltimatePC,
        u.UpdateDate,
        u.UpdatedBy
    FROM [Ultimates].[UltimatePremium] up
    INNER JOIN [Ultimates].[Updates] u ON up.UpdateID = u.UpdateID
    WHERE up.Class = @Class
        AND up.YOA = @YOA
    GROUP BY up.UpdateID, up.Class, up.YOA, u.UpdateDate, u.UpdatedBy
    ORDER BY up.UpdateID DESC
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
        up.UltimatePremiumID,
        up.UpdateID,
        up.Class,
        up.ReservingClass,
        up.YOA,
        up.DistributionChannel,
        up.Currency,
        up.UltimateGrossPremium,
        up.UltimateNetPremium,
        up.UltimateRIPs,
        up.UltimatePC,
        u.UpdateDate,
        u.UpdatedBy
    FROM [Ultimates].[UltimatePremium] up
    INNER JOIN [Ultimates].[Updates] u ON up.UpdateID = u.UpdateID
    WHERE up.UpdateID = @UpdateID
    ORDER BY up.ReservingClass, up.DistributionChannel, up.Currency
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumHistoryDetail] created'
GO

-- =============================================
-- SP: Upsert Ultimate Premium
-- Inserts a new version for each record
-- Always creates new records for audit trail
-- Requires UpdateID from Updates table
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Ultimates].[spUpsertUltimatePremium]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [Ultimates].[spUpsertUltimatePremium]
GO

CREATE PROCEDURE [Ultimates].[spUpsertUltimatePremium]
    @UpdateID INT,
    @Class NVARCHAR(100),
    @ReservingClass NVARCHAR(100),
    @YOA INT,
    @DistributionChannel NVARCHAR(10),
    @Currency NVARCHAR(10),
    @UltimateGrossPremium DECIMAL(18,2),
    @UltimateNetPremium DECIMAL(18,2),
    @UltimateRIPs DECIMAL(18,2),
    @UltimatePC DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert a new record for audit trail with provided UpdateID
    INSERT INTO [Ultimates].[UltimatePremium]
    (
        UpdateID,
        Class,
        ReservingClass,
        YOA,
        DistributionChannel,
        Currency,
        UltimateGrossPremium,
        UltimateNetPremium,
        UltimateRIPs,
        UltimatePC
    )
    VALUES
    (
        @UpdateID,
        @Class,
        @ReservingClass,
        @YOA,
        @DistributionChannel,
        @Currency,
        @UltimateGrossPremium,
        @UltimateNetPremium,
        @UltimateRIPs,
        @UltimatePC
    )
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
        MAX(UpdateDate) AS LastUpdatedDate
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
        MAX(UpdateDate) AS LastUpdatedDate
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
