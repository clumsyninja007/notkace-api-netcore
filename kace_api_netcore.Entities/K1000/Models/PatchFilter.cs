namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchFilter
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public string FindFields { get; set; }
    }
}