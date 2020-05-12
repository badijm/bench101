#https://docs.microsoft.com/ru-ru/dotnet/core/tools/dotnet-run

$currentPath = $PSScriptRoot;
Set-Location -Path $currentPath
dotnet clean
dotnet build -c Release --framework netcoreapp3.1
dotnet run -c Release --no-build --no-restore --framework netcoreapp3.1 VectorizationBenchmark 