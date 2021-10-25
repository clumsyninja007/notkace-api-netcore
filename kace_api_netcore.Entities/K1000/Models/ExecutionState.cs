namespace kace_api_netcore.Entities.K1000.Models
{
    public class ExecutionState
    {
        public int ExecutionId { get; set; }
        public int NodeId { get; set; }
        public byte[] NodeState { get; set; }
        public byte[] NodeActivatedFrom { get; set; }
        public int NodeThreadId { get; set; }
    }
}