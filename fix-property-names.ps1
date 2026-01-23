# PowerShell script to fix old property name references
# Run this from the C:\repos\DaleSandboxApp2 directory

Write-Host "Fixing property name references..." -ForegroundColor Yellow

# Fix 1: UltimatePremiumList.razor - Replace UltimateGrossPremium with UltimatePremium
$listFile = "Pages\Ultimates\UltimatePremiumList.razor"
if (Test-Path $listFile) {
    $content = Get-Content $listFile -Raw
    $content = $content -replace 'r\.UltimateGrossPremium', 'r.UltimatePremium'
    $content = $content -replace 'rec\.UltimateGrossPremium', 'rec.UltimatePremium'
    Set-Content $listFile $content -NoNewline
    Write-Host "✓ Fixed $listFile" -ForegroundColor Green
}

# Fix 2: EditUltimatePremium.razor - Replace cell.GrossPremium and cell.NetPremium with cell.Premium
$editFile = "Pages\Ultimates\EditUltimatePremium.razor"
if (Test-Path $editFile) {
    $content = Get-Content $editFile -Raw

    # Replace cell.GrossPremium with cell.Premium
    $content = $content -replace 'cell\.GrossPremium', 'cell.Premium'

    # Remove NetPremium references in switch statements (replace with null or remove the line)
    $content = $content -replace '\s*"NetPremium"\s*=>\s*cell\.NetPremium,?\s*', ''

    Set-Content $editFile $content -NoNewline
    Write-Host "✓ Fixed $editFile" -ForegroundColor Green
}

Write-Host "`nAll fixes applied! Please rebuild your solution." -ForegroundColor Cyan
Write-Host "If you still see errors, try:" -ForegroundColor Yellow
Write-Host "  1. Close Visual Studio" -ForegroundColor Gray
Write-Host "  2. Delete bin and obj folders" -ForegroundColor Gray
Write-Host "  3. Reopen and rebuild" -ForegroundColor Gray
