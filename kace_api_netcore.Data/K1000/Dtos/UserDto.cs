namespace kace_api_netcore.Data.K1000.Dtos
{
    public record UserDto
    {
        public long Id { get; init; }
        public string UserName { get; init; }
        public string FullName { get; init; }
    }
}
