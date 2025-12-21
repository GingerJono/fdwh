-- Migration: Add VersionID to SUA table and create FK relationship
-- Date: 2025-12-19

-- Step 1: Add VersionID column as NULLABLE
ALTER TABLE dbo.SUA
ADD VersionID INT NULL;
GO

-- Step 2: Populate VersionID by joining on Version string
UPDATE s
SET s.VersionID = sv.VersionID
FROM dbo.SUA s
INNER JOIN dbo.SUAVersions sv ON s.Version = sv.Version;
GO

-- Step 3: Verify all records were populated (optional check)
-- SELECT COUNT(*) as UnmatchedRecords FROM dbo.SUA WHERE VersionID IS NULL;

-- Step 4: Make VersionID NOT NULL
ALTER TABLE dbo.SUA
ALTER COLUMN VersionID INT NOT NULL;
GO

-- Step 5: Create Foreign Key constraint
ALTER TABLE dbo.SUA
ADD CONSTRAINT FK_SUA_SUAVersions
FOREIGN KEY (VersionID) REFERENCES dbo.SUAVersions(VersionID);
GO

-- Step 6 (Optional): Drop the Version column if no longer needed
-- ALTER TABLE dbo.SUA
-- DROP COLUMN Version;
-- GO

PRINT 'Migration completed successfully';
