-- =============================================
-- ULTIMATES Stored Procedures Update
-- Purpose: Update stored procedures to use new GrossNet, UltimatePremium, and Deductions columns
-- Author: Claude
-- Date: 2025-01-14
-- =============================================

-- =============================================
-- SP: Get Ultimate Premium Snapshot (Current Latest)
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
        ValueType,
        GrossNet,
        UltimatePremium,
        UltimateNetPremium,
        Deductions,
        UltimateRIPs,
        UltimatePC,
        UpdateDate,
        UpdatedBy
    FROM [Ultimates].[vwUltimatePremiumSnapshot]
    ORDER BY Class, YOA, ReservingClass, DistributionChannel, Currency
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumSnapshot] updated'
GO

-- =============================================
-- SP: Get Ultimate Premium by Class/YOA
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
        ValueType,
        GrossNet,
        UltimatePremium,
        UltimateNetPremium,
        Deductions,
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

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumByClassYOA] updated'
GO

-- =============================================
-- SP: Get Ultimate Premium History by Class/YOA
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

    SELECT
        up.UpdateID,
        up.Class,
        up.YOA,
        COUNT(*) AS RecordCount,
        SUM(up.UltimatePremium) AS TotalUltimatePremium,
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

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumHistoryByClassYOA] updated'
GO

-- =============================================
-- SP: Get Ultimate Premium History Detail by UpdateID
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
    WHERE up.UpdateID = @UpdateID
    ORDER BY up.ReservingClass, up.DistributionChannel, up.Currency
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumHistoryDetail] updated'
GO

-- =============================================
-- SP: Upsert Ultimate Premium
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
    @ValueType NVARCHAR(20),
    @GrossNet NVARCHAR(10),
    @UltimatePremium DECIMAL(18,2),
    @UltimateNetPremium DECIMAL(18,2),
    @Deductions DECIMAL(5,4),
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
        ValueType,
        GrossNet,
        UltimatePremium,
        UltimateNetPremium,
        Deductions,
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
        @ValueType,
        @GrossNet,
        @UltimatePremium,
        @UltimateNetPremium,
        @Deductions,
        @UltimateRIPs,
        @UltimatePC
    )
END
GO

PRINT 'Procedure [Ultimates].[spUpsertUltimatePremium] updated'
GO

-- =============================================
-- SP: Get List of YOAs for a specific Class
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
        SUM(UltimatePremium) AS TotalUltimatePremium,
        MAX(UpdateDate) AS LastUpdatedDate
    FROM [Ultimates].[vwUltimatePremiumSnapshot]
    WHERE Class = @Class
    GROUP BY YOA
    ORDER BY YOA DESC
END
GO

PRINT 'Procedure [Ultimates].[spGetUltimatePremiumYOAsByClass] updated'
GO

PRINT '=== Ultimates Stored Procedures updated successfully ==='
GO
