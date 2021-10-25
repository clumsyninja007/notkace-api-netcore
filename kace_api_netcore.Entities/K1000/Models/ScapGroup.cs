namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScapGroup
    {
        public long Id { get; set; }
        public long ScapProfileId { get; set; }
        public string Identifier { get; set; }
        public long? ParentScapGroupId { get; set; }
        public int Seq { get; set; }
        public int Level { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}