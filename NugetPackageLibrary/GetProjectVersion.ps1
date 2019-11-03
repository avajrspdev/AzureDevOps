param(
  [string]
  [Parameter(Mandatory=$true)]
  $csprojFile
)[xml]$csprojXml = Get-Content $csprojFile

$version = $csprojXml.Project.PropertyGroup.Version

Write-Host "##vso[task.setvariable variable=version]$version"