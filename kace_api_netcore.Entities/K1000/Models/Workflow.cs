using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Workflow
    {
        public Workflow()
        {
            Kworkflow = new HashSet<Kworkflow>();
        }

        public int WorkflowId { get; set; }
        public string WorkflowName { get; set; }
        public int WorkflowVersion { get; set; }
        public int WorkflowCreated { get; set; }

        public virtual ICollection<Kworkflow> Kworkflow { get; set; }
    }
}