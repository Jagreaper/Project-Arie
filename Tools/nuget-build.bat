set /p Project=Project: 
if not exist packages mkdir packages
cd packages
nuget pack ..\..\%Project%\%Project%.csproj -properties Configuration=Release 
pause