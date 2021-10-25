namespace kace_api_netcore.Data.K1000.Dtos
{
    public record SortField
    {
        public SortField(string field)
        {
            Field = field[1..].ToLower();
            SortDesc = field[0] == '-';
        }

        public string Field { get; }

        public bool SortDesc { get; }
    }
}