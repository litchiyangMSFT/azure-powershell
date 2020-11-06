
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Description for Creates a new web, mobile, or API app in an existing resource group, or updates an existing app.
.Description
Description for Creates a new web, mobile, or API app in an existing resource group, or updates an existing app.
.Example
PS C:\> Update-AzFunctionApp -Name MyUniqueFunctionAppName -ResourceGroupName MyResourceGroupName -PlanName NewPlanName 
.Example
PS C:\> Update-AzFunctionApp -Name MyUniqueFunctionAppName -ResourceGroupName MyResourceGroupName -IdentityType SystemAssigned 
.Example
PS C:\> Update-AzFunctionApp -Name MyUniqueFunctionAppName -ResourceGroupName MyResourceGroupName -ApplicationInsightsName ApplicationInsightsProjectName 
.Example
PS C:\> Update-AzFunctionApp -Name MyUniqueFunctionAppName -ResourceGroupName MyResourceGroupName -IdentityType None 

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISitePatchResource
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IFunctionsIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISite
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

HOSTNAMESSLSTATE <IHostNameSslState[]>: Hostname SSL states are used to manage the SSL bindings for app's hostnames.
  [HostType <HostType?>]: Indicates whether the hostname is a standard or repository hostname.
  [Name <String>]: Hostname.
  [SslState <SslState?>]: SSL type.
  [Thumbprint <String>]: SSL certificate thumbprint.
  [ToUpdate <Boolean?>]: Set to <code>true</code> to update existing hostname.
  [VirtualIP <String>]: Virtual IP address assigned to the hostname if IP based SSL is enabled.

INPUTOBJECT <IFunctionsIdentity>: Identity Parameter
  [AccountName <String>]: The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
  [AnalysisName <String>]: Analysis Name
  [AppSettingKey <String>]: App Setting key name.
  [Authprovider <String>]: The auth provider for the users.
  [BackupId <String>]: ID of the backup.
  [BaseAddress <String>]: Module base address.
  [BlobServicesName <String>]: The name of the blob Service within the specified storage account. Blob Service Name must be 'default'
  [CertificateOrderName <String>]: Name of the certificate order..
  [ContainerName <String>]: The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
  [DeletedSiteId <String>]: The numeric ID of the deleted app, e.g. 12345
  [DetectorName <String>]: Detector Resource Name
  [DiagnosticCategory <String>]: Diagnostic Category
  [DiagnosticsName <String>]: Name of the diagnostics item.
  [DomainName <String>]: Name of the domain.
  [DomainOwnershipIdentifierName <String>]: Name of domain ownership identifier.
  [EntityName <String>]: Name of the hybrid connection.
  [FunctionName <String>]: Function name.
  [GatewayName <String>]: Name of the gateway. Currently, the only supported string is "primary".
  [HostName <String>]: Hostname in the hostname binding.
  [HostingEnvironmentName <String>]: Name of the hosting environment.
  [Id <String>]: Deployment ID.
  [Id1 <String>]: Resource identity path
  [ImmutabilityPolicyName <String>]: The name of the blob container immutabilityPolicy within the specified storage account. ImmutabilityPolicy Name must be 'default'
  [Instance <String>]: Name of the instance in the multi-role pool.
  [InstanceId <String>]: 
  [KeyId <String>]: The API Key ID. This is unique within a Application Insights component.
  [KeyName <String>]: The name of the key.
  [KeyType <String>]: The type of host key.
  [Location <String>]: 
  [ManagementPolicyName <ManagementPolicyName?>]: The name of the Storage Account Management Policy. It should always be 'default'
  [Name <String>]: Name of the certificate.
  [NamespaceName <String>]: The namespace for this hybrid connection.
  [OperationId <String>]: GUID of the operation.
  [PrId <String>]: The stage site identifier.
  [PremierAddOnName <String>]: Add-on name.
  [PrivateEndpointConnectionName <String>]: 
  [ProcessId <String>]: PID.
  [PublicCertificateName <String>]: Public certificate name.
  [PurgeId <String>]: In a purge status request, this is the Id of the operation the status of which is returned.
  [RelayName <String>]: The relay name for this hybrid connection.
  [ResourceGroupName <String>]: Name of the resource group to which the resource belongs.
  [ResourceName <String>]: The name of the Application Insights component resource.
  [RouteName <String>]: Name of the Virtual Network route.
  [Scope <String>]: The resource provider scope of the resource. Parent resource being extended by Managed Identities.
  [SiteExtensionId <String>]: Site extension name.
  [SiteName <String>]: Site Name
  [Slot <String>]: Slot Name
  [SnapshotId <String>]: The ID of the snapshot to read.
  [SourceControlType <String>]: Type of source control
  [SubscriptionId <String>]: Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000).
  [Userid <String>]: The user id of the user.
  [View <String>]: The type of view. This can either be "summary" or "detailed".
  [VnetName <String>]: Name of the virtual network.
  [WebJobName <String>]: Name of Web Job.
  [WorkerName <String>]: Name of worker machine, which typically starts with RD.
  [WorkerPoolName <String>]: Name of the worker pool.

