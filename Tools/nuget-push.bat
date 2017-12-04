echo off
set /p Project=Project: 
set /p Version=Version: 
set /p Key=Key: 
set /p Auto=Automatic Pack: 
if not exist packages mkdir packages
if "%auto%" == "n" cd packages
if "%auto%" == "y" cd "..\%Project%\bin\Release"
echo on
nuget push %Project%.%Version%.nupkg %Key% -Source https://www.nuget.org/api/v2/package
pause