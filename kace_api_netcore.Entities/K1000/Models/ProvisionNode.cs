using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ProvisionNode
    {
        public long Id { get; set; }
        public string Ip { get; set; }
        public string Mac { get; set; }
        public short? PingStatus { get; set; }
        public short? AgentInstalled { get; set; }
        public byte[] ProvisioningLog { get; set; }
        public string HostName { get; set; }
        public string OperatingSystem { get; set; }
        public string Status { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long? ProvisionConfigId { get; set; }
        public string ProvisioningStatus { get; set; }
        public string FailureType { get; set; }
        public long ErrorCode { get; set; }
        public string Action { get; set; }
        public string Kuid { get; set; }
        public long KboxId { get; set; }
    }
}