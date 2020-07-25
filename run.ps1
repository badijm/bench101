#https://docs.microsoft.com/ru-ru/dotnet/core/tools/dotnet-run

$currentPath = $PSScriptRoot;
Set-Location -Path $currentPath
dotnet clean bench101.sln
dotnet build bench101.sln -c Release
dotnet run -c Release --no-build --no-restore LoopEvenOddBenchmark 