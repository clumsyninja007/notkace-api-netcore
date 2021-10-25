namespace kace_api_netcore.Entities.K1000.Models
{
    public class NodeConnection
    {
        public int NodeConnectionId { get; set; }
        public int IncomingNodeId { get; set; }
        public int OutgoingNodeId { get; set; }
    }
}