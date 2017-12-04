echo off
set /p Project=Project: 
if not exist packages mkdir packages
cd packages
echo on
nuget pack ..\..\%Project%\%Project%.csproj -properties Configuration=Release 
pause