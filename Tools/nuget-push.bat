echo off
set /p Project=Project: 
set /p Version=Version: 
set /p Key=Key: 
if not exist packages mkdir packages
cd packages 
echo on
nuget push %Project%.%Version%.nupkg %Key% -Source https://www.nuget.org/api/v2/package
pause