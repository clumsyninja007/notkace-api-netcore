﻿using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Asset
    {
        public long Id { get; set; }
        public long AssetTypeId { get; set; }
        public string Name { get; set; }
        public long? AssetDataId { get; set; }
        public long? OwnerId { get; set; }
        public long LocationId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long? MappedId { get; set; }
        public long AssetClassId { get; set; }
        public string Archive { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public string ArchiveReason { get; set; }
        public long? AssetStatusId { get; set; }

        public virtual ICollection<HdTicket> HdTicketsAsset { get; set; }
        public virtual ICollection<HdTicket> HdTicketsMachine { get; set; }
    }
}