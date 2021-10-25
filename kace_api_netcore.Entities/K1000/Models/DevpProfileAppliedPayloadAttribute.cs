namespace kace_api_netcore.Entities.K1000.Models
{
    public class DevpProfileAppliedPayloadAttribute
    {
        public int Id { get; set; }
        public int DevpProfileAppliedPayloadId { get; set; }
        public string AttributeKey { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeType { get; set; }

        public virtual DevpProfileAppliedPayload DevpProfileAppliedPayload { get; set; }
    }
}