namespace kace_api_netcore.Entities.K1000.Models
{
    public class KbotShellScript
    {
        public long KbotId { get; set; }
        public string FileName { get; set; }
        public string Checksum { get; set; }
        public string ScriptText { get; set; }
        public short? Timeout { get; set; }
        public byte? RemoveFiles { get; set; }
        public byte? UploadFile { get; set; }
        public string UploadFilePath { get; set; }
        public string UploadFileName { get; set; }
    }
}