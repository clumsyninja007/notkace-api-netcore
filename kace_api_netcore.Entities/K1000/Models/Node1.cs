using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Node1
    {
        public long Id { get; set; }
        public long Id1 { get; set; }
        public int WorkflowId { get; set; }
        public int WorkflowId1 { get; set; }
        public string Ip { get; set; }
        public string Ip1 { get; set; }
        public int NodeId { get; set; }
        public int NodeId1 { get; set; }
        public string Mac { get; set; }
        public string Mac1 { get; set; }
        public string NodeClass { get; set; }
        public string NodeClass1 { get; set; }
        public short? SocketStatus { get; set; }
        public short? SocketStatus1 { get; set; }
        public byte[] NodeConfiguration { get; set; }
        public byte[] NodeConfiguration1 { get; set; }
        public short? PingStatus { get; set; }
        public short? PingStatus1 { get; set; }
        public byte? LdapStatus { get; set; }
        public byte? LdapStatus1 { get; set; }
        public byte? ChromeosStatus { get; set; }
        public byte? ChromeosStatus1 { get; set; }
        public byte? GMobileStatus { get; set; }
        public byte? GMobileStatus1 { get; set; }
        public byte? KmmStatus { get; set; }
        public byte? KmmStatus1 { get; set; }
        public byte? DmmStatus { get; set; }
        public byte? DmmStatus1 { get; set; }
        public byte? AwStatus { get; set; }
        public byte? AwStatus1 { get; set; }
        public byte? NmapStatus { get; set; }
        public byte? NmapStatus1 { get; set; }
        public byte? CliStatus { get; set; }
        public byte? CliStatus1 { get; set; }
        public byte? WinrmStatus { get; set; }
        public byte? WinrmStatus1 { get; set; }
        public byte? VmwareType { get; set; }
        public byte? VmwareType1 { get; set; }
        public short? SnmpStatus { get; set; }
        public short? SnmpStatus1 { get; set; }
        public string SnmpWalkData { get; set; }
        public string SnmpWalkData1 { get; set; }
        public string SnmpUptime { get; set; }
        public string SnmpUptime1 { get; set; }
        public string SnmpSysdescr { get; set; }
        public string SnmpSysdescr1 { get; set; }
        public string SnmpContact { get; set; }
        public string SnmpContact1 { get; set; }
        public byte? SnmpVersion { get; set; }
        public byte? SnmpVersion1 { get; set; }
        public byte? VmwareStatus { get; set; }
        public byte? VmwareStatus1 { get; set; }
        public string ChromeosId { get; set; }
        public string ChromeosId1 { get; set; }
        public string GMobileId { get; set; }
        public string GMobileId1 { get; set; }
        public string KmmId { get; set; }
        public string KmmId1 { get; set; }
        public string DmmId { get; set; }
        public string DmmId1 { get; set; }
        public string AwId { get; set; }
        public string AwId1 { get; set; }
        public decimal? ScanSpeed { get; set; }
        public decimal? ScanSpeed1 { get; set; }
        public string OsType { get; set; }
        public string OsType1 { get; set; }
        public string HostName { get; set; }
        public string HostName1 { get; set; }
        public string RealName { get; set; }
        public string RealName1 { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Modified1 { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Created1 { get; set; }
        public long? ScanSettingsId { get; set; }
        public long? ScanSettingsId1 { get; set; }
        public long? MachineId { get; set; }
        public long? MachineId1 { get; set; }
        public long? RelayMachineId { get; set; }
        public long? RelayMachineId1 { get; set; }

        public virtual Machine RelayMachine { get; set; }
    }
}