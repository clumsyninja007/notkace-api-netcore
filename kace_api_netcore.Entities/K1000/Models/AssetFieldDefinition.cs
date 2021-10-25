namespace kace_api_netcore.Entities.K1000.Models
{
    public class AssetFieldDefinition
    {
        public long Id { get; set; }
        public long AssetTypeId { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string FieldValues { get; set; }
        public long Ordinal { get; set; }
        public string DefaultValue { get; set; }
        public int Required { get; set; }
        public int Multiple { get; set; }
        public int Protected { get; set; }
        public int SystemDefined { get; set; }
        public int Ignored { get; set; }
        public long AssetClassId { get; set; }
        public long DeviceDetailSectionId { get; set; }
        public long AssetFieldSectionId { get; set; }
    }
}