using System;

namespace kace_api_netcore.Data.K1000.Dtos
{
    public record HdTicketsDto
    {
        public long Ticket { get; init; }
        public string Title { get; init; }
        public string Priority { get; init; }
        public string Owner { get; init; }
        public string Submitter { get; init; }
        public string Asset { get; init; }
        public string Device { get; init; }
        public string Status { get; init; }
        public string ReferredTo { get; init; }
        public string UserName { get; init; }
        public string Dept { get; init; }
        public string Location { get; init; }
        public long PriOrd { get; init; }
        public long StatOrd { get; init; }
        public DateTimeOffset Created { get; init; }
        public DateTimeOffset Modified { get; init; }
        public DateTimeOffset? DueDate { get; init; }
    }
}