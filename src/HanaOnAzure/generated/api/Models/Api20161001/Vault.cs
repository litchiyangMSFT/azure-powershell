namespace Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Extensions;

    /// <summary>Resource information with extended details.</summary>
    public partial class Vault :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVault,
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.Resource();

        /// <summary>
        /// An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant
        /// ID as the key vault's tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access
        /// policies are required.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IAccessPolicyEntry[] AccessPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).AccessPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).AccessPolicy = value; }

        /// <summary>
        /// The vault's create mode to indicate whether the vault need to be recovered or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.CreateMode? CreateMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).CreateMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).CreateMode = value; }

        /// <summary>
        /// Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates
        /// protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable
        /// deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible -
        /// that is, the property does not accept false as its value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public bool? EnablePurgeProtection { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnablePurgeProtection; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnablePurgeProtection = value; }

        /// <summary>
        /// Property specifying whether recoverable deletion is enabled for this key vault. Setting this property to true activates
        /// the soft delete feature, whereby vaults or vault entities can be recovered after deletion. Enabling this functionality
        /// is irreversible - that is, the property does not accept false as its value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public bool? EnableSoftDelete { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnableSoftDelete; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnableSoftDelete = value; }

        /// <summary>
        /// Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key
        /// vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public bool? EnabledForDeployment { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnabledForDeployment; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnabledForDeployment = value; }

        /// <summary>
        /// Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public bool? EnabledForDiskEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnabledForDiskEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnabledForDiskEncryption = value; }

        /// <summary>
        /// Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public bool? EnabledForTemplateDeployment { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnabledForTemplateDeployment; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).EnabledForTemplateDeployment = value; }

        /// <summary>The Azure Resource Manager resource ID for the key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Id; }

        /// <summary>The supported Azure location where the key vault should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultProperties Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.VaultProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.ISku Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultInternal.Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).Sku = value; }

        /// <summary>Internal Acessors for SkuFamily</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultInternal.SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).SkuFamily; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).SkuFamily = value; }

        /// <summary>The name of the key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultProperties _property;

        /// <summary>Properties of the vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.VaultProperties()); set => this._property = value; }

        /// <summary>SKU family name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public string SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).SkuFamily; }

        /// <summary>
        /// SKU name to specify whether the key vault is a standard vault or a premium vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.SkuName SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).SkuName = value; }

        /// <summary>The tags that will be assigned to the key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResourceInternal)__resource).Tag = value; }

        /// <summary>
        /// The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).TenantId = value; }

        /// <summary>The resource type of the key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api10.IResourceInternal)__resource).Type; }

        /// <summary>The URI of the vault for performing operations on keys and secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Origin(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.PropertyOrigin.Inlined)]
        public string Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).VaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultPropertiesInternal)Property).VaultUri = value; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }

        /// <summary>Creates an new <see cref="Vault" /> instance.</summary>
        public Vault()
        {

        }
    }
    /// Resource information with extended details.
    public partial interface IVault :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResource
    {
        /// <summary>
        /// An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant
        /// ID as the key vault's tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access
        /// policies are required.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant ID as the key vault's tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access policies are required.",
        SerializedName = @"accessPolicies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IAccessPolicyEntry) })]
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IAccessPolicyEntry[] AccessPolicy { get; set; }
        /// <summary>
        /// The vault's create mode to indicate whether the vault need to be recovered or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The vault's create mode to indicate whether the vault need to be recovered or not.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.CreateMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.CreateMode? CreateMode { get; set; }
        /// <summary>
        /// Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates
        /// protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable
        /// deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible -
        /// that is, the property does not accept false as its value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible - that is, the property does not accept false as its value.",
        SerializedName = @"enablePurgeProtection",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnablePurgeProtection { get; set; }
        /// <summary>
        /// Property specifying whether recoverable deletion is enabled for this key vault. Setting this property to true activates
        /// the soft delete feature, whereby vaults or vault entities can be recovered after deletion. Enabling this functionality
        /// is irreversible - that is, the property does not accept false as its value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property specifying whether recoverable deletion is enabled for this key vault. Setting this property to true activates the soft delete feature, whereby vaults or vault entities can be recovered after deletion. Enabling this functionality is irreversible - that is, the property does not accept false as its value.",
        SerializedName = @"enableSoftDelete",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableSoftDelete { get; set; }
        /// <summary>
        /// Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key
        /// vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key vault.",
        SerializedName = @"enabledForDeployment",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnabledForDeployment { get; set; }
        /// <summary>
        /// Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys.",
        SerializedName = @"enabledForDiskEncryption",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnabledForDiskEncryption { get; set; }
        /// <summary>
        /// Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault.",
        SerializedName = @"enabledForTemplateDeployment",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnabledForTemplateDeployment { get; set; }
        /// <summary>SKU family name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"SKU family name",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        string SkuFamily { get;  }
        /// <summary>
        /// SKU name to specify whether the key vault is a standard vault or a premium vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"SKU name to specify whether the key vault is a standard vault or a premium vault.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.SkuName SkuName { get; set; }
        /// <summary>
        /// The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }
        /// <summary>The URI of the vault for performing operations on keys and secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI of the vault for performing operations on keys and secrets.",
        SerializedName = @"vaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Resource information with extended details.
    internal partial interface IVaultInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IResourceInternal
    {
        /// <summary>
        /// An array of 0 to 16 identities that have access to the key vault. All identities in the array must use the same tenant
        /// ID as the key vault's tenant ID. When `createMode` is set to `recover`, access policies are not required. Otherwise, access
        /// policies are required.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IAccessPolicyEntry[] AccessPolicy { get; set; }
        /// <summary>
        /// The vault's create mode to indicate whether the vault need to be recovered or not.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.CreateMode? CreateMode { get; set; }
        /// <summary>
        /// Property specifying whether protection against purge is enabled for this vault. Setting this property to true activates
        /// protection against purge for this vault and its content - only the Key Vault service may initiate a hard, irrecoverable
        /// deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible -
        /// that is, the property does not accept false as its value.
        /// </summary>
        bool? EnablePurgeProtection { get; set; }
        /// <summary>
        /// Property specifying whether recoverable deletion is enabled for this key vault. Setting this property to true activates
        /// the soft delete feature, whereby vaults or vault entities can be recovered after deletion. Enabling this functionality
        /// is irreversible - that is, the property does not accept false as its value.
        /// </summary>
        bool? EnableSoftDelete { get; set; }
        /// <summary>
        /// Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored as secrets from the key
        /// vault.
        /// </summary>
        bool? EnabledForDeployment { get; set; }
        /// <summary>
        /// Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        bool? EnabledForDiskEncryption { get; set; }
        /// <summary>
        /// Property to specify whether Azure Resource Manager is permitted to retrieve secrets from the key vault.
        /// </summary>
        bool? EnabledForTemplateDeployment { get; set; }
        /// <summary>Properties of the vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.IVaultProperties Property { get; set; }
        /// <summary>SKU details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Models.Api20161001.ISku Sku { get; set; }
        /// <summary>SKU family name</summary>
        string SkuFamily { get; set; }
        /// <summary>
        /// SKU name to specify whether the key vault is a standard vault or a premium vault.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HanaOnAzure.Support.SkuName SkuName { get; set; }
        /// <summary>
        /// The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.
        /// </summary>
        string TenantId { get; set; }
        /// <summary>The URI of the vault for performing operations on keys and secrets.</summary>
        string Uri { get; set; }

    }
}