using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteHostProtocol
    {
        public RemoteHostProtocol()
        {
            RemoteHost = new HashSet<RemoteHost>();
        }

        public long RemoteHostProtocolId { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }

        public virtual ICollection<RemoteHost> RemoteHost { get; set; }
    }
}