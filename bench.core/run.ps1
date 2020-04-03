
#https://docs.microsoft.com/ru-ru/dotnet/core/tools/dotnet-run

$currentPath = $PSScriptRoot;

$binPath = $currentPath+"\bin\Release\netcoreapp3.1"
Set-Location -Path $currentPath
dotnet build --configuration Release

#Start-Process -FilePath $binPath\bench.exe -ArgumentList NameParser #ListMemory


