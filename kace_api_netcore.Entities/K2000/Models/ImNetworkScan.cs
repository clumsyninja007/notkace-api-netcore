using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImNetworkScan
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Name { get; set; }
        public byte Enabled { get; set; }
        public string Notes { get; set; }
        public string ProbeRangeStart { get; set; }
        public string ProbeRangeEnd { get; set; }
        public byte PingProbeEnabled { get; set; }
        public int? PingProbeTimeout { get; set; }
        public byte PortProbeEnabled { get; set; }
        public int? PortProbeTimeout { get; set; }
        public string PortProbeTcpConfiguration { get; set; }
        public string PortProbeUdpConfiguration { get; set; }
        public byte DnsLookupEnabled { get; set; }
        public int? DnsLookupTimeout { get; set; }
        public long ImCronId { get; set; }
        public string State { get; set; }
    }
}