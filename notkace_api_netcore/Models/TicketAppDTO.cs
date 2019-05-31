namespace notkace_api_netcore.Models
{
    public class TicketAppDto
    {
        public long Ticket { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public string Owner { get; set; }
        public string Submitter { get; set; }
        public string Asset { get; set; }
        public string Device { get; set; }
        public string Status { get; set; }
        public string ReferredTo { get; set; }
        public string UserName { get; set; }
        public short PriOrd { get; set; }
        public short StatOrd { get; set; }
        public string Dept { get; set; }
        public string Location { get; set; }
    }
}