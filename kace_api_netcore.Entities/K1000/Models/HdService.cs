namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdService
    {
        public long Id { get; set; }
        public long? KworkflowId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? MarkdownEnabled { get; set; }
        public byte Enabled { get; set; }
        public byte AllowAllUsers { get; set; }
        public byte AllowAdminUsers { get; set; }
        public long? HdServiceTypeId { get; set; }
        public long? OwnerId { get; set; }
        public byte? CatalogEnabled { get; set; }
        public long? HdServiceCategoryId { get; set; }
        public byte? ApprovalRequired { get; set; }
        public byte? AllowAllAdminOverride { get; set; }
        public byte HideApprovalSteps { get; set; }
        public byte HideProcessSteps { get; set; }
        public byte ShowIntermediatePage { get; set; }
        public byte? HdUseProcessStatus { get; set; }
        public long? ParentTicketClosedStatusId { get; set; }
    }
}