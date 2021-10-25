using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Machine
    {
        public Machine()
        {
            AgentlessTaskLog = new HashSet<AgentlessTaskLog>();
            MachineChromeosDetails = new HashSet<MachineChromeosDetails>();
            MachineLocation = new HashSet<MachineLocation>();
            MachineMobile = new HashSet<MachineMobile>();
            MachineSnmpData = new HashSet<MachineSnmpData>();
            MachineVirtualGuest = new HashSet<MachineVirtualGuest>();
            MachineVirtualHost = new HashSet<MachineVirtualHost>();
            MachineVirtualManager = new HashSet<MachineVirtualManager>();
            Node1 = new HashSet<Node1>();
            ProvisionConfig = new HashSet<ProvisionConfig>();
            RemoteHost = new HashSet<RemoteHost>();
            ScanSettings = new HashSet<ScanSettings>();
        }

        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string User { get; set; }
        public string UserFullname { get; set; }
        public string Name { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public string Ipv6 { get; set; }
        public string Netmask { get; set; }
        public short? PrefixLen { get; set; }
        public string OsName { get; set; }
        public string OsNumber { get; set; }
        public string OsMajor { get; set; }
        public string OsMinor { get; set; }
        public string OsMinor2 { get; set; }
        public string ServicePack { get; set; }
        public long? OsId { get; set; }
        public string Notes { get; set; }
        public DateTimeOffset LastMessage { get; set; }
        public DateTimeOffset LastInventory { get; set; }
        public DateTimeOffset LastSync { get; set; }
        public DateTimeOffset LastClientUpdate { get; set; }
        public DateTimeOffset LastClientUpdateAttempt { get; set; }
        public string Domain { get; set; }
        public string OsVersion { get; set; }
        public string OsBuild { get; set; }
        public string OsInstalledDate { get; set; }
        public string LastReboot { get; set; }
        public string Uptime { get; set; }
        public string SystemDirectory { get; set; }
        public string SystemDescription { get; set; }
        public double? RamTotal { get; set; }
        public double? RamUsed { get; set; }
        public string RamMax { get; set; }
        public string CsManufacturer { get; set; }
        public string CsModel { get; set; }
        public string CsDomain { get; set; }
        public string LastUser { get; set; }
        public string UserLogged { get; set; }
        public string UserName { get; set; }
        public string UserDomain { get; set; }
        public string BiosName { get; set; }
        public string BiosVersion { get; set; }
        public string BiosManufacturer { get; set; }
        public string BiosDescription { get; set; }
        public string BiosIdentificationCode { get; set; }
        public string BiosSerialNumber { get; set; }
        public DateTimeOffset BiosReleaseDate { get; set; }
        public string CspIdNumber { get; set; }
        public string AssetTag { get; set; }
        public string Virtual { get; set; }
        public string DotNetVersions { get; set; }
        public string IeVersion { get; set; }
        public string OsFamily { get; set; }
        public string MotherboardPrimaryBus { get; set; }
        public string MotherboardSecondaryBus { get; set; }
        public string Processors { get; set; }
        public string SoundDevices { get; set; }
        public string CdromDevices { get; set; }
        public string VideoControllers { get; set; }
        public string Monitor { get; set; }
        public string RegistrySize { get; set; }
        public string RegistryMaxSize { get; set; }
        public string PagefileSize { get; set; }
        public string PagefileMaxSize { get; set; }
        public string Printers { get; set; }
        public string Kuid { get; set; }
        public byte ManualEntry { get; set; }
        public string SysArch { get; set; }
        public string OsArch { get; set; }
        public byte ForceInventory { get; set; }
        public string CustomFieldValue0 { get; set; }
        public string CustomFieldValue1 { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string CustomFieldValue3 { get; set; }
        public string CustomFieldValue4 { get; set; }
        public string CustomFieldValue5 { get; set; }
        public DateTime? InventoryStarted { get; set; }
        public string ClientVersion { get; set; }
        public DateTimeOffset ConnectTime { get; set; }
        public DateTimeOffset DisconnectTime { get; set; }
        public long PatchlinkLanguageId { get; set; }
        public string KpatchLanguageId { get; set; }
        public string LastShutdown { get; set; }
        public string ChassisType { get; set; }
        public string TzAgent { get; set; }
        public string WmiStatus { get; set; }
        public int? PhysicalProcessors { get; set; }
        public int? PhysicalCores { get; set; }
        public string CpuName { get; set; }
        public string ManufacturerProductNumber { get; set; }
        public string Ownership { get; set; }

        public virtual ICollection<AgentlessTaskLog> AgentlessTaskLog { get; set; }
        public virtual ICollection<MachineChromeosDetails> MachineChromeosDetails { get; set; }
        public virtual ICollection<MachineLocation> MachineLocation { get; set; }
        public virtual ICollection<MachineMobile> MachineMobile { get; set; }
        public virtual ICollection<MachineSnmpData> MachineSnmpData { get; set; }
        public virtual ICollection<MachineVirtualGuest> MachineVirtualGuest { get; set; }
        public virtual ICollection<MachineVirtualHost> MachineVirtualHost { get; set; }
        public virtual ICollection<MachineVirtualManager> MachineVirtualManager { get; set; }
        public virtual ICollection<Node1> Node1 { get; set; }
        public virtual ICollection<ProvisionConfig> ProvisionConfig { get; set; }
        public virtual ICollection<RemoteHost> RemoteHost { get; set; }
        public virtual ICollection<ScanSettings> ScanSettings { get; set; }
    }
}