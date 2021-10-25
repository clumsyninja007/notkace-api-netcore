namespace kace_api_netcore.Entities.K1000.Models
{
    public class Execution
    {
        public int WorkflowId { get; set; }
        public int ExecutionId { get; set; }
        public int? ExecutionParent { get; set; }
        public int ExecutionStarted { get; set; }
        public int? ExecutionSuspended { get; set; }
        public byte[] ExecutionVariables { get; set; }
        public byte[] ExecutionWaitingFor { get; set; }
        public byte[] ExecutionThreads { get; set; }
        public int ExecutionNextThreadId { get; set; }
    }
}