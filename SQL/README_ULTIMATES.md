# ULTIMATES Feature Implementation

## Overview
The ULTIMATES feature tracks underwriter selections of Ultimate Premium data with full audit trails. Data is stored at the resolution of:
- **Class**
- **ReservingClass**
- **YOA** (Year of Account)
- **DistributionChannel** (EU or LNDN)
- **Currency**

## Fields Tracked
- **Ultimate Gross Premium**
- **Ultimate Net Premium**
- **Ultimate RIPs** (Reinstatement Premiums)
- **Ultimate PC** (Profit Commission)

## Features Implemented

### 1. PREMIUM Tracking (COMPLETE)
- ✅ View/List page showing all Class/YOA combinations with summary totals
- ✅ Edit page with editable grid for all records at Class/YOA level
- ✅ Full audit trail - each update creates a new UpdateID
- ✅ History view showing all past updates with aggregated totals
- ✅ Snapshot view showing current "latest" version for each combination

### 2. CLAIMS Tracking (PLACEHOLDER)
- ⏳ Placeholder page created for future implementation

## Database Setup

### Step 1: Run SQL Scripts
Execute the following SQL scripts in order:

```sql
-- 1. Create schema and tables
USE [YourDatabase]
GO
-- Run: SQL/01_Ultimates_Schema_Tables.sql

-- 2. Create stored procedures
-- Run: SQL/02_Ultimates_StoredProcedures.sql
```

### Step 2: Populate Initial Data (Optional)
You can insert initial data for testing:

```sql
-- Example: Insert initial premium data
INSERT INTO [Ultimates].[UltimatePremium]
    (Class, ReservingClass, YOA, DistributionChannel, Currency,
     UltimateGrossPremium, UltimateNetPremium, UltimateRIPs, UltimatePC,
     CreatedBy, LastUpdatedBy)
VALUES
    ('Property', 'Fire', 2024, 'EU', 'USD', 1000000, 900000, 50000, 25000, 'SYSTEM', 'SYSTEM'),
    ('Property', 'Fire', 2024, 'LNDN', 'GBP', 800000, 720000, 40000, 20000, 'SYSTEM', 'SYSTEM'),
    ('Casualty', 'Liability', 2024, 'EU', 'EUR', 1200000, 1080000, 60000, 30000, 'SYSTEM', 'SYSTEM');
```

## Application Structure

### Database Objects
- **Schema**: `Ultimates`
- **Table**: `Ultimates.UltimatePremium` - Main table with audit tracking
- **Views**:
  - `Ultimates.vwUltimatePremiumSnapshot` - Current latest version
  - `Ultimates.vwUltimatePremiumSummaryByClassYOA` - Aggregated summary
- **Stored Procedures**:
  - `spGetUltimatePremiumSnapshot` - Get current snapshot
  - `spGetUltimatePremiumByClassYOA` - Get records for editing
  - `spGetUltimatePremiumHistoryByClassYOA` - Get history
  - `spUpsertUltimatePremium` - Save/update records
  - `spGetUltimatePremiumListClassYOA` - Get list for navigation

### C# Components

#### Models (`/Models/Ultimates/`)
- `UltimatePremiumRecordModel.cs` - Single record
- `UltimatePremiumEditModel.cs` - Edit page model with collection
- `UltimatePremiumHistoryModel.cs` - History record
- `UltimatePremiumSummaryModel.cs` - Summary for list view

#### Service (`/Services/`)
- `UltimatesService.cs` - Business logic layer with CRUD operations

#### Pages (`/Pages/Ultimates/`)
- `UltimatePremiumList.razor` - List/navigation page
- `EditUltimatePremium.razor` - Combined view/edit page with grid and history
- `UltimateClaimsList.razor` - Placeholder for claims

### Navigation
- Menu added to sidebar under "ULTIMATES" with two sub-items:
  - **Premium** → `/Ultimates/Premium`
  - **Claims** → `/Ultimates/Claims`

## Usage Guide

### Viewing Premium Data
1. Navigate to **ULTIMATES > Premium** from the sidebar
2. View summary list of all Class/YOA combinations with totals
3. Click **Edit** on any row to view/edit details

### Editing Premium Data
1. From the list, click **Edit** for a specific Class/YOA
2. The edit page displays:
   - **Summary totals** at the top (auto-calculated)
   - **Editable grid** with all records for that Class/YOA
   - **History section** showing all past updates
3. To modify a record:
   - Edit values in the grid (fields are editable)
   - Changes are tracked automatically
4. To add a new record:
   - Click **Add Row** button
   - Fill in Reserving Class, Distribution Channel, Currency
   - Enter premium values
5. Click **Save Changes** to commit
   - This creates a new UpdateID in the database
   - All modified records get new audit entries

### Understanding the Audit Trail
- Every save creates new records with new UpdateIDs
- The **Snapshot view** always shows the latest UpdateID for each combination
- The **History section** shows:
  - All past UpdateIDs
  - Aggregated totals for each update
  - Who made the update and when
- Old versions are never deleted - full audit trail is preserved

## Data Validation
- **Distribution Channel**: Must be 'EU' or 'LNDN' (enforced at database level)
- **Required fields** for new records:
  - Class (inherited from page context)
  - ReservingClass
  - YOA (inherited from page context)
  - DistributionChannel
  - Currency

## Technical Notes

### Versioning Strategy
- Each edit creates **new rows** in the database (not updates)
- UpdateID is auto-incrementing identity column
- Snapshot view uses MAX(UpdateID) to find latest version
- This pattern ensures complete audit history

### Future Enhancements (Not Yet Implemented)
- Approval workflow (approved/unapproved updates)
- Delete functionality (currently not implemented - follows audit-first approach)
- Export to Excel
- Bulk import from Excel
- Advanced filtering/search
- Class/YOA selection dropdowns from reference data
- Validation rules (e.g., Net Premium <= Gross Premium)

## Files Created

### SQL Scripts
- `/SQL/01_Ultimates_Schema_Tables.sql` - Database schema and tables
- `/SQL/02_Ultimates_StoredProcedures.sql` - All stored procedures

### C# Models
- `/Models/Ultimates/UltimatePremiumRecordModel.cs`
- `/Models/Ultimates/UltimatePremiumEditModel.cs`
- `/Models/Ultimates/UltimatePremiumHistoryModel.cs`
- `/Models/Ultimates/UltimatePremiumSummaryModel.cs`

### Service Layer
- `/Services/UltimatesService.cs`

### Razor Pages
- `/Pages/Ultimates/UltimatePremiumList.razor`
- `/Pages/Ultimates/EditUltimatePremium.razor`
- `/Pages/Ultimates/UltimateClaimsList.razor` (placeholder)

### Configuration
- `/Services/MenuDataServiceSandbox.cs` - Updated with ULTIMATES menu
- `/Program.cs` - Updated with UltimatesService registration

## Next Steps

### To Deploy
1. Run SQL scripts on your database
2. Build and run the application
3. Navigate to ULTIMATES > Premium
4. Add initial data or populate from existing sources

### For CLAIMS Implementation
When ready to implement ULTIMATES CLAIMS:
1. Follow the same pattern as PREMIUM
2. Create similar table structure for claims data
3. Define which claims fields to track
4. Reuse the same audit trail pattern
5. Create models, service methods, and pages similar to Premium

## Support
For questions or issues, refer to the existing patterns in:
- ORI module (for similar edit grid patterns)
- Windowpane module (for view patterns)
- RiskReview module (for audit trail examples)
