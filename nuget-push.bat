set /p Project=Project: 
set /p Version=Version: 
set /p Key=Key: 
nuget push %Project%.%Version%.nupkg %Key% -Source https://www.nuget.org/api/v2/package
pause