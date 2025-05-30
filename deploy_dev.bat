@echo off
setlocal

:: Variables
set SourcePath=%~dp0publish
set DestinationPath=\\duwpmdev01\c$\inetpub\wwwroot\Sandbox2
set Timestamp=%DATE:~-4%%DATE:~3,2%%DATE:~0,2%%TIME:~0,2%%TIME:~3,2%
set BackupPath=\\duwpmdev01\c$\inetpub\wwwroot\Sandbox2_Backup_%Timestamp%
set AppPoolName=DefaultAppPool

:: Clean up the existing publish folder
if exist "%SourcePath%" (
    echo Cleaning up the publish folder...
    rmdir /S /Q "%SourcePath%"
)

:: Publish the application
echo Publishing the application...
dotnet publish Sandbox.csproj -c Release -o "%SourcePath%"
if %ERRORLEVEL% neq 0 (
    echo Failed to publish the application. Exiting.
    exit /b 1
)

:: Backup the existing website using robocopy
if exist "%DestinationPath%" (
    echo Backing up the current website to "%BackupPath%"...
    mkdir "%BackupPath%"
    robocopy "%DestinationPath%" "%BackupPath%" /MIR /R:2 /W:1 /NFL /NDL /NS /NC /NP
    if %ERRORLEVEL% GEQ 8 (
        echo robocopy encountered an error during backup. Exiting.
        exit /b 1
    )
)

:: Stop the IIS Application Pool
echo Stopping IIS Application Pool...
"C:\PSTools\psexec.exe" \\duwpmdev01 C:\Windows\System32\inetsrv\appcmd stop apppool /apppool.name:%AppPoolName%
if %ERRORLEVEL% neq 0 (
    echo Application pool was not running or failed to stop. Continuing deployment.
) else (
    echo Application pool stopped successfully.
)

:: Deploy only changed files
echo Deploying updated files to IIS...
robocopy "%SourcePath%" "%DestinationPath%" /MIR /XO /R:2 /W:1 /NFL /NDL /NS /NC /NP
if %ERRORLEVEL% GEQ 8 (
    echo robocopy encountered an error during deployment. Exiting.
    exit /b 1
)

:: Start the IIS Application Pool
echo Starting the IIS Application Pool...
"C:\PSTools\psexec.exe" \\duwpmdev01 C:\Windows\System32\inetsrv\appcmd start apppool /apppool.name:%AppPoolName%
if %ERRORLEVEL% neq 0 (
    echo Failed to start the application pool. Exiting.
    exit /b 1
)

:: Restart IIS (optional)
echo Restarting IIS...
"C:\PSTools\psexec.exe" \\duwpmdev01 iisreset
if %ERRORLEVEL% neq 0 (
    echo Failed to restart IIS. Exiting.
    exit /b 1
)

echo Deployment completed successfully.
endlocal
exit /b 0
