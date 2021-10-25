namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineNics
    {
        public long NicId { get; set; }
        public long Id { get; set; }
        public string Nic { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public string Netmask { get; set; }
        public string DhcpEnabled { get; set; }
        public string Ipv6Config { get; set; }
        public string Dnsdoman { get; set; }
        public string Dnshostname { get; set; }
    }
}