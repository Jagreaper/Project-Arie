set /p Project=Project: 
nuget pack %Project%\%Project%.csproj -properties Configuration=Release 
pause