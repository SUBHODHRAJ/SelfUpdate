```bat
@echo off
echo ==============================
echo     Git Auto Push
echo ==============================

set /p msg=Enter commit message: 

if "%msg%"=="" (
    echo Commit message cannot be empty!
    pause
    exit /b 1
)

git add .

git commit -m "%msg%"

if errorlevel 1 (
    echo Commit failed or no changes to commit.
    pause
    exit /b 1
)

git push

if errorlevel 1 (
    echo Push failed. Please check your Git connection.
    pause
    exit /b 1
)

echo.
echo Successfully pushed to GitHub!
pause
```