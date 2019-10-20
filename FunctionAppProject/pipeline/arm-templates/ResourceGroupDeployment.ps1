param(
  [string]
  [Parameter(Mandatory=$true)]
  $deploymentName,

  [string]
  [Parameter(Mandatory=$true)]
  $resourceGroup,

  [string]
  [Parameter(Mandatory=$true)]
  $templateFile,

  [string]
  [Parameter(Mandatory=$true)]
  $templateParameterFile
)

# https://docs.microsoft.com/en-us/powershell/module/az.resources/new-azresourcegroupdeployment

New-AzResourceGroupDeployment `
  -Name $deploymentName `
  -ResourceGroupName $resourceGroup `
  -TemplateFile $templateFile `
  -TemplateParameterFile $templateParameterFile