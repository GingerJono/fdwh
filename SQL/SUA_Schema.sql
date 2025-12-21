-- SUA Upload Tables
-- Run this script to create the required tables for SUA upload functionality

-- Table to store SUA version metadata
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SUAVersions]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[SUAVersions](
        [ID] [int] IDENTITY(1,1) NOT NULL,
        [Version] [varchar](50) NOT NULL,
        [ProcessingMonth] [int] NOT NULL,
        [Syndicate] [varchar](10) NOT NULL,
        [Comments] [nvarchar](500) NULL,
        [UploadDate] [datetime] NOT NULL,
        [UploadedBy] [nvarchar](100) NOT NULL,
        [RowCount] [int] NOT NULL,
        [Status] [varchar](20) NOT NULL,
        [ErrorMessage] [nvarchar](max) NULL,
        CONSTRAINT [PK_SUAVersions] PRIMARY KEY CLUSTERED ([ID] ASC)
    ) ON [PRIMARY]
END
GO

-- Table to store SUA data
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SUA]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[SUA](
        [ID] [int] IDENTITY(1,1) NOT NULL,
        [SUAVersionID] [int] NOT NULL,
        [Version] [varchar](50) NULL,
        [YOA] [int] NULL,
        [ClassCode] [varchar](10) NULL,
        [ClassName] [varchar](100) NULL,
        [ReservingClass] [varchar](10) NULL,
        [DistributionChannel] [varchar](50) NULL,
        [SettCcy] [varchar](10) NULL,
        [Item] [varchar](100) NULL,
        [ClaimsDetail] [varchar](100) NULL,
        [RIType] [varchar](50) NULL,
        [ValueSettCcy] [decimal](18, 2) NULL,
        [Comment] [nvarchar](500) NULL,
        CONSTRAINT [PK_SUA] PRIMARY KEY CLUSTERED ([ID] ASC),
        CONSTRAINT [FK_SUA_SUAVersions] FOREIGN KEY([SUAVersionID])
            REFERENCES [dbo].[SUAVersions] ([ID])
            ON DELETE CASCADE
    ) ON [PRIMARY]
END
GO

-- Create indexes for better performance
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_SUA_SUAVersionID' AND object_id = OBJECT_ID('dbo.SUA'))
BEGIN
    CREATE NONCLUSTERED INDEX [IX_SUA_SUAVersionID] ON [dbo].[SUA]
    (
        [SUAVersionID] ASC
    ) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_SUAVersions_ProcessingMonth' AND object_id = OBJECT_ID('dbo.SUAVersions'))
BEGIN
    CREATE NONCLUSTERED INDEX [IX_SUAVersions_ProcessingMonth] ON [dbo].[SUAVersions]
    (
        [ProcessingMonth] ASC
    ) ON [PRIMARY]
END
GO

PRINT 'SUA tables created successfully'
