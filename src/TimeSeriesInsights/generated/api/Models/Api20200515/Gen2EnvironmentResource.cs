namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Extensions;

    /// <summary>
    /// An environment is a set of time-series data available for query, and is the top level Azure Time Series Insights resource.
    /// Gen2 environments do not have set data retention limits.
    /// </summary>
    [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.DoNotFormat]
    public partial class Gen2EnvironmentResource :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResource,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResource __environmentResource = new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EnvironmentResource();

        /// <summary>
        /// The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload
        /// reference data for the environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string DataAccessFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).DataAccessFqdn; }

        /// <summary>
        /// An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string DataAccessId { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).DataAccessId; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Id; }

        /// <summary>
        /// This string represents the state of ingress operations on an environment. It can be "Disabled", "Ready", "Running", "Paused"
        /// or "Unknown"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState? IngressState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).IngressState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).IngressState = value; }

        /// <summary>The kind of the environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal)__environmentResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal)__environmentResource).Kind = value; }

        /// <summary>Resource location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITrackedResourceInternal)__environmentResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITrackedResourceInternal)__environmentResource).Location = value; }

        /// <summary>Internal Acessors for DataAccessFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.DataAccessFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).DataAccessFqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).DataAccessFqdn = value; }

        /// <summary>Internal Acessors for DataAccessId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.DataAccessId { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).DataAccessId; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).DataAccessId = value; }

        /// <summary>Internal Acessors for IngressStateDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentStateDetails Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.IngressStateDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).IngressStateDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).IngressStateDetail = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for PropertyUsageStateDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoragePropertiesUsageStateDetails Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.PropertyUsageStateDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).PropertyUsageStateDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).PropertyUsageStateDetail = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentStatus Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for StatusIngress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IIngressEnvironmentStatus Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.StatusIngress { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StatusIngress; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StatusIngress = value; }

        /// <summary>Internal Acessors for StatusWarmStorage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStorageEnvironmentStatus Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.StatusWarmStorage { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StatusWarmStorage; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StatusWarmStorage = value; }

        /// <summary>Internal Acessors for StorageConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2StorageConfigurationOutput Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.StorageConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).StorageConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).StorageConfiguration = value; }

        /// <summary>Internal Acessors for WarmStoragePropertiesUsage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoragePropertiesUsage Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.WarmStoragePropertiesUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).WarmStoragePropertiesUsage; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).WarmStoragePropertiesUsage = value; }

        /// <summary>Internal Acessors for WarmStoreConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoreConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceInternal.WarmStoreConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).WarmStoreConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).WarmStoreConfiguration = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Type = value; }

        /// <summary>Resource name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties _property;

        /// <summary>Properties of the Gen2 environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentResourceProperties()); set => this._property = value; }

        /// <summary>
        /// This string represents the state of warm storage properties usage. It can be "Ok", "Error", "Unknown".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState? PropertyUsageState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).PropertyUsageState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).PropertyUsageState = value; }

        /// <summary>
        /// The sku determines the type of environment, either Gen1 (S1 or S2) or Gen2 (L1). For Gen1 environments the sku determines
        /// the capacity of the environment, the ingress rate, and the billing rate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ISku Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal)__environmentResource).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal)__environmentResource).Sku = value; }

        /// <summary>
        /// The capacity of the sku. For Gen1 environments, this value can be changed to support scale out of environments after they
        /// have been created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public int SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal)__environmentResource).SkuCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal)__environmentResource).SkuCapacity = value; }

        /// <summary>The name of this SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal)__environmentResource).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal)__environmentResource).SkuName = value; }

        /// <summary>
        /// Contains the code that represents the reason of an environment being in a particular state. Can be used to programmatically
        /// handle specific cases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string StateDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StateDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StateDetailCode = value; }

        /// <summary>
        /// A value that represents the number of properties used by the environment for S1/S2 SKU and number of properties used by
        /// Warm Store for PAYG SKU
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public int? StateDetailCurrentCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StateDetailCurrentCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StateDetailCurrentCount = value; }

        /// <summary>
        /// A value that represents the maximum number of properties used allowed by the environment for S1/S2 SKU and maximum number
        /// of properties allowed by Warm Store for PAYG SKU.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public int? StateDetailMaxCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StateDetailMaxCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StateDetailMaxCount = value; }

        /// <summary>A message that describes the state in detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string StateDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StateDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)Property).StateDetailMessage = value; }

        /// <summary>The name of the storage account that will hold the environment's Gen2 data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public string StorageConfigurationAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).StorageConfigurationAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).StorageConfigurationAccountName = value; }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITrackedResourceInternal)__environmentResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITrackedResourceInternal)__environmentResource).Tag = value; }

        /// <summary>
        /// The list of event properties which will be used to define the environment's time series id.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty[] TimeSeriesIdProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).TimeSeriesIdProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).TimeSeriesIdProperty = value; }

        /// <summary>Resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IResourceInternal)__environmentResource).Type; }

        /// <summary>
        /// ISO8601 timespan specifying the number of days the environment's events will be available for query from the warm store.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.PropertyOrigin.Inlined)]
        public global::System.TimeSpan WarmStoreConfigurationDataRetention { get => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).WarmStoreConfigurationDataRetention; set => ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)Property).WarmStoreConfigurationDataRetention = value; }

        /// <summary>Creates an new <see cref="Gen2EnvironmentResource" /> instance.</summary>
        public Gen2EnvironmentResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__environmentResource), __environmentResource);
            await eventListener.AssertObjectIsValid(nameof(__environmentResource), __environmentResource);
        }
    }
    /// An environment is a set of time-series data available for query, and is the top level Azure Time Series Insights resource.
    /// Gen2 environments do not have set data retention limits.
    public partial interface IGen2EnvironmentResource :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResource
    {
        /// <summary>
        /// The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload
        /// reference data for the environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.",
        SerializedName = @"dataAccessFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string DataAccessFqdn { get;  }
        /// <summary>
        /// An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.",
        SerializedName = @"dataAccessId",
        PossibleTypes = new [] { typeof(string) })]
        string DataAccessId { get;  }
        /// <summary>
        /// This string represents the state of ingress operations on an environment. It can be "Disabled", "Ready", "Running", "Paused"
        /// or "Unknown"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This string represents the state of ingress operations on an environment. It can be ""Disabled"", ""Ready"", ""Running"", ""Paused"" or ""Unknown""",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState? IngressState { get; set; }
        /// <summary>
        /// This string represents the state of warm storage properties usage. It can be "Ok", "Error", "Unknown".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This string represents the state of warm storage properties usage. It can be ""Ok"", ""Error"", ""Unknown"".",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState? PropertyUsageState { get; set; }
        /// <summary>
        /// Contains the code that represents the reason of an environment being in a particular state. Can be used to programmatically
        /// handle specific cases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Contains the code that represents the reason of an environment being in a particular state. Can be used to programmatically handle specific cases.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string StateDetailCode { get; set; }
        /// <summary>
        /// A value that represents the number of properties used by the environment for S1/S2 SKU and number of properties used by
        /// Warm Store for PAYG SKU
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value that represents the number of properties used by the environment for S1/S2 SKU and number of properties used by Warm Store for PAYG SKU",
        SerializedName = @"currentCount",
        PossibleTypes = new [] { typeof(int) })]
        int? StateDetailCurrentCount { get; set; }
        /// <summary>
        /// A value that represents the maximum number of properties used allowed by the environment for S1/S2 SKU and maximum number
        /// of properties allowed by Warm Store for PAYG SKU.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value that represents the maximum number of properties used allowed by the environment for S1/S2 SKU and maximum number of properties allowed by Warm Store for PAYG SKU.",
        SerializedName = @"maxCount",
        PossibleTypes = new [] { typeof(int) })]
        int? StateDetailMaxCount { get; set; }
        /// <summary>A message that describes the state in detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message that describes the state in detail.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string StateDetailMessage { get; set; }
        /// <summary>The name of the storage account that will hold the environment's Gen2 data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the storage account that will hold the environment's Gen2 data.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageConfigurationAccountName { get; set; }
        /// <summary>
        /// The list of event properties which will be used to define the environment's time series id.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of event properties which will be used to define the environment's time series id.",
        SerializedName = @"timeSeriesIdProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty) })]
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty[] TimeSeriesIdProperty { get; set; }
        /// <summary>
        /// ISO8601 timespan specifying the number of days the environment's events will be available for query from the warm store.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"ISO8601 timespan specifying the number of days the environment's events will be available for query from the warm store.",
        SerializedName = @"dataRetention",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan WarmStoreConfigurationDataRetention { get; set; }

    }
    /// An environment is a set of time-series data available for query, and is the top level Azure Time Series Insights resource.
    /// Gen2 environments do not have set data retention limits.
    internal partial interface IGen2EnvironmentResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourceInternal
    {
        /// <summary>
        /// The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload
        /// reference data for the environment.
        /// </summary>
        string DataAccessFqdn { get; set; }
        /// <summary>
        /// An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
        /// </summary>
        string DataAccessId { get; set; }
        /// <summary>
        /// This string represents the state of ingress operations on an environment. It can be "Disabled", "Ready", "Running", "Paused"
        /// or "Unknown"
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState? IngressState { get; set; }
        /// <summary>An object that contains the details about an environment's state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentStateDetails IngressStateDetail { get; set; }
        /// <summary>Properties of the Gen2 environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties Property { get; set; }
        /// <summary>
        /// This string represents the state of warm storage properties usage. It can be "Ok", "Error", "Unknown".
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState? PropertyUsageState { get; set; }
        /// <summary>An object that contains the details about warm storage properties usage state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoragePropertiesUsageStateDetails PropertyUsageStateDetail { get; set; }
        /// <summary>
        /// Contains the code that represents the reason of an environment being in a particular state. Can be used to programmatically
        /// handle specific cases.
        /// </summary>
        string StateDetailCode { get; set; }
        /// <summary>
        /// A value that represents the number of properties used by the environment for S1/S2 SKU and number of properties used by
        /// Warm Store for PAYG SKU
        /// </summary>
        int? StateDetailCurrentCount { get; set; }
        /// <summary>
        /// A value that represents the maximum number of properties used allowed by the environment for S1/S2 SKU and maximum number
        /// of properties allowed by Warm Store for PAYG SKU.
        /// </summary>
        int? StateDetailMaxCount { get; set; }
        /// <summary>A message that describes the state in detail.</summary>
        string StateDetailMessage { get; set; }
        /// <summary>
        /// An object that represents the status of the environment, and its internal state in the Time Series Insights service.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentStatus Status { get; set; }
        /// <summary>An object that represents the status of ingress on an environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IIngressEnvironmentStatus StatusIngress { get; set; }
        /// <summary>An object that represents the status of warm storage on an environment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStorageEnvironmentStatus StatusWarmStorage { get; set; }
        /// <summary>
        /// The storage configuration provides the connection details that allows the Time Series Insights service to connect to the
        /// customer storage account that is used to store the environment's data.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2StorageConfigurationOutput StorageConfiguration { get; set; }
        /// <summary>The name of the storage account that will hold the environment's Gen2 data.</summary>
        string StorageConfigurationAccountName { get; set; }
        /// <summary>
        /// The list of event properties which will be used to define the environment's time series id.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty[] TimeSeriesIdProperty { get; set; }
        /// <summary>An object that contains the status of warm storage properties usage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoragePropertiesUsage WarmStoragePropertiesUsage { get; set; }
        /// <summary>
        /// The warm store configuration provides the details to create a warm store cache that will retain a copy of the environment's
        /// data available for faster query.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoreConfigurationProperties WarmStoreConfiguration { get; set; }
        /// <summary>
        /// ISO8601 timespan specifying the number of days the environment's events will be available for query from the warm store.
        /// </summary>
        global::System.TimeSpan WarmStoreConfigurationDataRetention { get; set; }

    }
}