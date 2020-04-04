#https://docs.microsoft.com/ru-ru/dotnet/core/tools/dotnet-run

$currentPath = $PSScriptRoot;
Set-Location -Path $currentPath
dotnet run --configuration Release NameParserBenchmark