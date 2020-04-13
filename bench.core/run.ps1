#https://docs.microsoft.com/ru-ru/dotnet/core/tools/dotnet-run

$currentPath = $PSScriptRoot;
Set-Location -Path $currentPath
#binaries - up to date
dotnet build -c Release 
dotnet run -c Release --no-build BranchBenchmark