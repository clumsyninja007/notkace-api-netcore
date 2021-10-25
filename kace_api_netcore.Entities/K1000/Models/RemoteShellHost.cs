namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteShellHost
    {
        public long RemoteShellHostId { get; set; }
        public long RemoteHostId { get; set; }
        public int ShellProtocol { get; set; }
        public int? Port { get; set; }
        public int OsType { get; set; }
        public string ExecutionShell { get; set; }
        public byte[] SudoPasswordEnc { get; set; }
        public byte Validated { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}