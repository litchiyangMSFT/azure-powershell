namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    public partial class Machine :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachine,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal
    {

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; set => this._etag = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for PropertiesAgent</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfiguration Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal.PropertiesAgent { get => (this._propertiesAgent = this._propertiesAgent ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.AgentConfiguration()); set { {_propertiesAgent = value;} } }

        /// <summary>Internal Acessors for PropertiesHosting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHostingConfiguration Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal.PropertiesHosting { get => (this._propertiesHosting = this._propertiesHosting ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.HostingConfiguration()); set { {_propertiesHosting = value;} } }

        /// <summary>Internal Acessors for PropertiesHypervisor</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHypervisorConfiguration Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal.PropertiesHypervisor { get => (this._propertiesHypervisor = this._propertiesHypervisor ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.HypervisorConfiguration()); set { {_propertiesHypervisor = value;} } }

        /// <summary>Internal Acessors for PropertiesNetworking</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfiguration Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal.PropertiesNetworking { get => (this._propertiesNetworking = this._propertiesNetworking ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.NetworkConfiguration()); set { {_propertiesNetworking = value;} } }

        /// <summary>Internal Acessors for PropertiesOperatingSystem</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfiguration Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal.PropertiesOperatingSystem { get => (this._propertiesOperatingSystem = this._propertiesOperatingSystem ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.OperatingSystemConfiguration()); set { {_propertiesOperatingSystem = value;} } }

        /// <summary>Internal Acessors for PropertiesResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfiguration Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal.PropertiesResource { get => (this._propertiesResource = this._propertiesResource ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.MachineResourcesConfiguration()); set { {_propertiesResource = value;} } }

        /// <summary>Internal Acessors for PropertiesTimezone</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.ITimezone Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal.PropertiesTimezone { get => (this._propertiesTimezone = this._propertiesTimezone ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.Timezone()); set { {_propertiesTimezone = value;} } }

        /// <summary>Internal Acessors for PropertiesVirtualMachine</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfiguration Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineInternal.PropertiesVirtualMachine { get => (this._propertiesVirtualMachine = this._propertiesVirtualMachine ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.VirtualMachineConfiguration()); set { {_propertiesVirtualMachine = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PropertiesAgent" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfiguration _propertiesAgent;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfiguration PropertiesAgent { get => (this._propertiesAgent = this._propertiesAgent ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.AgentConfiguration()); set => this._propertiesAgent = value; }

        /// <summary>Backing field for <see cref="PropertiesBootTime" /> property.</summary>
        private global::System.DateTime? _propertiesBootTime;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? PropertiesBootTime { get => this._propertiesBootTime; set => this._propertiesBootTime = value; }

        /// <summary>Backing field for <see cref="PropertiesComputerName" /> property.</summary>
        private string _propertiesComputerName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PropertiesComputerName { get => this._propertiesComputerName; set => this._propertiesComputerName = value; }

        /// <summary>Backing field for <see cref="PropertiesDisplayName" /> property.</summary>
        private string _propertiesDisplayName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PropertiesDisplayName { get => this._propertiesDisplayName; set => this._propertiesDisplayName = value; }

        /// <summary>Backing field for <see cref="PropertiesFullyQualifiedDomainName" /> property.</summary>
        private string _propertiesFullyQualifiedDomainName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PropertiesFullyQualifiedDomainName { get => this._propertiesFullyQualifiedDomainName; set => this._propertiesFullyQualifiedDomainName = value; }

        /// <summary>Backing field for <see cref="PropertiesHosting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHostingConfiguration _propertiesHosting;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHostingConfiguration PropertiesHosting { get => (this._propertiesHosting = this._propertiesHosting ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.HostingConfiguration()); set => this._propertiesHosting = value; }

        /// <summary>Backing field for <see cref="PropertiesHypervisor" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHypervisorConfiguration _propertiesHypervisor;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHypervisorConfiguration PropertiesHypervisor { get => (this._propertiesHypervisor = this._propertiesHypervisor ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.HypervisorConfiguration()); set => this._propertiesHypervisor = value; }

        /// <summary>Backing field for <see cref="PropertiesMonitoringState" /> property.</summary>
        private string _propertiesMonitoringState;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PropertiesMonitoringState { get => this._propertiesMonitoringState; set => this._propertiesMonitoringState = value; }

        /// <summary>Backing field for <see cref="PropertiesNetworking" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfiguration _propertiesNetworking;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfiguration PropertiesNetworking { get => (this._propertiesNetworking = this._propertiesNetworking ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.NetworkConfiguration()); set => this._propertiesNetworking = value; }

        /// <summary>Backing field for <see cref="PropertiesOperatingSystem" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfiguration _propertiesOperatingSystem;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfiguration PropertiesOperatingSystem { get => (this._propertiesOperatingSystem = this._propertiesOperatingSystem ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.OperatingSystemConfiguration()); set => this._propertiesOperatingSystem = value; }

        /// <summary>Backing field for <see cref="PropertiesResource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfiguration _propertiesResource;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfiguration PropertiesResource { get => (this._propertiesResource = this._propertiesResource ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.MachineResourcesConfiguration()); set => this._propertiesResource = value; }

        /// <summary>Backing field for <see cref="PropertiesTimestamp" /> property.</summary>
        private global::System.DateTime? _propertiesTimestamp;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? PropertiesTimestamp { get => this._propertiesTimestamp; set => this._propertiesTimestamp = value; }

        /// <summary>Backing field for <see cref="PropertiesTimezone" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.ITimezone _propertiesTimezone;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.ITimezone PropertiesTimezone { get => (this._propertiesTimezone = this._propertiesTimezone ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.Timezone()); set => this._propertiesTimezone = value; }

        /// <summary>Backing field for <see cref="PropertiesVirtualMachine" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfiguration _propertiesVirtualMachine;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfiguration PropertiesVirtualMachine { get => (this._propertiesVirtualMachine = this._propertiesVirtualMachine ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.VirtualMachineConfiguration()); set => this._propertiesVirtualMachine = value; }

        /// <summary>Backing field for <see cref="PropertiesVirtualizationState" /> property.</summary>
        private string _propertiesVirtualizationState;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PropertiesVirtualizationState { get => this._propertiesVirtualizationState; set => this._propertiesVirtualizationState = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? PropertyAgentClockGranularity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).ClockGranularity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).ClockGranularity = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyAgentDependencyAgentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).DependencyAgentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).DependencyAgentId = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyAgentDependencyAgentRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).DependencyAgentRevision; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).DependencyAgentRevision = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyAgentDependencyAgentVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).DependencyAgentVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).DependencyAgentVersion = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyAgentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).AgentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).AgentId = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyAgentRebootStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).RebootStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfigurationInternal)PropertiesAgent).RebootStatus = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyHostingProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHostingConfigurationInternal)PropertiesHosting).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHostingConfigurationInternal)PropertiesHosting).Provider = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyHypervisorNativeHostMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHypervisorConfigurationInternal)PropertiesHypervisor).NativeHostMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHypervisorConfigurationInternal)PropertiesHypervisor).NativeHostMachineId = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyHypervisorType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHypervisorConfigurationInternal)PropertiesHypervisor).HypervisorType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHypervisorConfigurationInternal)PropertiesHypervisor).HypervisorType = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string[] PropertyNetworkingDefaultIpv4Gateway { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).DefaultIpv4Gateway; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).DefaultIpv4Gateway = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string[] PropertyNetworkingDnsCanonicalName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).DnsCanonicalName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).DnsCanonicalName = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string[] PropertyNetworkingDnsName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).DnsName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).DnsName = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string[] PropertyNetworkingDnsQuestion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).DnsQuestion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).DnsQuestion = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IIpv4NetworkInterface[] PropertyNetworkingIpv4Interface { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).Ipv4Interface; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).Ipv4Interface = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IIpv6NetworkInterface[] PropertyNetworkingIpv6Interface { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).Ipv6Interface; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).Ipv6Interface = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string[] PropertyNetworkingMacAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).MacAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfigurationInternal)PropertiesNetworking).MacAddress = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyOperatingSystemBitness { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfigurationInternal)PropertiesOperatingSystem).Bitness; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfigurationInternal)PropertiesOperatingSystem).Bitness = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyOperatingSystemFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfigurationInternal)PropertiesOperatingSystem).Family; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfigurationInternal)PropertiesOperatingSystem).Family = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyOperatingSystemFullName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfigurationInternal)PropertiesOperatingSystem).FullName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfigurationInternal)PropertiesOperatingSystem).FullName = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? PropertyResourceCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfigurationInternal)PropertiesResource).Cpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfigurationInternal)PropertiesResource).Cpu = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? PropertyResourceCpuSpeed { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfigurationInternal)PropertiesResource).CpuSpeed; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfigurationInternal)PropertiesResource).CpuSpeed = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyResourceCpuSpeedAccuracy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfigurationInternal)PropertiesResource).CpuSpeedAccuracy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfigurationInternal)PropertiesResource).CpuSpeedAccuracy = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? PropertyResourcePhysicalMemory { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfigurationInternal)PropertiesResource).PhysicalMemory; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfigurationInternal)PropertiesResource).PhysicalMemory = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyTimezoneFullName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.ITimezoneInternal)PropertiesTimezone).FullName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.ITimezoneInternal)PropertiesTimezone).FullName = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyVirtualMachineName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfigurationInternal)PropertiesVirtualMachine).VirtualMachineName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfigurationInternal)PropertiesVirtualMachine).VirtualMachineName = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyVirtualMachineNativeHostMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfigurationInternal)PropertiesVirtualMachine).NativeHostMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfigurationInternal)PropertiesVirtualMachine).NativeHostMachineId = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyVirtualMachineNativeMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfigurationInternal)PropertiesVirtualMachine).NativeMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfigurationInternal)PropertiesVirtualMachine).NativeMachineId = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PropertyVirtualMachineType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfigurationInternal)PropertiesVirtualMachine).VirtualMachineType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfigurationInternal)PropertiesVirtualMachine).VirtualMachineType = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="Machine" /> instance.</summary>
        public Machine()
        {

        }
    }
    public partial interface IMachine :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"properties.bootTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PropertiesBootTime { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"properties.computerName",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesComputerName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"properties.displayName",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesDisplayName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"properties.fullyQualifiedDomainName",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesFullyQualifiedDomainName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"properties.monitoringState",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesMonitoringState { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"properties.timestamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PropertiesTimestamp { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"properties.virtualizationState",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesVirtualizationState { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clockGranularity",
        PossibleTypes = new [] { typeof(int) })]
        int? PropertyAgentClockGranularity { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dependencyAgentId",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyAgentDependencyAgentId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dependencyAgentRevision",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyAgentDependencyAgentRevision { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dependencyAgentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyAgentDependencyAgentVersion { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"agentId",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyAgentId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"rebootStatus",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyAgentRebootStatus { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyHostingProvider { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"nativeHostMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyHypervisorNativeHostMachineId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hypervisorType",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyHypervisorType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"defaultIpv4Gateways",
        PossibleTypes = new [] { typeof(string) })]
        string[] PropertyNetworkingDefaultIpv4Gateway { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dnsCanonicalNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] PropertyNetworkingDnsCanonicalName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dnsNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] PropertyNetworkingDnsName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dnsQuestions",
        PossibleTypes = new [] { typeof(string) })]
        string[] PropertyNetworkingDnsQuestion { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ipv4Interfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IIpv4NetworkInterface) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IIpv4NetworkInterface[] PropertyNetworkingIpv4Interface { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ipv6Interfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IIpv6NetworkInterface) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IIpv6NetworkInterface[] PropertyNetworkingIpv6Interface { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"macAddresses",
        PossibleTypes = new [] { typeof(string) })]
        string[] PropertyNetworkingMacAddress { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bitness",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyOperatingSystemBitness { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyOperatingSystemFamily { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fullName",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyOperatingSystemFullName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpus",
        PossibleTypes = new [] { typeof(int) })]
        int? PropertyResourceCpu { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpuSpeed",
        PossibleTypes = new [] { typeof(int) })]
        int? PropertyResourceCpuSpeed { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cpuSpeedAccuracy",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyResourceCpuSpeedAccuracy { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"physicalMemory",
        PossibleTypes = new [] { typeof(int) })]
        int? PropertyResourcePhysicalMemory { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fullName",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyTimezoneFullName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"virtualMachineName",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyVirtualMachineName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"nativeHostMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyVirtualMachineNativeHostMachineId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"nativeMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyVirtualMachineNativeMachineId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"virtualMachineType",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyVirtualMachineType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    internal partial interface IMachineInternal

    {
        string Etag { get; set; }

        string Id { get; set; }

        string Name { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IAgentConfiguration PropertiesAgent { get; set; }

        global::System.DateTime? PropertiesBootTime { get; set; }

        string PropertiesComputerName { get; set; }

        string PropertiesDisplayName { get; set; }

        string PropertiesFullyQualifiedDomainName { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHostingConfiguration PropertiesHosting { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IHypervisorConfiguration PropertiesHypervisor { get; set; }

        string PropertiesMonitoringState { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.INetworkConfiguration PropertiesNetworking { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IOperatingSystemConfiguration PropertiesOperatingSystem { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachineResourcesConfiguration PropertiesResource { get; set; }

        global::System.DateTime? PropertiesTimestamp { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.ITimezone PropertiesTimezone { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IVirtualMachineConfiguration PropertiesVirtualMachine { get; set; }

        string PropertiesVirtualizationState { get; set; }

        int? PropertyAgentClockGranularity { get; set; }

        string PropertyAgentDependencyAgentId { get; set; }

        string PropertyAgentDependencyAgentRevision { get; set; }

        string PropertyAgentDependencyAgentVersion { get; set; }

        string PropertyAgentId { get; set; }

        string PropertyAgentRebootStatus { get; set; }

        string PropertyHostingProvider { get; set; }

        string PropertyHypervisorNativeHostMachineId { get; set; }

        string PropertyHypervisorType { get; set; }

        string[] PropertyNetworkingDefaultIpv4Gateway { get; set; }

        string[] PropertyNetworkingDnsCanonicalName { get; set; }

        string[] PropertyNetworkingDnsName { get; set; }

        string[] PropertyNetworkingDnsQuestion { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IIpv4NetworkInterface[] PropertyNetworkingIpv4Interface { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IIpv6NetworkInterface[] PropertyNetworkingIpv6Interface { get; set; }

        string[] PropertyNetworkingMacAddress { get; set; }

        string PropertyOperatingSystemBitness { get; set; }

        string PropertyOperatingSystemFamily { get; set; }

        string PropertyOperatingSystemFullName { get; set; }

        int? PropertyResourceCpu { get; set; }

        int? PropertyResourceCpuSpeed { get; set; }

        string PropertyResourceCpuSpeedAccuracy { get; set; }

        int? PropertyResourcePhysicalMemory { get; set; }

        string PropertyTimezoneFullName { get; set; }

        string PropertyVirtualMachineName { get; set; }

        string PropertyVirtualMachineNativeHostMachineId { get; set; }

        string PropertyVirtualMachineNativeMachineId { get; set; }

        string PropertyVirtualMachineType { get; set; }

        string Type { get; set; }

    }
}