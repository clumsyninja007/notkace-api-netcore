using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class SmartyReport
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Query { get; set; }
        public byte? CsvSupport { get; set; }
        public byte? TxtSupport { get; set; }
        public byte? HtmlSupport { get; set; }
        public byte? BuiltIn { get; set; }
        public byte? LineNumbers { get; set; }
        public string ColumnsJson { get; set; }
        public string BreakColumns { get; set; }
        public string Fieldlist { get; set; }
        public string Orderby { get; set; }
        public string Orderseq { get; set; }
        public string Breaks { get; set; }
        public string FfJson { get; set; }
        public string BusinessObjectId { get; set; }
        public string AtleastOne { get; set; }
        public byte? XlsSupport { get; set; }
        public byte? PdfSupport { get; set; }
        public string RequiredFeature { get; set; }
    }
}