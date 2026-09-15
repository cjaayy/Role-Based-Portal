@echo off
title RoleBasedPortal
echo ===================================================
echo             Starting RoleBasedPortal
echo ===================================================
echo.

cd /d "%~dp0RoleBasedPortal"

echo Restoring and running application...
dotnet run --launch-profile http

if %ERRORLEVEL% NEQ 0 (
    echo.
    echo Application exited with error code %ERRORLEVEL%.
)

pause
