using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class AdvisoryRatings
    {
        public int Id { get; set; }
        public int AdvisoryId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public long PageViews { get; set; }
        public DateTimeOffset LastView { get; set; }
        public long PageVotes { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
    }
}