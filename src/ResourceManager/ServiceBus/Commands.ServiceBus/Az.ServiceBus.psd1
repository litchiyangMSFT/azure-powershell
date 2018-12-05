#
# Module manifest for module 'Az.ServiceBus'
#
# Generated by: Microsoft Corporation
#
# Generated on: 3/9/2018
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '0.6.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'ced192ca-b6cd-4848-90dc-b83a5970befc'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - ServiceBus service cmdlets for Azure Resource Manager in PowerShell and PowerShell Core'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '0.6.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = '.\Microsoft.Azure.Management.ServiceBus.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = '.\Microsoft.Azure.Commands.ServiceBus.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('.\Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'New-AzServiceBusNamespace', 'Get-AzServiceBusNamespace', 
    'Set-AzServiceBusNamespace', 
    'Remove-AzServiceBusNamespace', 'New-AzServiceBusQueue', 
    'Get-AzServiceBusQueue', 'Set-AzServiceBusQueue', 
    'Remove-AzServiceBusQueue', 'New-AzServiceBusTopic', 
    'Get-AzServiceBusTopic', 'Set-AzServiceBusTopic', 
    'Remove-AzServiceBusTopic', 'New-AzServiceBusSubscription', 
    'Get-AzServiceBusSubscription', 
    'Set-AzServiceBusSubscription', 
    'Remove-AzServiceBusSubscription', 
    'New-AzServiceBusAuthorizationRule', 
    'Get-AzServiceBusAuthorizationRule', 
    'Set-AzServiceBusAuthorizationRule', 
    'Remove-AzServiceBusAuthorizationRule', 
    'New-AzServiceBusKey', 'Get-AzServiceBusKey', 
    'Get-AzServiceBusOperation', 'New-AzServiceBusRule', 
    'Get-AzServiceBusRule', 'Set-AzServiceBusRule', 
    'Remove-AzServiceBusRule', 
    'New-AzServiceBusGeoDRConfiguration', 
    'Get-AzServiceBusGeoDRConfiguration', 
    'Remove-AzServiceBusGeoDRConfiguration', 
    'Set-AzServiceBusGeoDRConfigurationBreakPair', 
    'Set-AzServiceBusGeoDRConfigurationFailOver', 
    'Test-AzServiceBusName', 'Get-AzServiceBusMigration', 
    'Stop-AzServiceBusMigration', 
    'Start-AzServiceBusMigration', 
    'Complete-AzServiceBusMigration', 
    'Remove-AzServiceBusMigration'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure', 'ResourceManager', 'ARM', 'ServiceBus'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = 'Update release with latest service features and serialization fixes'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