SITECONFIG <ISiteConfig>: Configuration of the app.
  IsPushEnabled <Boolean>: Gets or sets a flag indicating whether the Push endpoint is enabled.
  [ActionMinProcessExecutionTime <String>]: Minimum time the process must execute         before taking the action
  [ActionType <AutoHealActionType?>]: Predefined action to be taken.
  [AlwaysOn <Boolean?>]: <code>true</code> if Always On is enabled; otherwise, <code>false</code>.
  [ApiDefinitionUrl <String>]: The URL of the API definition.
  [ApiManagementConfigId <String>]: APIM-Api Identifier.
  [AppCommandLine <String>]: App command line to launch.
  [AppSetting <INameValuePair[]>]: Application settings.
    [Name <String>]: Pair name.
    [Value <String>]: Pair value.
  [AutoHealEnabled <Boolean?>]: <code>true</code> if Auto Heal is enabled; otherwise, <code>false</code>.
  [AutoSwapSlotName <String>]: Auto-swap slot name.
  [ConnectionString <IConnStringInfo[]>]: Connection strings.
    [ConnectionString <String>]: Connection string value.
    [Name <String>]: Name of connection string.
    [Type <ConnectionStringType?>]: Type of database.
  [CorAllowedOrigin <String[]>]: Gets or sets the list of origins that should be allowed to make cross-origin         calls (for example: http://example.com:12345). Use "*" to allow all.
  [CorSupportCredentials <Boolean?>]: Gets or sets whether CORS requests with credentials are allowed. See         https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials         for more details.
  [CustomActionExe <String>]: Executable to be run.
  [CustomActionParameter <String>]: Parameters for the executable.
  [DefaultDocument <String[]>]: Default documents.
  [DetailedErrorLoggingEnabled <Boolean?>]: <code>true</code> if detailed error logging is enabled; otherwise, <code>false</code>.
  [DocumentRoot <String>]: Document root.
  [DynamicTagsJson <String>]: Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
  [ExperimentRampUpRule <IRampUpRule[]>]: List of ramp-up rules.
    [ActionHostName <String>]: Hostname of a slot to which the traffic will be redirected if decided to. E.g. myapp-stage.azurewebsites.net.
    [ChangeDecisionCallbackUrl <String>]: Custom decision algorithm can be provided in TiPCallback site extension which URL can be specified. See TiPCallback site extension for the scaffold and contracts.         https://www.siteextensions.net/packages/TiPCallback/
    [ChangeIntervalInMinute <Int32?>]: Specifies interval in minutes to reevaluate ReroutePercentage.
    [ChangeStep <Double?>]: In auto ramp up scenario this is the step to add/remove from <code>ReroutePercentage</code> until it reaches \n<code>MinReroutePercentage</code> or         <code>MaxReroutePercentage</code>. Site metrics are checked every N minutes specified in <code>ChangeIntervalInMinutes</code>.\nCustom decision algorithm         can be provided in TiPCallback site extension which URL can be specified in <code>ChangeDecisionCallbackUrl</code>.
    [MaxReroutePercentage <Double?>]: Specifies upper boundary below which ReroutePercentage will stay.
    [MinReroutePercentage <Double?>]: Specifies lower boundary above which ReroutePercentage will stay.
    [Name <String>]: Name of the routing rule. The recommended name would be to point to the slot which will receive the traffic in the experiment.
    [ReroutePercentage <Double?>]: Percentage of the traffic which will be redirected to <code>ActionHostName</code>.
  [FtpsState <FtpsState?>]: State of FTP / FTPS service
  [HandlerMapping <IHandlerMapping[]>]: Handler mappings.
    [Argument <String>]: Command-line arguments to be passed to the script processor.
    [Extension <String>]: Requests with this extension will be handled using the specified FastCGI application.
    [ScriptProcessor <String>]: The absolute path to the FastCGI application.
  [HealthCheckPath <String>]: Health check path
  [Http20Enabled <Boolean?>]: Http20Enabled: configures a web site to allow clients to connect over http2.0
  [HttpLoggingEnabled <Boolean?>]: <code>true</code> if HTTP logging is enabled; otherwise, <code>false</code>.
  [IPSecurityRestriction <IIPSecurityRestriction[]>]: IP security restrictions for main.
    [Action <String>]: Allow or Deny access for this IP range.
    [Description <String>]: IP restriction rule description.
    [IPAddress <String>]: IP address the security restriction is valid for.         It can be in form of pure ipv4 address (required SubnetMask property) or         CIDR notation such as ipv4/mask (leading bit match). For CIDR,         SubnetMask property must not be specified.
    [Name <String>]: IP restriction rule name.
    [Priority <Int32?>]: Priority of IP restriction rule.
    [SubnetMask <String>]: Subnet mask for the range of IP addresses the restriction is valid for.
    [SubnetTrafficTag <Int32?>]: (internal) Subnet traffic tag
    [Tag <IPFilterTag?>]: Defines what this IP filter will be used for. This is to support IP filtering on proxies.
    [VnetSubnetResourceId <String>]: Virtual network resource id
    [VnetTrafficTag <Int32?>]: (internal) Vnet traffic tag
  [JavaContainer <String>]: Java container.
  [JavaContainerVersion <String>]: Java container version.
  [JavaVersion <String>]: Java version.
  [LimitMaxDiskSizeInMb <Int64?>]: Maximum allowed disk size usage in MB.
  [LimitMaxMemoryInMb <Int64?>]: Maximum allowed memory usage in MB.
  [LimitMaxPercentageCpu <Double?>]: Maximum allowed CPU usage percentage.
  [LinuxFxVersion <String>]: Linux App Framework and version
  [LoadBalancing <SiteLoadBalancing?>]: Site load balancing.
  [LocalMySqlEnabled <Boolean?>]: <code>true</code> to enable local MySQL; otherwise, <code>false</code>.
  [LogsDirectorySizeLimit <Int32?>]: HTTP logs directory size limit.
  [MachineKeyDecryption <String>]: Algorithm used for decryption.
  [MachineKeyDecryptionKey <String>]: Decryption key.
  [MachineKeyValidation <String>]: MachineKey validation.
  [MachineKeyValidationKey <String>]: Validation key.
  [ManagedPipelineMode <ManagedPipelineMode?>]: Managed pipeline mode.
  [ManagedServiceIdentityId <Int32?>]: Managed Service Identity Id
  [MinTlsVersion <SupportedTlsVersions?>]: MinTlsVersion: configures the minimum version of TLS required for SSL requests
  [NetFrameworkVersion <String>]: .NET Framework version.
  [NodeVersion <String>]: Version of Node.js.
  [NumberOfWorker <Int32?>]: Number of workers.
  [PhpVersion <String>]: Version of PHP.
  [PowerShellVersion <String>]: Version of PowerShell.
  [PreWarmedInstanceCount <Int32?>]: Number of preWarmed instances.         This setting only applies to the Consumption and Elastic Plans
  [PublishingUsername <String>]: Publishing user name.
  [PushKind <String>]: Kind of resource.
  [PythonVersion <String>]: Version of Python.
  [RemoteDebuggingEnabled <Boolean?>]: <code>true</code> if remote debugging is enabled; otherwise, <code>false</code>.
  [RemoteDebuggingVersion <String>]: Remote debugging version.
  [RequestCount <Int32?>]: Request Count.
  [RequestTimeInterval <String>]: Time interval.
  [RequestTracingEnabled <Boolean?>]: <code>true</code> if request tracing is enabled; otherwise, <code>false</code>.
  [RequestTracingExpirationTime <DateTime?>]: Request tracing expiration time.
  [ScmIPSecurityRestriction <IIPSecurityRestriction[]>]: IP security restrictions for scm.
  [ScmIPSecurityRestrictionsUseMain <Boolean?>]: IP security restrictions for scm to use main.
  [ScmType <ScmType?>]: SCM type.
  [SlowRequestCount <Int32?>]: Request Count.
  [SlowRequestTimeInterval <String>]: Time interval.
  [SlowRequestTimeTaken <String>]: Time taken.
  [TagWhitelistJson <String>]: Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
  [TagsRequiringAuth <String>]: Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.         Tags can consist of alphanumeric characters and the following:         '_', '@', '#', '.', ':', '-'.         Validation should be performed at the PushRequestHandler.
  [TracingOption <String>]: Tracing options.
  [TriggerPrivateBytesInKb <Int32?>]: A rule based on private bytes.
  [TriggerStatusCode <IStatusCodesBasedTrigger[]>]: A rule based on status codes.
    [Count <Int32?>]: Request Count.
    [Status <Int32?>]: HTTP status code.
    [SubStatus <Int32?>]: Request Sub Status.
    [TimeInterval <String>]: Time interval.
    [Win32Status <Int32?>]: Win32 error code.
  [Use32BitWorkerProcess <Boolean?>]: <code>true</code> to use 32-bit worker process; otherwise, <code>false</code>.
  [VirtualApplication <IVirtualApplication[]>]: Virtual applications.
    [PhysicalPath <String>]: Physical path.
    [PreloadEnabled <Boolean?>]: <code>true</code> if preloading is enabled; otherwise, <code>false</code>.
    [VirtualDirectory <IVirtualDirectory[]>]: Virtual directories for virtual application.
      [PhysicalPath <String>]: Physical path.
      [VirtualPath <String>]: Path to virtual application.
    [VirtualPath <String>]: Virtual path.
  [VnetName <String>]: Virtual Network name.
  [WebSocketsEnabled <Boolean?>]: <code>true</code> if WebSocket is enabled; otherwise, <code>false</code>.
  [WindowsFxVersion <String>]: Xenon App Framework and version
  [XManagedServiceIdentityId <Int32?>]: Explicit Managed Service Identity Id

SITEENVELOPE <ISitePatchResource>: ARM resource for a site.
  CloningInfoSourceWebAppId <String>: ARM resource ID of the source app. App resource ID is of the form         /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and         /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
  [Kind <String>]: Kind of resource.
  [ClientAffinityEnabled <Boolean?>]: <code>true</code> to enable client affinity; <code>false</code> to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is <code>true</code>.
  [ClientCertEnabled <Boolean?>]: <code>true</code> to enable client certificate authentication (TLS mutual authentication); otherwise, <code>false</code>. Default is <code>false</code>.
  [ClientCertExclusionPath <String>]: client certificate authentication comma-separated exclusion paths
  [CloningInfoAppSettingsOverride <ICloningInfoAppSettingsOverrides>]: Application setting overrides for cloned app. If specified, these settings override the settings cloned         from source app. Otherwise, application settings from source app are retained.
    [(Any) <String>]: This indicates any property can be added to this object.
  [CloningInfoCloneCustomHostName <Boolean?>]: <code>true</code> to clone custom hostnames from source app; otherwise, <code>false</code>.
  [CloningInfoCloneSourceControl <Boolean?>]: <code>true</code> to clone source control from source app; otherwise, <code>false</code>.
  [CloningInfoConfigureLoadBalancing <Boolean?>]: <code>true</code> to configure load balancing for source and destination app.
  [CloningInfoCorrelationId <String>]: Correlation ID of cloning operation. This ID ties multiple cloning operations         together to use the same snapshot.
  [CloningInfoHostingEnvironment <String>]: App Service Environment.
  [CloningInfoOverwrite <Boolean?>]: <code>true</code> to overwrite destination app; otherwise, <code>false</code>.
  [CloningInfoSourceWebAppLocation <String>]: Location of source app ex: West US or North Europe
  [CloningInfoTrafficManagerProfileId <String>]: ARM resource ID of the Traffic Manager profile to use, if it exists. Traffic Manager resource ID is of the form         /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
  [CloningInfoTrafficManagerProfileName <String>]: Name of Traffic Manager profile to create. This is only needed if Traffic Manager profile does not already exist.
  [ContainerSize <Int32?>]: Size of the function container.
  [DailyMemoryTimeQuota <Int32?>]: Maximum allowed daily memory-time quota (applicable on dynamic apps only).
  [Enabled <Boolean?>]: <code>true</code> if the app is enabled; otherwise, <code>false</code>. Setting this value to false disables the app (takes the app offline).
  [HostNameSslState <IHostNameSslState[]>]: Hostname SSL states are used to manage the SSL bindings for app's hostnames.
    [HostType <HostType?>]: Indicates whether the hostname is a standard or repository hostname.
    [Name <String>]: Hostname.
    [SslState <SslState?>]: SSL type.
    [Thumbprint <String>]: SSL certificate thumbprint.
    [ToUpdate <Boolean?>]: Set to <code>true</code> to update existing hostname.
    [VirtualIP <String>]: Virtual IP address assigned to the hostname if IP based SSL is enabled.
  [HostNamesDisabled <Boolean?>]: <code>true</code> to disable the public hostnames of the app; otherwise, <code>false</code>.          If <code>true</code>, the app is only accessible via API management process.
  [HostingEnvironmentProfileId <String>]: Resource ID of the App Service Environment.
  [HttpsOnly <Boolean?>]: HttpsOnly: configures a web site to accept only https requests. Issues redirect for         http requests
  [HyperV <Boolean?>]: Hyper-V sandbox.
  [IdentityType <ManagedServiceIdentityType?>]: Type of managed service identity.
  [IdentityUserAssignedIdentity <IManagedServiceIdentityUserAssignedIdentities>]: The list of user assigned identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
    [(Any) <IComponents1Jq1T4ISchemasManagedserviceidentityPropertiesUserassignedidentitiesAdditionalproperties>]: This indicates any property can be added to this object.
  [IsXenon <Boolean?>]: Obsolete: Hyper-V sandbox.
  [RedundancyMode <RedundancyMode?>]: Site redundancy mode
  [Reserved <Boolean?>]: <code>true</code> if reserved; otherwise, <code>false</code>.
  [ScmSiteAlsoStopped <Boolean?>]: <code>true</code> to stop SCM (KUDU) site when the app is stopped; otherwise, <code>false</code>. The default is <code>false</code>.
  [ServerFarmId <String>]: Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
  [SiteConfig <ISiteConfig>]: Configuration of the app.
    IsPushEnabled <Boolean>: Gets or sets a flag indicating whether the Push endpoint is enabled.
    [ActionMinProcessExecutionTime <String>]: Minimum time the process must execute         before taking the action
    [ActionType <AutoHealActionType?>]: Predefined action to be taken.
    [AlwaysOn <Boolean?>]: <code>true</code> if Always On is enabled; otherwise, <code>false</code>.
    [ApiDefinitionUrl <String>]: The URL of the API definition.
    [ApiManagementConfigId <String>]: APIM-Api Identifier.
    [AppCommandLine <String>]: App command line to launch.
    [AppSetting <INameValuePair[]>]: Application settings.
      [Name <String>]: Pair name.
      [Value <String>]: Pair value.
    [AutoHealEnabled <Boolean?>]: <code>true</code> if Auto Heal is enabled; otherwise, <code>false</code>.
    [AutoSwapSlotName <String>]: Auto-swap slot name.
    [ConnectionString <IConnStringInfo[]>]: Connection strings.
      [ConnectionString <String>]: Connection string value.
      [Name <String>]: Name of connection string.
      [Type <ConnectionStringType?>]: Type of database.
    [CorAllowedOrigin <String[]>]: Gets or sets the list of origins that should be allowed to make cross-origin         calls (for example: http://example.com:12345). Use "*" to allow all.
    [CorSupportCredentials <Boolean?>]: Gets or sets whether CORS requests with credentials are allowed. See         https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS#Requests_with_credentials         for more details.
    [CustomActionExe <String>]: Executable to be run.
    [CustomActionParameter <String>]: Parameters for the executable.
    [DefaultDocument <String[]>]: Default documents.
    [DetailedErrorLoggingEnabled <Boolean?>]: <code>true</code> if detailed error logging is enabled; otherwise, <code>false</code>.
    [DocumentRoot <String>]: Document root.
    [DynamicTagsJson <String>]: Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
    [ExperimentRampUpRule <IRampUpRule[]>]: List of ramp-up rules.
      [ActionHostName <String>]: Hostname of a slot to which the traffic will be redirected if decided to. E.g. myapp-stage.azurewebsites.net.
      [ChangeDecisionCallbackUrl <String>]: Custom decision algorithm can be provided in TiPCallback site extension which URL can be specified. See TiPCallback site extension for the scaffold and contracts.         https://www.siteextensions.net/packages/TiPCallback/
      [ChangeIntervalInMinute <Int32?>]: Specifies interval in minutes to reevaluate ReroutePercentage.
      [ChangeStep <Double?>]: In auto ramp up scenario this is the step to add/remove from <code>ReroutePercentage</code> until it reaches \n<code>MinReroutePercentage</code> or         <code>MaxReroutePercentage</code>. Site metrics are checked every N minutes specified in <code>ChangeIntervalInMinutes</code>.\nCustom decision algorithm         can be provided in TiPCallback site extension which URL can be specified in <code>ChangeDecisionCallbackUrl</code>.
      [MaxReroutePercentage <Double?>]: Specifies upper boundary below which ReroutePercentage will stay.
      [MinReroutePercentage <Double?>]: Specifies lower boundary above which ReroutePercentage will stay.
      [Name <String>]: Name of the routing rule. The recommended name would be to point to the slot which will receive the traffic in the experiment.
      [ReroutePercentage <Double?>]: Percentage of the traffic which will be redirected to <code>ActionHostName</code>.
    [FtpsState <FtpsState?>]: State of FTP / FTPS service
    [HandlerMapping <IHandlerMapping[]>]: Handler mappings.
      [Argument <String>]: Command-line arguments to be passed to the script processor.
      [Extension <String>]: Requests with this extension will be handled using the specified FastCGI application.
      [ScriptProcessor <String>]: The absolute path to the FastCGI application.
    [HealthCheckPath <String>]: Health check path
    [Http20Enabled <Boolean?>]: Http20Enabled: configures a web site to allow clients to connect over http2.0
    [HttpLoggingEnabled <Boolean?>]: <code>true</code> if HTTP logging is enabled; otherwise, <code>false</code>.
    [IPSecurityRestriction <IIPSecurityRestriction[]>]: IP security restrictions for main.
      [Action <String>]: Allow or Deny access for this IP range.
      [Description <String>]: IP restriction rule description.
      [IPAddress <String>]: IP address the security restriction is valid for.         It can be in form of pure ipv4 address (required SubnetMask property) or         CIDR notation such as ipv4/mask (leading bit match). For CIDR,         SubnetMask property must not be specified.
      [Name <String>]: IP restriction rule name.
      [Priority <Int32?>]: Priority of IP restriction rule.
      [SubnetMask <String>]: Subnet mask for the range of IP addresses the restriction is valid for.
      [SubnetTrafficTag <Int32?>]: (internal) Subnet traffic tag
      [Tag <IPFilterTag?>]: Defines what this IP filter will be used for. This is to support IP filtering on proxies.
      [VnetSubnetResourceId <String>]: Virtual network resource id
      [VnetTrafficTag <Int32?>]: (internal) Vnet traffic tag
    [JavaContainer <String>]: Java container.
    [JavaContainerVersion <String>]: Java container version.
    [JavaVersion <String>]: Java version.
    [LimitMaxDiskSizeInMb <Int64?>]: Maximum allowed disk size usage in MB.
    [LimitMaxMemoryInMb <Int64?>]: Maximum allowed memory usage in MB.
    [LimitMaxPercentageCpu <Double?>]: Maximum allowed CPU usage percentage.
    [LinuxFxVersion <String>]: Linux App Framework and version
    [LoadBalancing <SiteLoadBalancing?>]: Site load balancing.
    [LocalMySqlEnabled <Boolean?>]: <code>true</code> to enable local MySQL; otherwise, <code>false</code>.
    [LogsDirectorySizeLimit <Int32?>]: HTTP logs directory size limit.
    [MachineKeyDecryption <String>]: Algorithm used for decryption.
    [MachineKeyDecryptionKey <String>]: Decryption key.
    [MachineKeyValidation <String>]: MachineKey validation.
    [MachineKeyValidationKey <String>]: Validation key.
    [ManagedPipelineMode <ManagedPipelineMode?>]: Managed pipeline mode.
    [ManagedServiceIdentityId <Int32?>]: Managed Service Identity Id
    [MinTlsVersion <SupportedTlsVersions?>]: MinTlsVersion: configures the minimum version of TLS required for SSL requests
    [NetFrameworkVersion <String>]: .NET Framework version.
    [NodeVersion <String>]: Version of Node.js.
    [NumberOfWorker <Int32?>]: Number of workers.
    [PhpVersion <String>]: Version of PHP.
    [PowerShellVersion <String>]: Version of PowerShell.
    [PreWarmedInstanceCount <Int32?>]: Number of preWarmed instances.         This setting only applies to the Consumption and Elastic Plans
    [PublishingUsername <String>]: Publishing user name.
    [PushKind <String>]: Kind of resource.
    [PythonVersion <String>]: Version of Python.
    [RemoteDebuggingEnabled <Boolean?>]: <code>true</code> if remote debugging is enabled; otherwise, <code>false</code>.
    [RemoteDebuggingVersion <String>]: Remote debugging version.
    [RequestCount <Int32?>]: Request Count.
    [RequestTimeInterval <String>]: Time interval.
    [RequestTracingEnabled <Boolean?>]: <code>true</code> if request tracing is enabled; otherwise, <code>false</code>.
    [RequestTracingExpirationTime <DateTime?>]: Request tracing expiration time.
    [ScmIPSecurityRestriction <IIPSecurityRestriction[]>]: IP security restrictions for scm.
    [ScmIPSecurityRestrictionsUseMain <Boolean?>]: IP security restrictions for scm to use main.
    [ScmType <ScmType?>]: SCM type.
    [SlowRequestCount <Int32?>]: Request Count.
    [SlowRequestTimeInterval <String>]: Time interval.
    [SlowRequestTimeTaken <String>]: Time taken.
    [TagWhitelistJson <String>]: Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
    [TagsRequiringAuth <String>]: Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.         Tags can consist of alphanumeric characters and the following:         '_', '@', '#', '.', ':', '-'.         Validation should be performed at the PushRequestHandler.
    [TracingOption <String>]: Tracing options.
    [TriggerPrivateBytesInKb <Int32?>]: A rule based on private bytes.
    [TriggerStatusCode <IStatusCodesBasedTrigger[]>]: A rule based on status codes.
      [Count <Int32?>]: Request Count.
      [Status <Int32?>]: HTTP status code.
      [SubStatus <Int32?>]: Request Sub Status.
      [TimeInterval <String>]: Time interval.
      [Win32Status <Int32?>]: Win32 error code.
    [Use32BitWorkerProcess <Boolean?>]: <code>true</code> to use 32-bit worker process; otherwise, <code>false</code>.
    [VirtualApplication <IVirtualApplication[]>]: Virtual applications.
      [PhysicalPath <String>]: Physical path.
      [PreloadEnabled <Boolean?>]: <code>true</code> if preloading is enabled; otherwise, <code>false</code>.
      [VirtualDirectory <IVirtualDirectory[]>]: Virtual directories for virtual application.
        [PhysicalPath <String>]: Physical path.
        [VirtualPath <String>]: Path to virtual application.
      [VirtualPath <String>]: Virtual path.
    [VnetName <String>]: Virtual Network name.
    [WebSocketsEnabled <Boolean?>]: <code>true</code> if WebSocket is enabled; otherwise, <code>false</code>.
    [WindowsFxVersion <String>]: Xenon App Framework and version
    [XManagedServiceIdentityId <Int32?>]: Explicit Managed Service Identity Id
.Link
https://docs.microsoft.com/en-us/powershell/module/az.functions/update-azfunctionapp
#>
function Update-AzFunctionApp {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISite])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Update', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Path')]
    [System.String]
    # Unique name of the app to create or update.
    # To create or update a deployment slot, use the {slot} parameter.
    ${Name},

    [Parameter(ParameterSetName='Update', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Path')]
    [System.String]
    # Name of the resource group to which the resource belongs.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Update')]
    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Your Azure subscription ID.
    # This is a GUID-formatted string (e.g.
    # 00000000-0000-0000-0000-000000000000).
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IFunctionsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISitePatchResource]
    # ARM resource for a site.
    # To construct, see NOTES section for SITEENVELOPE properties and create a hash table.
    ${SiteEnvelope},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> to enable client affinity; <code>false</code> to stop sending session affinity cookies, which route client requests in the same session to the same instance.
    # Default is <code>true</code>.
    ${ClientAffinityEnabled},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> to enable client certificate authentication (TLS mutual authentication); otherwise, <code>false</code>.
    # Default is <code>false</code>.
    ${ClientCertEnabled},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # client certificate authentication comma-separated exclusion paths
    ${ClientCertExclusionPath},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICloningInfoAppSettingsOverrides]))]
    [System.Collections.Hashtable]
    # Application setting overrides for cloned app.
    # If specified, these settings override the settings cloned from source app.
    # Otherwise, application settings from source app are retained.
    ${CloningInfoAppSettingsOverride},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> to clone custom hostnames from source app; otherwise, <code>false</code>.
    ${CloningInfoCloneCustomHostName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> to clone source control from source app; otherwise, <code>false</code>.
    ${CloningInfoCloneSourceControl},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> to configure load balancing for source and destination app.
    ${CloningInfoConfigureLoadBalancing},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # Correlation ID of cloning operation.
    # This ID ties multiple cloning operationstogether to use the same snapshot.
    ${CloningInfoCorrelationId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # App Service Environment.
    ${CloningInfoHostingEnvironment},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> to overwrite destination app; otherwise, <code>false</code>.
    ${CloningInfoOverwrite},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # ARM resource ID of the source app.
    # App resource ID is of the form /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName} for production slots and /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName} for other slots.
    ${CloningInfoSourceWebAppId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # Location of source app ex: West US or North Europe
    ${CloningInfoSourceWebAppLocation},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # ARM resource ID of the Traffic Manager profile to use, if it exists.
    # Traffic Manager resource ID is of the form /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
    ${CloningInfoTrafficManagerProfileId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # Name of Traffic Manager profile to create.
    # This is only needed if Traffic Manager profile does not already exist.
    ${CloningInfoTrafficManagerProfileName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Int32]
    # Size of the function container.
    ${ContainerSize},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Int32]
    # Maximum allowed daily memory-time quota (applicable on dynamic apps only).
    ${DailyMemoryTimeQuota},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> if the app is enabled; otherwise, <code>false</code>.
    # Setting this value to false disables the app (takes the app offline).
    ${Enabled},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IHostNameSslState[]]
    # Hostname SSL states are used to manage the SSL bindings for app's hostnames.
    # To construct, see NOTES section for HOSTNAMESSLSTATE properties and create a hash table.
    ${HostNameSslState},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> to disable the public hostnames of the app; otherwise, <code>false</code>.
    # If <code>true</code>, the app is only accessible via API management process.
    ${HostNamesDisabled},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # Resource ID of the App Service Environment.
    ${HostingEnvironmentProfileId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HttpsOnly: configures a web site to accept only https requests.
    # Issues redirect forhttp requests
    ${HttpsOnly},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Hyper-V sandbox.
    ${HyperV},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ManagedServiceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ManagedServiceIdentityType]
    # Type of managed service identity.
    ${IdentityType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IManagedServiceIdentityUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The list of user assigned identities associated with the resource.
    # The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
    ${IdentityUserAssignedIdentity},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Obsolete: Hyper-V sandbox.
    ${IsXenon},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # Kind of resource.
    ${Kind},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RedundancyMode])]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RedundancyMode]
    # Site redundancy mode
    ${RedundancyMode},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> if reserved; otherwise, <code>false</code>.
    ${Reserved},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # <code>true</code> to stop SCM (KUDU) site when the app is stopped; otherwise, <code>false</code>.
    # The default is <code>false</code>.
    ${ScmSiteAlsoStopped},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [System.String]
    # Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
    ${ServerFarmId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISiteConfig]
    # Configuration of the app.
    # To construct, see NOTES section for SITECONFIG properties and create a hash table.
    ${SiteConfig},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Functions.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Update = 'Az.Functions.private\Update-AzFunctionApp_Update';
            UpdateExpanded = 'Az.Functions.private\Update-AzFunctionApp_UpdateExpanded';
            UpdateViaIdentity = 'Az.Functions.private\Update-AzFunctionApp_UpdateViaIdentity';
            UpdateViaIdentityExpanded = 'Az.Functions.private\Update-AzFunctionApp_UpdateViaIdentityExpanded';
        }
        if (('Update', 'UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
