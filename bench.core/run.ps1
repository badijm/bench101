#https://docs.microsoft.com/ru-ru/dotnet/core/tools/dotnet-run

$currentPath = $PSScriptRoot;
Set-Location -Path $currentPath
dotnet run -c Release --no-build