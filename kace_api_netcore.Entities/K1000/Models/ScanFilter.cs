﻿using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScanFilter
    {
        public long Id { get; set; }
        public string Query { get; set; }
        public long? Type { get; set; }
        public long? LabelId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Ordinal { get; set; }
    }
}