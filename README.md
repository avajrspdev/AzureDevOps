# Playing with Azure DevOps

#### Resources

- [Azure Pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/)
  - [YAML schema reference](https://docs.microsoft.com/en-us/azure/devops/pipelines/yaml-schema)
  - [Build and release tasks](https://docs.microsoft.com/en-us/azure/devops/pipelines/tasks)
  - [Predefined variables](https://docs.microsoft.com/en-us/azure/devops/pipelines/build/variables)
- [Azure PowerShell](https://docs.microsoft.com/en-us/powershell/azure)
  - [Install the Azure PowerShell module](https://docs.microsoft.com/en-us/powershell/azure/install-az-ps)
  - [PowerShell Module Browser](https://docs.microsoft.com/en-us/powershell/module/)
- ARM - [Azure Resource Manager](https://docs.microsoft.com/en-us/azure/azure-resource-manager/)
  - [Understand the structure and syntax of ARM templates](https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-authoring-templates)
  - [ARM template functions](https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-template-functions)
  - [Define resources in ARM templates](https://docs.microsoft.com/en-us/azure/templates/)
  - [Deploy resources with ARM templates and Azure PowerShell](https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-template-deploy)
- Others
  - [Azure DevOps Pipelines Refactoring Technics](https://devkimchi.com/2019/09/04/azure-devops-pipelines-refactoring-technics/) *(DevKimchi)*

#### Pipelines

###### HelloDevOps/pipeline-hello-devops.yml

This is a very simple pipeline using just script tasks to play around with the template and YAML basics.

###### FunctionAppProject/pipeline/pipeline-function-app.yml

1. Stage: Build Azure Function App
2. Stage: Deploy to Development, Stage or Production depends on the parameter
   1. Job: Provisioning Azure Resources using ARM templates. Using a variable group to read values from KeyVault and set them to the Function App configuration during the provisioning process.
   2. Job: Deploy Azure Function App

![](https://github.com/19balazs86/AzureDevOps/blob/master/FunctionAppProject/DevOpsPipelineResult.JPG)
