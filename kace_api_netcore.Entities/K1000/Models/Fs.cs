using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Fs
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long? SoftwareId { get; set; }
        public string Notes { get; set; }
        public long? Enabled { get; set; }
        public long? CreateLocation { get; set; }
        public string Location { get; set; }
        public long? ReplaceExisting { get; set; }
        public long? CreateShortcut { get; set; }
        public string ShortcutName { get; set; }
        public long? NoUncompress { get; set; }
        public long? RemoveFiles { get; set; }
        public int? HourBegin { get; set; }
        public int? HourEnd { get; set; }
        public string AltLocation { get; set; }
        public string AltChecksum { get; set; }
        public string PreinstallMessage { get; set; }
        public string PostinstallMessage { get; set; }
        public string Type { get; set; }
        public long? CredentialIdLocation { get; set; }
        public byte? Persistent { get; set; }
        public long? CredentialIdAltLocation { get; set; }
        public byte TargetAllMachines { get; set; }
    }
}