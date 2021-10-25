namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdQueue
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EmailUser { get; set; }
        public string PopUsername { get; set; }
        public byte[] PopPasswordEnc { get; set; }
        public byte PopSsl { get; set; }
        public long? DefaultPriorityId { get; set; }
        public long? DefaultStatusId { get; set; }
        public long? DefaultImpactId { get; set; }
        public long? DefaultCategoryId { get; set; }
        public byte CreateUsersOnEmail { get; set; }
        public string AltEmailAddr { get; set; }
        public byte AllowAllUsers { get; set; }
        public byte AllowDelete { get; set; }
        public byte AllowParentClose { get; set; }
        public byte AllowAllApprovers { get; set; }
        public byte AllowOwnersViaAdminui { get; set; }
        public string ArchiveInterval { get; set; }
        public string PurgeInterval { get; set; }
        public string PopServer { get; set; }
        public string SmtpServer { get; set; }
        public string SmtpUsername { get; set; }
        public byte[] SmtpPasswordEnc { get; set; }
        public long SmtpPort { get; set; }
        public byte OwnersOnlyComments { get; set; }
        public byte ConflictWarningEnabled { get; set; }
        public byte ShowNewTicketComments { get; set; }
        public byte ShowNewTicketAttachments { get; set; }
        public byte AllowManagerCommentViaUserui { get; set; }
        public byte AutoAddCclistOnComment { get; set; }
        public byte AllowUsersEditOwnComment { get; set; }
        public byte AllowOwnersEditAllComment { get; set; }
    }
}