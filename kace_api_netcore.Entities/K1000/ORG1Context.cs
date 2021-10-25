using kace_api_netcore.Entities.K1000.Models;
using Microsoft.EntityFrameworkCore;

namespace kace_api_netcore.Entities.K1000
{
    public class ORG1Context : DbContext
    {
        public ORG1Context(DbContextOptions<ORG1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Advisory> Advisory { get; set; }
        public virtual DbSet<AdvisoryLabelJt> AdvisoryLabelJt { get; set; }
        public virtual DbSet<AdvisoryRatings> AdvisoryRatings { get; set; }
        public virtual DbSet<AgentlessTaskLog> AgentlessTaskLog { get; set; }
        public virtual DbSet<Approval> Approval { get; set; }
        public virtual DbSet<ApprovalStage> ApprovalStage { get; set; }
        public virtual DbSet<ApprovalStageUser> ApprovalStageUser { get; set; }
        public virtual DbSet<ArchiveAssetDevice> ArchiveAssetDevice { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetAssociation> AssetAssociation { get; set; }
        public virtual DbSet<AssetBarcodeJt> AssetBarcodeJt { get; set; }
        public virtual DbSet<AssetCatalogAssociation> AssetCatalogAssociation { get; set; }
        public virtual DbSet<AssetClass> AssetClass { get; set; }
        public virtual DbSet<AssetData1> AssetData1 { get; set; }
        public virtual DbSet<AssetData10000> AssetData10000 { get; set; }
        public virtual DbSet<AssetData10001> AssetData10001 { get; set; }
        public virtual DbSet<AssetData10002> AssetData10002 { get; set; }
        public virtual DbSet<AssetData10200> AssetData10200 { get; set; }
        public virtual DbSet<AssetData12> AssetData12 { get; set; }
        public virtual DbSet<AssetData2> AssetData2 { get; set; }
        public virtual DbSet<AssetData3> AssetData3 { get; set; }
        public virtual DbSet<AssetData4> AssetData4 { get; set; }
        public virtual DbSet<AssetData5> AssetData5 { get; set; }
        public virtual DbSet<AssetData6> AssetData6 { get; set; }
        public virtual DbSet<AssetData7> AssetData7 { get; set; }
        public virtual DbSet<AssetFieldDefinition> AssetFieldDefinition { get; set; }
        public virtual DbSet<AssetFieldSection> AssetFieldSection { get; set; }
        public virtual DbSet<AssetFilter> AssetFilter { get; set; }
        public virtual DbSet<AssetHierarchy> AssetHierarchy { get; set; }
        public virtual DbSet<AssetHistory> AssetHistory { get; set; }
        public virtual DbSet<AssetStatus> AssetStatus { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<Authentication> Authentication { get; set; }
        public virtual DbSet<Barcode> Barcode { get; set; }
        public virtual DbSet<ClientDistribution> ClientDistribution { get; set; }
        public virtual DbSet<ClientdistLabelJt> ClientdistLabelJt { get; set; }
        public virtual DbSet<ContractFilter> ContractFilter { get; set; }
        public virtual DbSet<Credential> Credential { get; set; }
        public virtual DbSet<CustomFieldDefinition> CustomFieldDefinition { get; set; }
        public virtual DbSet<CustomView> CustomView { get; set; }
        public virtual DbSet<Dashboard> Dashboard { get; set; }
        public virtual DbSet<DashboardCache> DashboardCache { get; set; }
        public virtual DbSet<DellAsset> DellAsset { get; set; }
        public virtual DbSet<DellInventory> DellInventory { get; set; }
        public virtual DbSet<DellInventoryDeviceJt> DellInventoryDeviceJt { get; set; }
        public virtual DbSet<DellMachinePkgUpdateStatus> DellMachinePkgUpdateStatus { get; set; }
        public virtual DbSet<DellMachineStatus> DellMachineStatus { get; set; }
        public virtual DbSet<DellPkgLabelJt> DellPkgLabelJt { get; set; }
        public virtual DbSet<DellPkgStatus> DellPkgStatus { get; set; }
        public virtual DbSet<DellSchedule> DellSchedule { get; set; }
        public virtual DbSet<DellScheduleLabelJt> DellScheduleLabelJt { get; set; }
        public virtual DbSet<DellScheduleMachineStatus> DellScheduleMachineStatus { get; set; }
        public virtual DbSet<DellScheduleOsJt> DellScheduleOsJt { get; set; }
        public virtual DbSet<DellScheduleUpdateLabelJt> DellScheduleUpdateLabelJt { get; set; }
        public virtual DbSet<DeviceDetailField> DeviceDetailField { get; set; }
        public virtual DbSet<DeviceDetailGroup> DeviceDetailGroup { get; set; }
        public virtual DbSet<DeviceDetailGroupAssetClassJt> DeviceDetailGroupAssetClassJt { get; set; }
        public virtual DbSet<DeviceDetailSection> DeviceDetailSection { get; set; }
        public virtual DbSet<DeviceDetailSectionAssetClassJt> DeviceDetailSectionAssetClassJt { get; set; }
        public virtual DbSet<DevpProfileApplied> DevpProfileApplied { get; set; }
        public virtual DbSet<DevpProfileAppliedMachine> DevpProfileAppliedMachine { get; set; }
        public virtual DbSet<DevpProfileAppliedPayload> DevpProfileAppliedPayload { get; set; }
        public virtual DbSet<DevpProfileAppliedPayloadAttribute> DevpProfileAppliedPayloadAttribute { get; set; }
        public virtual DbSet<EmailEvent> EmailEvent { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<Execution> Execution { get; set; }
        public virtual DbSet<ExecutionState> ExecutionState { get; set; }
        public virtual DbSet<FederatedAccessRole> FederatedAccessRole { get; set; }
        public virtual DbSet<Filter> Filter { get; set; }
        public virtual DbSet<Fs> Fs { get; set; }
        public virtual DbSet<FsLabelJt> FsLabelJt { get; set; }
        public virtual DbSet<FsMachineJt> FsMachineJt { get; set; }
        public virtual DbSet<GlobalOptions> GlobalOptions { get; set; }
        public virtual DbSet<GridColumnsOverrides> GridColumnsOverrides { get; set; }
        public virtual DbSet<HdAnnouncement> HdAnnouncement { get; set; }
        public virtual DbSet<HdAnnouncementLabelJt> HdAnnouncementLabelJt { get; set; }
        public virtual DbSet<HdArchiveAttachment> HdArchiveAttachment { get; set; }
        public virtual DbSet<HdArchiveTicket> HdArchiveTicket { get; set; }
        public virtual DbSet<HdArchiveTicketChange> HdArchiveTicketChange { get; set; }
        public virtual DbSet<HdArchiveTicketChangeField> HdArchiveTicketChangeField { get; set; }
        public virtual DbSet<HdArchiveWork> HdArchiveWork { get; set; }
        public virtual DbSet<HdAttachment> HdAttachment { get; set; }
        public virtual DbSet<HdCategory> HdCategory { get; set; }
        public virtual DbSet<HdCustomFields> HdCustomFields { get; set; }
        public virtual DbSet<HdEmailEvent> HdEmailEvent { get; set; }
        public virtual DbSet<HdField> HdField { get; set; }
        public virtual DbSet<HdHomePageWidget> HdHomePageWidget { get; set; }
        public virtual DbSet<HdImpact> HdImpact { get; set; }
        public virtual DbSet<HdLink> HdLink { get; set; }
        public virtual DbSet<HdMailtemplate> HdMailtemplate { get; set; }
        public virtual DbSet<HdPriority> HdPriority { get; set; }
        public virtual DbSet<HdQueue> HdQueue { get; set; }
        public virtual DbSet<HdQueueApproverLabelJt> HdQueueApproverLabelJt { get; set; }
        public virtual DbSet<HdQueueOwnerCommentLabelJt> HdQueueOwnerCommentLabelJt { get; set; }
        public virtual DbSet<HdQueueOwnerLabelJt> HdQueueOwnerLabelJt { get; set; }
        public virtual DbSet<HdQueueSubmitterLabelJt> HdQueueSubmitterLabelJt { get; set; }
        public virtual DbSet<HdQueueUserCommentLabelJt> HdQueueUserCommentLabelJt { get; set; }
        public virtual DbSet<HdResponseTemplate> HdResponseTemplate { get; set; }
        public virtual DbSet<HdService> HdService { get; set; }
        public virtual DbSet<HdServiceCategory> HdServiceCategory { get; set; }
        public virtual DbSet<HdServiceOverrideLabelJt> HdServiceOverrideLabelJt { get; set; }
        public virtual DbSet<HdServiceStatus> HdServiceStatus { get; set; }
        public virtual DbSet<HdServiceTicket> HdServiceTicket { get; set; }
        public virtual DbSet<HdServiceType> HdServiceType { get; set; }
        public virtual DbSet<HdServiceUserLabelJt> HdServiceUserLabelJt { get; set; }
        public virtual DbSet<HdSlaBusinessHours> HdSlaBusinessHours { get; set; }
        public virtual DbSet<HdSlaHolidays> HdSlaHolidays { get; set; }
        public virtual DbSet<HdStatus> HdStatus { get; set; }
        public virtual DbSet<HdTicket> HdTicket { get; set; }
        public virtual DbSet<HdTicketApproval> HdTicketApproval { get; set; }
        public virtual DbSet<HdTicketApprovalParent> HdTicketApprovalParent { get; set; }
        public virtual DbSet<HdTicketApprovalStage> HdTicketApprovalStage { get; set; }
        public virtual DbSet<HdTicketChange> HdTicketChange { get; set; }
        public virtual DbSet<HdTicketChangeField> HdTicketChangeField { get; set; }
        public virtual DbSet<HdTicketFilter> HdTicketFilter { get; set; }
        public virtual DbSet<HdTicketRule> HdTicketRule { get; set; }
        public virtual DbSet<HdWork> HdWork { get; set; }
        public virtual DbSet<HpAsset> HpAsset { get; set; }
        public virtual DbSet<ImCron> ImCron { get; set; }
        public virtual DbSet<Kbot> Kbot { get; set; }
        public virtual DbSet<KbotEventSchedule> KbotEventSchedule { get; set; }
        public virtual DbSet<KbotForm> KbotForm { get; set; }
        public virtual DbSet<KbotFormData> KbotFormData { get; set; }
        public virtual DbSet<KbotLabelJt> KbotLabelJt { get; set; }
        public virtual DbSet<KbotLog> KbotLog { get; set; }
        public virtual DbSet<KbotLogDetail> KbotLogDetail { get; set; }
        public virtual DbSet<KbotLogLatest> KbotLogLatest { get; set; }
        public virtual DbSet<KbotOsJt> KbotOsJt { get; set; }
        public virtual DbSet<KbotRun> KbotRun { get; set; }
        public virtual DbSet<KbotRunMachine> KbotRunMachine { get; set; }
        public virtual DbSet<KbotShellScript> KbotShellScript { get; set; }
        public virtual DbSet<KbotVerify> KbotVerify { get; set; }
        public virtual DbSet<KbotVerifySteps> KbotVerifySteps { get; set; }
        public virtual DbSet<KbotWolrelayLabelJt> KbotWolrelayLabelJt { get; set; }
        public virtual DbSet<KmonAlert> KmonAlert { get; set; }
        public virtual DbSet<KmonCondition> KmonCondition { get; set; }
        public virtual DbSet<KmonConfig> KmonConfig { get; set; }
        public virtual DbSet<KmonConfigDefault> KmonConfigDefault { get; set; }
        public virtual DbSet<KmonConfigDetail> KmonConfigDetail { get; set; }
        public virtual DbSet<KmonConfigDeviceJt> KmonConfigDeviceJt { get; set; }
        public virtual DbSet<KmonInstallLepDeviceJt> KmonInstallLepDeviceJt { get; set; }
        public virtual DbSet<KmonLep> KmonLep { get; set; }
        public virtual DbSet<KmonLepInstall> KmonLepInstall { get; set; }
        public virtual DbSet<KmonLogConfig> KmonLogConfig { get; set; }
        public virtual DbSet<KmonMaintConfig> KmonMaintConfig { get; set; }
        public virtual DbSet<KmonMonitoredDevice> KmonMonitoredDevice { get; set; }
        public virtual DbSet<KmonSnmpConfig> KmonSnmpConfig { get; set; }
        public virtual DbSet<Kworkflow> Kworkflow { get; set; }
        public virtual DbSet<KworkflowApprover> KworkflowApprover { get; set; }
        public virtual DbSet<KworkflowExecution> KworkflowExecution { get; set; }
        public virtual DbSet<KworkflowExecutionApproverStatus> KworkflowExecutionApproverStatus { get; set; }
        public virtual DbSet<Label> Label { get; set; }
        public virtual DbSet<LabelLabelJt> LabelLabelJt { get; set; }
        public virtual DbSet<LdapFilter> LdapFilter { get; set; }
        public virtual DbSet<LdapImportUser> LdapImportUser { get; set; }
        public virtual DbSet<LenovoAsset> LenovoAsset { get; set; }
        public virtual DbSet<LicenseComplianceException> LicenseComplianceException { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MachineActions> MachineActions { get; set; }
        public virtual DbSet<MachineBitlockerVolume> MachineBitlockerVolume { get; set; }
        public virtual DbSet<MachineChromeosDetails> MachineChromeosDetails { get; set; }
        public virtual DbSet<MachineDailyUptime> MachineDailyUptime { get; set; }
        public virtual DbSet<MachineDcmAmtSettings> MachineDcmAmtSettings { get; set; }
        public virtual DbSet<MachineDcmVproSettings> MachineDcmVproSettings { get; set; }
        public virtual DbSet<MachineDdpe> MachineDdpe { get; set; }
        public virtual DbSet<MachineDdpeVolume> MachineDdpeVolume { get; set; }
        public virtual DbSet<MachineDriveEncryptionSummary> MachineDriveEncryptionSummary { get; set; }
        public virtual DbSet<MachineFieldDefinition> MachineFieldDefinition { get; set; }
        public virtual DbSet<MachineFilevaultVolume> MachineFilevaultVolume { get; set; }
        public virtual DbSet<MachineIntelAmt> MachineIntelAmt { get; set; }
        public virtual DbSet<MachineLabelJt> MachineLabelJt { get; set; }
        public virtual DbSet<MachineLocation> MachineLocation { get; set; }
        public virtual DbSet<MachineMobile> MachineMobile { get; set; }
        public virtual DbSet<MachineNics> MachineNics { get; set; }
        public virtual DbSet<MachineNtserviceJt> MachineNtserviceJt { get; set; }
        public virtual DbSet<MachineProcessJt> MachineProcessJt { get; set; }
        public virtual DbSet<MachineSnmpData> MachineSnmpData { get; set; }
        public virtual DbSet<MachineSoftwareJt> MachineSoftwareJt { get; set; }
        public virtual DbSet<MachineStartupprogramJt> MachineStartupprogramJt { get; set; }
        public virtual DbSet<MachineTpm> MachineTpm { get; set; }
        public virtual DbSet<MachineVirtualGuest> MachineVirtualGuest { get; set; }
        public virtual DbSet<MachineVirtualHost> MachineVirtualHost { get; set; }
        public virtual DbSet<MachineVirtualManager> MachineVirtualManager { get; set; }
        public virtual DbSet<MachineVirtualState> MachineVirtualState { get; set; }
        public virtual DbSet<MachineVirtualStatus> MachineVirtualStatus { get; set; }
        public virtual DbSet<MachineVirtualToolsStatus> MachineVirtualToolsStatus { get; set; }
        public virtual DbSet<MachineVirtualType> MachineVirtualType { get; set; }
        public virtual DbSet<ManufacturerWarrantyApiKeys> ManufacturerWarrantyApiKeys { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageLabelJt> MessageLabelJt { get; set; }
        public virtual DbSet<Mi> Mi { get; set; }
        public virtual DbSet<MiAttempt> MiAttempt { get; set; }
        public virtual DbSet<MiLabelJt> MiLabelJt { get; set; }
        public virtual DbSet<Node1> Node1 { get; set; }
        public virtual DbSet<NodeConnection> NodeConnection { get; set; }
        public virtual DbSet<NodeLabelJt> NodeLabelJt { get; set; }
        public virtual DbSet<NodeSnmpSystem> NodeSnmpSystem { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotificationUserJt> NotificationUserJt { get; set; }
        public virtual DbSet<NtserviceLabelJt> NtserviceLabelJt { get; set; }
        public virtual DbSet<ObjectFieldDefinition> ObjectFieldDefinition { get; set; }
        public virtual DbSet<ObjectHistory> ObjectHistory { get; set; }
        public virtual DbSet<ObjectHistoryConfiguration> ObjectHistoryConfiguration { get; set; }
        public virtual DbSet<OperatingSystems> OperatingSystems { get; set; }
        public virtual DbSet<OvalStatus> OvalStatus { get; set; }
        public virtual DbSet<PatchFilter> PatchFilter { get; set; }
        public virtual DbSet<PatchMachineStatus> PatchMachineStatus { get; set; }
        public virtual DbSet<PatchlinkBulletinCount> PatchlinkBulletinCount { get; set; }
        public virtual DbSet<PatchlinkBulletinMachineStatus> PatchlinkBulletinMachineStatus { get; set; }
        public virtual DbSet<PatchlinkMachineApplicablePackage> PatchlinkMachineApplicablePackage { get; set; }
        public virtual DbSet<PatchlinkMachineStatus> PatchlinkMachineStatus { get; set; }
        public virtual DbSet<PatchlinkPatchCount> PatchlinkPatchCount { get; set; }
        public virtual DbSet<PatchlinkPatchLabelJt> PatchlinkPatchLabelJt { get; set; }
        public virtual DbSet<PatchlinkPatchStatus> PatchlinkPatchStatus { get; set; }
        public virtual DbSet<PatchlinkSchedule> PatchlinkSchedule { get; set; }
        public virtual DbSet<PatchlinkScheduleDeployLabelJt> PatchlinkScheduleDeployLabelJt { get; set; }
        public virtual DbSet<PatchlinkScheduleDetectLabelJt> PatchlinkScheduleDetectLabelJt { get; set; }
        public virtual DbSet<PatchlinkScheduleLabelJt> PatchlinkScheduleLabelJt { get; set; }
        public virtual DbSet<PatchlinkScheduleMachineStatus> PatchlinkScheduleMachineStatus { get; set; }
        public virtual DbSet<PatchlinkScheduleOsJt> PatchlinkScheduleOsJt { get; set; }
        public virtual DbSet<PatchlinkScheduleRollbackLabelJt> PatchlinkScheduleRollbackLabelJt { get; set; }
        public virtual DbSet<PatchlinkScheduleRun> PatchlinkScheduleRun { get; set; }
        public virtual DbSet<PatchlinkScheduleRunCounts> PatchlinkScheduleRunCounts { get; set; }
        public virtual DbSet<PatchlinkScheduleRunLog> PatchlinkScheduleRunLog { get; set; }
        public virtual DbSet<PatchlinkScheduleRunMachine> PatchlinkScheduleRunMachine { get; set; }
        public virtual DbSet<Portal> Portal { get; set; }
        public virtual DbSet<PortalLabelJt> PortalLabelJt { get; set; }
        public virtual DbSet<ProcessLabelJt> ProcessLabelJt { get; set; }
        public virtual DbSet<ProvisionConfig> ProvisionConfig { get; set; }
        public virtual DbSet<ProvisionNode> ProvisionNode { get; set; }
        public virtual DbSet<RemoteAirwatchHost> RemoteAirwatchHost { get; set; }
        public virtual DbSet<RemoteChromeosHost> RemoteChromeosHost { get; set; }
        public virtual DbSet<RemoteGSuiteHost> RemoteGSuiteHost { get; set; }
        public virtual DbSet<RemoteHost> RemoteHost { get; set; }
        public virtual DbSet<RemoteHostKuid> RemoteHostKuid { get; set; }
        public virtual DbSet<RemoteHostProtocol> RemoteHostProtocol { get; set; }
        public virtual DbSet<RemoteKmmHost> RemoteKmmHost { get; set; }
        public virtual DbSet<RemoteShellHost> RemoteShellHost { get; set; }
        public virtual DbSet<RemoteSnmpHost> RemoteSnmpHost { get; set; }
        public virtual DbSet<RemoteVmwareHost> RemoteVmwareHost { get; set; }
        public virtual DbSet<RemoteWsmanHost> RemoteWsmanHost { get; set; }
        public virtual DbSet<ReplicationShare> ReplicationShare { get; set; }
        public virtual DbSet<ReportField> ReportField { get; set; }
        public virtual DbSet<ReportFieldGroup> ReportFieldGroup { get; set; }
        public virtual DbSet<ReportJoin> ReportJoin { get; set; }
        public virtual DbSet<ReportObject> ReportObject { get; set; }
        public virtual DbSet<ReportSchedule> ReportSchedule { get; set; }
        public virtual DbSet<ReportSoftwareCatalogException> ReportSoftwareCatalogException { get; set; }
        public virtual DbSet<SamAttachedFile> SamAttachedFile { get; set; }
        public virtual DbSet<SamCatalogFilter> SamCatalogFilter { get; set; }
        public virtual DbSet<SamCatalogLabelJt> SamCatalogLabelJt { get; set; }
        public virtual DbSet<SamComplianceDetail> SamComplianceDetail { get; set; }
        public virtual DbSet<SamComplianceSummary> SamComplianceSummary { get; set; }
        public virtual DbSet<SamCount> SamCount { get; set; }
        public virtual DbSet<SamMachineJt> SamMachineJt { get; set; }
        public virtual DbSet<SamMachineTerminatedApps> SamMachineTerminatedApps { get; set; }
        public virtual DbSet<SamMeter> SamMeter { get; set; }
        public virtual DbSet<SamMeterData> SamMeterData { get; set; }
        public virtual DbSet<SamMeterTitledApplication> SamMeterTitledApplication { get; set; }
        public virtual DbSet<SamNotAllowed> SamNotAllowed { get; set; }
        public virtual DbSet<SamRecentJt> SamRecentJt { get; set; }
        public virtual DbSet<SavedSearch> SavedSearch { get; set; }
        public virtual DbSet<ScanFilter> ScanFilter { get; set; }
        public virtual DbSet<ScanSettings> ScanSettings { get; set; }
        public virtual DbSet<ScapBenchmark> ScapBenchmark { get; set; }
        public virtual DbSet<ScapGroup> ScapGroup { get; set; }
        public virtual DbSet<ScapProfile> ScapProfile { get; set; }
        public virtual DbSet<ScapResult> ScapResult { get; set; }
        public virtual DbSet<ScapResultRule> ScapResultRule { get; set; }
        public virtual DbSet<ScapResultScore> ScapResultScore { get; set; }
        public virtual DbSet<ScapRule> ScapRule { get; set; }
        public virtual DbSet<ScapRuleIdent> ScapRuleIdent { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SettingsHistory> SettingsHistory { get; set; }
        public virtual DbSet<SettingsHistoryConfiguration> SettingsHistoryConfiguration { get; set; }
        public virtual DbSet<SettingsHistoryFieldDefinition> SettingsHistoryFieldDefinition { get; set; }
        public virtual DbSet<SmartyReport> SmartyReport { get; set; }
        public virtual DbSet<SnmpInventoryOids> SnmpInventoryOids { get; set; }
        public virtual DbSet<SnmpInventorySettings> SnmpInventorySettings { get; set; }
        public virtual DbSet<SnmpInventorySettingsDefault> SnmpInventorySettingsDefault { get; set; }
        public virtual DbSet<SnmpInventorySettingsJt> SnmpInventorySettingsJt { get; set; }
        public virtual DbSet<SnoozeAlert> SnoozeAlert { get; set; }
        public virtual DbSet<Software> Software { get; set; }
        public virtual DbSet<SoftwareFileJt> SoftwareFileJt { get; set; }
        public virtual DbSet<SoftwareLabelJt> SoftwareLabelJt { get; set; }
        public virtual DbSet<SoftwareOsJt> SoftwareOsJt { get; set; }
        public virtual DbSet<StartupprogramLabelJt> StartupprogramLabelJt { get; set; }
        public virtual DbSet<TaskChain> TaskChain { get; set; }
        public virtual DbSet<TaskChainLabelJt> TaskChainLabelJt { get; set; }
        public virtual DbSet<TaskChainOsJt> TaskChainOsJt { get; set; }
        public virtual DbSet<TaskChainRun> TaskChainRun { get; set; }
        public virtual DbSet<TaskChainRunMachine> TaskChainRunMachine { get; set; }
        public virtual DbSet<TaskChainRunMachineCount> TaskChainRunMachineCount { get; set; }
        public virtual DbSet<TaskChainSteps> TaskChainSteps { get; set; }
        public virtual DbSet<Throttle> Throttle { get; set; }
        public virtual DbSet<ToadLicense> ToadLicense { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAdditionalEmail> UserAdditionalEmail { get; set; }
        public virtual DbSet<UserAutoRefresh> UserAutoRefresh { get; set; }
        public virtual DbSet<UserDownloadApprovalHistory> UserDownloadApprovalHistory { get; set; }
        public virtual DbSet<UserFieldDefinition> UserFieldDefinition { get; set; }
        public virtual DbSet<UserFieldValue> UserFieldValue { get; set; }
        public virtual DbSet<UserHistory> UserHistory { get; set; }
        public virtual DbSet<UserKeys> UserKeys { get; set; }
        public virtual DbSet<UserLabelJt> UserLabelJt { get; set; }
        public virtual DbSet<UserProfileFields> UserProfileFields { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserRoleDeviceLabelJt> UserRoleDeviceLabelJt { get; set; }
        public virtual DbSet<UserimportSchedule> UserimportSchedule { get; set; }
        public virtual DbSet<VariableHandler> VariableHandler { get; set; }
        public virtual DbSet<Workflow> Workflow { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Advisory>(entity =>
            {
                entity.ToTable("ADVISORY", "ORG1");

                entity.HasIndex(e => e.Category)
                    .HasName("CATEGORY");

                entity.HasIndex(e => new {e.Note, e.Importance, e.Platform, e.Title})
                    .HasName("NOTE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Importance)
                    .IsRequired()
                    .HasColumnName("IMPORTANCE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Markdown)
                    .HasColumnName("MARKDOWN")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasColumnType("text");

                entity.Property(e => e.OldMarkdownNote)
                    .HasColumnName("OLD_MARKDOWN_NOTE")
                    .IsUnicode(false);

                entity.Property(e => e.PageViews)
                    .HasColumnName("PAGE_VIEWS")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PageVotes)
                    .HasColumnName("PAGE_VOTES")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasColumnName("PLATFORM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdvisoryLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.AdvisoryId, e.LabelId});

                entity.ToTable("ADVISORY_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.AdvisoryId)
                    .HasColumnName("ADVISORY_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AdvisoryRatings>(entity =>
            {
                entity.ToTable("ADVISORY_RATINGS", "ORG1");

                entity.HasIndex(e => new {e.AdvisoryId, e.UserId})
                    .HasName("UNIQUE_ADVISORY_ID_USER_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdvisoryId)
                    .HasColumnName("ADVISORY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastView)
                    .HasColumnName("LAST_VIEW")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.PageViews)
                    .HasColumnName("PAGE_VIEWS")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PageVotes)
                    .HasColumnName("PAGE_VOTES")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rating)
                    .HasColumnName("RATING")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<AgentlessTaskLog>(entity =>
            {
                entity.ToTable("AGENTLESS_TASK_LOG", "ORG1");

                entity.HasIndex(e => e.Kuid)
                    .HasName("AGENTLESS_TASK_LOG_KUID_idx");

                entity.Property(e => e.AgentlessTaskLogId)
                    .HasColumnName("AGENTLESS_TASK_LOG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DateTime)
                    .HasColumnName("DATE_TIME")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Kuid)
                    .IsRequired()
                    .HasColumnName("KUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCode)
                    .HasColumnName("MESSAGE_CODE")
                    .HasColumnType("int(10)");

                entity.Property(e => e.MessageVars)
                    .HasColumnName("MESSAGE_VARS")
                    .IsUnicode(false);

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasColumnName("TASK_TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ku)
                    .WithMany(p => p.AgentlessTaskLog)
                    .HasPrincipalKey(p => p.Kuid)
                    .HasForeignKey(d => d.Kuid)
                    .HasConstraintName("AGENTLESS_TASK_LOG_KUID");
            });

            modelBuilder.Entity<Approval>(entity =>
            {
                entity.ToTable("APPROVAL", "ORG1");

                entity.HasIndex(e => new {e.ObjectType, e.ObjectId})
                    .HasName("OBJECT_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NotificationRecurrenceMinutes)
                    .HasColumnName("NOTIFICATION_RECURRENCE_MINUTES")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeoutMinutes)
                    .HasColumnName("TIMEOUT_MINUTES")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseBusinessHours)
                    .HasColumnName("USE_BUSINESS_HOURS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ApprovalStage>(entity =>
            {
                entity.ToTable("APPROVAL_STAGE", "ORG1");

                entity.HasIndex(e => e.ApprovalId)
                    .HasName("APPROVAL_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApprovalId)
                    .HasColumnName("APPROVAL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApprovalType)
                    .IsRequired()
                    .HasColumnName("APPROVAL_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stage)
                    .HasColumnName("STAGE")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<ApprovalStageUser>(entity =>
            {
                entity.ToTable("APPROVAL_STAGE_USER", "ORG1");

                entity.HasIndex(e => e.ApprovalStageId)
                    .HasName("STAGE_IDX");

                entity.HasIndex(e => e.UserId)
                    .HasName("USER_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApprovalStageId)
                    .HasColumnName("APPROVAL_STAGE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ArchiveAssetDevice>(entity =>
            {
                entity.ToTable("ARCHIVE_ASSET_DEVICE", "ORG1");

                entity.HasIndex(e => e.AssetId)
                    .HasName("IDX_ASSET_ID")
                    .IsUnique();

                entity.HasIndex(e => new {e.AssetId, e.Name})
                    .HasName("IDX_NAME");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HardwareJson)
                    .HasColumnName("HARDWARE_JSON")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelatedJson)
                    .HasColumnName("RELATED_JSON")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.SoftwareJson)
                    .HasColumnName("SOFTWARE_JSON")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("ASSET", "ORG1");

                entity.HasIndex(e => e.AssetClassId)
                    .HasName("INDEX_CLASS_ID");

                entity.HasIndex(e => e.AssetStatusId)
                    .HasName("INDEX_ASSET_STATUS_ID");

                entity.HasIndex(e => e.Name)
                    .HasName("INDEX_NAME");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("INDEX_OWNER_ID");

                entity.HasIndex(e => new {e.Archive, e.ArchiveDate})
                    .HasName("INDEX_ARCHIVE");

                entity.HasIndex(e => new {e.AssetTypeId, e.AssetDataId})
                    .HasName("INDEX_TYPE_DATA_ID")
                    .IsUnique();

                entity.HasIndex(e => new {e.AssetTypeId, e.MappedId})
                    .HasName("INDEX_TYPE_MAPPED_ID");

                entity.HasIndex(e => new {e.AssetTypeId, e.Name})
                    .HasName("INDEX_TYPE_NAME");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Archive)
                    .HasColumnName("ARCHIVE")
                    .HasColumnType("enum('PENDING','COMPLETED','')");

                entity.Property(e => e.ArchiveDate).HasColumnName("ARCHIVE_DATE");

                entity.Property(e => e.ArchiveReason)
                    .HasColumnName("ARCHIVE_REASON")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AssetClassId)
                    .HasColumnName("ASSET_CLASS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetDataId)
                    .HasColumnName("ASSET_DATA_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetStatusId)
                    .HasColumnName("ASSET_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetTypeId)
                    .HasColumnName("ASSET_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LOCATION_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MappedId)
                    .HasColumnName("MAPPED_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OWNER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AssetAssociation>(entity =>
            {
                entity.HasKey(e => new {e.AssetId, e.AssetFieldId, e.AssociatedAssetId});

                entity.ToTable("ASSET_ASSOCIATION", "ORG1");

                entity.HasIndex(e => new {e.AssociatedAssetId, e.AssetFieldId, e.AssetId})
                    .HasName("INDEX_ASSOCIATED_ASSET_ID");

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetFieldId)
                    .HasColumnName("ASSET_FIELD_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssociatedAssetId)
                    .HasColumnName("ASSOCIATED_ASSET_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AssetBarcodeJt>(entity =>
            {
                entity.HasKey(e => new {e.AssetId, e.BarcodeId});

                entity.ToTable("ASSET_BARCODE_JT", "ORG1");

                entity.HasIndex(e => new {e.AssetId, e.BarcodeId})
                    .HasName("BARCODE_IDX");

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.BarcodeId)
                    .HasColumnName("BARCODE_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AssetCatalogAssociation>(entity =>
            {
                entity.HasKey(e => new {e.AssetId, e.AssetFieldId, e.AssociatedCatalogId});

                entity.ToTable("ASSET_CATALOG_ASSOCIATION", "ORG1");

                entity.HasIndex(e => new {e.AssetFieldId, e.AssociatedCatalogId})
                    .HasName("FIELD_CATALOG_IDX");

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AssetFieldId)
                    .HasColumnName("ASSET_FIELD_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AssociatedCatalogId)
                    .HasColumnName("ASSOCIATED_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetClass>(entity =>
            {
                entity.ToTable("ASSET_CLASS", "ORG1");

                entity.HasIndex(e => e.AssetTypeId)
                    .HasName("ASSET_TYPE_ID_INDEX");

                entity.HasIndex(e => e.ParentClassId)
                    .HasName("PARENT_CLASS_ID_INDEX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetTypeId)
                    .HasColumnName("ASSET_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("IS_DEFAULT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ParentClassId)
                    .HasColumnName("PARENT_CLASS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Protected)
                    .HasColumnName("PROTECTED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AssetData1>(entity =>
            {
                entity.ToTable("ASSET_DATA_1", "ORG1");

                entity.HasIndex(e => e.Field10007)
                    .HasName("INDEX_10007");

                entity.HasIndex(e => e.Parent)
                    .HasName("INDEX_PARENT");

                entity.HasIndex(e => e.PrimaryContact)
                    .HasName("INDEX_PRIMARY_CONTACT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasColumnType("longtext");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10007)
                    .HasColumnName("FIELD_10007")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Locale)
                    .HasColumnName("LOCALE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parent)
                    .HasColumnName("PARENT")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("PHONE_NUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryContact)
                    .HasColumnName("PRIMARY_CONTACT")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.WebSite)
                    .HasColumnName("WEB_SITE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetData10000>(entity =>
            {
                entity.ToTable("ASSET_DATA_10000", "ORG1");

                entity.HasIndex(e => e.Field9977)
                    .HasName("INDEX_9977");

                entity.HasIndex(e => e.Field9978)
                    .HasName("INDEX_9978");

                entity.HasIndex(e => e.Field9979)
                    .HasName("INDEX_9979");

                entity.HasIndex(e => e.Field9980)
                    .HasName("INDEX_9980");

                entity.HasIndex(e => e.Field9981)
                    .HasName("INDEX_9981");

                entity.HasIndex(e => e.Field9982)
                    .HasName("INDEX_9982");

                entity.HasIndex(e => e.Field9983)
                    .HasName("INDEX_9983");

                entity.HasIndex(e => e.Field9984)
                    .HasName("INDEX_9984");

                entity.HasIndex(e => e.Field9985)
                    .HasName("INDEX_9985");

                entity.HasIndex(e => e.Field9986)
                    .HasName("INDEX_9986");

                entity.HasIndex(e => e.Field9987)
                    .HasName("INDEX_9987");

                entity.HasIndex(e => e.Field9988)
                    .HasName("INDEX_9988");

                entity.HasIndex(e => e.Field9989)
                    .HasName("INDEX_9989");

                entity.HasIndex(e => e.Field9990)
                    .HasName("INDEX_9990");

                entity.HasIndex(e => e.Field9991)
                    .HasName("INDEX_9991");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field9977)
                    .HasColumnName("FIELD_9977")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9978)
                    .HasColumnName("FIELD_9978")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9979)
                    .HasColumnName("FIELD_9979")
                    .HasColumnType("date");

                entity.Property(e => e.Field9980)
                    .HasColumnName("FIELD_9980")
                    .HasColumnType("date");

                entity.Property(e => e.Field9981)
                    .HasColumnName("FIELD_9981")
                    .HasColumnType("date");

                entity.Property(e => e.Field9982)
                    .HasColumnName("FIELD_9982")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9983)
                    .HasColumnName("FIELD_9983")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9984)
                    .HasColumnName("FIELD_9984")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9985)
                    .HasColumnName("FIELD_9985")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9986)
                    .HasColumnName("FIELD_9986")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9987)
                    .HasColumnName("FIELD_9987")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9988)
                    .HasColumnName("FIELD_9988")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9989)
                    .HasColumnName("FIELD_9989")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9990)
                    .HasColumnName("FIELD_9990")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9991)
                    .HasColumnName("FIELD_9991")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9992)
                    .HasColumnName("FIELD_9992")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetData10001>(entity =>
            {
                entity.ToTable("ASSET_DATA_10001", "ORG1");

                entity.HasIndex(e => e.Field10107)
                    .HasName("INDEX_10107");

                entity.HasIndex(e => e.Field9955)
                    .HasName("INDEX_9955");

                entity.HasIndex(e => e.Field9956)
                    .HasName("INDEX_9956");

                entity.HasIndex(e => e.Field9957)
                    .HasName("INDEX_9957");

                entity.HasIndex(e => e.Field9958)
                    .HasName("INDEX_9958");

                entity.HasIndex(e => e.Field9959)
                    .HasName("INDEX_9959");

                entity.HasIndex(e => e.Field9961)
                    .HasName("INDEX_9961");

                entity.HasIndex(e => e.Field9962)
                    .HasName("INDEX_9962");

                entity.HasIndex(e => e.Field9963)
                    .HasName("INDEX_9963");

                entity.HasIndex(e => e.Field9964)
                    .HasName("INDEX_9964");

                entity.HasIndex(e => e.Field9965)
                    .HasName("INDEX_9965");

                entity.HasIndex(e => e.Field9966)
                    .HasName("INDEX_9966");

                entity.HasIndex(e => e.Field9968)
                    .HasName("INDEX_9968");

                entity.HasIndex(e => e.Field9969)
                    .HasName("INDEX_9969");

                entity.HasIndex(e => e.Field9970)
                    .HasName("INDEX_9970");

                entity.HasIndex(e => e.Field9972)
                    .HasName("INDEX_9972");

                entity.HasIndex(e => e.Field9973)
                    .HasName("INDEX_9973");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field10107)
                    .HasColumnName("FIELD_10107")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9955)
                    .HasColumnName("FIELD_9955")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9956)
                    .HasColumnName("FIELD_9956")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9957)
                    .HasColumnName("FIELD_9957")
                    .HasColumnType("date");

                entity.Property(e => e.Field9958)
                    .HasColumnName("FIELD_9958")
                    .HasColumnType("date");

                entity.Property(e => e.Field9959)
                    .HasColumnName("FIELD_9959")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9961)
                    .HasColumnName("FIELD_9961")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9962)
                    .HasColumnName("FIELD_9962")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9963)
                    .HasColumnName("FIELD_9963")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9964)
                    .HasColumnName("FIELD_9964")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9965)
                    .HasColumnName("FIELD_9965")
                    .HasColumnType("date");

                entity.Property(e => e.Field9966)
                    .HasColumnName("FIELD_9966")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9968)
                    .HasColumnName("FIELD_9968")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9969)
                    .HasColumnName("FIELD_9969")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9970)
                    .HasColumnName("FIELD_9970")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9971)
                    .HasColumnName("FIELD_9971")
                    .IsUnicode(false);

                entity.Property(e => e.Field9972)
                    .HasColumnName("FIELD_9972")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9973)
                    .HasColumnName("FIELD_9973")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetData10002>(entity =>
            {
                entity.ToTable("ASSET_DATA_10002", "ORG1");

                entity.HasIndex(e => e.Field9898)
                    .HasName("INDEX_9898");

                entity.HasIndex(e => e.Field9900)
                    .HasName("INDEX_9900");

                entity.HasIndex(e => e.Field9901)
                    .HasName("INDEX_9901");

                entity.HasIndex(e => e.Field9902)
                    .HasName("INDEX_9902");

                entity.HasIndex(e => e.Field9903)
                    .HasName("INDEX_9903");

                entity.HasIndex(e => e.Field9904)
                    .HasName("INDEX_9904");

                entity.HasIndex(e => e.Field9908)
                    .HasName("INDEX_9908");

                entity.HasIndex(e => e.Field9909)
                    .HasName("INDEX_9909");

                entity.HasIndex(e => e.Field9910)
                    .HasName("INDEX_9910");

                entity.HasIndex(e => e.Field9911)
                    .HasName("INDEX_9911");

                entity.HasIndex(e => e.Field9912)
                    .HasName("INDEX_9912");

                entity.HasIndex(e => e.Field9913)
                    .HasName("INDEX_9913");

                entity.HasIndex(e => e.Field9914)
                    .HasName("INDEX_9914");

                entity.HasIndex(e => e.Field9915)
                    .HasName("INDEX_9915");

                entity.HasIndex(e => e.Field9917)
                    .HasName("INDEX_9917");

                entity.HasIndex(e => e.Field9918)
                    .HasName("INDEX_9918");

                entity.HasIndex(e => e.Field9919)
                    .HasName("INDEX_9919");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field9898)
                    .HasColumnName("FIELD_9898")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9900)
                    .HasColumnName("FIELD_9900")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9901)
                    .HasColumnName("FIELD_9901")
                    .HasColumnType("date");

                entity.Property(e => e.Field9902)
                    .HasColumnName("FIELD_9902")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9903)
                    .HasColumnName("FIELD_9903")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9904)
                    .HasColumnName("FIELD_9904")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9905)
                    .HasColumnName("FIELD_9905")
                    .IsUnicode(false);

                entity.Property(e => e.Field9906)
                    .HasColumnName("FIELD_9906")
                    .IsUnicode(false);

                entity.Property(e => e.Field9908)
                    .HasColumnName("FIELD_9908")
                    .HasColumnType("date");

                entity.Property(e => e.Field9909)
                    .HasColumnName("FIELD_9909")
                    .HasColumnType("date");

                entity.Property(e => e.Field9910)
                    .HasColumnName("FIELD_9910")
                    .HasColumnType("date");

                entity.Property(e => e.Field9911)
                    .HasColumnName("FIELD_9911")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9912)
                    .HasColumnName("FIELD_9912")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9913)
                    .HasColumnName("FIELD_9913")
                    .HasColumnType("date");

                entity.Property(e => e.Field9914)
                    .HasColumnName("FIELD_9914")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field9915).HasColumnName("FIELD_9915");

                entity.Property(e => e.Field9917)
                    .HasColumnName("FIELD_9917")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9918)
                    .HasColumnName("FIELD_9918")
                    .HasColumnType("date");

                entity.Property(e => e.Field9919)
                    .HasColumnName("FIELD_9919")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9920)
                    .HasColumnName("FIELD_9920")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetData10200>(entity =>
            {
                entity.ToTable("ASSET_DATA_10200", "ORG1");

                entity.HasIndex(e => e.Field9940)
                    .HasName("INDEX_9940");

                entity.HasIndex(e => e.Field9941)
                    .HasName("INDEX_9941");

                entity.HasIndex(e => e.Field9942)
                    .HasName("INDEX_9942");

                entity.HasIndex(e => e.Field9943)
                    .HasName("INDEX_9943");

                entity.HasIndex(e => e.Field9945)
                    .HasName("INDEX_9945");

                entity.HasIndex(e => e.Field9946)
                    .HasName("INDEX_9946");

                entity.HasIndex(e => e.Field9947)
                    .HasName("INDEX_9947");

                entity.HasIndex(e => e.Field9949)
                    .HasName("INDEX_9949");

                entity.HasIndex(e => e.Field9950)
                    .HasName("INDEX_9950");

                entity.HasIndex(e => e.Field9951)
                    .HasName("INDEX_9951");

                entity.HasIndex(e => e.Field9953)
                    .HasName("INDEX_9953");

                entity.HasIndex(e => e.Field9954)
                    .HasName("INDEX_9954");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field9940)
                    .HasColumnName("FIELD_9940")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9941)
                    .HasColumnName("FIELD_9941")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9942)
                    .HasColumnName("FIELD_9942")
                    .HasColumnType("date");

                entity.Property(e => e.Field9943)
                    .HasColumnName("FIELD_9943")
                    .HasColumnType("date");

                entity.Property(e => e.Field9945)
                    .HasColumnName("FIELD_9945")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9946)
                    .HasColumnName("FIELD_9946")
                    .HasColumnType("date");

                entity.Property(e => e.Field9947)
                    .HasColumnName("FIELD_9947")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9949)
                    .HasColumnName("FIELD_9949")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9950)
                    .HasColumnName("FIELD_9950")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9951)
                    .HasColumnName("FIELD_9951")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9952)
                    .HasColumnName("FIELD_9952")
                    .IsUnicode(false);

                entity.Property(e => e.Field9953)
                    .HasColumnName("FIELD_9953")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9954)
                    .HasColumnName("FIELD_9954")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetData12>(entity =>
            {
                entity.ToTable("ASSET_DATA_12", "ORG1");

                entity.HasIndex(e => e.Field10043)
                    .HasName("INDEX_10043");

                entity.HasIndex(e => e.Field10045)
                    .HasName("INDEX_10045");

                entity.HasIndex(e => e.Field10070)
                    .HasName("INDEX_10070");

                entity.HasIndex(e => e.Field10071)
                    .HasName("INDEX_10071");

                entity.HasIndex(e => e.Field10072)
                    .HasName("INDEX_10072");

                entity.HasIndex(e => e.Field10073)
                    .HasName("INDEX_10073");

                entity.HasIndex(e => e.Field10075)
                    .HasName("INDEX_10075");

                entity.HasIndex(e => e.Field10077)
                    .HasName("INDEX_10077");

                entity.HasIndex(e => e.Field10078)
                    .HasName("INDEX_10078");

                entity.HasIndex(e => e.Field10079)
                    .HasName("INDEX_10079");

                entity.HasIndex(e => e.Field10080)
                    .HasName("INDEX_10080");

                entity.HasIndex(e => e.Field10081)
                    .HasName("INDEX_10081");

                entity.HasIndex(e => e.Field10082)
                    .HasName("INDEX_10082");

                entity.HasIndex(e => e.Field10083)
                    .HasName("INDEX_10083");

                entity.HasIndex(e => e.Field10084)
                    .HasName("INDEX_10084");

                entity.HasIndex(e => e.Field10090)
                    .HasName("INDEX_10090");

                entity.HasIndex(e => e.Field10091)
                    .HasName("INDEX_10091");

                entity.HasIndex(e => e.Field10092)
                    .HasName("INDEX_10092");

                entity.HasIndex(e => e.Field10093)
                    .HasName("INDEX_10093");

                entity.HasIndex(e => e.Field10094)
                    .HasName("INDEX_10094");

                entity.HasIndex(e => e.Field10095)
                    .HasName("INDEX_10095");

                entity.HasIndex(e => e.Field10100)
                    .HasName("INDEX_10100");

                entity.HasIndex(e => e.Field10103)
                    .HasName("INDEX_10103");

                entity.HasIndex(e => e.Field10104)
                    .HasName("INDEX_10104");

                entity.HasIndex(e => e.Field10106)
                    .HasName("INDEX_10106");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field10043)
                    .HasColumnName("FIELD_10043")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10045)
                    .HasColumnName("FIELD_10045")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10049)
                    .HasColumnName("FIELD_10049")
                    .IsUnicode(false);

                entity.Property(e => e.Field10070)
                    .HasColumnName("FIELD_10070")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10071)
                    .HasColumnName("FIELD_10071")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10072)
                    .HasColumnName("FIELD_10072")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10073)
                    .HasColumnName("FIELD_10073")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10075)
                    .HasColumnName("FIELD_10075")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10077)
                    .HasColumnName("FIELD_10077")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10078)
                    .HasColumnName("FIELD_10078")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10079)
                    .HasColumnName("FIELD_10079")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10080)
                    .HasColumnName("FIELD_10080")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10081)
                    .HasColumnName("FIELD_10081")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field10082)
                    .HasColumnName("FIELD_10082")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10083)
                    .HasColumnName("FIELD_10083")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10084)
                    .HasColumnName("FIELD_10084")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10090)
                    .HasColumnName("FIELD_10090")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10091)
                    .HasColumnName("FIELD_10091")
                    .HasColumnType("date");

                entity.Property(e => e.Field10092)
                    .HasColumnName("FIELD_10092")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10093)
                    .HasColumnName("FIELD_10093")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10094)
                    .HasColumnName("FIELD_10094")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10095)
                    .HasColumnName("FIELD_10095")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10100)
                    .HasColumnName("FIELD_10100")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10103)
                    .HasColumnName("FIELD_10103")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10104)
                    .HasColumnName("FIELD_10104")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10106)
                    .HasColumnName("FIELD_10106")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<AssetData2>(entity =>
            {
                entity.ToTable("ASSET_DATA_2", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<AssetData3>(entity =>
            {
                entity.ToTable("ASSET_DATA_3", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<AssetData4>(entity =>
            {
                entity.ToTable("ASSET_DATA_4", "ORG1");

                entity.HasIndex(e => e.Field10015)
                    .HasName("INDEX_10015");

                entity.HasIndex(e => e.Field10016)
                    .HasName("INDEX_10016");

                entity.HasIndex(e => e.Field10017)
                    .HasName("INDEX_10017");

                entity.HasIndex(e => e.Field10050)
                    .HasName("INDEX_10050");

                entity.HasIndex(e => e.Field10060)
                    .HasName("INDEX_10060");

                entity.HasIndex(e => e.Field10061)
                    .HasName("INDEX_10061");

                entity.HasIndex(e => e.Field10062)
                    .HasName("INDEX_10062");

                entity.HasIndex(e => e.Field10064)
                    .HasName("INDEX_10064");

                entity.HasIndex(e => e.Field10065)
                    .HasName("INDEX_10065");

                entity.HasIndex(e => e.Field10066)
                    .HasName("INDEX_10066");

                entity.HasIndex(e => e.Field10067)
                    .HasName("INDEX_10067");

                entity.HasIndex(e => e.Field10068)
                    .HasName("INDEX_10068");

                entity.HasIndex(e => e.Field10069)
                    .HasName("INDEX_10069");

                entity.HasIndex(e => e.Field10085)
                    .HasName("INDEX_10085");

                entity.HasIndex(e => e.Field10086)
                    .HasName("INDEX_10086");

                entity.HasIndex(e => e.Field10087)
                    .HasName("INDEX_10087");

                entity.HasIndex(e => e.Field10088)
                    .HasName("INDEX_10088");

                entity.HasIndex(e => e.Field10098)
                    .HasName("INDEX_10098");

                entity.HasIndex(e => e.Field10102)
                    .HasName("INDEX_10102");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field10014)
                    .HasColumnName("FIELD_10014")
                    .IsUnicode(false);

                entity.Property(e => e.Field10015)
                    .HasColumnName("FIELD_10015")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10016)
                    .HasColumnName("FIELD_10016")
                    .HasColumnType("date");

                entity.Property(e => e.Field10017)
                    .HasColumnName("FIELD_10017")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10050)
                    .HasColumnName("FIELD_10050")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10060)
                    .HasColumnName("FIELD_10060")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10061)
                    .HasColumnName("FIELD_10061")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10062)
                    .HasColumnName("FIELD_10062")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10064)
                    .HasColumnName("FIELD_10064")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10065)
                    .HasColumnName("FIELD_10065")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10066)
                    .HasColumnName("FIELD_10066")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10067)
                    .HasColumnName("FIELD_10067")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10068)
                    .HasColumnName("FIELD_10068")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10069)
                    .HasColumnName("FIELD_10069")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10085)
                    .HasColumnName("FIELD_10085")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10086)
                    .HasColumnName("FIELD_10086")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10087)
                    .HasColumnName("FIELD_10087")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10088)
                    .HasColumnName("FIELD_10088")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10097)
                    .HasColumnName("FIELD_10097")
                    .IsUnicode(false);

                entity.Property(e => e.Field10098)
                    .HasColumnName("FIELD_10098")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10102)
                    .HasColumnName("FIELD_10102")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetData5>(entity =>
            {
                entity.ToTable("ASSET_DATA_5", "ORG1");

                entity.HasIndex(e => e.Field10002)
                    .HasName("INDEX_10002");

                entity.HasIndex(e => e.Field10003)
                    .HasName("INDEX_10003");

                entity.HasIndex(e => e.Field10009)
                    .HasName("INDEX_10009");

                entity.HasIndex(e => e.Field9921)
                    .HasName("INDEX_9921");

                entity.HasIndex(e => e.Field9922)
                    .HasName("INDEX_9922");

                entity.HasIndex(e => e.Field9923)
                    .HasName("INDEX_9923");

                entity.HasIndex(e => e.Field9924)
                    .HasName("INDEX_9924");

                entity.HasIndex(e => e.Field9925)
                    .HasName("INDEX_9925");

                entity.HasIndex(e => e.Field9926)
                    .HasName("INDEX_9926");

                entity.HasIndex(e => e.Field9927)
                    .HasName("INDEX_9927");

                entity.HasIndex(e => e.Field9928)
                    .HasName("INDEX_9928");

                entity.HasIndex(e => e.Field9929)
                    .HasName("INDEX_9929");

                entity.HasIndex(e => e.Field9930)
                    .HasName("INDEX_9930");

                entity.HasIndex(e => e.Field9931)
                    .HasName("INDEX_9931");

                entity.HasIndex(e => e.Field9932)
                    .HasName("INDEX_9932");

                entity.HasIndex(e => e.Field9933)
                    .HasName("INDEX_9933");

                entity.HasIndex(e => e.Field9934)
                    .HasName("INDEX_9934");

                entity.HasIndex(e => e.Field9935)
                    .HasName("INDEX_9935");

                entity.HasIndex(e => e.Field9936)
                    .HasName("INDEX_9936");

                entity.HasIndex(e => e.Field9937)
                    .HasName("INDEX_9937");

                entity.HasIndex(e => e.Field9938)
                    .HasName("INDEX_9938");

                entity.HasIndex(e => e.Field9939)
                    .HasName("INDEX_9939");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field10002)
                    .HasColumnName("FIELD_10002")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field10003)
                    .HasColumnName("FIELD_10003")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10009)
                    .HasColumnName("FIELD_10009")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9921)
                    .HasColumnName("FIELD_9921")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9922)
                    .HasColumnName("FIELD_9922")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9923)
                    .HasColumnName("FIELD_9923")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9924)
                    .HasColumnName("FIELD_9924")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9925)
                    .HasColumnName("FIELD_9925")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9926)
                    .HasColumnName("FIELD_9926")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9927)
                    .HasColumnName("FIELD_9927")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9928)
                    .HasColumnName("FIELD_9928")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9929)
                    .HasColumnName("FIELD_9929")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9930)
                    .HasColumnName("FIELD_9930")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9931)
                    .HasColumnName("FIELD_9931")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9932)
                    .HasColumnName("FIELD_9932")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9933)
                    .HasColumnName("FIELD_9933")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9934)
                    .HasColumnName("FIELD_9934")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9935)
                    .HasColumnName("FIELD_9935")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9936)
                    .HasColumnName("FIELD_9936")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9937)
                    .HasColumnName("FIELD_9937")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9938)
                    .HasColumnName("FIELD_9938")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field9939)
                    .HasColumnName("FIELD_9939")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<AssetData6>(entity =>
            {
                entity.ToTable("ASSET_DATA_6", "ORG1");

                entity.HasIndex(e => e.Field10001)
                    .HasName("INDEX_10001");

                entity.HasIndex(e => e.Field10011)
                    .HasName("INDEX_10011");

                entity.HasIndex(e => e.Field10013)
                    .HasName("INDEX_10013");

                entity.HasIndex(e => e.Field10029)
                    .HasName("INDEX_10029");

                entity.HasIndex(e => e.Field10032)
                    .HasName("INDEX_10032");

                entity.HasIndex(e => e.Field10033)
                    .HasName("INDEX_10033");

                entity.HasIndex(e => e.Field10051)
                    .HasName("INDEX_10051");

                entity.HasIndex(e => e.Field10052)
                    .HasName("INDEX_10052");

                entity.HasIndex(e => e.Field10059)
                    .HasName("INDEX_10059");

                entity.HasIndex(e => e.Field10063)
                    .HasName("INDEX_10063");

                entity.HasIndex(e => e.Field10096)
                    .HasName("INDEX_10096");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field10001)
                    .HasColumnName("FIELD_10001")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field10010)
                    .HasColumnName("FIELD_10010")
                    .IsUnicode(false);

                entity.Property(e => e.Field10011)
                    .HasColumnName("FIELD_10011")
                    .HasColumnType("date");

                entity.Property(e => e.Field10013)
                    .HasColumnName("FIELD_10013")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10029)
                    .HasColumnName("FIELD_10029")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10032)
                    .HasColumnName("FIELD_10032")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10033)
                    .HasColumnName("FIELD_10033")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10051)
                    .HasColumnName("FIELD_10051")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10052)
                    .HasColumnName("FIELD_10052")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10059)
                    .HasColumnName("FIELD_10059")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field10063)
                    .HasColumnName("FIELD_10063")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field10096)
                    .HasColumnName("FIELD_10096")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<AssetData7>(entity =>
            {
                entity.ToTable("ASSET_DATA_7", "ORG1");

                entity.HasIndex(e => e.Field1)
                    .HasName("INDEX_1");

                entity.HasIndex(e => e.Field10)
                    .HasName("INDEX_10");

                entity.HasIndex(e => e.Field13)
                    .HasName("INDEX_13");

                entity.HasIndex(e => e.Field14)
                    .HasName("INDEX_14");

                entity.HasIndex(e => e.Field15)
                    .HasName("INDEX_15");

                entity.HasIndex(e => e.Field16)
                    .HasName("INDEX_16");

                entity.HasIndex(e => e.Field17)
                    .HasName("INDEX_17");

                entity.HasIndex(e => e.Field18)
                    .HasName("INDEX_18");

                entity.HasIndex(e => e.Field4)
                    .HasName("INDEX_4");

                entity.HasIndex(e => e.Field5)
                    .HasName("INDEX_5");

                entity.HasIndex(e => e.Field6)
                    .HasName("INDEX_6");

                entity.HasIndex(e => e.Field7)
                    .HasName("INDEX_7");

                entity.HasIndex(e => e.Field9)
                    .HasName("INDEX_9");

                entity.HasIndex(e => e.Field9994)
                    .HasName("INDEX_9994");

                entity.HasIndex(e => e.Field9996)
                    .HasName("INDEX_9996");

                entity.HasIndex(e => e.Field9997)
                    .HasName("INDEX_9997");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Field1)
                    .HasColumnName("FIELD_1")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field10)
                    .HasColumnName("FIELD_10")
                    .HasColumnType("date");

                entity.Property(e => e.Field11)
                    .HasColumnName("FIELD_11")
                    .IsUnicode(false);

                entity.Property(e => e.Field12)
                    .HasColumnName("FIELD_12")
                    .IsUnicode(false);

                entity.Property(e => e.Field13)
                    .HasColumnName("FIELD_13")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field14)
                    .HasColumnName("FIELD_14")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field15)
                    .HasColumnName("FIELD_15")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field16)
                    .HasColumnName("FIELD_16")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field17)
                    .HasColumnName("FIELD_17")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field18)
                    .HasColumnName("FIELD_18")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .HasColumnName("FIELD_4")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field5)
                    .HasColumnName("FIELD_5")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field6)
                    .HasColumnName("FIELD_6")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Field7)
                    .HasColumnName("FIELD_7")
                    .HasColumnType("date");

                entity.Property(e => e.Field9)
                    .HasColumnName("FIELD_9")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9994)
                    .HasColumnName("FIELD_9994")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9996)
                    .HasColumnName("FIELD_9996")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field9997)
                    .HasColumnName("FIELD_9997")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetFieldDefinition>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.SystemDefined});

                entity.ToTable("ASSET_FIELD_DEFINITION", "ORG1");

                entity.HasIndex(e => e.AssetClassId)
                    .HasName("INDEX_CLASS_ID");

                entity.HasIndex(e => e.Id)
                    .HasName("AFD_ID");

                entity.HasIndex(e => new {e.AssetTypeId, e.FieldType})
                    .HasName("ASSET_TYPE_FIELD_TYPE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SystemDefined)
                    .HasColumnName("SYSTEM_DEFINED")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetClassId)
                    .HasColumnName("ASSET_CLASS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetFieldSectionId)
                    .HasColumnName("ASSET_FIELD_SECTION_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetTypeId)
                    .HasColumnName("ASSET_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultValue)
                    .IsRequired()
                    .HasColumnName("DEFAULT_VALUE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceDetailSectionId)
                    .HasColumnName("DEVICE_DETAIL_SECTION_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldType)
                    .IsRequired()
                    .HasColumnName("FIELD_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValues)
                    .HasColumnName("FIELD_VALUES")
                    .IsUnicode(false);

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Multiple)
                    .HasColumnName("MULTIPLE")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Protected)
                    .HasColumnName("PROTECTED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Required)
                    .HasColumnName("REQUIRED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AssetFieldSection>(entity =>
            {
                entity.ToTable("ASSET_FIELD_SECTION", "ORG1");

                entity.HasIndex(e => e.AssetTypeId)
                    .HasName("ASSET_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetTypeId)
                    .HasColumnName("ASSET_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AssetFilter>(entity =>
            {
                entity.ToTable("ASSET_FILTER", "ORG1");

                entity.HasIndex(e => new {e.Name, e.UserId})
                    .HasName("NAME_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetTypeId)
                    .HasColumnName("ASSET_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FindFields)
                    .HasColumnName("FIND_FIELDS")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AssetHierarchy>(entity =>
            {
                entity.HasKey(e => e.ChildAssetId);

                entity.ToTable("ASSET_HIERARCHY", "ORG1");

                entity.HasIndex(e => e.ParentAssetId)
                    .HasName("INDEX_PARENT");

                entity.HasIndex(e => e.Path)
                    .HasName("INDEX_PATH");

                entity.Property(e => e.ChildAssetId)
                    .HasColumnName("CHILD_ASSET_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentAssetId)
                    .HasColumnName("PARENT_ASSET_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("PATH")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetHistory>(entity =>
            {
                entity.ToTable("ASSET_HISTORY", "ORG1");

                entity.HasIndex(e => e.ChangeType)
                    .HasName("CHANGE_TYPE_IDX");

                entity.HasIndex(e => e.FriendlyFieldName)
                    .HasName("FRIENDLY_FIELD_NAME_IDX");

                entity.HasIndex(e => e.Name)
                    .HasName("NAME_IDX");

                entity.HasIndex(e => e.Time)
                    .HasName("TIME_IDX");

                entity.HasIndex(e => e.TypeName)
                    .HasName("TYPE_NAME_IDX");

                entity.HasIndex(e => e.UserId)
                    .HasName("USER_ID_IDX_01172017");

                entity.HasIndex(e => e.UserText)
                    .HasName("USER_TEXT_IDX");

                entity.HasIndex(e => e.Value1)
                    .HasName("VALUE1_IDX");

                entity.HasIndex(e => e.Value2)
                    .HasName("VALUE2_IDX");

                entity.HasIndex(e => new {e.AssetId, e.FieldName, e.ChangeType, e.FriendlyFieldName})
                    .HasName("USAGE_1_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FriendlyFieldName)
                    .HasColumnName("FRIENDLY_FIELD_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnName("TIME");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.UserText)
                    .HasColumnName("USER_TEXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1)
                    .HasColumnName("VALUE1")
                    .HasColumnType("text");

                entity.Property(e => e.Value2)
                    .HasColumnName("VALUE2")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<AssetStatus>(entity =>
            {
                entity.ToTable("ASSET_STATUS", "ORG1");

                entity.HasIndex(e => e.Name)
                    .HasName("INDEX_ASSET_STATUS_NAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.IsSystem)
                    .HasColumnName("IS_SYSTEM")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.ToTable("ASSET_TYPE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetCategory)
                    .HasColumnName("ASSET_CATEGORY")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AssetMapField)
                    .HasColumnName("ASSET_MAP_FIELD")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeTagValues)
                    .HasColumnName("BARCODE_TAG_VALUES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DefaultArchiveAssetStatusId)
                    .HasColumnName("DEFAULT_ARCHIVE_ASSET_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultAssetStatusId)
                    .HasColumnName("DEFAULT_ASSET_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DetailPage)
                    .HasColumnName("DETAIL_PAGE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsHierarchy)
                    .HasColumnName("IS_HIERARCHY")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MappedField)
                    .HasColumnName("MAPPED_FIELD")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MappedTable)
                    .HasColumnName("MAPPED_TABLE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Authentication>(entity =>
            {
                entity.ToTable("AUTHENTICATION", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AuthType)
                    .HasColumnName("AUTH_TYPE")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Dn)
                    .HasColumnName("DN")
                    .IsUnicode(false);

                entity.Property(e => e.ExternalServer)
                    .HasColumnName("EXTERNAL_SERVER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LdapEncryption)
                    .HasColumnName("LDAP_ENCRYPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LdapLogin)
                    .HasColumnName("LDAP_LOGIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LdapPasswordEnc)
                    .HasColumnName("LDAP_PASSWORD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.RequiresSsl)
                    .HasColumnName("REQUIRES_SSL")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("ROLE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SearchFilter)
                    .HasColumnName("SEARCH_FILTER")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Barcode>(entity =>
            {
                entity.ToTable("BARCODE", "ORG1");

                entity.HasIndex(e => e.BarcodeData)
                    .HasName("INDEX_BARCODE_DATA")
                    .IsUnique();

                entity.HasIndex(e => new {e.BarcodeData, e.BarcodeName})
                    .HasName("INDEX_BARCODE_DATA_NAME");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BarcodeData)
                    .IsRequired()
                    .HasColumnName("BARCODE_DATA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeFormat)
                    .IsRequired()
                    .HasColumnName("BARCODE_FORMAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeName)
                    .IsRequired()
                    .HasColumnName("BARCODE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.FirstScannedDate)
                    .HasColumnName("FIRST_SCANNED_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.FirstScannedGeolocation)
                    .IsRequired()
                    .HasColumnName("FIRST_SCANNED_GEOLOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstScannedMethod)
                    .HasColumnName("FIRST_SCANNED_METHOD")
                    .HasColumnType("enum('SCANNED','IMPORT','MANUAL','INVENTORY')");

                entity.Property(e => e.FirstScannedUser)
                    .IsRequired()
                    .HasColumnName("FIRST_SCANNED_USER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastScannedDate)
                    .HasColumnName("LAST_SCANNED_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LastScannedGeolocation)
                    .IsRequired()
                    .HasColumnName("LAST_SCANNED_GEOLOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastScannedMethod)
                    .HasColumnName("LAST_SCANNED_METHOD")
                    .HasColumnType("enum('SCANNED','IMPORT','MANUAL','INVENTORY')");

                entity.Property(e => e.LastScannedUser)
                    .IsRequired()
                    .HasColumnName("LAST_SCANNED_USER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ClientDistribution>(entity =>
            {
                entity.ToTable("CLIENT_DISTRIBUTION", "ORG1");

                entity.HasIndex(e => e.Enabled)
                    .HasName("ENABLED_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DistKey)
                    .HasColumnName("DIST_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DontReplicate)
                    .HasColumnName("DONT_REPLICATE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Family)
                    .HasColumnName("FAMILY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasColumnName("FILE_PATH")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasColumnName("FILE_SIZE")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateUnknownMachines)
                    .HasColumnName("UPDATE_UNKNOWN_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientdistLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.ClientdistId, e.LabelId});

                entity.ToTable("CLIENTDIST_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.ClientdistId)
                    .HasColumnName("CLIENTDIST_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ContractFilter>(entity =>
            {
                entity.ToTable("CONTRACT_FILTER", "ORG1");

                entity.HasIndex(e => new {e.Name, e.UserId})
                    .HasName("NAME_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetTypeId)
                    .HasColumnName("ASSET_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FindFields)
                    .HasColumnName("FIND_FIELDS")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Credential>(entity =>
            {
                entity.ToTable("CREDENTIAL", "ORG1");

                entity.HasIndex(e => e.Name)
                    .HasName("NAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CredentialType)
                    .HasColumnName("CREDENTIAL_TYPE")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.GoogleAccessTokenEnc)
                    .HasColumnName("GOOGLE_ACCESS_TOKEN_ENC")
                    .HasColumnType("blob");

                entity.Property(e => e.GoogleClientId)
                    .HasColumnName("GOOGLE_CLIENT_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleClientSecretEnc)
                    .HasColumnName("GOOGLE_CLIENT_SECRET_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SkSecretEnc)
                    .HasColumnName("SK_SECRET_ENC")
                    .HasColumnType("blob");

                entity.Property(e => e.SnmpCommunity)
                    .HasColumnName("SNMP_COMMUNITY")
                    .HasMaxLength(77)
                    .IsUnicode(false);

                entity.Property(e => e.Snmpv3AuthProtocol)
                    .HasColumnName("SNMPV3_AUTH_PROTOCOL")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Snmpv3AuthPwEnc)
                    .HasColumnName("SNMPV3_AUTH_PW_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.Snmpv3PrivacyProtocol)
                    .HasColumnName("SNMPV3_PRIVACY_PROTOCOL")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Snmpv3PrivacyPwEnc)
                    .HasColumnName("SNMPV3_PRIVACY_PW_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.Snmpv3SecurityLevel)
                    .HasColumnName("SNMPV3_SECURITY_LEVEL")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Snmpv3User)
                    .HasColumnName("SNMPV3_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpDomainname)
                    .HasColumnName("UP_DOMAINNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpPwEnc)
                    .HasColumnName("UP_PW_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.UpTargets)
                    .HasColumnName("UP_TARGETS")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.UpUsername)
                    .HasColumnName("UP_USERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomFieldDefinition>(entity =>
            {
                entity.ToTable("CUSTOM_FIELD_DEFINITION", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CustomFieldName0)
                    .HasColumnName("CUSTOM_FIELD_NAME0")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldName1)
                    .HasColumnName("CUSTOM_FIELD_NAME1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldName2)
                    .HasColumnName("CUSTOM_FIELD_NAME2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldName3)
                    .HasColumnName("CUSTOM_FIELD_NAME3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldName4)
                    .HasColumnName("CUSTOM_FIELD_NAME4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldName5)
                    .HasColumnName("CUSTOM_FIELD_NAME5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldType0)
                    .HasColumnName("CUSTOM_FIELD_TYPE0")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldType1)
                    .HasColumnName("CUSTOM_FIELD_TYPE1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldType2)
                    .HasColumnName("CUSTOM_FIELD_TYPE2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldType3)
                    .HasColumnName("CUSTOM_FIELD_TYPE3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldType4)
                    .HasColumnName("CUSTOM_FIELD_TYPE4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldType5)
                    .HasColumnName("CUSTOM_FIELD_TYPE5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValues0)
                    .HasColumnName("CUSTOM_FIELD_VALUES0")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValues1)
                    .HasColumnName("CUSTOM_FIELD_VALUES1")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValues2)
                    .HasColumnName("CUSTOM_FIELD_VALUES2")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValues3)
                    .HasColumnName("CUSTOM_FIELD_VALUES3")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValues4)
                    .HasColumnName("CUSTOM_FIELD_VALUES4")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValues5)
                    .HasColumnName("CUSTOM_FIELD_VALUES5")
                    .IsUnicode(false);

                entity.Property(e => e.HelpHtml)
                    .HasColumnName("HELP_HTML")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasColumnName("TABLE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomView>(entity =>
            {
                entity.HasKey(e => e.PageName);

                entity.ToTable("CUSTOM_VIEW", "ORG1");

                entity.Property(e => e.PageName)
                    .HasColumnName("PAGE_NAME")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cols)
                    .HasColumnName("COLS")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.ToTable("DASHBOARD", "ORG1");

                entity.HasIndex(e => new {e.UserId, e.Page})
                    .HasName("DASHBOARD_USER_ID_PAGE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DashboardDef)
                    .HasColumnName("DASHBOARD_DEF")
                    .IsUnicode(false);

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasColumnName("PAGE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<DashboardCache>(entity =>
            {
                entity.ToTable("DASHBOARD_CACHE", "ORG1");

                entity.HasIndex(e => new {e.DatasourceId, e.UserId, e.LocaleBrowserId})
                    .HasName("DATASOURCE_USER_LOCALE_ID");

                entity.Property(e => e.DashboardCacheId)
                    .HasColumnName("DASHBOARD_CACHE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DatasourceId)
                    .HasColumnName("DATASOURCE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DatasourceLastResult)
                    .HasColumnName("DATASOURCE_LAST_RESULT")
                    .IsUnicode(false);

                entity.Property(e => e.DatasourceLastTime).HasColumnName("DATASOURCE_LAST_TIME");

                entity.Property(e => e.LocaleBrowserId)
                    .HasColumnName("LOCALE_BROWSER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<DellAsset>(entity =>
            {
                entity.HasKey(e => e.ServiceTag);

                entity.ToTable("DELL_ASSET", "ORG1");

                entity.HasIndex(e => e.ParentServiceTag)
                    .HasName("INDEX_PARENT");

                entity.Property(e => e.ServiceTag)
                    .HasColumnName("SERVICE_TAG")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryLookupCode)
                    .IsRequired()
                    .HasColumnName("COUNTRY_LOOKUP_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CustomerNumber)
                    .HasColumnName("CUSTOMER_NUMBER")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Disabled)
                    .HasColumnName("DISABLED")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemClassCode)
                    .HasColumnName("ITEM_CLASS_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocalChannel)
                    .IsRequired()
                    .HasColumnName("LOCAL_CHANNEL")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineDescription)
                    .IsRequired()
                    .HasColumnName("MACHINE_DESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentServiceTag)
                    .HasColumnName("PARENT_SERVICE_TAG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<DellInventory>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("DELL_INVENTORY", "ORG1");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.InvLogXml)
                    .HasColumnName("INV_LOG_XML")
                    .IsUnicode(false);

                entity.Property(e => e.InvOutXml)
                    .HasColumnName("INV_OUT_XML")
                    .IsUnicode(false);

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasColumnName("LANG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.OsArch)
                    .HasColumnName("OS_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OsCode)
                    .HasColumnName("OS_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OsMajver)
                    .HasColumnName("OS_MAJVER")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsMinver)
                    .HasColumnName("OS_MINVER")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsVendor)
                    .IsRequired()
                    .HasColumnName("OS_VENDOR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasColumnName("STATUS_CODE")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatusPhase)
                    .HasColumnName("STATUS_PHASE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDid)
                    .HasColumnName("SYSTEM_DID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DellInventoryDeviceJt>(entity =>
            {
                entity.ToTable("DELL_INVENTORY_DEVICE_JT", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Acpiid)
                    .HasColumnName("ACPIID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentDid)
                    .HasColumnName("COMPONENT_DID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceDid)
                    .HasColumnName("DEVICE_DID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Display)
                    .IsRequired()
                    .HasColumnName("DISPLAY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PnpProductId)
                    .HasColumnName("PNP_PRODUCT_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubDeviceDid)
                    .HasColumnName("SUB_DEVICE_DID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubVendorDid)
                    .HasColumnName("SUB_VENDOR_DID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VendorDid)
                    .HasColumnName("VENDOR_DID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DellMachinePkgUpdateStatus>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.CatalogId, e.PackageDid});

                entity.ToTable("DELL_MACHINE_PKG_UPDATE_STATUS", "ORG1");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CatalogId)
                    .HasColumnName("CATALOG_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PackageDid)
                    .HasColumnName("PACKAGE_DID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DellScheduleId)
                    .HasColumnName("DELL_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxUpdateAttempt)
                    .HasColumnName("MAX_UPDATE_ATTEMPT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.UpdateCount)
                    .HasColumnName("UPDATE_COUNT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateStatusDt)
                    .HasColumnName("UPDATE_STATUS_DT")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<DellMachineStatus>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.CatalogId, e.DeviceId, e.PackageDid});

                entity.ToTable("DELL_MACHINE_STATUS", "ORG1");

                entity.HasIndex(e => new {e.PackageDid, e.CatalogId, e.MachineId, e.DeviceId})
                    .HasName("CATALOG_DEVICE_MACHINE");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CatalogId)
                    .HasColumnName("CATALOG_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DEVICE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PackageDid)
                    .HasColumnName("PACKAGE_DID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicableUpdate)
                    .IsRequired()
                    .HasColumnName("APPLICABLE_UPDATE")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DellPkgLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.DellPkgId, e.LabelId});

                entity.ToTable("DELL_PKG_LABEL_JT", "ORG1");

                entity.HasIndex(e => new {e.LabelId, e.DellPkgId})
                    .HasName("LABEL_ID");

                entity.Property(e => e.DellPkgId)
                    .HasColumnName("DELL_PKG_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DellPkgStatus>(entity =>
            {
                entity.HasKey(e => e.DellPkgId);

                entity.ToTable("DELL_PKG_STATUS", "ORG1");

                entity.Property(e => e.DellPkgId)
                    .HasColumnName("DELL_PKG_ID")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DellSchedule>(entity =>
            {
                entity.ToTable("DELL_SCHEDULE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AlertId)
                    .HasColumnName("ALERT_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DellAction)
                    .HasColumnName("DELL_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InvTimeout)
                    .HasColumnName("INV_TIMEOUT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("3600");

                entity.Property(e => e.KeepAlive)
                    .HasColumnName("KEEP_ALIVE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KonductorTaskType)
                    .HasColumnName("KONDUCTOR_TASK_TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastRun).HasColumnName("LAST_RUN");

                entity.Property(e => e.LimitPrompt)
                    .HasColumnName("LIMIT_PROMPT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MatchMachineLabels)
                    .HasColumnName("MATCH_MACHINE_LABELS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxRunDuration)
                    .HasColumnName("MAX_RUN_DURATION")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxUpdateAttempt)
                    .HasColumnName("MAX_UPDATE_ATTEMPT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.QueueDisconnected)
                    .HasColumnName("QUEUE_DISCONNECTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RebootAction)
                    .HasColumnName("REBOOT_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RebootAuto)
                    .HasColumnName("REBOOT_AUTO")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RebootDelayInterval)
                    .HasColumnName("REBOOT_DELAY_INTERVAL")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.RebootMessage)
                    .HasColumnName("REBOOT_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.RebootMode)
                    .HasColumnName("REBOOT_MODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RebootTimeout)
                    .HasColumnName("REBOOT_TIMEOUT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepromptCount)
                    .HasColumnName("REPROMPT_COUNT")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.RepromptInterval)
                    .HasColumnName("REPROMPT_INTERVAL")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateAllPkgs)
                    .HasColumnName("UPDATE_ALL_PKGS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateTimeout)
                    .HasColumnName("UPDATE_TIMEOUT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("10800");
            });

            modelBuilder.Entity<DellScheduleLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.DellScheduleId, e.LabelId});

                entity.ToTable("DELL_SCHEDULE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.DellScheduleId)
                    .HasColumnName("DELL_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DellScheduleMachineStatus>(entity =>
            {
                entity.HasKey(e => new {e.DellScheduleId, e.MachineId});

                entity.ToTable("DELL_SCHEDULE_MACHINE_STATUS", "ORG1");

                entity.Property(e => e.DellScheduleId)
                    .HasColumnName("DELL_SCHEDULE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LastRun).HasColumnName("LAST_RUN");
            });

            modelBuilder.Entity<DellScheduleOsJt>(entity =>
            {
                entity.ToTable("DELL_SCHEDULE_OS_JT", "ORG1");

                entity.HasIndex(e => new {e.DellScheduleId, e.SelectionType})
                    .HasName("ALL_IDX");

                entity.HasIndex(e => new {e.DellScheduleId, e.SelectionType, e.OsFamilyId})
                    .HasName("FAMILY_IDX");

                entity.HasIndex(e => new {e.DellScheduleId, e.SelectionType, e.OsId})
                    .HasName("BUILD_IDX");

                entity.HasIndex(e => new {e.DellScheduleId, e.SelectionType, e.OsFamilyId, e.OsProductId})
                    .HasName("PRODUCT_IDX");

                entity.HasIndex(e => new {e.DellScheduleId, e.SelectionType, e.OsFamilyId, e.OsProductId, e.OsArch})
                    .HasName("ARCH_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DellScheduleId)
                    .HasColumnName("DELL_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsArch)
                    .IsRequired()
                    .HasColumnName("OS_ARCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OsFamilyId)
                    .HasColumnName("OS_FAMILY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsId)
                    .HasColumnName("OS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsProductId)
                    .HasColumnName("OS_PRODUCT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SelectionType)
                    .HasColumnName("SELECTION_TYPE")
                    .HasColumnType("enum('ALL','FAMILY','PRODUCT','ARCH','BUILD')")
                    .HasDefaultValueSql("ALL");
            });

            modelBuilder.Entity<DellScheduleUpdateLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.DellScheduleId, e.LabelId});

                entity.ToTable("DELL_SCHEDULE_UPDATE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.DellScheduleId)
                    .HasColumnName("DELL_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DeviceDetailField>(entity =>
            {
                entity.ToTable("DEVICE_DETAIL_FIELD", "ORG1");

                entity.HasIndex(e => e.DeviceDetailSectionId)
                    .HasName("DEVICE_DETAIL_SECTION_ID_IDX");

                entity.HasIndex(e => new {e.Name, e.DeviceDetailSectionId})
                    .HasName("NAME_DEVICE_DETAIL_SECTION_ID_IDX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeviceDetailSectionId)
                    .HasColumnName("DEVICE_DETAIL_SECTION_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsManual)
                    .HasColumnName("IS_MANUAL")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceDetailGroup>(entity =>
            {
                entity.ToTable("DEVICE_DETAIL_GROUP", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HideLabelText)
                    .HasColumnName("HIDE_LABEL_TEXT")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnName("TEMPLATE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceDetailGroupAssetClassJt>(entity =>
            {
                entity.HasKey(e => new {e.DeviceDetailGroupId, e.AssetClassId});

                entity.ToTable("DEVICE_DETAIL_GROUP_ASSET_CLASS_JT", "ORG1");

                entity.HasIndex(e => e.AssetClassId)
                    .HasName("ASSET_CLASS_IDX");

                entity.Property(e => e.DeviceDetailGroupId)
                    .HasColumnName("DEVICE_DETAIL_GROUP_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetClassId)
                    .HasColumnName("ASSET_CLASS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DeviceDetailSection>(entity =>
            {
                entity.ToTable("DEVICE_DETAIL_SECTION", "ORG1");

                entity.HasIndex(e => e.GroupId)
                    .HasName("GROUP_ID_INDEX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GROUP_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DeviceDetailSectionAssetClassJt>(entity =>
            {
                entity.HasKey(e => new {e.DeviceDetailSectionId, e.AssetClassId});

                entity.ToTable("DEVICE_DETAIL_SECTION_ASSET_CLASS_JT", "ORG1");

                entity.HasIndex(e => e.AssetClassId)
                    .HasName("ASSET_CLASS_IDX");

                entity.Property(e => e.DeviceDetailSectionId)
                    .HasColumnName("DEVICE_DETAIL_SECTION_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetClassId)
                    .HasColumnName("ASSET_CLASS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<DevpProfileApplied>(entity =>
            {
                entity.ToTable("DEVP_PROFILE_APPLIED", "ORG1");

                entity.HasIndex(e => e.Scope)
                    .HasName("DEVP_PROFILE_APPLIED_SCOPE_IX");

                entity.HasIndex(e => e.Type)
                    .HasName("DEVP_PROFILE_APPLIED_TYPE_IX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("ACTION")
                    .HasColumnType("enum('add','remove')");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProfileName)
                    .IsRequired()
                    .HasColumnName("PROFILE_NAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileString)
                    .IsRequired()
                    .HasColumnName("PROFILE_STRING")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Scope)
                    .IsRequired()
                    .HasColumnName("SCOPE")
                    .HasColumnType("enum('System','User')");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("enum('active','disabled')")
                    .HasDefaultValueSql("active");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasColumnType("enum('raw','configured')");

                entity.Property(e => e.UiFormatter)
                    .HasColumnName("UI_FORMATTER")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Uidentifier)
                    .HasColumnName("UIDENTIFIER")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DevpProfileAppliedMachine>(entity =>
            {
                entity.ToTable("DEVP_PROFILE_APPLIED_MACHINE", "ORG1");

                entity.HasIndex(e => e.DevpProfileAppliedId)
                    .HasName("DEVP_PROFILE_APPLIED_MACHINE_DEVP_PROFILE_APPLIED_CK");

                entity.HasIndex(e => e.Status)
                    .HasName("DEVP_PROFILE_APPLIED_MACHINE_STATUS_IX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DevpProfileAppliedId)
                    .HasColumnName("DEVP_PROFILE_APPLIED_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PayloadUid)
                    .IsRequired()
                    .HasColumnName("PAYLOAD_UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResultLog)
                    .IsRequired()
                    .HasColumnName("RESULT_LOG")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("enum('in-progress','failed','succeed','scheduled')");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.DevpProfileApplied)
                    .WithMany(p => p.DevpProfileAppliedMachine)
                    .HasForeignKey(d => d.DevpProfileAppliedId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("DEVP_PROFILE_APPLIED_MACHINE_DEVP_PROFILE_APPLIED_CK");
            });

            modelBuilder.Entity<DevpProfileAppliedPayload>(entity =>
            {
                entity.ToTable("DEVP_PROFILE_APPLIED_PAYLOAD", "ORG1");

                entity.HasIndex(e => e.DevpProfileAppliedId)
                    .HasName("DEVP_PROFILE_APPLIED_PAYLOAD_DEVP_PROFILE_APPLIED_CK");

                entity.HasIndex(e => e.PayloadName)
                    .HasName("DEVP_PROFILE_APPLIED_PAYLOAD_NAME_IX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DevpProfileAppliedId)
                    .HasColumnName("DEVP_PROFILE_APPLIED_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("GROUP_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PayloadName)
                    .IsRequired()
                    .HasColumnName("PAYLOAD_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.DevpProfileApplied)
                    .WithMany(p => p.DevpProfileAppliedPayload)
                    .HasForeignKey(d => d.DevpProfileAppliedId)
                    .HasConstraintName("DEVP_PROFILE_APPLIED_PAYLOAD_DEVP_PROFILE_APPLIED_CK");
            });

            modelBuilder.Entity<DevpProfileAppliedPayloadAttribute>(entity =>
            {
                entity.ToTable("DEVP_PROFILE_APPLIED_PAYLOAD_ATTRIBUTE", "ORG1");

                entity.HasIndex(e => e.AttributeKey)
                    .HasName("DEVP_PROFILE_APPLIED_PAYLOAD_ATTRIBUTE_KEY_IX");

                entity.HasIndex(e => e.DevpProfileAppliedPayloadId)
                    .HasName("DPA_ATTRIBUTES_DPA_PAYLOADS_CK");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttributeKey)
                    .IsRequired()
                    .HasColumnName("ATTRIBUTE_KEY")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeType)
                    .IsRequired()
                    .HasColumnName("ATTRIBUTE_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("string");

                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasColumnName("ATTRIBUTE_VALUE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DevpProfileAppliedPayloadId)
                    .HasColumnName("DEVP_PROFILE_APPLIED_PAYLOAD_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.DevpProfileAppliedPayload)
                    .WithMany(p => p.DevpProfileAppliedPayloadAttribute)
                    .HasForeignKey(d => d.DevpProfileAppliedPayloadId)
                    .HasConstraintName("DPA_ATTRIBUTES_DPA_PAYLOADS_CK");
            });

            modelBuilder.Entity<EmailEvent>(entity =>
            {
                entity.HasKey(e => new {e.ObjectType, e.ObjectId, e.Recipient, e.Event});

                entity.ToTable("EMAIL_EVENT", "ORG1");

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recipient)
                    .HasColumnName("RECIPIENT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("owner");

                entity.Property(e => e.Event)
                    .HasColumnName("EVENT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("owner_change");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.ToTable("EMAIL_TEMPLATE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .IsUnicode(false);

                entity.Property(e => e.Markdown)
                    .HasColumnName("MARKDOWN")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Execution>(entity =>
            {
                entity.HasKey(e => new {e.WorkflowId, e.ExecutionId});

                entity.ToTable("execution", "ORG1");

                entity.HasIndex(e => e.ExecutionParent)
                    .HasName("execution_parent");

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("workflow_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExecutionId)
                    .HasColumnName("execution_id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExecutionNextThreadId)
                    .HasColumnName("execution_next_thread_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExecutionParent)
                    .HasColumnName("execution_parent")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExecutionStarted)
                    .HasColumnName("execution_started")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExecutionSuspended)
                    .HasColumnName("execution_suspended")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExecutionThreads)
                    .HasColumnName("execution_threads")
                    .HasColumnType("blob");

                entity.Property(e => e.ExecutionVariables)
                    .HasColumnName("execution_variables")
                    .HasColumnType("blob");

                entity.Property(e => e.ExecutionWaitingFor)
                    .HasColumnName("execution_waiting_for")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<ExecutionState>(entity =>
            {
                entity.HasKey(e => new {e.ExecutionId, e.NodeId});

                entity.ToTable("execution_state", "ORG1");

                entity.Property(e => e.ExecutionId)
                    .HasColumnName("execution_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.NodeActivatedFrom)
                    .HasColumnName("node_activated_from")
                    .HasColumnType("blob");

                entity.Property(e => e.NodeState)
                    .HasColumnName("node_state")
                    .HasColumnType("blob");

                entity.Property(e => e.NodeThreadId)
                    .HasColumnName("node_thread_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<FederatedAccessRole>(entity =>
            {
                entity.ToTable("FEDERATED_ACCESS_ROLE", "ORG1");

                entity.HasIndex(e => e.LinkedApplianceId)
                    .HasName("LINKED_APPLIANCE_ID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LinkedApplianceId)
                    .HasColumnName("LINKED_APPLIANCE_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.UserRoleId)
                    .HasColumnName("USER_ROLE_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Filter>(entity =>
            {
                entity.ToTable("FILTER", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.FfJson)
                    .HasColumnName("FF_JSON")
                    .IsUnicode(false);

                entity.Property(e => e.IsAdvancedSearch)
                    .HasColumnName("IS_ADVANCED_SEARCH")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<Fs>(entity =>
            {
                entity.ToTable("FS", "ORG1");

                entity.HasIndex(e => e.SoftwareId)
                    .HasName("SOFTWARE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AltChecksum)
                    .HasColumnName("ALT_CHECKSUM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AltLocation)
                    .HasColumnName("ALT_LOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateLocation)
                    .HasColumnName("CREATE_LOCATION")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreateShortcut)
                    .HasColumnName("CREATE_SHORTCUT")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CredentialIdAltLocation)
                    .HasColumnName("CREDENTIAL_ID_ALT_LOCATION")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdLocation)
                    .HasColumnName("CREDENTIAL_ID_LOCATION")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HourBegin)
                    .HasColumnName("HOUR_BEGIN")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HourEnd)
                    .HasColumnName("HOUR_END")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NoUncompress)
                    .HasColumnName("NO_UNCOMPRESS")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.Persistent)
                    .HasColumnName("PERSISTENT")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.PostinstallMessage)
                    .HasColumnName("POSTINSTALL_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.PreinstallMessage)
                    .HasColumnName("PREINSTALL_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.RemoveFiles)
                    .HasColumnName("REMOVE_FILES")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReplaceExisting)
                    .HasColumnName("REPLACE_EXISTING")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ShortcutName)
                    .HasColumnName("SHORTCUT_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SOFTWARE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FsLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.FsId, e.LabelId});

                entity.ToTable("FS_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.FsId)
                    .HasColumnName("FS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<FsMachineJt>(entity =>
            {
                entity.HasKey(e => new {e.FsId, e.MachineId});

                entity.ToTable("FS_MACHINE_JT", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_IDX");

                entity.Property(e => e.FsId)
                    .HasColumnName("FS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DownloadTime)
                    .HasColumnName("DOWNLOAD_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<GlobalOptions>(entity =>
            {
                entity.ToTable("GLOBAL_OPTIONS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AdminEmail)
                    .HasColumnName("ADMIN_EMAIL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClientFrequency)
                    .HasColumnName("CLIENT_FREQUENCY")
                    .HasColumnType("decimal(20,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("COMPANY_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EmailSuffix)
                    .HasColumnName("EMAIL_SUFFIX")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HourBegin)
                    .HasColumnName("HOUR_BEGIN")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.HourEnd)
                    .HasColumnName("HOUR_END")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IgnoreClientIpList)
                    .HasColumnName("IGNORE_CLIENT_IP_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.InventoryFrequency)
                    .HasColumnName("INVENTORY_FREQUENCY")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotLogHandling)
                    .HasColumnName("KBOT_LOG_HANDLING")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotPingInterval)
                    .HasColumnName("KBOT_PING_INTERVAL")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotUpdateInterval)
                    .HasColumnName("KBOT_UPDATE_INTERVAL")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MiaDeleteEnable)
                    .HasColumnName("MIA_DELETE_ENABLE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MiaDeleteInterval)
                    .HasColumnName("MIA_DELETE_INTERVAL")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SambaEnable)
                    .HasColumnName("SAMBA_ENABLE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SambaPasswordEnc)
                    .HasColumnName("SAMBA_PASSWORD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.ShowFailed)
                    .HasColumnName("SHOW_FAILED")
                    .HasColumnType("smallint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SplashText)
                    .HasColumnName("SPLASH_TEXT")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GridColumnsOverrides>(entity =>
            {
                entity.ToTable("GRID_COLUMNS_OVERRIDES", "ORG1");

                entity.HasIndex(e => e.Page)
                    .HasName("PAGE");

                entity.HasIndex(e => e.UserId)
                    .HasName("USER_ID");

                entity.HasIndex(e => new {e.UserId, e.Page})
                    .HasName("USER_PAGE_DEFS_LOOKUP")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ColumnsDef)
                    .HasColumnName("COLUMNS_DEF")
                    .IsUnicode(false);

                entity.Property(e => e.CompactView)
                    .HasColumnName("COMPACT_VIEW")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayLength)
                    .HasColumnName("DISPLAY_LENGTH")
                    .HasColumnType("int(7)")
                    .HasDefaultValueSql("250");

                entity.Property(e => e.Page)
                    .IsRequired()
                    .HasColumnName("PAGE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<HdAnnouncement>(entity =>
            {
                entity.ToTable("HD_ANNOUNCEMENT", "ORG1");

                entity.HasIndex(e => e.Ordinal)
                    .HasName("ORDINAL_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.IsHidden)
                    .HasColumnName("IS_HIDDEN")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsUrgent)
                    .HasColumnName("IS_URGENT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("NOTE")
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdAnnouncementLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.HdAnnouncementId, e.LabelId});

                entity.ToTable("HD_ANNOUNCEMENT_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.HdAnnouncementId)
                    .HasColumnName("HD_ANNOUNCEMENT_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdArchiveAttachment>(entity =>
            {
                entity.ToTable("HD_ARCHIVE_ATTACHMENT", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Checksum)
                    .HasColumnName("CHECKSUM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasColumnName("FILE_SIZE")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdTicketChangeId)
                    .HasColumnName("HD_TICKET_CHANGE_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<HdArchiveTicket>(entity =>
            {
                entity.ToTable("HD_ARCHIVE_TICKET", "ORG1");

                entity.HasIndex(e => e.HdCategoryId)
                    .HasName("HD_CATEGORY_IDX");

                entity.HasIndex(e => e.HdImpactId)
                    .HasName("HD_IMPACT_IDX");

                entity.HasIndex(e => e.HdPriorityId)
                    .HasName("HD_PRIORITY_IDX");

                entity.HasIndex(e => e.HdQueueId)
                    .HasName("HD_QUEUE_IDX");

                entity.HasIndex(e => e.HdStatusId)
                    .HasName("HD_STATUS_IDX");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Approval)
                    .HasColumnName("APPROVAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalNote)
                    .HasColumnName("APPROVAL_NOTE")
                    .IsUnicode(false);

                entity.Property(e => e.ApproveState)
                    .HasColumnName("APPROVE_STATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverFullName)
                    .HasColumnName("APPROVER_FULL_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverId)
                    .HasColumnName("APPROVER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ApproverWorkPhone)
                    .HasColumnName("APPROVER_WORK_PHONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArchiveStatus)
                    .HasColumnName("ARCHIVE_STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Archived)
                    .HasColumnName("ARCHIVED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ArchiverFullName)
                    .HasColumnName("ARCHIVER_FULL_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ArchiverId)
                    .HasColumnName("ARCHIVER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArchiverUserName)
                    .HasColumnName("ARCHIVER_USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetName)
                    .HasColumnName("ASSET_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AssetType)
                    .HasColumnName("ASSET_TYPE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CcList)
                    .IsRequired()
                    .HasColumnName("CC_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CustomFieldValue0)
                    .HasColumnName("CUSTOM_FIELD_VALUE0")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue1)
                    .HasColumnName("CUSTOM_FIELD_VALUE1")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue10)
                    .HasColumnName("CUSTOM_FIELD_VALUE10")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue11)
                    .HasColumnName("CUSTOM_FIELD_VALUE11")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue12)
                    .HasColumnName("CUSTOM_FIELD_VALUE12")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue13)
                    .HasColumnName("CUSTOM_FIELD_VALUE13")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue14)
                    .HasColumnName("CUSTOM_FIELD_VALUE14")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue15)
                    .HasColumnName("CUSTOM_FIELD_VALUE15")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue2)
                    .HasColumnName("CUSTOM_FIELD_VALUE2")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue3)
                    .HasColumnName("CUSTOM_FIELD_VALUE3")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue4)
                    .HasColumnName("CUSTOM_FIELD_VALUE4")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue5)
                    .HasColumnName("CUSTOM_FIELD_VALUE5")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue6)
                    .HasColumnName("CUSTOM_FIELD_VALUE6")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue7)
                    .HasColumnName("CUSTOM_FIELD_VALUE7")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue8)
                    .HasColumnName("CUSTOM_FIELD_VALUE8")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue9)
                    .HasColumnName("CUSTOM_FIELD_VALUE9")
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Escalated)
                    .HasColumnName("ESCALATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.HdCategoryId)
                    .HasColumnName("HD_CATEGORY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdCategoryName)
                    .HasColumnName("HD_CATEGORY_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HdImpactId)
                    .HasColumnName("HD_IMPACT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdImpactName)
                    .HasColumnName("HD_IMPACT_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HdPriorityId)
                    .HasColumnName("HD_PRIORITY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdPriorityName)
                    .HasColumnName("HD_PRIORITY_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdQueueName)
                    .HasColumnName("HD_QUEUE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HdServiceStatusId)
                    .HasColumnName("HD_SERVICE_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdStatusId)
                    .HasColumnName("HD_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdStatusName)
                    .HasColumnName("HD_STATUS_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HdUseProcessStatus)
                    .HasColumnName("HD_USE_PROCESS_STATUS")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsManualDueDate)
                    .HasColumnName("IS_MANUAL_DUE_DATE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsParent)
                    .HasColumnName("IS_PARENT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineName)
                    .HasColumnName("MACHINE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.OwnerFullName)
                    .HasColumnName("OWNER_FULL_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OWNER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OwnerUserName)
                    .HasColumnName("OWNER_USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Resolution)
                    .HasColumnName("RESOLUTION")
                    .IsUnicode(false);

                entity.Property(e => e.SatisfactionComment)
                    .HasColumnName("SATISFACTION_COMMENT")
                    .IsUnicode(false);

                entity.Property(e => e.SatisfactionRating)
                    .HasColumnName("SATISFACTION_RATING")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceName)
                    .HasColumnName("SERVICE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTicketId)
                    .HasColumnName("SERVICE_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SlaNotified)
                    .HasColumnName("SLA_NOTIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.SubmitterFullName)
                    .HasColumnName("SUBMITTER_FULL_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitterId)
                    .HasColumnName("SUBMITTER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubmitterUserName)
                    .HasColumnName("SUBMITTER_USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitterWorkPhone)
                    .HasColumnName("SUBMITTER_WORK_PHONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .IsUnicode(false);

                entity.Property(e => e.TicketLayout)
                    .HasColumnName("TICKET_LAYOUT")
                    .IsUnicode(false);

                entity.Property(e => e.TimeClosed)
                    .HasColumnName("TIME_CLOSED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.TimeOpened)
                    .HasColumnName("TIME_OPENED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.TimeStalled)
                    .HasColumnName("TIME_STALLED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdArchiveTicketChange>(entity =>
            {
                entity.ToTable("HD_ARCHIVE_TICKET_CHANGE", "ORG1");

                entity.HasIndex(e => e.HdTicketId)
                    .HasName("HD_TICKET_IDX");

                entity.HasIndex(e => e.Mailed)
                    .HasName("MAILED");

                entity.HasIndex(e => e.MailerSession)
                    .HasName("MAILER_SESSION");

                entity.HasIndex(e => e.UserId)
                    .HasName("USER_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.CommentLoc)
                    .HasColumnName("COMMENT_LOC")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.HdTicketId)
                    .HasColumnName("HD_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LocalizedDescription)
                    .HasColumnName("LOCALIZED_DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.LocalizedOwnersOnlyDescription)
                    .HasColumnName("LOCALIZED_OWNERS_ONLY_DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Mailed)
                    .HasColumnName("MAILED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MailedTimestamp).HasColumnName("MAILED_TIMESTAMP");

                entity.Property(e => e.MailerSession)
                    .HasColumnName("MAILER_SESSION")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NotifyUsers)
                    .HasColumnName("NOTIFY_USERS")
                    .IsUnicode(false);

                entity.Property(e => e.OwnersOnly)
                    .HasColumnName("OWNERS_ONLY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OwnersOnlyDescription)
                    .HasColumnName("OWNERS_ONLY_DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.ResolutionChanged)
                    .HasColumnName("RESOLUTION_CHANGED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SystemComment)
                    .HasColumnName("SYSTEM_COMMENT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TicketDataChange)
                    .HasColumnName("TICKET_DATA_CHANGE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ViaEmail)
                    .IsRequired()
                    .HasColumnName("VIA_EMAIL")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdArchiveTicketChangeField>(entity =>
            {
                entity.ToTable("HD_ARCHIVE_TICKET_CHANGE_FIELD", "ORG1");

                entity.HasIndex(e => e.FieldChanged)
                    .HasName("FIELD_CHANGED_IDX");

                entity.HasIndex(e => e.HdTicketChangeId)
                    .HasName("HD_TICKET_CHANGE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterValue)
                    .HasColumnName("AFTER_VALUE")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.BeforeValue)
                    .HasColumnName("BEFORE_VALUE")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.FieldChanged)
                    .IsRequired()
                    .HasColumnName("FIELD_CHANGED")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HdTicketChangeId)
                    .HasColumnName("HD_TICKET_CHANGE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocalizedDescription)
                    .HasColumnName("LOCALIZED_DESCRIPTION")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<HdArchiveWork>(entity =>
            {
                entity.ToTable("HD_ARCHIVE_WORK", "ORG1");

                entity.HasIndex(e => e.HdTicketId)
                    .HasName("TICKET_IDX");

                entity.HasIndex(e => e.Start)
                    .HasName("START_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AdjustmentHours)
                    .HasColumnName("ADJUSTMENT_HOURS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdTicketId)
                    .HasColumnName("HD_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .IsUnicode(false);

                entity.Property(e => e.Start)
                    .HasColumnName("START")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Stop)
                    .HasColumnName("STOP")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.VoidedBy)
                    .HasColumnName("VOIDED_BY")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<HdAttachment>(entity =>
            {
                entity.ToTable("HD_ATTACHMENT", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Checksum)
                    .HasColumnName("CHECKSUM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasColumnName("FILE_SIZE")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdTicketChangeId)
                    .HasColumnName("HD_TICKET_CHANGE_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<HdCategory>(entity =>
            {
                entity.ToTable("HD_CATEGORY", "ORG1");

                entity.HasIndex(e => e.HdQueueId)
                    .HasName("HD_QUEUE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CcList)
                    .IsRequired()
                    .HasColumnName("CC_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.DefaultOwnerId)
                    .HasColumnName("DEFAULT_OWNER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserSettable)
                    .HasColumnName("USER_SETTABLE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<HdCustomFields>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.HdQueueId});

                entity.ToTable("HD_CUSTOM_FIELDS", "ORG1");

                entity.HasIndex(e => new {e.HdQueueId, e.Name})
                    .HasName("NAME_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Default)
                    .HasColumnName("DEFAULT")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnersOnly)
                    .HasColumnName("OWNERS_ONLY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OwnersOnlyRead)
                    .HasColumnName("OWNERS_ONLY_READ")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .IsUnicode(false);

                entity.Property(e => e.Values)
                    .HasColumnName("VALUES")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdEmailEvent>(entity =>
            {
                entity.HasKey(e => new {e.HdQueueId, e.Recipient, e.Event});

                entity.ToTable("HD_EMAIL_EVENT", "ORG1");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recipient)
                    .HasColumnName("RECIPIENT")
                    .HasColumnType("enum('owner','submitter','ticket_cc','category_cc','approver')")
                    .HasDefaultValueSql("owner");

                entity.Property(e => e.Event)
                    .HasColumnName("EVENT")
                    .HasColumnType(
                        "enum('owner_change','status_change','any_change','escalation','survey','resolution_change','comment','email_ticket_ack','approval_change','sla_violation')")
                    .HasDefaultValueSql("owner_change");
            });

            modelBuilder.Entity<HdField>(entity =>
            {
                entity.ToTable("HD_FIELD", "ORG1");

                entity.HasIndex(e => e.HdQueueId)
                    .HasName("HD_QUEUE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FieldLabel)
                    .IsRequired()
                    .HasColumnName("FIELD_LABEL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdTicketFieldName)
                    .HasColumnName("HD_TICKET_FIELD_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredState)
                    .IsRequired()
                    .HasColumnName("REQUIRED_STATE")
                    .HasColumnType("enum('none','all','opened','closed','stalled')")
                    .HasDefaultValueSql("none");

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasColumnName("VISIBLE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("hidden");
            });

            modelBuilder.Entity<HdHomePageWidget>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.Name});

                entity.ToTable("HD_HOME_PAGE_WIDGET", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasColumnName("DATA_SOURCE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnName("TEMPLATE_NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("VISIBLE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WidgetType)
                    .IsRequired()
                    .HasColumnName("WIDGET_TYPE")
                    .HasColumnType("enum('quick_action','main','right')")
                    .HasDefaultValueSql("quick_action");
            });

            modelBuilder.Entity<HdImpact>(entity =>
            {
                entity.ToTable("HD_IMPACT", "ORG1");

                entity.HasIndex(e => e.HdQueueId)
                    .HasName("HD_QUEUE_IDX");

                entity.HasIndex(e => new {e.Name, e.HdQueueId})
                    .HasName("NAME")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdLink>(entity =>
            {
                entity.ToTable("HD_LINK", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdMailtemplate>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.Name});

                entity.ToTable("HD_MAILTEMPLATE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .IsUnicode(false);

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Markdown)
                    .HasColumnName("MARKDOWN")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdPriority>(entity =>
            {
                entity.ToTable("HD_PRIORITY", "ORG1");

                entity.HasIndex(e => e.HdQueueId)
                    .HasName("HD_QUEUE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("COLOR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EscalationMinutes)
                    .HasColumnName("ESCALATION_MINUTES")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSlaEnabled)
                    .HasColumnName("IS_SLA_ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResolutionDueDateMinutes)
                    .HasColumnName("RESOLUTION_DUE_DATE_MINUTES")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SlaNotificationRecurrenceMinutes)
                    .HasColumnName("SLA_NOTIFICATION_RECURRENCE_MINUTES")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseBusinessHoursForEscalation)
                    .HasColumnName("USE_BUSINESS_HOURS_FOR_ESCALATION")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseBusinessHoursForSla)
                    .HasColumnName("USE_BUSINESS_HOURS_FOR_SLA")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdQueue>(entity =>
            {
                entity.ToTable("HD_QUEUE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AllowAllApprovers)
                    .HasColumnName("ALLOW_ALL_APPROVERS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowAllUsers)
                    .HasColumnName("ALLOW_ALL_USERS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowDelete)
                    .HasColumnName("ALLOW_DELETE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowManagerCommentViaUserui)
                    .HasColumnName("ALLOW_MANAGER_COMMENT_VIA_USERUI")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowOwnersEditAllComment)
                    .HasColumnName("ALLOW_OWNERS_EDIT_ALL_COMMENT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowOwnersViaAdminui)
                    .HasColumnName("ALLOW_OWNERS_VIA_ADMINUI")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowParentClose)
                    .HasColumnName("ALLOW_PARENT_CLOSE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowUsersEditOwnComment)
                    .HasColumnName("ALLOW_USERS_EDIT_OWN_COMMENT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AltEmailAddr)
                    .HasColumnName("ALT_EMAIL_ADDR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArchiveInterval)
                    .HasColumnName("ARCHIVE_INTERVAL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("never");

                entity.Property(e => e.AutoAddCclistOnComment)
                    .HasColumnName("AUTO_ADD_CCLIST_ON_COMMENT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ConflictWarningEnabled)
                    .HasColumnName("CONFLICT_WARNING_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreateUsersOnEmail)
                    .HasColumnName("CREATE_USERS_ON_EMAIL")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultCategoryId)
                    .HasColumnName("DEFAULT_CATEGORY_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultImpactId)
                    .HasColumnName("DEFAULT_IMPACT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultPriorityId)
                    .HasColumnName("DEFAULT_PRIORITY_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultStatusId)
                    .HasColumnName("DEFAULT_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EmailUser)
                    .HasColumnName("EMAIL_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnersOnlyComments)
                    .HasColumnName("OWNERS_ONLY_COMMENTS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PopPasswordEnc)
                    .HasColumnName("POP_PASSWORD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.PopServer)
                    .IsRequired()
                    .HasColumnName("POP_SERVER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PopSsl)
                    .HasColumnName("POP_SSL")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PopUsername)
                    .HasColumnName("POP_USERNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurgeInterval)
                    .HasColumnName("PURGE_INTERVAL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("never");

                entity.Property(e => e.ShowNewTicketAttachments)
                    .HasColumnName("SHOW_NEW_TICKET_ATTACHMENTS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShowNewTicketComments)
                    .HasColumnName("SHOW_NEW_TICKET_COMMENTS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SmtpPasswordEnc)
                    .HasColumnName("SMTP_PASSWORD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.SmtpPort)
                    .HasColumnName("SMTP_PORT")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SmtpServer)
                    .IsRequired()
                    .HasColumnName("SMTP_SERVER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpUsername)
                    .IsRequired()
                    .HasColumnName("SMTP_USERNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdQueueApproverLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.HdQueueId, e.LabelId});

                entity.ToTable("HD_QUEUE_APPROVER_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdQueueOwnerCommentLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.HdQueueId, e.LabelId});

                entity.ToTable("HD_QUEUE_OWNER_COMMENT_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("OWNER_COMMENT_LABEL_IDX");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdQueueOwnerLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.HdQueueId, e.LabelId});

                entity.ToTable("HD_QUEUE_OWNER_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdQueueSubmitterLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.HdQueueId, e.LabelId});

                entity.ToTable("HD_QUEUE_SUBMITTER_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdQueueUserCommentLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.HdQueueId, e.LabelId});

                entity.ToTable("HD_QUEUE_USER_COMMENT_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("USER_COMMENT_LABEL_IDX");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdResponseTemplate>(entity =>
            {
                entity.ToTable("HD_RESPONSE_TEMPLATE", "ORG1");

                entity.HasIndex(e => new {e.QueueId, e.CreatedBy})
                    .HasName("HD_RESPONSE_TEMPLATE_IDX_1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsPublic)
                    .HasColumnName("IS_PUBLIC")
                    .HasColumnType("smallint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QueueId)
                    .HasColumnName("QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Template)
                    .HasColumnName("TEMPLATE")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdService>(entity =>
            {
                entity.ToTable("HD_SERVICE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AllowAdminUsers)
                    .HasColumnName("ALLOW_ADMIN_USERS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowAllAdminOverride)
                    .HasColumnName("ALLOW_ALL_ADMIN_OVERRIDE")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.AllowAllUsers)
                    .HasColumnName("ALLOW_ALL_USERS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ApprovalRequired)
                    .HasColumnName("APPROVAL_REQUIRED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.CatalogEnabled)
                    .HasColumnName("CATALOG_ENABLED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdServiceCategoryId)
                    .HasColumnName("HD_SERVICE_CATEGORY_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdServiceTypeId)
                    .HasColumnName("HD_SERVICE_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdUseProcessStatus)
                    .HasColumnName("HD_USE_PROCESS_STATUS")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideApprovalSteps)
                    .HasColumnName("HIDE_APPROVAL_STEPS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideProcessSteps)
                    .HasColumnName("HIDE_PROCESS_STEPS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KworkflowId)
                    .HasColumnName("KWORKFLOW_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MarkdownEnabled)
                    .HasColumnName("MARKDOWN_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OWNER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ParentTicketClosedStatusId)
                    .HasColumnName("PARENT_TICKET_CLOSED_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ShowIntermediatePage)
                    .HasColumnName("SHOW_INTERMEDIATE_PAGE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdServiceCategory>(entity =>
            {
                entity.ToTable("HD_SERVICE_CATEGORY", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdServiceOverrideLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.HdServiceId, e.LabelId});

                entity.ToTable("HD_SERVICE_OVERRIDE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.HdServiceId)
                    .HasColumnName("HD_SERVICE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdServiceStatus>(entity =>
            {
                entity.ToTable("HD_SERVICE_STATUS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasColumnType("enum('opened','closed','stalled')")
                    .HasDefaultValueSql("opened");
            });

            modelBuilder.Entity<HdServiceTicket>(entity =>
            {
                entity.ToTable("HD_SERVICE_TICKET", "ORG1");

                entity.HasIndex(e => e.HdQueueId)
                    .HasName("HD_QUEUE_IDX");

                entity.HasIndex(e => e.ParentId)
                    .HasName("PARENT_ID_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApproveState)
                    .HasColumnName("APPROVE_STATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverId)
                    .HasColumnName("APPROVER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CcList)
                    .IsRequired()
                    .HasColumnName("CC_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CustomFieldValue0)
                    .HasColumnName("CUSTOM_FIELD_VALUE0")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue1)
                    .HasColumnName("CUSTOM_FIELD_VALUE1")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue10)
                    .HasColumnName("CUSTOM_FIELD_VALUE10")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue11)
                    .HasColumnName("CUSTOM_FIELD_VALUE11")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue12)
                    .HasColumnName("CUSTOM_FIELD_VALUE12")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue13)
                    .HasColumnName("CUSTOM_FIELD_VALUE13")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue14)
                    .HasColumnName("CUSTOM_FIELD_VALUE14")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue15)
                    .HasColumnName("CUSTOM_FIELD_VALUE15")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue2)
                    .HasColumnName("CUSTOM_FIELD_VALUE2")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue3)
                    .HasColumnName("CUSTOM_FIELD_VALUE3")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue4)
                    .HasColumnName("CUSTOM_FIELD_VALUE4")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue5)
                    .HasColumnName("CUSTOM_FIELD_VALUE5")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue6)
                    .HasColumnName("CUSTOM_FIELD_VALUE6")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue7)
                    .HasColumnName("CUSTOM_FIELD_VALUE7")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue8)
                    .HasColumnName("CUSTOM_FIELD_VALUE8")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue9)
                    .HasColumnName("CUSTOM_FIELD_VALUE9")
                    .IsUnicode(false);

                entity.Property(e => e.DependsId)
                    .HasColumnName("DEPENDS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DueDateOffset)
                    .HasColumnName("DUE_DATE_OFFSET")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.HdCategoryId)
                    .HasColumnName("HD_CATEGORY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdImpactId)
                    .HasColumnName("HD_IMPACT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdPriorityId)
                    .HasColumnName("HD_PRIORITY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdServiceId)
                    .HasColumnName("HD_SERVICE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdStatusId)
                    .HasColumnName("HD_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdUseProcessStatus)
                    .HasColumnName("HD_USE_PROCESS_STATUS")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsParent)
                    .HasColumnName("IS_PARENT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OWNER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OwnersOnly)
                    .HasColumnName("OWNERS_ONLY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Resolution)
                    .HasColumnName("RESOLUTION")
                    .IsUnicode(false);

                entity.Property(e => e.SubmitterId)
                    .HasColumnName("SUBMITTER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdServiceType>(entity =>
            {
                entity.ToTable("HD_SERVICE_TYPE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsSystem)
                    .HasColumnName("IS_SYSTEM")
                    .HasColumnType("smallint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequiresApproval)
                    .HasColumnName("REQUIRES_APPROVAL")
                    .HasColumnType("smallint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdServiceUserLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.HdServiceId, e.LabelId});

                entity.ToTable("HD_SERVICE_USER_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.HdServiceId)
                    .HasColumnName("HD_SERVICE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdSlaBusinessHours>(entity =>
            {
                entity.ToTable("HD_SLA_BUSINESS_HOURS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("DAY_OF_WEEK")
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasDefaultValueSql("00:00:00");

                entity.Property(e => e.IsAllDay)
                    .HasColumnName("IS_ALL_DAY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsClosed)
                    .HasColumnName("IS_CLOSED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasDefaultValueSql("00:00:00");
            });

            modelBuilder.Entity<HdSlaHolidays>(entity =>
            {
                entity.ToTable("HD_SLA_HOLIDAYS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<HdStatus>(entity =>
            {
                entity.ToTable("HD_STATUS", "ORG1");

                entity.HasIndex(e => e.HdQueueId)
                    .HasName("HD_QUEUE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasColumnType("enum('opened','closed','stalled')")
                    .HasDefaultValueSql("opened");
            });

            modelBuilder.Entity<HdTicket>(entity =>
            {
                entity.ToTable("HD_TICKET", "ORG1");

                entity.HasIndex(e => e.HdCategoryId)
                    .HasName("HD_CATEGORY_IDX");

                entity.HasIndex(e => e.HdImpactId)
                    .HasName("HD_IMPACT_IDX");

                entity.HasIndex(e => e.HdPriorityId)
                    .HasName("HD_PRIORITY_IDX");

                entity.HasIndex(e => e.HdQueueId)
                    .HasName("HD_QUEUE_IDX");

                entity.HasIndex(e => e.HdStatusId)
                    .HasName("HD_STATUS_IDX");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_IDX");

                entity.HasIndex(e => e.ParentId)
                    .HasName("PARENT");

                entity.HasIndex(e => new {e.OwnerId, e.HdStatusId})
                    .HasName("OWNER_STATUS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Approval)
                    .HasColumnName("APPROVAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalNote)
                    .HasColumnName("APPROVAL_NOTE")
                    .IsUnicode(false);

                entity.Property(e => e.ApproveState)
                    .HasColumnName("APPROVE_STATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverId)
                    .HasColumnName("APPROVER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CcList)
                    .IsRequired()
                    .HasColumnName("CC_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CustomFieldValue0)
                    .HasColumnName("CUSTOM_FIELD_VALUE0")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue1)
                    .HasColumnName("CUSTOM_FIELD_VALUE1")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue10)
                    .HasColumnName("CUSTOM_FIELD_VALUE10")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue11)
                    .HasColumnName("CUSTOM_FIELD_VALUE11")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue12)
                    .HasColumnName("CUSTOM_FIELD_VALUE12")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue13)
                    .HasColumnName("CUSTOM_FIELD_VALUE13")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue14)
                    .HasColumnName("CUSTOM_FIELD_VALUE14")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue15)
                    .HasColumnName("CUSTOM_FIELD_VALUE15")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue2)
                    .HasColumnName("CUSTOM_FIELD_VALUE2")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue3)
                    .HasColumnName("CUSTOM_FIELD_VALUE3")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue4)
                    .HasColumnName("CUSTOM_FIELD_VALUE4")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue5)
                    .HasColumnName("CUSTOM_FIELD_VALUE5")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue6)
                    .HasColumnName("CUSTOM_FIELD_VALUE6")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue7)
                    .HasColumnName("CUSTOM_FIELD_VALUE7")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue8)
                    .HasColumnName("CUSTOM_FIELD_VALUE8")
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue9)
                    .HasColumnName("CUSTOM_FIELD_VALUE9")
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Escalated)
                    .HasColumnName("ESCALATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.HdCategoryId)
                    .HasColumnName("HD_CATEGORY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdImpactId)
                    .HasColumnName("HD_IMPACT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdPriorityId)
                    .HasColumnName("HD_PRIORITY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdServiceStatusId)
                    .HasColumnName("HD_SERVICE_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdStatusId)
                    .HasColumnName("HD_STATUS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdUseProcessStatus)
                    .HasColumnName("HD_USE_PROCESS_STATUS")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsManualDueDate)
                    .HasColumnName("IS_MANUAL_DUE_DATE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsParent)
                    .HasColumnName("IS_PARENT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OWNER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Resolution)
                    .HasColumnName("RESOLUTION")
                    .IsUnicode(false);

                entity.Property(e => e.SatisfactionComment)
                    .HasColumnName("SATISFACTION_COMMENT")
                    .IsUnicode(false);

                entity.Property(e => e.SatisfactionRating)
                    .HasColumnName("SATISFACTION_RATING")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceTicketId)
                    .HasColumnName("SERVICE_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SlaNotified)
                    .HasColumnName("SLA_NOTIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.SubmitterId)
                    .HasColumnName("SUBMITTER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Summary)
                    .HasColumnName("SUMMARY")
                    .IsUnicode(false);

                entity.Property(e => e.TimeClosed)
                    .HasColumnName("TIME_CLOSED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.TimeOpened)
                    .HasColumnName("TIME_OPENED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.TimeStalled)
                    .HasColumnName("TIME_STALLED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(e => e.Owner)
                    .WithMany(u => u.HdTicketOwner)
                    .HasForeignKey(t => t.OwnerId);

                entity.HasOne(e => e.Submitter)
                    .WithMany(u => u.HdTicketSubmitter)
                    .HasForeignKey(t => t.SubmitterId);

                entity.HasOne(e => e.Asset)
                    .WithMany(a => a.HdTicketsAsset)
                    .HasForeignKey(t => t.AssetId);

                entity.HasOne(e => e.Machine)
                    .WithMany(a => a.HdTicketsMachine)
                    .HasForeignKey(t => new {t.MachineId});

                entity.HasOne(e => e.Status)
                    .WithMany(s => s.HdTickets)
                    .HasForeignKey(t => t.HdStatusId);

                entity.HasOne(e => e.Priority)
                    .WithMany(p => p.HdTickets)
                    .HasForeignKey(t => t.HdPriorityId);
            });

            modelBuilder.Entity<HdTicketApproval>(entity =>
            {
                entity.ToTable("HD_TICKET_APPROVAL", "ORG1");

                entity.HasIndex(e => e.HdTicketApprovalStageId)
                    .HasName("HD_TICKET_APPROVAL_STAGE_ID_IDX");

                entity.HasIndex(e => e.HdTicketId)
                    .HasName("HD_TICKET_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Approval)
                    .HasColumnName("APPROVAL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalDate)
                    .HasColumnName("APPROVAL_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ApprovalNote)
                    .HasColumnName("APPROVAL_NOTE")
                    .IsUnicode(false);

                entity.Property(e => e.HdTicketApprovalStageId)
                    .HasColumnName("HD_TICKET_APPROVAL_STAGE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdTicketId)
                    .HasColumnName("HD_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.HdTicketApprovalStage)
                    .WithMany(p => p.HdTicketApproval)
                    .HasForeignKey(d => d.HdTicketApprovalStageId)
                    .HasConstraintName("HD_TICKET_APPROVAL_ID_FK");
            });

            modelBuilder.Entity<HdTicketApprovalParent>(entity =>
            {
                entity.ToTable("HD_TICKET_APPROVAL_PARENT", "ORG1");

                entity.HasIndex(e => e.HdTicketId)
                    .HasName("HD_TICKET_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApprovalId)
                    .HasColumnName("APPROVAL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdTicketId)
                    .HasColumnName("HD_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KworkflowExecutionId)
                    .HasColumnName("KWORKFLOW_EXECUTION_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NotificationRecurrenceMinutes)
                    .HasColumnName("NOTIFICATION_RECURRENCE_MINUTES")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TimeoutMinutes)
                    .HasColumnName("TIMEOUT_MINUTES")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UseBusinessHours)
                    .HasColumnName("USE_BUSINESS_HOURS")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.HdTicket)
                    .WithMany(p => p.HdTicketApprovalParent)
                    .HasForeignKey(d => d.HdTicketId)
                    .HasConstraintName("HD_TICKET_ID_FK");
            });

            modelBuilder.Entity<HdTicketApprovalStage>(entity =>
            {
                entity.ToTable("HD_TICKET_APPROVAL_STAGE", "ORG1");

                entity.HasIndex(e => e.HdTicketApprovalParentId)
                    .HasName("HD_TICKET_APPROVAL_PARENT_ID_IDX");

                entity.HasIndex(e => e.HdTicketId)
                    .HasName("HD_TICKET_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnName("APPROVAL_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ApprovalDueDate)
                    .HasColumnName("APPROVAL_DUE_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ApprovalNotified)
                    .HasColumnName("APPROVAL_NOTIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ApprovalType)
                    .HasColumnName("APPROVAL_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HdTicketApprovalParentId)
                    .HasColumnName("HD_TICKET_APPROVAL_PARENT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdTicketId)
                    .HasColumnName("HD_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Stage)
                    .HasColumnName("STAGE")
                    .HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.HdTicketApprovalParent)
                    .WithMany(p => p.HdTicketApprovalStage)
                    .HasForeignKey(d => d.HdTicketApprovalParentId)
                    .HasConstraintName("HD_TICKET_APPROVAL_PARENT_ID_FK");
            });

            modelBuilder.Entity<HdTicketChange>(entity =>
            {
                entity.ToTable("HD_TICKET_CHANGE", "ORG1");

                entity.HasIndex(e => e.HdTicketId)
                    .HasName("HD_TICKET_IDX");

                entity.HasIndex(e => e.Mailed)
                    .HasName("MAILED");

                entity.HasIndex(e => e.MailerSession)
                    .HasName("MAILER_SESSION");

                entity.HasIndex(e => e.UserId)
                    .HasName("USER_IDX");

                entity.HasIndex(e => new {e.Mailed, e.MailerSession})
                    .HasName("MAILED_MAILER_SESSION_IDX");

                entity.HasIndex(e => new {e.ViaEmail, e.Timestamp})
                    .HasName("VIA_EMAIL_TIMESTAMP_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.CommentLoc)
                    .HasColumnName("COMMENT_LOC")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.HdTicketId)
                    .HasColumnName("HD_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LocalizedDescription)
                    .HasColumnName("LOCALIZED_DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.LocalizedOwnersOnlyDescription)
                    .HasColumnName("LOCALIZED_OWNERS_ONLY_DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Mailed)
                    .HasColumnName("MAILED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MailedTimestamp).HasColumnName("MAILED_TIMESTAMP");

                entity.Property(e => e.MailerSession)
                    .HasColumnName("MAILER_SESSION")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NotifyUsers)
                    .HasColumnName("NOTIFY_USERS")
                    .IsUnicode(false);

                entity.Property(e => e.OwnersOnly)
                    .HasColumnName("OWNERS_ONLY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OwnersOnlyDescription)
                    .HasColumnName("OWNERS_ONLY_DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.ResolutionChanged)
                    .HasColumnName("RESOLUTION_CHANGED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SystemComment)
                    .HasColumnName("SYSTEM_COMMENT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TicketDataChange)
                    .HasColumnName("TICKET_DATA_CHANGE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ViaEmail)
                    .IsRequired()
                    .HasColumnName("VIA_EMAIL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(e => e.HdTicket)
                    .WithMany(t => t.HdTicketChanges)
                    .HasForeignKey(e => e.HdTicketId);

                entity.HasOne(e => e.User)
                    .WithMany(u => u.HdTicketChanges)
                    .HasForeignKey(e => e.UserId);
            });

            modelBuilder.Entity<HdTicketChangeField>(entity =>
            {
                entity.ToTable("HD_TICKET_CHANGE_FIELD", "ORG1");

                entity.HasIndex(e => e.FieldChanged)
                    .HasName("FIELD_CHANGED_IDX");

                entity.HasIndex(e => e.HdTicketChangeId)
                    .HasName("HD_TICKET_CHANGE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AfterValue)
                    .HasColumnName("AFTER_VALUE")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.BeforeValue)
                    .HasColumnName("BEFORE_VALUE")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.FieldChanged)
                    .IsRequired()
                    .HasColumnName("FIELD_CHANGED")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HdTicketChangeId)
                    .HasColumnName("HD_TICKET_CHANGE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocalizedDescription)
                    .HasColumnName("LOCALIZED_DESCRIPTION")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<HdTicketFilter>(entity =>
            {
                entity.ToTable("HD_TICKET_FILTER", "ORG1");

                entity.HasIndex(e => new {e.Name, e.UserId})
                    .HasName("NAME_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FindFields)
                    .HasColumnName("FIND_FIELDS")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdTicketRule>(entity =>
            {
                entity.ToTable("HD_TICKET_RULE", "ORG1");

                entity.HasIndex(e => e.Enabled)
                    .HasName("ENABLED");

                entity.HasIndex(e => e.Frequency)
                    .HasName("FREQUENCY");

                entity.HasIndex(e => e.NextRun)
                    .HasName("NEXT_RUN");

                entity.HasIndex(e => e.Ordinal)
                    .HasName("ORDINAL");

                entity.HasIndex(e => e.SystemRule)
                    .HasName("SYSTEM_RULE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EmailBody)
                    .HasColumnName("EMAIL_BODY")
                    .IsUnicode(false);

                entity.Property(e => e.EmailSubject)
                    .HasColumnName("EMAIL_SUBJECT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmailToAttribute)
                    .HasColumnName("EMAIL_TO_ATTRIBUTE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Frequency)
                    .HasColumnName("FREQUENCY")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdQueueId)
                    .HasColumnName("HD_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastRunLog)
                    .HasColumnName("LAST_RUN_LOG")
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NextRun)
                    .HasColumnName("NEXT_RUN")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.Recipient)
                    .HasColumnName("RECIPIENT")
                    .IsUnicode(false);

                entity.Property(e => e.SelectQuery)
                    .HasColumnName("SELECT_QUERY")
                    .IsUnicode(false);

                entity.Property(e => e.SerializedQueryData)
                    .HasColumnName("SERIALIZED_QUERY_DATA")
                    .IsUnicode(false);

                entity.Property(e => e.SystemRule)
                    .HasColumnName("SYSTEM_RULE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SystemRuleParms)
                    .HasColumnName("SYSTEM_RULE_PARMS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TicketComment)
                    .HasColumnName("TICKET_COMMENT")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TicketCommentOwnersOnly)
                    .HasColumnName("TICKET_COMMENT_OWNERS_ONLY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UpdateQuery)
                    .HasColumnName("UPDATE_QUERY")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HdWork>(entity =>
            {
                entity.ToTable("HD_WORK", "ORG1");

                entity.HasIndex(e => e.HdTicketId)
                    .HasName("TICKET_IDX");

                entity.HasIndex(e => e.Start)
                    .HasName("START_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AdjustmentHours)
                    .HasColumnName("ADJUSTMENT_HOURS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HdTicketId)
                    .HasColumnName("HD_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .IsUnicode(false);

                entity.Property(e => e.Start)
                    .HasColumnName("START")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Stop)
                    .HasColumnName("STOP")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.VoidedBy)
                    .HasColumnName("VOIDED_BY")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.HdTicket)
                    .WithMany(p => p.HdWork)
                    .HasForeignKey(d => d.HdTicketId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("HD_WORK_ID_FK");
            });

            modelBuilder.Entity<HpAsset>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("HP_ASSET", "ORG1");

                entity.Property(e => e.Serial)
                    .HasColumnName("SERIAL")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<ImCron>(entity =>
            {
                entity.ToTable("IM_CRON", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Command)
                    .HasColumnName("COMMAND")
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DaysOfMonth)
                    .HasColumnName("DAYS_OF_MONTH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DaysOfWeek)
                    .HasColumnName("DAYS_OF_WEEK")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hours)
                    .HasColumnName("HOURS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsAgentTimeZone)
                    .HasColumnName("IS_AGENT_TIME_ZONE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Minutes)
                    .HasColumnName("MINUTES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Months)
                    .HasColumnName("MONTHS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TzForOffset)
                    .HasColumnName("TZ_FOR_OFFSET")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kbot>(entity =>
            {
                entity.ToTable("KBOT", "ORG1");

                entity.HasIndex(e => e.Enabled)
                    .HasName("ENABLED_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AlertDialogOptions)
                    .HasColumnName("ALERT_DIALOG_OPTIONS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlertDialogTimeout)
                    .HasColumnName("ALERT_DIALOG_TIMEOUT")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlertDialogTimeoutAction)
                    .HasColumnName("ALERT_DIALOG_TIMEOUT_ACTION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AlertEnabled)
                    .HasColumnName("ALERT_ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AlertMessage)
                    .HasColumnName("ALERT_MESSAGE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlertSnoozeDuration)
                    .HasColumnName("ALERT_SNOOZE_DURATION")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CachedParseError)
                    .HasColumnName("CACHED_PARSE_ERROR")
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.NotifyAdmins)
                    .HasColumnName("NOTIFY_ADMINS")
                    .HasColumnType("tinyint(2) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QueueDisconnected)
                    .HasColumnName("QUEUE_DISCONNECTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunAs)
                    .HasColumnName("RUN_AS")
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunAsCredentialId)
                    .HasColumnName("RUN_AS_CREDENTIAL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunDisconnected)
                    .HasColumnName("RUN_DISCONNECTED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunInventory)
                    .HasColumnName("RUN_INVENTORY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunLoggedOff)
                    .HasColumnName("RUN_LOGGED_OFF")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScheduleType)
                    .HasColumnName("SCHEDULE_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("offline-kscript");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KbotEventSchedule>(entity =>
            {
                entity.HasKey(e => new {e.KbotId, e.Event});

                entity.ToTable("KBOT_EVENT_SCHEDULE", "ORG1");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Event)
                    .HasColumnName("EVENT")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KbotForm>(entity =>
            {
                entity.ToTable("KBOT_FORM", "ORG1");

                entity.HasIndex(e => e.KbotId)
                    .HasName("KBOT_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasColumnName("FORM_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FormUrl)
                    .HasColumnName("FORM_URL")
                    .IsUnicode(false);

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<KbotFormData>(entity =>
            {
                entity.HasKey(e => new {e.KbotFormId, e.FieldName});

                entity.ToTable("KBOT_FORM_DATA", "ORG1");

                entity.Property(e => e.KbotFormId)
                    .HasColumnName("KBOT_FORM_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.FieldData)
                    .HasColumnName("FIELD_DATA")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KbotLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.KbotId, e.LabelId});

                entity.ToTable("KBOT_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<KbotLog>(entity =>
            {
                entity.ToTable("KBOT_LOG", "ORG1");

                entity.HasIndex(e => e.KbotId)
                    .HasName("KBOT_ID");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_ID");

                entity.HasIndex(e => e.Serial)
                    .HasName("SERIAL_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ActivityDetailId)
                    .HasColumnName("ACTIVITY_DETAIL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DebugDetailId)
                    .HasColumnName("DEBUG_DETAIL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotVersion)
                    .HasColumnName("KBOT_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OutputDetailId)
                    .HasColumnName("OUTPUT_DETAIL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Serial)
                    .HasColumnName("SERIAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartTime).HasColumnName("START_TIME");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.StatusDetailId)
                    .HasColumnName("STATUS_DETAIL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.StopTime).HasColumnName("STOP_TIME");
            });

            modelBuilder.Entity<KbotLogDetail>(entity =>
            {
                entity.ToTable("KBOT_LOG_DETAIL", "ORG1");

                entity.HasIndex(e => e.Serial)
                    .HasName("SERIAL_IDX");

                entity.HasIndex(e => e.Text)
                    .HasName("TEXT_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Serial)
                    .HasColumnName("SERIAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Text)
                    .HasColumnName("TEXT")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<KbotLogLatest>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.KbotId});

                entity.ToTable("KBOT_LOG_LATEST", "ORG1");

                entity.HasIndex(e => e.Serial)
                    .HasName("SERIAL_IDX");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotLogId)
                    .HasColumnName("KBOT_LOG_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Serial)
                    .HasColumnName("SERIAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<KbotOsJt>(entity =>
            {
                entity.ToTable("KBOT_OS_JT", "ORG1");

                entity.HasIndex(e => new {e.KbotId, e.SelectionType})
                    .HasName("ALL_IDX");

                entity.HasIndex(e => new {e.KbotId, e.SelectionType, e.OsFamilyId})
                    .HasName("FAMILY_IDX");

                entity.HasIndex(e => new {e.KbotId, e.SelectionType, e.OsId})
                    .HasName("BUILD_IDX");

                entity.HasIndex(e => new {e.KbotId, e.SelectionType, e.OsFamilyId, e.OsProductId})
                    .HasName("PRODUCT_IDX");

                entity.HasIndex(e => new {e.KbotId, e.SelectionType, e.OsFamilyId, e.OsProductId, e.OsArch})
                    .HasName("ARCH_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsArch)
                    .IsRequired()
                    .HasColumnName("OS_ARCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OsFamilyId)
                    .HasColumnName("OS_FAMILY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsId)
                    .HasColumnName("OS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsProductId)
                    .HasColumnName("OS_PRODUCT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SelectionType)
                    .HasColumnName("SELECTION_TYPE")
                    .HasColumnType("enum('ALL','FAMILY','PRODUCT','ARCH','BUILD')")
                    .HasDefaultValueSql("ALL");
            });

            modelBuilder.Entity<KbotRun>(entity =>
            {
                entity.ToTable("KBOT_RUN", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotVersion)
                    .HasColumnName("KBOT_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KbotXml)
                    .HasColumnName("KBOT_XML")
                    .IsUnicode(false);

                entity.Property(e => e.Serial)
                    .HasColumnName("SERIAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<KbotRunMachine>(entity =>
            {
                entity.HasKey(e => new {e.KbotRunId, e.MachineId});

                entity.ToTable("KBOT_RUN_MACHINE", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_ID");

                entity.Property(e => e.KbotRunId)
                    .HasColumnName("KBOT_RUN_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotLogId)
                    .HasColumnName("KBOT_LOG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KbotReplXml)
                    .HasColumnName("KBOT_REPL_XML")
                    .IsUnicode(false);

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("REQUEST_STATUS")
                    .IsUnicode(false);

                entity.Property(e => e.RequestTime).HasColumnName("REQUEST_TIME");

                entity.Property(e => e.Serial)
                    .HasColumnName("SERIAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaskChainRunId)
                    .HasColumnName("TASK_CHAIN_RUN_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<KbotShellScript>(entity =>
            {
                entity.HasKey(e => e.KbotId);

                entity.ToTable("KBOT_SHELL_SCRIPT", "ORG1");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Checksum)
                    .HasColumnName("CHECKSUM")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RemoveFiles)
                    .HasColumnName("REMOVE_FILES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScriptText)
                    .HasColumnName("SCRIPT_TEXT")
                    .IsUnicode(false);

                entity.Property(e => e.Timeout)
                    .HasColumnName("TIMEOUT")
                    .HasColumnType("smallint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UploadFile)
                    .HasColumnName("UPLOAD_FILE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UploadFileName)
                    .HasColumnName("UPLOAD_FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UploadFilePath)
                    .HasColumnName("UPLOAD_FILE_PATH")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KbotVerify>(entity =>
            {
                entity.HasKey(e => new {e.KbotId, e.VerifyIndex});

                entity.ToTable("KBOT_VERIFY", "ORG1");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifyIndex)
                    .HasColumnName("VERIFY_INDEX")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Attempts)
                    .HasColumnName("ATTEMPTS")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FailureMode)
                    .IsRequired()
                    .HasColumnName("FAILURE_MODE")
                    .HasColumnType("enum('break','continue')")
                    .HasDefaultValueSql("break");
            });

            modelBuilder.Entity<KbotVerifySteps>(entity =>
            {
                entity.HasKey(e => new {e.KbotId, e.VerifyIndex, e.StepIndex, e.KbotGrammarId, e.AttrOrder});

                entity.ToTable("KBOT_VERIFY_STEPS", "ORG1");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VerifyIndex)
                    .HasColumnName("VERIFY_INDEX")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StepIndex)
                    .HasColumnName("STEP_INDEX")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KbotGrammarId)
                    .HasColumnName("KBOT_GRAMMAR_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttrOrder)
                    .HasColumnName("ATTR_ORDER")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttrValue)
                    .HasColumnName("ATTR_VALUE")
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .HasColumnName("SECTION")
                    .HasColumnType(
                        "enum('verify','on_verify_success','on_verify_failure','on_remediation_success','on_remediation_failure')");
            });

            modelBuilder.Entity<KbotWolrelayLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.KbotId, e.LabelId});

                entity.ToTable("KBOT_WOLRELAY_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<KmonAlert>(entity =>
            {
                entity.ToTable("KMON_ALERT", "ORG1");

                entity.HasIndex(e => e.Acknowledged)
                    .HasName("KMON_ALERT_IDX_1");

                entity.HasIndex(e => e.KmonConditionId)
                    .HasName("KMON_ALERT_FK_1");

                entity.HasIndex(e => e.KmonMonitoredDeviceId)
                    .HasName("KMON_ALERT_IDX_3");

                entity.HasIndex(e => e.MessageConstant)
                    .HasName("KMON_ALERT_IDX_4");

                entity.HasIndex(e => e.ServerRepeatTime)
                    .HasName("KMON_ALERT_IDX_2");

                entity.Property(e => e.KmonAlertId)
                    .HasColumnName("KMON_ALERT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Acknowledged)
                    .HasColumnName("ACKNOWLEDGED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClientCreateTime).HasColumnName("CLIENT_CREATE_TIME");

                entity.Property(e => e.ClientRepeatTime).HasColumnName("CLIENT_REPEAT_TIME");

                entity.Property(e => e.DynamicMessage)
                    .HasColumnName("DYNAMIC_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.KmonConditionId)
                    .HasColumnName("KMON_CONDITION_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KmonMonitoredDeviceId)
                    .HasColumnName("KMON_MONITORED_DEVICE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.MessageConstant)
                    .HasColumnName("MESSAGE_CONSTANT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatCount)
                    .HasColumnName("REPEAT_COUNT")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerCreateTime)
                    .HasColumnName("SERVER_CREATE_TIME")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ServerRepeatTime)
                    .HasColumnName("SERVER_REPEAT_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.HasOne(d => d.KmonCondition)
                    .WithMany(p => p.KmonAlert)
                    .HasForeignKey(d => d.KmonConditionId)
                    .HasConstraintName("KMON_ALERT_FK_1");

                entity.HasOne(d => d.KmonMonitoredDevice)
                    .WithMany(p => p.KmonAlert)
                    .HasForeignKey(d => d.KmonMonitoredDeviceId)
                    .HasConstraintName("KMON_ALERT_FK_2");
            });

            modelBuilder.Entity<KmonCondition>(entity =>
            {
                entity.ToTable("KMON_CONDITION", "ORG1");

                entity.HasIndex(e => e.KmonConfigId)
                    .HasName("KMON_CONDITION_FK_1");

                entity.Property(e => e.KmonConditionId)
                    .HasColumnName("KMON_CONDITION_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Criteria)
                    .IsRequired()
                    .HasColumnName("CRITERIA")
                    .HasColumnType("longtext");

                entity.Property(e => e.ExcludeCriteria)
                    .HasColumnName("EXCLUDE_CRITERIA")
                    .HasColumnType("longtext");

                entity.Property(e => e.IsCaseSensitive)
                    .HasColumnName("IS_CASE_SENSITIVE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KmonConfigId)
                    .HasColumnName("KMON_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QueueId)
                    .HasColumnName("QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasColumnName("SEVERITY")
                    .HasColumnType("enum('01_critical','02_error','03_warn','04_info','05_recovered')");

                entity.HasOne(d => d.KmonConfig)
                    .WithMany(p => p.KmonCondition)
                    .HasForeignKey(d => d.KmonConfigId)
                    .HasConstraintName("KMON_CONDITION_FK_1");
            });

            modelBuilder.Entity<KmonConfig>(entity =>
            {
                entity.ToTable("KMON_CONFIG", "ORG1");

                entity.HasIndex(e => e.ConfigType)
                    .HasName("KMON_CONFIG_IDX_1");

                entity.HasIndex(e => new {e.ConfigType, e.IsDefault})
                    .HasName("KMON_CONFIG_IDX_2");

                entity.Property(e => e.KmonConfigId)
                    .HasColumnName("KMON_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ConfigType)
                    .HasColumnName("CONFIG_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDefault)
                    .HasColumnName("IS_DEFAULT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsHidden)
                    .HasColumnName("IS_HIDDEN")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsLepProfile)
                    .HasColumnName("IS_LEP_PROFILE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KmonConfigDefault>(entity =>
            {
                entity.ToTable("KMON_CONFIG_DEFAULT", "ORG1");

                entity.HasIndex(e => new {e.ConfigType, e.OsType})
                    .HasName("KMON_CONFIG_DEFAULT_IDX_1");

                entity.Property(e => e.KmonConfigDefaultId)
                    .HasColumnName("KMON_CONFIG_DEFAULT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AlertFormat)
                    .HasColumnName("ALERT_FORMAT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigType)
                    .HasColumnName("CONFIG_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LogDateFormat)
                    .HasColumnName("LOG_DATE_FORMAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogPath)
                    .IsRequired()
                    .HasColumnName("LOG_PATH")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OsType)
                    .HasColumnName("OS_TYPE")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.SerializedCondition)
                    .IsRequired()
                    .HasColumnName("SERIALIZED_CONDITION")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KmonConfigDetail>(entity =>
            {
                entity.ToTable("KMON_CONFIG_DETAIL", "ORG1");

                entity.HasIndex(e => e.KmonConfigId)
                    .HasName("KMON_CONFIG_DETAIL_FK_2");

                entity.HasIndex(e => e.KmonMonitoredDeviceId)
                    .HasName("KMON_CONFIG_DETAIL_FK_1");

                entity.Property(e => e.KmonConfigDetailId)
                    .HasColumnName("KMON_CONFIG_DETAIL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KmonConfigId)
                    .HasColumnName("KMON_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KmonMonitoredDeviceId)
                    .HasColumnName("KMON_MONITORED_DEVICE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.KmonConfig)
                    .WithMany(p => p.KmonConfigDetail)
                    .HasForeignKey(d => d.KmonConfigId)
                    .HasConstraintName("KMON_CONFIG_DETAIL_FK_2");

                entity.HasOne(d => d.KmonMonitoredDevice)
                    .WithMany(p => p.KmonConfigDetail)
                    .HasForeignKey(d => d.KmonMonitoredDeviceId)
                    .HasConstraintName("KMON_CONFIG_DETAIL_FK_1");
            });

            modelBuilder.Entity<KmonConfigDeviceJt>(entity =>
            {
                entity.HasKey(e => new {e.KmonMonitoredDeviceId, e.KmonConfigId});

                entity.ToTable("KMON_CONFIG_DEVICE_JT", "ORG1");

                entity.HasIndex(e => e.KmonConfigId)
                    .HasName("KMON_CONFIG_DEVICE_JT_IDX_2");

                entity.HasIndex(e => e.KmonMonitoredDeviceId)
                    .HasName("KMON_CONFIG_DEVICE_JT_IDX_1");

                entity.Property(e => e.KmonMonitoredDeviceId)
                    .HasColumnName("KMON_MONITORED_DEVICE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KmonConfigId)
                    .HasColumnName("KMON_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.KmonConfig)
                    .WithMany(p => p.KmonConfigDeviceJt)
                    .HasForeignKey(d => d.KmonConfigId)
                    .HasConstraintName("KMON_CONFIG_DEVICE_JT_FK_2");

                entity.HasOne(d => d.KmonMonitoredDevice)
                    .WithMany(p => p.KmonConfigDeviceJt)
                    .HasForeignKey(d => d.KmonMonitoredDeviceId)
                    .HasConstraintName("KMON_CONFIG_DEVICE_JT_FK_1");
            });

            modelBuilder.Entity<KmonInstallLepDeviceJt>(entity =>
            {
                entity.HasKey(e => new {e.KmonLepInstallId, e.KmonLepId, e.KmonMonitoredDeviceId});

                entity.ToTable("KMON_INSTALL_LEP_DEVICE_JT", "ORG1");

                entity.HasIndex(e => e.KmonLepId)
                    .HasName("KMON_INSTALL_LEP_DEVICE_JT_FK_2");

                entity.HasIndex(e => e.KmonMonitoredDeviceId)
                    .HasName("KMON_INSTALL_LEP_DEVICE_JT_FK_3");

                entity.Property(e => e.KmonLepInstallId)
                    .HasColumnName("KMON_LEP_INSTALL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KmonLepId)
                    .HasColumnName("KMON_LEP_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KmonMonitoredDeviceId)
                    .HasColumnName("KMON_MONITORED_DEVICE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.KmonLep)
                    .WithMany(p => p.KmonInstallLepDeviceJt)
                    .HasForeignKey(d => d.KmonLepId)
                    .HasConstraintName("KMON_INSTALL_LEP_DEVICE_JT_FK_2");

                entity.HasOne(d => d.KmonLepInstall)
                    .WithMany(p => p.KmonInstallLepDeviceJt)
                    .HasForeignKey(d => d.KmonLepInstallId)
                    .HasConstraintName("KMON_INSTALL_LEP_DEVICE_JT_FK_1");

                entity.HasOne(d => d.KmonMonitoredDevice)
                    .WithMany(p => p.KmonInstallLepDeviceJt)
                    .HasForeignKey(d => d.KmonMonitoredDeviceId)
                    .HasConstraintName("KMON_INSTALL_LEP_DEVICE_JT_FK_3");
            });

            modelBuilder.Entity<KmonLep>(entity =>
            {
                entity.ToTable("KMON_LEP", "ORG1");

                entity.HasIndex(e => e.ItnFileTypeId)
                    .HasName("KMON_LEP_IDX_1");

                entity.Property(e => e.KmonLepId)
                    .HasColumnName("KMON_LEP_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileLocation)
                    .IsRequired()
                    .HasColumnName("FILE_LOCATION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ItnFileId)
                    .HasColumnName("ITN_FILE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ItnFileTypeId)
                    .HasColumnName("ITN_FILE_TYPE_ID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KmonLepInstall>(entity =>
            {
                entity.ToTable("KMON_LEP_INSTALL", "ORG1");

                entity.Property(e => e.KmonLepInstallId)
                    .HasColumnName("KMON_LEP_INSTALL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AutoAddProfile)
                    .HasColumnName("AUTO_ADD_PROFILE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OverwriteNonWinLep)
                    .HasColumnName("OVERWRITE_NON_WIN_LEP")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverwriteWinLep)
                    .HasColumnName("OVERWRITE_WIN_LEP")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<KmonLogConfig>(entity =>
            {
                entity.ToTable("KMON_LOG_CONFIG", "ORG1");

                entity.HasIndex(e => e.KmonConfigId)
                    .HasName("KMON_LOG_CONFIG_FK_1");

                entity.HasIndex(e => e.OsType)
                    .HasName("KMON_LOG_CONFIG_IDX_1");

                entity.Property(e => e.KmonLogConfigId)
                    .HasColumnName("KMON_LOG_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KmonConfigId)
                    .HasColumnName("KMON_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LogDateFormat)
                    .HasColumnName("LOG_DATE_FORMAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogPath)
                    .IsRequired()
                    .HasColumnName("LOG_PATH")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OsType)
                    .HasColumnName("OS_TYPE")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.KmonConfig)
                    .WithMany(p => p.KmonLogConfig)
                    .HasForeignKey(d => d.KmonConfigId)
                    .HasConstraintName("KMON_LOG_CONFIG_FK_1");
            });

            modelBuilder.Entity<KmonMaintConfig>(entity =>
            {
                entity.ToTable("KMON_MAINT_CONFIG", "ORG1");

                entity.HasIndex(e => e.KmonConfigId)
                    .HasName("KMON_MAINT_CONFIG_FK_1");

                entity.Property(e => e.KmonMaintConfigId)
                    .HasColumnName("KMON_MAINT_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KmonConfigId)
                    .HasColumnName("KMON_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MaintenanceDay)
                    .HasColumnName("MAINTENANCE_DAY")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaintenanceEndTime).HasColumnName("MAINTENANCE_END_TIME");

                entity.Property(e => e.MaintenanceFrequency)
                    .HasColumnName("MAINTENANCE_FREQUENCY")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaintenanceMonth)
                    .HasColumnName("MAINTENANCE_MONTH")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaintenanceStartTime).HasColumnName("MAINTENANCE_START_TIME");

                entity.HasOne(d => d.KmonConfig)
                    .WithMany(p => p.KmonMaintConfig)
                    .HasForeignKey(d => d.KmonConfigId)
                    .HasConstraintName("KMON_MAINT_CONFIG_FK_1");
            });

            modelBuilder.Entity<KmonMonitoredDevice>(entity =>
            {
                entity.ToTable("KMON_MONITORED_DEVICE", "ORG1");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("DEVICE_ID")
                    .IsUnique();

                entity.HasIndex(e => e.Enabled)
                    .HasName("KMON_MONITORED_DEVICE_IDX_1");

                entity.Property(e => e.KmonMonitoredDeviceId)
                    .HasColumnName("KMON_MONITORED_DEVICE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ConfigAlertEnabled)
                    .HasColumnName("CONFIG_ALERT_ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DEVICE_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<KmonSnmpConfig>(entity =>
            {
                entity.ToTable("KMON_SNMP_CONFIG", "ORG1");

                entity.HasIndex(e => e.KmonConfigId)
                    .HasName("KMON_SNMP_CONFIG_FK_1");

                entity.Property(e => e.KmonSnmpConfigId)
                    .HasColumnName("KMON_SNMP_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AlertFormat)
                    .IsRequired()
                    .HasColumnName("ALERT_FORMAT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AutoAddAll)
                    .HasColumnName("AUTO_ADD_ALL")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KmonConfigId)
                    .HasColumnName("KMON_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.KmonConfig)
                    .WithMany(p => p.KmonSnmpConfig)
                    .HasForeignKey(d => d.KmonConfigId)
                    .HasConstraintName("KMON_SNMP_CONFIG_FK_1");
            });

            modelBuilder.Entity<Kworkflow>(entity =>
            {
                entity.ToTable("KWORKFLOW", "ORG1");

                entity.HasIndex(e => e.WorkflowId)
                    .HasName("WORKFLOW_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CallbackClass)
                    .HasColumnName("CALLBACK_CLASS")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationResendMinutes)
                    .HasColumnName("NOTIFICATION_RESEND_MINUTES")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.TimeoutMinutes)
                    .HasColumnName("TIMEOUT_MINUTES")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.UseBusinessHours)
                    .HasColumnName("USE_BUSINESS_HOURS")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("WORKFLOW_ID")
                    .HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.Kworkflow)
                    .HasForeignKey(d => d.WorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("KWORKFLOW_WORKFLOW_ID_FK");
            });

            modelBuilder.Entity<KworkflowApprover>(entity =>
            {
                entity.ToTable("KWORKFLOW_APPROVER", "ORG1");

                entity.HasIndex(e => e.KworkflowId)
                    .HasName("KWORKFLOW_APPROVER_KWORKFLOW_ID_FK");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Approver)
                    .IsRequired()
                    .HasColumnName("APPROVER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.KworkflowId)
                    .HasColumnName("KWORKFLOW_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Stage)
                    .HasColumnName("STAGE")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.StageType)
                    .HasColumnName("STAGE_TYPE")
                    .HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.Kworkflow)
                    .WithMany(p => p.KworkflowApprover)
                    .HasForeignKey(d => d.KworkflowId)
                    .HasConstraintName("KWORKFLOW_APPROVER_KWORKFLOW_ID_FK");
            });

            modelBuilder.Entity<KworkflowExecution>(entity =>
            {
                entity.ToTable("KWORKFLOW_EXECUTION", "ORG1");

                entity.HasIndex(e => e.ExecutionId)
                    .HasName("KWORKFLOW_EXECUTION_EXECUTION_ID_FK");

                entity.HasIndex(e => e.KworkflowId)
                    .HasName("KWORKFLOW_EXECUTION_KWORKFLOW_ID_FK");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CallbackClass)
                    .HasColumnName("CALLBACK_CLASS")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentStage)
                    .HasColumnName("CURRENT_STAGE")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ended)
                    .HasColumnName("ENDED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExecutionId)
                    .HasColumnName("EXECUTION_ID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.KworkflowId)
                    .HasColumnName("KWORKFLOW_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NotificationResendMinutes)
                    .HasColumnName("NOTIFICATION_RESEND_MINUTES")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Started)
                    .HasColumnName("STARTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeoutMinutes)
                    .HasColumnName("TIMEOUT_MINUTES")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.UseBusinessHours)
                    .HasColumnName("USE_BUSINESS_HOURS")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.Kworkflow)
                    .WithMany(p => p.KworkflowExecution)
                    .HasForeignKey(d => d.KworkflowId)
                    .HasConstraintName("KWORKFLOW_EXECUTION_KWORKFLOW_ID_FK");
            });

            modelBuilder.Entity<KworkflowExecutionApproverStatus>(entity =>
            {
                entity.ToTable("KWORKFLOW_EXECUTION_APPROVER_STATUS", "ORG1");

                entity.HasIndex(e => e.KworkflowExecutionId)
                    .HasName("KWORKFLOW_EXECUTION_APPROVER_STATUS_KWORKFLOW_EXECUTION_ID_FK");

                entity.HasIndex(e => e.UserId)
                    .HasName("KWORKFLOW_EXECUTION_APPROVER_STATUS_USER_ID_FK");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Approval)
                    .IsRequired()
                    .HasColumnName("APPROVAL")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("PENDING");

                entity.Property(e => e.KworkflowExecutionId)
                    .HasColumnName("KWORKFLOW_EXECUTION_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Stage)
                    .HasColumnName("STAGE")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.KworkflowExecution)
                    .WithMany(p => p.KworkflowExecutionApproverStatus)
                    .HasForeignKey(d => d.KworkflowExecutionId)
                    .HasConstraintName("KWORKFLOW_EXECUTION_APPROVER_STATUS_KWORKFLOW_EXECUTION_ID_FK");
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("LABEL", "ORG1");

                entity.HasIndex(e => e.MeterEnabled)
                    .HasName("IDX_METER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AppCtrlEnabled)
                    .HasColumnName("APP_CTRL_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.KaceAltLocation)
                    .HasColumnName("KACE_ALT_LOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KaceAltLocationPasswordEnc)
                    .HasColumnName("KACE_ALT_LOCATION_PASSWORD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.KaceAltLocationUser)
                    .HasColumnName("KACE_ALT_LOCATION_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MeterEnabled)
                    .HasColumnName("METER_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeUserRoleId)
                    .HasColumnName("SCOPE_USER_ROLE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsageAll)
                    .HasColumnName("USAGE_ALL")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UsageCatalog)
                    .HasColumnName("USAGE_CATALOG")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsageDell)
                    .HasColumnName("USAGE_DELL")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsageLabel)
                    .HasColumnName("USAGE_LABEL")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsageMachine)
                    .HasColumnName("USAGE_MACHINE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsageNode)
                    .HasColumnName("USAGE_NODE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsagePatch)
                    .HasColumnName("USAGE_PATCH")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsageProcess)
                    .HasColumnName("USAGE_PROCESS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsageSoftware)
                    .HasColumnName("USAGE_SOFTWARE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsageUser)
                    .HasColumnName("USAGE_USER")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LabelLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.ChildLabelId, e.LabelId});

                entity.ToTable("LABEL_LABEL_JT", "ORG1");

                entity.HasIndex(e => new {e.LabelId, e.ChildLabelId})
                    .HasName("LABEL_IDX");

                entity.Property(e => e.ChildLabelId)
                    .HasColumnName("CHILD_LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LdapFilter>(entity =>
            {
                entity.ToTable("LDAP_FILTER", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Dn)
                    .HasColumnName("DN")
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExternalServer)
                    .HasColumnName("EXTERNAL_SERVER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelPrefix)
                    .HasColumnName("LABEL_PREFIX")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LdapLogin)
                    .HasColumnName("LDAP_LOGIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LdapPasswordEnc)
                    .HasColumnName("LDAP_PASSWORD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.MemberOfAttrib)
                    .HasColumnName("MEMBER_OF_ATTRIB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.SearchFilter)
                    .HasColumnName("SEARCH_FILTER")
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LdapImportUser>(entity =>
            {
                entity.ToTable("LDAP_IMPORT_USER", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Attrib)
                    .HasColumnName("ATTRIB")
                    .IsUnicode(false);

                entity.Property(e => e.BinAttrib)
                    .HasColumnName("BIN_ATTRIB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dn)
                    .HasColumnName("DN")
                    .IsUnicode(false);

                entity.Property(e => e.ExternalServer)
                    .HasColumnName("EXTERNAL_SERVER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LabelAttrib)
                    .HasColumnName("LABEL_ATTRIB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LabelPrefix)
                    .HasColumnName("LABEL_PREFIX")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LdapLogin)
                    .HasColumnName("LDAP_LOGIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LdapPasswordEnc)
                    .HasColumnName("LDAP_PASSWORD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.Mapping)
                    .HasColumnName("MAPPING")
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RowLimit)
                    .HasColumnName("ROW_LIMIT")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SearchFilter)
                    .HasColumnName("SEARCH_FILTER")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LenovoAsset>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("LENOVO_ASSET", "ORG1");

                entity.Property(e => e.Serial)
                    .HasColumnName("SERIAL")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.InWarranty)
                    .IsRequired()
                    .HasColumnName("IN_WARRANTY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnName("PRODUCT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Purchased)
                    .HasColumnName("PURCHASED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Shipped)
                    .HasColumnName("SHIPPED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.UpgradeUrl)
                    .IsRequired()
                    .HasColumnName("UPGRADE_URL")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LicenseComplianceException>(entity =>
            {
                entity.HasKey(e => e.SamCatalogId);

                entity.ToTable("LICENSE_COMPLIANCE_EXCEPTION", "ORG1");

                entity.Property(e => e.SamCatalogId)
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.ToTable("MACHINE", "ORG1");

                entity.HasIndex(e => e.BiosSerialNumber)
                    .HasName("DELL_WARRANTY_IDX1");

                entity.HasIndex(e => e.CsManufacturer)
                    .HasName("DELL_WARRANTY_IDX2");

                entity.HasIndex(e => e.InventoryStarted)
                    .HasName("INVENTORY_STARTED");

                entity.HasIndex(e => e.Kuid)
                    .HasName("KUID_INDEX")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("MACHINE_NAME_IDX");

                entity.HasIndex(e => e.OsId)
                    .HasName("OS_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetTag)
                    .HasColumnName("ASSET_TAG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BiosDescription)
                    .HasColumnName("BIOS_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.BiosIdentificationCode)
                    .HasColumnName("BIOS_IDENTIFICATION_CODE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.BiosManufacturer)
                    .HasColumnName("BIOS_MANUFACTURER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.BiosName)
                    .HasColumnName("BIOS_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.BiosReleaseDate)
                    .HasColumnName("BIOS_RELEASE_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.BiosSerialNumber)
                    .HasColumnName("BIOS_SERIAL_NUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.BiosVersion)
                    .HasColumnName("BIOS_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.CdromDevices)
                    .HasColumnName("CDROM_DEVICES")
                    .IsUnicode(false);

                entity.Property(e => e.ChassisType)
                    .HasColumnName("CHASSIS_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.ClientVersion)
                    .HasColumnName("CLIENT_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectTime)
                    .HasColumnName("CONNECT_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CpuName)
                    .HasColumnName("CPU_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CsDomain)
                    .HasColumnName("CS_DOMAIN")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.CsManufacturer)
                    .HasColumnName("CS_MANUFACTURER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.CsModel)
                    .HasColumnName("CS_MODEL")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.CspIdNumber)
                    .HasColumnName("CSP_ID_NUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue0)
                    .HasColumnName("CUSTOM_FIELD_VALUE0")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue1)
                    .HasColumnName("CUSTOM_FIELD_VALUE1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue2)
                    .HasColumnName("CUSTOM_FIELD_VALUE2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue3)
                    .HasColumnName("CUSTOM_FIELD_VALUE3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue4)
                    .HasColumnName("CUSTOM_FIELD_VALUE4")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue5)
                    .HasColumnName("CUSTOM_FIELD_VALUE5")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisconnectTime)
                    .HasColumnName("DISCONNECT_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Domain)
                    .HasColumnName("DOMAIN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.DotNetVersions)
                    .HasColumnName("DOT_NET_VERSIONS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ForceInventory)
                    .HasColumnName("FORCE_INVENTORY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IeVersion)
                    .HasColumnName("IE_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryStarted).HasColumnName("INVENTORY_STARTED");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipv6)
                    .HasColumnName("IPV6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KpatchLanguageId)
                    .HasColumnName("KPATCH_LANGUAGE_ID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Kuid)
                    .IsRequired()
                    .HasColumnName("KUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastClientUpdate)
                    .HasColumnName("LAST_CLIENT_UPDATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LastClientUpdateAttempt)
                    .HasColumnName("LAST_CLIENT_UPDATE_ATTEMPT")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LastInventory)
                    .HasColumnName("LAST_INVENTORY")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LastMessage)
                    .HasColumnName("LAST_MESSAGE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LastReboot)
                    .HasColumnName("LAST_REBOOT")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.LastShutdown)
                    .HasColumnName("LAST_SHUTDOWN")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.LastSync)
                    .HasColumnName("LAST_SYNC")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LastUser)
                    .HasColumnName("LAST_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManualEntry)
                    .HasColumnName("MANUAL_ENTRY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManufacturerProductNumber)
                    .HasColumnName("MANUFACTURER_PRODUCT_NUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Monitor)
                    .HasColumnName("MONITOR")
                    .IsUnicode(false);

                entity.Property(e => e.MotherboardPrimaryBus)
                    .HasColumnName("MOTHERBOARD_PRIMARY_BUS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.MotherboardSecondaryBus)
                    .HasColumnName("MOTHERBOARD_SECONDARY_BUS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.Netmask)
                    .HasColumnName("NETMASK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.OsArch)
                    .HasColumnName("OS_ARCH")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OsBuild)
                    .HasColumnName("OS_BUILD")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.OsFamily)
                    .HasColumnName("OS_FAMILY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OsId)
                    .HasColumnName("OS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsInstalledDate)
                    .HasColumnName("OS_INSTALLED_DATE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.OsMajor)
                    .HasColumnName("OS_MAJOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OsMinor)
                    .HasColumnName("OS_MINOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OsMinor2)
                    .HasColumnName("OS_MINOR2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OsName)
                    .HasColumnName("OS_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OsNumber)
                    .HasColumnName("OS_NUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OsVersion)
                    .HasColumnName("OS_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.Ownership)
                    .HasColumnName("OWNERSHIP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PagefileMaxSize)
                    .HasColumnName("PAGEFILE_MAX_SIZE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.PagefileSize)
                    .HasColumnName("PAGEFILE_SIZE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.PatchlinkLanguageId)
                    .HasColumnName("PATCHLINK_LANGUAGE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PhysicalCores)
                    .HasColumnName("PHYSICAL_CORES")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PhysicalProcessors)
                    .HasColumnName("PHYSICAL_PROCESSORS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrefixLen)
                    .HasColumnName("PREFIX_LEN")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Printers)
                    .HasColumnName("PRINTERS")
                    .IsUnicode(false);

                entity.Property(e => e.Processors)
                    .HasColumnName("PROCESSORS")
                    .IsUnicode(false);

                entity.Property(e => e.RamMax)
                    .HasColumnName("RAM_MAX")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RamTotal).HasColumnName("RAM_TOTAL");

                entity.Property(e => e.RamUsed).HasColumnName("RAM_USED");

                entity.Property(e => e.RegistryMaxSize)
                    .HasColumnName("REGISTRY_MAX_SIZE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.RegistrySize)
                    .HasColumnName("REGISTRY_SIZE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.ServicePack)
                    .HasColumnName("SERVICE_PACK")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.SoundDevices)
                    .HasColumnName("SOUND_DEVICES")
                    .IsUnicode(false);

                entity.Property(e => e.SysArch)
                    .HasColumnName("SYS_ARCH")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDescription)
                    .HasColumnName("SYSTEM_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.SystemDirectory)
                    .HasColumnName("SYSTEM_DIRECTORY")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.TzAgent)
                    .HasColumnName("TZ_AGENT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uptime)
                    .HasColumnName("UPTIME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.UserDomain)
                    .HasColumnName("USER_DOMAIN")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.UserFullname)
                    .HasColumnName("USER_FULLNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.UserLogged)
                    .HasColumnName("USER_LOGGED")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("empty");

                entity.Property(e => e.VideoControllers)
                    .HasColumnName("VIDEO_CONTROLLERS")
                    .IsUnicode(false);

                entity.Property(e => e.Virtual)
                    .HasColumnName("VIRTUAL")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WmiStatus)
                    .HasColumnName("WMI_STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineActions>(entity =>
            {
                entity.ToTable("MACHINE_ACTIONS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("ACTION")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineBitlockerVolume>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.DeviceId});

                entity.ToTable("MACHINE_BITLOCKER_VOLUME", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DEVICE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConversionStatus)
                    .HasColumnName("CONVERSION_STATUS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DriveLetter)
                    .IsRequired()
                    .HasColumnName("DRIVE_LETTER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EncryptionMethod)
                    .IsRequired()
                    .HasColumnName("ENCRYPTION_METHOD")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EncryptionPercentage)
                    .HasColumnName("ENCRYPTION_PERCENTAGE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HardwareEncryptionStatus)
                    .IsRequired()
                    .HasColumnName("HARDWARE_ENCRYPTION_STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationField)
                    .IsRequired()
                    .HasColumnName("IDENTIFICATION_FIELD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsSystemVolume)
                    .HasColumnName("IS_SYSTEM_VOLUME")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KeyProtectors)
                    .IsRequired()
                    .HasColumnName("KEY_PROTECTORS")
                    .IsUnicode(false);

                entity.Property(e => e.LockStatus)
                    .IsRequired()
                    .HasColumnName("LOCK_STATUS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PersistentVolumeId)
                    .IsRequired()
                    .HasColumnName("PERSISTENT_VOLUME_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProtectionStatus)
                    .IsRequired()
                    .HasColumnName("PROTECTION_STATUS")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SelfEncryptionDriveEncryptionMethod)
                    .IsRequired()
                    .HasColumnName("SELF_ENCRYPTION_DRIVE_ENCRYPTION_METHOD")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WipingPercentage)
                    .HasColumnName("WIPING_PERCENTAGE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WipingStatus)
                    .HasColumnName("WIPING_STATUS")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineChromeosDetails>(entity =>
            {
                entity.HasKey(e => e.MachineChromeosDetailsId);

                entity.ToTable("MACHINE_CHROMEOS_DETAILS", "ORG1");

                entity.HasIndex(e => e.Id)
                    .HasName("MACHINE_CHROMEOS_DETAILS_MACHINE_ID_FK_idx");

                entity.Property(e => e.MachineChromeosDetailsId)
                    .HasColumnName("MACHINE_CHROMEOS_DETAILS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AnnotatedLocation)
                    .HasColumnName("ANNOTATED_LOCATION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AnnotatedUser)
                    .HasColumnName("ANNOTATED_USER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BootMode)
                    .HasColumnName("BOOT_MODE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DEVICE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirmwareVersion)
                    .HasColumnName("FIRMWARE_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LastEnrollmentTime).HasColumnName("LAST_ENROLLMENT_TIME");

                entity.Property(e => e.LastSync).HasColumnName("LAST_SYNC");

                entity.Property(e => e.MacAddress)
                    .HasColumnName("MAC_ADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Meid)
                    .HasColumnName("MEID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("ORDER_NUMBER")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OrgUnitPath)
                    .HasColumnName("ORG_UNIT_PATH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OsVersion)
                    .HasColumnName("OS_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformVersion)
                    .HasColumnName("PLATFORM_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("SERIAL_NUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SupportEndDate).HasColumnName("SUPPORT_END_DATE");

                entity.Property(e => e.WillAutoRenew)
                    .HasColumnName("WILL_AUTO_RENEW")
                    .HasColumnType("tinyint(1)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.MachineChromeosDetails)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("MACHINE_CHROMEOS_DETAILS_MACHINE_ID_FK");
            });

            modelBuilder.Entity<MachineDailyUptime>(entity =>
            {
                entity.ToTable("MACHINE_DAILY_UPTIME", "ORG1");

                entity.HasIndex(e => new {e.MachineId, e.Day})
                    .HasName("MACHINE_ID_DAY_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Day)
                    .HasColumnName("DAY")
                    .HasColumnType("date")
                    .HasDefaultValueSql("0000-00-00");

                entity.Property(e => e.Hours)
                    .HasColumnName("HOURS")
                    .HasColumnType("decimal(4,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MachineDcmAmtSettings>(entity =>
            {
                entity.ToTable("MACHINE_DCM_AMT_SETTINGS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsAmtSupported)
                    .HasColumnName("IS_AMT_SUPPORTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsIderEnabled)
                    .HasColumnName("IS_IDER_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSolEnabled)
                    .HasColumnName("IS_SOL_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MachineDcmVproSettings>(entity =>
            {
                entity.ToTable("MACHINE_DCM_VPRO_SETTINGS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.VproCharacteristics)
                    .IsRequired()
                    .HasColumnName("VPRO_CHARACTERISTICS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineDdpe>(entity =>
            {
                entity.ToTable("MACHINE_DDPE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentVersion)
                    .IsRequired()
                    .HasColumnName("AGENT_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mcid)
                    .IsRequired()
                    .HasColumnName("MCID")
                    .IsUnicode(false);

                entity.Property(e => e.ProtectionStatus)
                    .IsRequired()
                    .HasColumnName("PROTECTION_STATUS")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ProtectionStatusUpdated).HasColumnName("PROTECTION_STATUS_UPDATED");

                entity.Property(e => e.ServerHostname)
                    .IsRequired()
                    .HasColumnName("SERVER_HOSTNAME")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineDdpeVolume>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.DeviceId});

                entity.ToTable("MACHINE_DDPE_VOLUME", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DEVICE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProtectionReason)
                    .IsRequired()
                    .HasColumnName("PROTECTION_REASON")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProtectionStatus)
                    .IsRequired()
                    .HasColumnName("PROTECTION_STATUS")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineDriveEncryptionSummary>(entity =>
            {
                entity.ToTable("MACHINE_DRIVE_ENCRYPTION_SUMMARY", "ORG1");

                entity.HasIndex(e => e.IsDriveEncryptionEnabled)
                    .HasName("IS_DRIVE_ENCRYPTION_ENABLED_IDX");

                entity.HasIndex(e => e.IsDriveProtected)
                    .HasName("IS_DRIVE_PROTECTED_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsDriveEncryptionEnabled)
                    .HasColumnName("IS_DRIVE_ENCRYPTION_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDriveProtected)
                    .HasColumnName("IS_DRIVE_PROTECTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProtectionReason)
                    .IsRequired()
                    .HasColumnName("PROTECTION_REASON")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineFieldDefinition>(entity =>
            {
                entity.HasKey(e => e.FieldName);

                entity.ToTable("MACHINE_FIELD_DEFINITION", "ORG1");

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FieldType)
                    .HasColumnName("FIELD_TYPE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FriendlyFieldName)
                    .HasColumnName("FRIENDLY_FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MachineFilevaultVolume>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.DeviceId});

                entity.ToTable("MACHINE_FILEVAULT_VOLUME", "ORG1");

                entity.HasIndex(e => e.HasInstitutionalRecoveryKey)
                    .HasName("HAS_INSTITUTIONAL_RECOVERY_KEY_IDX");

                entity.HasIndex(e => e.HasPersonalRecoveryKey)
                    .HasName("HAS_PERSONAL_RECOVERY_KEY_IDX");

                entity.HasIndex(e => e.IsEnabled)
                    .HasName("IS_ENABLED_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DEVICE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedUsers)
                    .HasColumnName("AUTHORIZED_USERS")
                    .IsUnicode(false);

                entity.Property(e => e.ConversionPercentage)
                    .HasColumnName("CONVERSION_PERCENTAGE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConversionStatus)
                    .IsRequired()
                    .HasColumnName("CONVERSION_STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EncryptionStatus)
                    .IsRequired()
                    .HasColumnName("ENCRYPTION_STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EncryptionType)
                    .IsRequired()
                    .HasColumnName("ENCRYPTION_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HasInstitutionalRecoveryKey)
                    .HasColumnName("HAS_INSTITUTIONAL_RECOVERY_KEY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasPersonalRecoveryKey)
                    .HasColumnName("HAS_PERSONAL_RECOVERY_KEY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("IS_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineIntelAmt>(entity =>
            {
                entity.ToTable("MACHINE_INTEL_AMT", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigurationMode)
                    .IsRequired()
                    .HasColumnName("CONFIGURATION_MODE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ControlMode)
                    .IsRequired()
                    .HasColumnName("CONTROL_MODE")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FwVersion)
                    .IsRequired()
                    .HasColumnName("FW_VERSION")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsAmtConfigured)
                    .HasColumnName("IS_AMT_CONFIGURED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsAmtEnabledInBios)
                    .HasColumnName("IS_AMT_ENABLED_IN_BIOS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsAmtSupported)
                    .HasColumnName("IS_AMT_SUPPORTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMeiEnabled)
                    .HasColumnName("IS_MEI_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MeiVersion)
                    .IsRequired()
                    .HasColumnName("MEI_VERSION")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.LabelId});

                entity.ToTable("MACHINE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MachineLocation>(entity =>
            {
                entity.HasKey(e => e.MachineLocationId);

                entity.ToTable("MACHINE_LOCATION", "ORG1");

                entity.HasIndex(e => e.Id)
                    .HasName("MACHINE_LOCATION_MACHINE_ID_FK_idx");

                entity.Property(e => e.MachineLocationId)
                    .HasColumnName("MACHINE_LOCATION_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Counrty)
                    .HasColumnName("COUNRTY")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("COUNTRY_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LastUpdate).HasColumnName("LAST_UPDATE");

                entity.Property(e => e.Latitude)
                    .HasColumnName("LATITUDE")
                    .HasColumnType("decimal(10,7)");

                entity.Property(e => e.Locality)
                    .HasColumnName("LOCALITY")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("LONGITUDE")
                    .HasColumnType("decimal(10,7)");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("POSTAL_CODE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("REGION")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasColumnName("STREET_ADDRESS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.MachineLocation)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("MACHINE_LOCATION_MACHINE_ID_FK");
            });

            modelBuilder.Entity<MachineMobile>(entity =>
            {
                entity.HasKey(e => e.MachineMobileId);

                entity.ToTable("MACHINE_MOBILE", "ORG1");

                entity.HasIndex(e => e.Id)
                    .HasName("MACHINE_MOBILE_MACHINE_ID_FK_idx");

                entity.Property(e => e.MachineMobileId)
                    .HasColumnName("MACHINE_MOBILE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ActivationLockEnabled)
                    .HasColumnName("ACTIVATION_LOCK_ENABLED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.BatteryLevel)
                    .HasColumnName("BATTERY_LEVEL")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Carrier)
                    .HasColumnName("CARRIER")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCarrierNetwork)
                    .HasColumnName("CURRENT_CARRIER_NETWORK")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DataRoamingEnabled)
                    .HasColumnName("DATA_ROAMING_ENABLED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.DeviceType)
                    .HasColumnName("DEVICE_TYPE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Iccid)
                    .HasColumnName("ICCID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsCompliant)
                    .HasColumnName("IS_COMPLIANT")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsEncrypted)
                    .HasColumnName("IS_ENCRYPTED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsEnrolled)
                    .HasColumnName("IS_ENROLLED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsLost)
                    .HasColumnName("IS_LOST")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsRooted)
                    .HasColumnName("IS_ROOTED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsSupervised)
                    .HasColumnName("IS_SUPERVISED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.LastCheckIn).HasColumnName("LAST_CHECK_IN");

                entity.Property(e => e.LocatorServiceEnabled)
                    .HasColumnName("LOCATOR_SERVICE_ENABLED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Meid)
                    .HasColumnName("MEID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModemFirmware)
                    .HasColumnName("MODEM_FIRMWARE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("PHONE_NUMBER")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Udid)
                    .HasColumnName("UDID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceRoamingEnabled)
                    .HasColumnName("VOICE_ROAMING_ENABLED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.MachineMobile)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("MACHINE_MOBILE_MACHINE_ID_FK");
            });

            modelBuilder.Entity<MachineNics>(entity =>
            {
                entity.HasKey(e => e.NicId);

                entity.ToTable("MACHINE_NICS", "ORG1");

                entity.HasIndex(e => e.Id)
                    .HasName("ID_IDX");

                entity.Property(e => e.NicId)
                    .HasColumnName("NIC_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DhcpEnabled)
                    .HasColumnName("DHCP_ENABLED")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dnsdoman)
                    .HasColumnName("DNSDOMAN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dnshostname)
                    .HasColumnName("DNSHOSTNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ipv6Config)
                    .HasColumnName("IPV6_CONFIG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Netmask)
                    .HasColumnName("NETMASK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nic)
                    .HasColumnName("NIC")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineNtserviceJt>(entity =>
            {
                entity.HasKey(e => new {e.NtserviceId, e.MachineId});

                entity.ToTable("MACHINE_NTSERVICE_JT", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_IDX");

                entity.Property(e => e.NtserviceId)
                    .HasColumnName("NTSERVICE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MachineProcessJt>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.ProcessId});

                entity.ToTable("MACHINE_PROCESS_JT", "ORG1");

                entity.HasIndex(e => e.ProcessId)
                    .HasName("PROCESS_IDX");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProcessId)
                    .HasColumnName("PROCESS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MachineSnmpData>(entity =>
            {
                entity.ToTable("MACHINE_SNMP_DATA", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_SNMP_DATA_MACHINE_ID_FK");

                entity.Property(e => e.MachineSnmpDataId)
                    .HasColumnName("MACHINE_SNMP_DATA_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FullWalk)
                    .HasColumnName("FULL_WALK")
                    .HasColumnType("longtext");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MachineSnmpData)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("MACHINE_SNMP_DATA_MACHINE_ID_FK");
            });

            modelBuilder.Entity<MachineSoftwareJt>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.SoftwareId});

                entity.ToTable("MACHINE_SOFTWARE_JT", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_IDX");

                entity.HasIndex(e => e.SoftwareId)
                    .HasName("SOFTWARE_IDX");

                entity.HasIndex(e => new {e.SoftwareId, e.MachineId})
                    .HasName("SOFTWARE_IDX2")
                    .IsUnique();

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SOFTWARE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MachineStartupprogramJt>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.StartupprogramId});

                entity.ToTable("MACHINE_STARTUPPROGRAM_JT", "ORG1");

                entity.HasIndex(e => e.StartupprogramId)
                    .HasName("STARTUPPROGRAM_IDX");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartupprogramId)
                    .HasColumnName("STARTUPPROGRAM_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MachineTpm>(entity =>
            {
                entity.ToTable("MACHINE_TPM", "ORG1");

                entity.HasIndex(e => e.IsActivated)
                    .HasName("IS_ACTIVATED_IDX");

                entity.HasIndex(e => e.IsEnabled)
                    .HasName("IS_ENABLED_IDX");

                entity.HasIndex(e => e.IsOwned)
                    .HasName("IS_OWNED_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActivated)
                    .HasColumnName("IS_ACTIVATED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("IS_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsOwned)
                    .HasColumnName("IS_OWNED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("MANUFACTURER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ManufacturerIdText)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_ID_TEXT")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerVersion)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_VERSION")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerVersionInfo)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER_VERSION_INFO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalPresenceVersionInfo)
                    .IsRequired()
                    .HasColumnName("PHYSICAL_PRESENCE_VERSION_INFO")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificationVersion)
                    .IsRequired()
                    .HasColumnName("SPECIFICATION_VERSION")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineVirtualGuest>(entity =>
            {
                entity.HasKey(e => e.MachineVirtualGuestId);

                entity.ToTable("MACHINE_VIRTUAL_GUEST", "ORG1");

                entity.HasIndex(e => e.Id)
                    .HasName("MACHINE_VIRTUAL_GUEST_MACHINE_VIRT_HOST_MACH_VIRT_HOST_ID_FK_IDX");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_VIRTUAL_GUEST_MACHINE_ID_FK_IDX");

                entity.HasIndex(e => e.MachineVirtualStateId)
                    .HasName("MACHINE_VIRTUAL_STATE_FK_IDX");

                entity.HasIndex(e => e.MachineVirtualStatusId)
                    .HasName("MACHINE_VIRTUAL_STATUS_FK_IDX");

                entity.HasIndex(e => e.MachineVirtualToolsStatusId)
                    .HasName("MACHINE_VIRTUAL_TOOLS_STATUS_FK_IDX");

                entity.HasIndex(e => e.MachineVirtualTypeId)
                    .HasName("MACHINE_VIRTUAL_TYPE_FK_IDX");

                entity.HasIndex(e => e.UsageCpu)
                    .HasName("USAGE_CPU_IDX");

                entity.HasIndex(e => e.UsageDatastore)
                    .HasName("USAGE_DATASTORE_IDX");

                entity.HasIndex(e => e.UsageMemory)
                    .HasName("USAGE_MEMORY_IDX");

                entity.Property(e => e.MachineVirtualGuestId)
                    .HasColumnName("MACHINE_VIRTUAL_GUEST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Hostname)
                    .HasColumnName("HOSTNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InstanceUuid)
                    .HasColumnName("INSTANCE_UUID")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineVirtualStateId)
                    .HasColumnName("MACHINE_VIRTUAL_STATE_ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MachineVirtualStatusId)
                    .HasColumnName("MACHINE_VIRTUAL_STATUS_ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MachineVirtualToolsStatusId)
                    .HasColumnName("MACHINE_VIRTUAL_TOOLS_STATUS_ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MachineVirtualTypeId)
                    .HasColumnName("MACHINE_VIRTUAL_TYPE_ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToolsVersion)
                    .HasColumnName("TOOLS_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UsageCpu)
                    .HasColumnName("USAGE_CPU")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.UsageDatastore)
                    .HasColumnName("USAGE_DATASTORE")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.UsageMemory)
                    .HasColumnName("USAGE_MEMORY")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.MachineVirtualGuest)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("MACHINE_VIRTUAL_GUEST_MACHINE_VIRT_HOST_MACH_VIRT_HOST_ID_FK");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MachineVirtualGuest)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("MACHINE_VIRTUAL_GUEST_MACHINE_ID_FK");

                entity.HasOne(d => d.MachineVirtualState)
                    .WithMany(p => p.MachineVirtualGuest)
                    .HasForeignKey(d => d.MachineVirtualStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_VIRTUAL_GUEST_MACHINE_VIRTUAL_STATE_ID_FK");

                entity.HasOne(d => d.MachineVirtualStatus)
                    .WithMany(p => p.MachineVirtualGuest)
                    .HasForeignKey(d => d.MachineVirtualStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_VIRTUAL_GUEST_MACHINE_VIRTUAL_STATUS_ID_FK");

                entity.HasOne(d => d.MachineVirtualToolsStatus)
                    .WithMany(p => p.MachineVirtualGuest)
                    .HasForeignKey(d => d.MachineVirtualToolsStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_VIRTUAL_GUEST_MACHINE_VIRTUAL_TOOLS_STATUS_ID_FK");

                entity.HasOne(d => d.MachineVirtualType)
                    .WithMany(p => p.MachineVirtualGuest)
                    .HasForeignKey(d => d.MachineVirtualTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_VIRTUAL_GUEST_MACHINE_VIRTUAL_TYPE_ID_FK");
            });

            modelBuilder.Entity<MachineVirtualHost>(entity =>
            {
                entity.HasKey(e => e.MachineVirtualHostId);

                entity.ToTable("MACHINE_VIRTUAL_HOST", "ORG1");

                entity.HasIndex(e => e.Id)
                    .HasName("MACHINE_VIRTUAL_HOST_MACHINE_ID_FK_IDX");

                entity.HasIndex(e => e.InstanceUuid)
                    .HasName("MACHINE_VIRTUAL_HOST_MACHINE_INSTANCE_UUID_IDX");

                entity.HasIndex(e => e.MachineVirtualManagerId)
                    .HasName("MACHINE_VIRTUAL_HOST_MACHINE_VIRTUAL_MANAGER_FK_IDX");

                entity.HasIndex(e => e.MachineVirtualManagerName)
                    .HasName("MACHINE_VIRTUAL_HOST_MACHINE_VIRTUAL_MANAGER_NAME_IDX");

                entity.HasIndex(e => e.MachineVirtualStatusId)
                    .HasName("MACHINE_VIRTUAL_HOST_MACHINE_VIRTUAL_STATUS_FK_IDX");

                entity.HasIndex(e => e.MachineVirtualTypeId)
                    .HasName("MACHINE_VIRTUAL_HOST_MACHINE_VIRTUAL_TYPE_FK_IDX");

                entity.Property(e => e.MachineVirtualHostId)
                    .HasColumnName("MACHINE_VIRTUAL_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InstanceUuid)
                    .IsRequired()
                    .HasColumnName("INSTANCE_UUID")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.MachineVirtualManagerId)
                    .HasColumnName("MACHINE_VIRTUAL_MANAGER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineVirtualManagerName)
                    .HasColumnName("MACHINE_VIRTUAL_MANAGER_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MachineVirtualStatusId)
                    .HasColumnName("MACHINE_VIRTUAL_STATUS_ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MachineVirtualTypeId)
                    .HasColumnName("MACHINE_VIRTUAL_TYPE_ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.MachineVirtualHost)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("MACHINE_VIRTUAL_HOST_MACHINE_ID_FK");

                entity.HasOne(d => d.MachineVirtualManager)
                    .WithMany(p => p.MachineVirtualHost)
                    .HasForeignKey(d => d.MachineVirtualManagerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("MACHINE_VIRTUAL_HOST_MACHINE_VIRTUAL_MANAGER_MACH_VIRT_MGR_ID_FK");

                entity.HasOne(d => d.MachineVirtualStatus)
                    .WithMany(p => p.MachineVirtualHost)
                    .HasForeignKey(d => d.MachineVirtualStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_VIRTUAL_HOST_MACHINE_VIRTUAL_STATUS_ID_FK");

                entity.HasOne(d => d.MachineVirtualType)
                    .WithMany(p => p.MachineVirtualHost)
                    .HasForeignKey(d => d.MachineVirtualTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_VIRTUAL_HOST_MACHINE_VIRTUAL_TYPE_ID_FK");
            });

            modelBuilder.Entity<MachineVirtualManager>(entity =>
            {
                entity.HasKey(e => e.MachineVirtualManagerId);

                entity.ToTable("MACHINE_VIRTUAL_MANAGER", "ORG1");

                entity.HasIndex(e => e.Id)
                    .HasName("MACHINE_VIRTUAL_MANAGER_MACHINE_ID_FK_IDX");

                entity.HasIndex(e => e.InstanceUuid)
                    .HasName("MACHINE_VIRTUAL_MANAGER_INSTANCE_UUID_IDX");

                entity.HasIndex(e => e.MachineVirtualTypeId)
                    .HasName("MACHINE_VIRTUAL_TYPE_FK_IDX");

                entity.Property(e => e.MachineVirtualManagerId)
                    .HasColumnName("MACHINE_VIRTUAL_MANAGER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InstanceUuid)
                    .IsRequired()
                    .HasColumnName("INSTANCE_UUID")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.MachineVirtualTypeId)
                    .HasColumnName("MACHINE_VIRTUAL_TYPE_ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.MachineVirtualManager)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("MACHINE_VIRTUAL_MANAGER_MACHINE_ID_FK");

                entity.HasOne(d => d.MachineVirtualType)
                    .WithMany(p => p.MachineVirtualManager)
                    .HasForeignKey(d => d.MachineVirtualTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MACHINE_VIRTUAL_MANAGER_MACHINE_VIRTUAL_TYPE_ID_FK");
            });

            modelBuilder.Entity<MachineVirtualState>(entity =>
            {
                entity.ToTable("MACHINE_VIRTUAL_STATE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineVirtualStatus>(entity =>
            {
                entity.ToTable("MACHINE_VIRTUAL_STATUS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineVirtualToolsStatus>(entity =>
            {
                entity.ToTable("MACHINE_VIRTUAL_TOOLS_STATUS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineVirtualType>(entity =>
            {
                entity.ToTable("MACHINE_VIRTUAL_TYPE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManufacturerWarrantyApiKeys>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId);

                entity.ToTable("MANUFACTURER_WARRANTY_API_KEYS", "ORG1");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("MANUFACTURER_ID")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KeyEnc)
                    .IsRequired()
                    .HasColumnName("KEY_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.SecretEnc)
                    .HasColumnName("SECRET_ENC")
                    .HasColumnType("tinyblob");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("MESSAGE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KeepAlive)
                    .HasColumnName("KEEP_ALIVE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Message1)
                    .HasColumnName("MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MessageLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.MessageId, e.LabelId});

                entity.ToTable("MESSAGE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MESSAGE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Mi>(entity =>
            {
                entity.ToTable("MI", "ORG1");

                entity.HasIndex(e => e.SamCatalogId)
                    .HasName("SAM_CATALOG_IX");

                entity.HasIndex(e => e.SoftwareId)
                    .HasName("SOFTWARE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AdminInstall)
                    .HasColumnName("ADMIN_INSTALL")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AltChecksum)
                    .HasColumnName("ALT_CHECKSUM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AltLocation)
                    .HasColumnName("ALT_LOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CredentialIdAltLocation)
                    .HasColumnName("CREDENTIAL_ID_ALT_LOCATION")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeployOrder)
                    .HasColumnName("DEPLOY_ORDER")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.DontPrependMsiexec)
                    .HasColumnName("DONT_PREPEND_MSIEXEC")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HourBegin)
                    .HasColumnName("HOUR_BEGIN")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HourEnd)
                    .HasColumnName("HOUR_END")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstallFile)
                    .HasColumnName("INSTALL_FILE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstallFullCommandline)
                    .HasColumnName("INSTALL_FULL_COMMANDLINE")
                    .IsUnicode(false);

                entity.Property(e => e.InstallParms)
                    .HasColumnName("INSTALL_PARMS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaxAttemptCount)
                    .HasColumnName("MAX_ATTEMPT_COUNT")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.PostinstallMessage)
                    .HasColumnName("POSTINSTALL_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.PostinstallMessageTimeout)
                    .HasColumnName("POSTINSTALL_MESSAGE_TIMEOUT")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PreinstallMessage)
                    .HasColumnName("PREINSTALL_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.PreinstallMessageTimeout)
                    .HasColumnName("PREINSTALL_MESSAGE_TIMEOUT")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PreinstallTimeoutAction)
                    .IsRequired()
                    .HasColumnName("PREINSTALL_TIMEOUT_ACTION")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("noinstall");

                entity.Property(e => e.RebootMode)
                    .HasColumnName("REBOOT_MODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemoveFiles)
                    .HasColumnName("REMOVE_FILES")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunOnly)
                    .HasColumnName("RUN_ONLY")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SamAttachedFileId)
                    .HasColumnName("SAM_ATTACHED_FILE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SamCatalogId)
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.SamMinorVersion)
                    .IsRequired()
                    .HasColumnName("SAM_MINOR_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SetupMode)
                    .HasColumnName("SETUP_MODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Snooze)
                    .HasColumnName("SNOOZE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SnoozeMessage)
                    .HasColumnName("SNOOZE_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.SnoozeTimeout)
                    .HasColumnName("SNOOZE_TIMEOUT")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.SnoozeTimeoutAction)
                    .IsRequired()
                    .HasColumnName("SNOOZE_TIMEOUT_ACTION")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("noinstall");

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SOFTWARE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Uninstall)
                    .HasColumnName("UNINSTALL")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<MiAttempt>(entity =>
            {
                entity.HasKey(e => new {e.MiId, e.MachineId});

                entity.ToTable("MI_ATTEMPT", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("MACHINE_ID");

                entity.Property(e => e.MiId)
                    .HasColumnName("MI_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttemptCount)
                    .HasColumnName("ATTEMPT_COUNT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunNow)
                    .HasColumnName("RUN_NOW")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MiLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.MiId, e.LabelId});

                entity.ToTable("MI_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.MiId)
                    .HasColumnName("MI_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Node1>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.Id1, e.NodeId, e.NodeId1});

                entity.ToTable("node", "ORG1");

                entity.HasIndex(e => e.RelayMachineId)
                    .HasName("NODE_RELAY_MACHINE_ID_MACHINE_ID_FK_idx");

                entity.HasIndex(e => e.WorkflowId)
                    .HasName("workflow_id");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Id1)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NodeId1)
                    .HasColumnName("node_id")
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AwId)
                    .HasColumnName("AW_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AwId1)
                    .HasColumnName("AW_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AwStatus)
                    .HasColumnName("AW_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AwStatus1)
                    .HasColumnName("AW_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChromeosId)
                    .HasColumnName("CHROMEOS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChromeosId1)
                    .HasColumnName("CHROMEOS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChromeosStatus)
                    .HasColumnName("CHROMEOS_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChromeosStatus1)
                    .HasColumnName("CHROMEOS_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CliStatus)
                    .HasColumnName("CLI_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CliStatus1)
                    .HasColumnName("CLI_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Created1)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DmmId)
                    .HasColumnName("DMM_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DmmId1)
                    .HasColumnName("DMM_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DmmStatus)
                    .HasColumnName("DMM_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DmmStatus1)
                    .HasColumnName("DMM_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GMobileId)
                    .HasColumnName("G_MOBILE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GMobileId1)
                    .HasColumnName("G_MOBILE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GMobileStatus)
                    .HasColumnName("G_MOBILE_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GMobileStatus1)
                    .HasColumnName("G_MOBILE_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HostName)
                    .HasColumnName("HOST_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HostName1)
                    .HasColumnName("HOST_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ip1)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KmmId)
                    .HasColumnName("KMM_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KmmId1)
                    .HasColumnName("KMM_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KmmStatus)
                    .HasColumnName("KMM_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KmmStatus1)
                    .HasColumnName("KMM_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LdapStatus)
                    .HasColumnName("LDAP_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LdapStatus1)
                    .HasColumnName("LDAP_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Mac1)
                    .HasColumnName("MAC")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineId1)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Modified1)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NmapStatus)
                    .HasColumnName("NMAP_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NmapStatus1)
                    .HasColumnName("NMAP_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NodeClass)
                    .IsRequired()
                    .HasColumnName("node_class")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NodeClass1)
                    .IsRequired()
                    .HasColumnName("node_class")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NodeConfiguration)
                    .HasColumnName("node_configuration")
                    .HasColumnType("blob");

                entity.Property(e => e.NodeConfiguration1)
                    .HasColumnName("node_configuration")
                    .HasColumnType("blob");

                entity.Property(e => e.OsType)
                    .HasColumnName("OS_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OsType1)
                    .HasColumnName("OS_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PingStatus)
                    .HasColumnName("PING_STATUS")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PingStatus1)
                    .HasColumnName("PING_STATUS")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RealName)
                    .HasColumnName("REAL_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RealName1)
                    .HasColumnName("REAL_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RelayMachineId)
                    .HasColumnName("RELAY_MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RelayMachineId1)
                    .HasColumnName("RELAY_MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ScanSettingsId)
                    .HasColumnName("SCAN_SETTINGS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ScanSettingsId1)
                    .HasColumnName("SCAN_SETTINGS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ScanSpeed)
                    .HasColumnName("SCAN_SPEED")
                    .HasColumnType("decimal(6,2)");

                entity.Property(e => e.ScanSpeed1)
                    .HasColumnName("SCAN_SPEED")
                    .HasColumnType("decimal(6,2)");

                entity.Property(e => e.SnmpContact)
                    .HasColumnName("SNMP_CONTACT")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SnmpContact1)
                    .HasColumnName("SNMP_CONTACT")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SnmpStatus)
                    .HasColumnName("SNMP_STATUS")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SnmpStatus1)
                    .HasColumnName("SNMP_STATUS")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SnmpSysdescr)
                    .HasColumnName("SNMP_SYSDESCR")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.SnmpSysdescr1)
                    .HasColumnName("SNMP_SYSDESCR")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.SnmpUptime)
                    .HasColumnName("SNMP_UPTIME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SnmpUptime1)
                    .HasColumnName("SNMP_UPTIME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SnmpVersion)
                    .HasColumnName("SNMP_VERSION")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.SnmpVersion1)
                    .HasColumnName("SNMP_VERSION")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.SnmpWalkData)
                    .HasColumnName("SNMP_WALK_DATA")
                    .HasColumnType("longtext");

                entity.Property(e => e.SnmpWalkData1)
                    .HasColumnName("SNMP_WALK_DATA")
                    .HasColumnType("longtext");

                entity.Property(e => e.SocketStatus)
                    .HasColumnName("SOCKET_STATUS")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketStatus1)
                    .HasColumnName("SOCKET_STATUS")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VmwareStatus)
                    .HasColumnName("VMWARE_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VmwareStatus1)
                    .HasColumnName("VMWARE_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VmwareType)
                    .HasColumnName("VMWARE_TYPE")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.VmwareType1)
                    .HasColumnName("VMWARE_TYPE")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.WinrmStatus)
                    .HasColumnName("WINRM_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WinrmStatus1)
                    .HasColumnName("WINRM_STATUS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("workflow_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.WorkflowId1)
                    .HasColumnName("workflow_id")
                    .HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.RelayMachine)
                    .WithMany(p => p.Node1)
                    .HasForeignKey(d => d.RelayMachineId)
                    .HasConstraintName("NODE_RELAY_MACHINE_ID_MACHINE_ID_FK");
            });

            modelBuilder.Entity<NodeConnection>(entity =>
            {
                entity.ToTable("node_connection", "ORG1");

                entity.Property(e => e.NodeConnectionId)
                    .HasColumnName("node_connection_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.IncomingNodeId)
                    .HasColumnName("incoming_node_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.OutgoingNodeId)
                    .HasColumnName("outgoing_node_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<NodeLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.NodeId, e.LabelId});

                entity.ToTable("NODE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.NodeId)
                    .HasColumnName("NODE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NodeSnmpSystem>(entity =>
            {
                entity.ToTable("NODE_SNMP_SYSTEM", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullWalk)
                    .HasColumnName("FULL_WALK")
                    .HasColumnType("longtext");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uptime)
                    .HasColumnName("UPTIME")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("NOTIFICATION", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FfJson)
                    .HasColumnName("FF_JSON")
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasColumnName("FREQUENCY")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsAdvancedSearch)
                    .HasColumnName("IS_ADVANCED_SEARCH")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("LOCALE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NextRun)
                    .HasColumnName("NEXT_RUN")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.PushEnabled)
                    .HasColumnName("PUSH_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .IsUnicode(false);

                entity.Property(e => e.Recipient)
                    .HasColumnName("RECIPIENT")
                    .IsUnicode(false);

                entity.Property(e => e.ScopeUserRoleId)
                    .HasColumnName("SCOPE_USER_ROLE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<NotificationUserJt>(entity =>
            {
                entity.HasKey(e => new {e.NotificationId, e.UserId});

                entity.ToTable("NOTIFICATION_USER_JT", "ORG1");

                entity.HasIndex(e => e.NotificationId)
                    .HasName("NOTIFICATION_USER_JT_IDX_1");

                entity.HasIndex(e => e.UserId)
                    .HasName("NOTIFICATION_USER_JT_IDX_2");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("NOTIFICATION_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NotificationUserJt)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("NOTIFICATION_USER_JT_FK_1");
            });

            modelBuilder.Entity<NtserviceLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.NtserviceId, e.LabelId});

                entity.ToTable("NTSERVICE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.NtserviceId)
                    .HasColumnName("NTSERVICE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ObjectFieldDefinition>(entity =>
            {
                entity.HasKey(e => new {e.TypeName, e.FieldName});

                entity.ToTable("OBJECT_FIELD_DEFINITION", "ORG1");

                entity.HasIndex(e => e.FriendlyFieldName)
                    .HasName("FRIENDLY_FIELD_NAME_IDX");

                entity.Property(e => e.TypeName)
                    .HasColumnName("TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldType)
                    .HasColumnName("FIELD_TYPE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FriendlyFieldName)
                    .HasColumnName("FRIENDLY_FIELD_NAME")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ObjectHistory>(entity =>
            {
                entity.ToTable("OBJECT_HISTORY", "ORG1");

                entity.HasIndex(e => e.ChangeType)
                    .HasName("CHANGE_TYPE_IDX");

                entity.HasIndex(e => e.Name)
                    .HasName("NAME_IDX");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("OBJECT_ID_IDX");

                entity.HasIndex(e => e.Time)
                    .HasName("TIME_IDX");

                entity.HasIndex(e => e.TypeName)
                    .HasName("TYPE_NAME_IDX");

                entity.HasIndex(e => e.UserText)
                    .HasName("USER_TEXT_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time).HasColumnName("TIME");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserText)
                    .IsRequired()
                    .HasColumnName("USER_TEXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1)
                    .HasColumnName("VALUE1")
                    .IsUnicode(false);

                entity.Property(e => e.Value2)
                    .HasColumnName("VALUE2")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObjectHistoryConfiguration>(entity =>
            {
                entity.HasKey(e => e.TypeName);

                entity.ToTable("OBJECT_HISTORY_CONFIGURATION", "ORG1");

                entity.Property(e => e.TypeName)
                    .HasColumnName("TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FriendlyName)
                    .HasColumnName("FRIENDLY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<OperatingSystems>(entity =>
            {
                entity.ToTable("OPERATING_SYSTEMS", "ORG1");

                entity.HasIndex(e => e.CommonName)
                    .HasName("TINDEX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Arch)
                    .HasColumnName("ARCH")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Build)
                    .HasColumnName("BUILD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommonName)
                    .HasColumnName("COMMON_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Family)
                    .HasColumnName("FAMILY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MajorVersion)
                    .HasColumnName("MAJOR_VERSION")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Managed)
                    .HasColumnName("MANAGED")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Minor2Version)
                    .HasColumnName("MINOR2_VERSION")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.MinorVersion)
                    .HasColumnName("MINOR_VERSION")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OsFamilyId)
                    .HasColumnName("OS_FAMILY_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsProductId)
                    .HasColumnName("OS_PRODUCT_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchlinkOsTypeId)
                    .HasColumnName("PATCHLINK_OS_TYPE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sp)
                    .HasColumnName("SP")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<OvalStatus>(entity =>
            {
                entity.ToTable("OVAL_STATUS", "ORG1");

                entity.HasIndex(e => e.OvalDefinitionId)
                    .HasName("OVAL_DEFINITION_IDX");

                entity.HasIndex(e => new {e.MachineId, e.OvalDefinitionId})
                    .HasName("MACHINE_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OvalDefinitionId)
                    .HasColumnName("OVAL_DEFINITION_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Result)
                    .HasColumnName("RESULT")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatchFilter>(entity =>
            {
                entity.ToTable("PATCH_FILTER", "ORG1");

                entity.HasIndex(e => new {e.Name, e.UserId})
                    .HasName("NAME_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FindFields)
                    .HasColumnName("FIND_FIELDS")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchMachineStatus>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.PatchId, e.PatchProductId, e.PatchDetect});

                entity.ToTable("PATCH_MACHINE_STATUS", "ORG1");

                entity.HasIndex(e => new {e.PatchId, e.PatchProductId})
                    .HasName("PATCHPRD");

                entity.HasIndex(e => new {e.PatchId, e.PatchProductId, e.PatchDetect})
                    .HasName("PATCHPRDDETECT");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchId)
                    .HasColumnName("PATCH_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.PatchProductId)
                    .HasColumnName("PATCH_PRODUCT_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.PatchDetect)
                    .HasColumnName("PATCH_DETECT")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DetectErrorCode)
                    .HasColumnName("DETECT_ERROR_CODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DetectRdesc)
                    .HasColumnName("DETECT_RDESC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PatchApplicable)
                    .HasColumnName("PATCH_APPLICABLE")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchInstalled)
                    .HasColumnName("PATCH_INSTALLED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductInstalled)
                    .HasColumnName("PRODUCT_INSTALLED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("SCHEDULE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatusDt)
                    .HasColumnName("STATUS_DT")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<PatchlinkBulletinCount>(entity =>
            {
                entity.HasKey(e => new {e.BulletinId, e.PlatformId});

                entity.ToTable("PATCHLINK_BULLETIN_COUNT", "ORG1");

                entity.Property(e => e.BulletinId)
                    .HasColumnName("BULLETIN_ID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformId)
                    .HasColumnName("PLATFORM_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CacheSize)
                    .HasColumnName("CACHE_SIZE")
                    .HasColumnType("bigint(30) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Compliance)
                    .HasColumnName("COMPLIANCE")
                    .HasColumnType("bigint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Patched)
                    .HasColumnName("PATCHED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchesActive)
                    .HasColumnName("PATCHES_ACTIVE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchesApplicable)
                    .HasColumnName("PATCHES_APPLICABLE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchesDisabled)
                    .HasColumnName("PATCHES_DISABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchesInactive)
                    .HasColumnName("PATCHES_INACTIVE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchesSuperceded)
                    .HasColumnName("PATCHES_SUPERCEDED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchesTotal)
                    .HasColumnName("PATCHES_TOTAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Unpatched)
                    .HasColumnName("UNPATCHED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkBulletinMachineStatus>(entity =>
            {
                entity.HasKey(e => new {e.BulletinId, e.PlatformId, e.MachineId});

                entity.ToTable("PATCHLINK_BULLETIN_MACHINE_STATUS", "ORG1");

                entity.HasIndex(e => new {e.BulletinId, e.Status})
                    .HasName("PATCHLINK_BULLETIN_MACHINE_STATUS_KEY");

                entity.Property(e => e.BulletinId)
                    .HasColumnName("BULLETIN_ID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformId)
                    .HasColumnName("PLATFORM_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("enum('PATCHED','UNPATCHED','ERROR')")
                    .HasDefaultValueSql("PATCHED");
            });

            modelBuilder.Entity<PatchlinkMachineApplicablePackage>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.Patchuid, e.ApplicablePackage});

                entity.ToTable("PATCHLINK_MACHINE_APPLICABLE_PACKAGE", "ORG1");

                entity.HasIndex(e => new {e.Patchuid, e.DeployStatus})
                    .HasName("PATCHSTATUS");

                entity.HasIndex(e => new {e.Patchuid, e.ApplicablePackagePath, e.ApplicablePackage})
                    .HasName("PATCHSTATUS_PACKAGE");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Patchuid)
                    .HasColumnName("PATCHUID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicablePackage)
                    .HasColumnName("APPLICABLE_PACKAGE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicablePackagePath)
                    .IsRequired()
                    .HasColumnName("APPLICABLE_PACKAGE_PATH")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.DeployErrorCode)
                    .HasColumnName("DEPLOY_ERROR_CODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeployRcode)
                    .HasColumnName("DEPLOY_RCODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeployRdesc)
                    .HasColumnName("DEPLOY_RDESC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeployStatus)
                    .HasColumnName("DEPLOY_STATUS")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RollbackErrorCode)
                    .HasColumnName("ROLLBACK_ERROR_CODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RollbackRcode)
                    .HasColumnName("ROLLBACK_RCODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RollbackRdesc)
                    .HasColumnName("ROLLBACK_RDESC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RollbackStatus)
                    .HasColumnName("ROLLBACK_STATUS")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatchlinkMachineStatus>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.Patchuid});

                entity.ToTable("PATCHLINK_MACHINE_STATUS", "ORG1");

                entity.HasIndex(e => new {e.Patchuid, e.DeployStatus})
                    .HasName("PATCHSTATUS");

                entity.HasIndex(e => new {e.Patchuid, e.Status, e.DetectErrorCode})
                    .HasName("PATCHDETECTSTATUS");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Patchuid)
                    .HasColumnName("PATCHUID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeployAttemptCount)
                    .HasColumnName("DEPLOY_ATTEMPT_COUNT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeployErrorCode)
                    .HasColumnName("DEPLOY_ERROR_CODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeployRcode)
                    .HasColumnName("DEPLOY_RCODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeployRdesc)
                    .HasColumnName("DEPLOY_RDESC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeployStatus)
                    .HasColumnName("DEPLOY_STATUS")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeployStatusDt)
                    .HasColumnName("DEPLOY_STATUS_DT")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DetectErrorCode)
                    .HasColumnName("DETECT_ERROR_CODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsError)
                    .HasColumnName("IS_ERROR")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDeployAttempt)
                    .HasColumnName("MAX_DEPLOY_ATTEMPT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.MaxRollbackAttempt)
                    .HasColumnName("MAX_ROLLBACK_ATTEMPT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.RollbackAttemptCount)
                    .HasColumnName("ROLLBACK_ATTEMPT_COUNT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RollbackErrorCode)
                    .HasColumnName("ROLLBACK_ERROR_CODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RollbackRcode)
                    .HasColumnName("ROLLBACK_RCODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RollbackRdesc)
                    .HasColumnName("ROLLBACK_RDESC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RollbackStatus)
                    .HasColumnName("ROLLBACK_STATUS")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RollbackStatusDt)
                    .HasColumnName("ROLLBACK_STATUS_DT")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("SCHEDULE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDt)
                    .HasColumnName("STATUS_DT")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<PatchlinkPatchCount>(entity =>
            {
                entity.HasKey(e => e.Patchuid);

                entity.ToTable("PATCHLINK_PATCH_COUNT", "ORG1");

                entity.Property(e => e.Patchuid)
                    .HasColumnName("PATCHUID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Compliance)
                    .HasColumnName("COMPLIANCE")
                    .HasColumnType("bigint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Patched)
                    .HasColumnName("PATCHED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Unpatched)
                    .HasColumnName("UNPATCHED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkPatchLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.Patchuid, e.LabelId});

                entity.ToTable("PATCHLINK_PATCH_LABEL_JT", "ORG1");

                entity.HasIndex(e => new {e.LabelId, e.Patchuid})
                    .HasName("LABEL_ID");

                entity.Property(e => e.Patchuid)
                    .HasColumnName("PATCHUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkPatchStatus>(entity =>
            {
                entity.HasKey(e => e.Patchuid);

                entity.ToTable("PATCHLINK_PATCH_STATUS", "ORG1");

                entity.HasIndex(e => new {e.Status, e.Patchuid})
                    .HasName("STATUS_PATCH");

                entity.Property(e => e.Patchuid)
                    .HasColumnName("PATCHUID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsSuperceded)
                    .HasColumnName("IS_SUPERCEDED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkSchedule>(entity =>
            {
                entity.ToTable("PATCHLINK_SCHEDULE", "ORG1");

                entity.HasIndex(e => new {e.KonductorTaskType, e.Id})
                    .HasName("TASKTYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AlertId)
                    .HasColumnName("ALERT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DelayScheduleBy)
                    .HasColumnName("DELAY_SCHEDULE_BY")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeployAllPatches)
                    .HasColumnName("DEPLOY_ALL_PATCHES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeployTimeout)
                    .HasColumnName("DEPLOY_TIMEOUT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("10800");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DetectAllPatches)
                    .HasColumnName("DETECT_ALL_PATCHES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DetectTimeout)
                    .HasColumnName("DETECT_TIMEOUT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("7200");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KeepAlive)
                    .HasColumnName("KEEP_ALIVE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KonductorTaskType)
                    .HasColumnName("KONDUCTOR_TASK_TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastRun).HasColumnName("LAST_RUN");

                entity.Property(e => e.LimitPrompt)
                    .HasColumnName("LIMIT_PROMPT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MatchMachineLabels)
                    .HasColumnName("MATCH_MACHINE_LABELS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxDeployAttempt)
                    .HasColumnName("MAX_DEPLOY_ATTEMPT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.MaxRollbackAttempt)
                    .HasColumnName("MAX_ROLLBACK_ATTEMPT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.MaxRunDuration)
                    .HasColumnName("MAX_RUN_DURATION")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PatchAction)
                    .HasColumnName("PATCH_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatchCompletedMessage)
                    .HasColumnName("PATCH_COMPLETED_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.PatchProgressMessage)
                    .HasColumnName("PATCH_PROGRESS_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.PatchlinkScheduleRunId)
                    .HasColumnName("PATCHLINK_SCHEDULE_RUN_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.QueueDisconnected)
                    .HasColumnName("QUEUE_DISCONNECTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RebootAction)
                    .HasColumnName("REBOOT_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RebootAuto)
                    .HasColumnName("REBOOT_AUTO")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RebootDelayInterval)
                    .HasColumnName("REBOOT_DELAY_INTERVAL")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.RebootMessage)
                    .HasColumnName("REBOOT_MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.RebootMode)
                    .HasColumnName("REBOOT_MODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RebootTimeout)
                    .HasColumnName("REBOOT_TIMEOUT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RepromptCount)
                    .HasColumnName("REPROMPT_COUNT")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.RepromptInterval)
                    .HasColumnName("REPROMPT_INTERVAL")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RollbackAllPatches)
                    .HasColumnName("ROLLBACK_ALL_PATCHES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RollbackTimeout)
                    .HasColumnName("ROLLBACK_TIMEOUT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("10800");

                entity.Property(e => e.ShowPatchProgress)
                    .HasColumnName("SHOW_PATCH_PROGRESS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkScheduleDeployLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.PatchlinkScheduleId, e.LabelId});

                entity.ToTable("PATCHLINK_SCHEDULE_DEPLOY_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkScheduleDetectLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.PatchlinkScheduleId, e.LabelId});

                entity.ToTable("PATCHLINK_SCHEDULE_DETECT_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkScheduleLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.PatchlinkScheduleId, e.LabelId});

                entity.ToTable("PATCHLINK_SCHEDULE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkScheduleMachineStatus>(entity =>
            {
                entity.HasKey(e => new {e.PatchlinkScheduleId, e.MachineId});

                entity.ToTable("PATCHLINK_SCHEDULE_MACHINE_STATUS", "ORG1");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeployRollbackFailures)
                    .HasColumnName("DEPLOY_ROLLBACK_FAILURES")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DetectFailures)
                    .HasColumnName("DETECT_FAILURES")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastRun).HasColumnName("LAST_RUN");

                entity.Property(e => e.Notpatched)
                    .HasColumnName("NOTPATCHED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Patched)
                    .HasColumnName("PATCHED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkScheduleOsJt>(entity =>
            {
                entity.HasKey(e => new {e.PatchlinkScheduleId, e.OsId});

                entity.ToTable("PATCHLINK_SCHEDULE_OS_JT", "ORG1");

                entity.HasIndex(e => e.OsId)
                    .HasName("OS_IDX");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsId)
                    .HasColumnName("OS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkScheduleRollbackLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.PatchlinkScheduleId, e.LabelId});

                entity.ToTable("PATCHLINK_SCHEDULE_ROLLBACK_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkScheduleRun>(entity =>
            {
                entity.ToTable("PATCHLINK_SCHEDULE_RUN", "ORG1");

                entity.HasIndex(e => e.PatchlinkScheduleId)
                    .HasName("PSR_PATCHLINK_SCHEDULE_ID_KEY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("LAST_UPDATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RunTime)
                    .HasColumnName("RUN_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<PatchlinkScheduleRunCounts>(entity =>
            {
                entity.ToTable("PATCHLINK_SCHEDULE_RUN_COUNTS", "ORG1");

                entity.HasIndex(e => e.PatchlinkScheduleId)
                    .HasName("PSRC_PATCHLINK_SCHEDULE_ID_KEY");

                entity.HasIndex(e => e.PatchlinkScheduleRunId)
                    .HasName("PSRC_PATCHLINK_SCHEDULE_RUN_ID_KEY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Completed)
                    .HasColumnName("COMPLETED")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Downloading)
                    .HasColumnName("DOWNLOADING")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Executing)
                    .HasColumnName("EXECUTING")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Failed)
                    .HasColumnName("FAILED")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Offline)
                    .HasColumnName("OFFLINE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PatchlinkScheduleRunId)
                    .HasColumnName("PATCHLINK_SCHEDULE_RUN_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Paused)
                    .HasColumnName("PAUSED")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pending)
                    .HasColumnName("PENDING")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rebooting)
                    .HasColumnName("REBOOTING")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Succeeded)
                    .HasColumnName("SUCCEEDED")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PatchlinkScheduleRunLog>(entity =>
            {
                entity.ToTable("PATCHLINK_SCHEDULE_RUN_LOG", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("PSRL_MACHINE_ID");

                entity.HasIndex(e => e.PatchlinkScheduleId)
                    .HasName("PSRL_PATCHLINK_SCHEDULE_ID");

                entity.HasIndex(e => e.PatchlinkScheduleRunId)
                    .HasName("PSRL_PATCHLINK_SCHEDULE_RUN_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EndTime)
                    .HasColumnName("END_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PatchlinkScheduleRunId)
                    .HasColumnName("PATCHLINK_SCHEDULE_RUN_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatchlinkScheduleRunMachine>(entity =>
            {
                entity.ToTable("PATCHLINK_SCHEDULE_RUN_MACHINE", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("PSRM_MACHINE_ID");

                entity.HasIndex(e => e.PatchlinkScheduleId)
                    .HasName("PSRM_PATCHLINK_SCHEDULE_ID");

                entity.HasIndex(e => e.PatchlinkScheduleRunId)
                    .HasName("PSRM_PATCHLINK_SCHEDULE_RUN_ID");

                entity.HasIndex(e => e.Status)
                    .HasName("PSRM_STATUS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PatchlinkScheduleId)
                    .HasColumnName("PATCHLINK_SCHEDULE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PatchlinkScheduleRunId)
                    .HasColumnName("PATCHLINK_SCHEDULE_RUN_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Portal>(entity =>
            {
                entity.ToTable("PORTAL", "ORG1");

                entity.HasIndex(e => e.KbotId)
                    .HasName("KBOT_IDX");

                entity.HasIndex(e => e.SoftwareId)
                    .HasName("SOFTWARE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApprovalFrequency)
                    .HasColumnName("APPROVAL_FREQUENCY")
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DisplayCost)
                    .HasColumnName("DISPLAY_COST")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DocfileName)
                    .HasColumnName("DOCFILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocfileSize)
                    .HasColumnName("DOCFILE_SIZE")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmailManagement)
                    .HasColumnName("EMAIL_MANAGEMENT")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmailUser)
                    .HasColumnName("EMAIL_USER")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdServiceId)
                    .HasColumnName("HD_SERVICE_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.InstallationNotes)
                    .HasColumnName("INSTALLATION_NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.KbotId)
                    .HasColumnName("KBOT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LicenseId)
                    .HasColumnName("LICENSE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LicenseText)
                    .HasColumnName("LICENSE_TEXT")
                    .IsUnicode(false);

                entity.Property(e => e.MiId)
                    .HasColumnName("MI_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.ProductKey)
                    .HasColumnName("PRODUCT_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RequiresKey)
                    .HasColumnName("REQUIRES_KEY")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RestrictMachine)
                    .HasColumnName("RESTRICT_MACHINE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SamAttachedFileId)
                    .HasColumnName("SAM_ATTACHED_FILE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SamCatalogId)
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SOFTWARE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnitCost)
                    .HasColumnName("UNIT_COST")
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VendorLicenseText)
                    .HasColumnName("VENDOR_LICENSE_TEXT")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<PortalLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.PortalId, e.LabelId});

                entity.ToTable("PORTAL_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.PortalId)
                    .HasColumnName("PORTAL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProcessLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.ProcessId, e.LabelId});

                entity.ToTable("PROCESS_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.ProcessId)
                    .HasColumnName("PROCESS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProvisionConfig>(entity =>
            {
                entity.ToTable("PROVISION_CONFIG", "ORG1");

                entity.HasIndex(e => e.RelayMachineId)
                    .HasName("PROVISION_RELAY_MACHINE_ID_MACHINE_ID_FK_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AndRemoveKuid)
                    .HasColumnName("AND_REMOVE_KUID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CredentialIdLinux)
                    .HasColumnName("CREDENTIAL_ID_LINUX")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CredentialIdMac)
                    .HasColumnName("CREDENTIAL_ID_MAC")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CredentialIdWin)
                    .HasColumnName("CREDENTIAL_ID_WIN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Debug)
                    .HasColumnName("DEBUG")
                    .HasColumnType("smallint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DnsLookupEnabled)
                    .HasColumnName("DNS_LOOKUP_ENABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DnsServer)
                    .HasColumnName("DNS_SERVER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DnsTimeout)
                    .HasColumnName("DNS_TIMEOUT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.HostnameList)
                    .HasColumnName("HOSTNAME_LIST")
                    .HasColumnType("longtext");

                entity.Property(e => e.IpList)
                    .HasColumnName("IP_LIST")
                    .HasColumnType("longtext");

                entity.Property(e => e.IpRange)
                    .HasColumnName("IP_RANGE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KboxClientShareName)
                    .IsRequired()
                    .HasColumnName("KBOX_CLIENT_SHARE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KboxServerName)
                    .IsRequired()
                    .HasColumnName("KBOX_SERVER_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastRun)
                    .HasColumnName("LAST_RUN")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LogLevel)
                    .HasColumnName("LOG_LEVEL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .IsUnicode(false);

                entity.Property(e => e.RelayMachineId)
                    .HasColumnName("RELAY_MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RemoveEnabled)
                    .HasColumnName("REMOVE_ENABLED")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("auto");

                entity.Property(e => e.UnixPortBypass)
                    .HasColumnName("UNIX_PORT_BYPASS")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UnixPortList)
                    .HasColumnName("UNIX_PORT_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.UnixScanTimeout)
                    .HasColumnName("UNIX_SCAN_TIMEOUT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.WinTryWinrm)
                    .HasColumnName("WIN_TRY_WINRM")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WinWinrmPort)
                    .HasColumnName("WIN_WINRM_PORT")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.WindowsAgentPort)
                    .HasColumnName("WINDOWS_AGENT_PORT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WindowsPortBypass)
                    .HasColumnName("WINDOWS_PORT_BYPASS")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WindowsPortList)
                    .HasColumnName("WINDOWS_PORT_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.WindowsScanTimeout)
                    .HasColumnName("WINDOWS_SCAN_TIMEOUT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("2");

                entity.HasOne(d => d.RelayMachine)
                    .WithMany(p => p.ProvisionConfig)
                    .HasForeignKey(d => d.RelayMachineId)
                    .HasConstraintName("PROVISION_RELAY_MACHINE_ID_MACHINE_ID_FK");
            });

            modelBuilder.Entity<ProvisionNode>(entity =>
            {
                entity.ToTable("PROVISION_NODE", "ORG1");

                entity.HasIndex(e => e.ProvisionConfigId)
                    .HasName("PROVISION_CONFIG_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Action)
                    .HasColumnName("ACTION")
                    .HasColumnType("enum('null','I','U')");

                entity.Property(e => e.AgentInstalled)
                    .HasColumnName("AGENT_INSTALLED")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ErrorCode)
                    .HasColumnName("ERROR_CODE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FailureType)
                    .HasColumnName("FAILURE_TYPE")
                    .HasColumnType("enum('null','kbox','network','agent')");

                entity.Property(e => e.HostName)
                    .HasColumnName("HOST_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KboxId)
                    .HasColumnName("KBOX_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Kuid)
                    .IsRequired()
                    .HasColumnName("KUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OperatingSystem)
                    .HasColumnName("OPERATING_SYSTEM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PingStatus)
                    .HasColumnName("PING_STATUS")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProvisionConfigId)
                    .HasColumnName("PROVISION_CONFIG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProvisioningLog)
                    .HasColumnName("PROVISIONING_LOG")
                    .HasColumnType("longblob");

                entity.Property(e => e.ProvisioningStatus)
                    .IsRequired()
                    .HasColumnName("PROVISIONING_STATUS")
                    .HasColumnType("enum('not started','preparing','queued','running','succeeded','failed')")
                    .HasDefaultValueSql("not started");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RemoteAirwatchHost>(entity =>
            {
                entity.ToTable("REMOTE_AIRWATCH_HOST", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_AIRWATCH_HOST_REMOTE_HOST_ID_FK_idx");

                entity.Property(e => e.RemoteAirwatchHostId)
                    .HasColumnName("REMOTE_AIRWATCH_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApiKeyEnc)
                    .HasColumnName("API_KEY_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.AwId)
                    .HasColumnName("AW_ID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ServiceHost)
                    .HasColumnName("SERVICE_HOST")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteAirwatchHost)
                    .HasForeignKey(d => d.RemoteHostId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("REMOTE_AIRWATCH_HOST_REMOTE_HOST_ID_FK");
            });

            modelBuilder.Entity<RemoteChromeosHost>(entity =>
            {
                entity.ToTable("REMOTE_CHROMEOS_HOST", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_CHROMEOS_HOST_REMOTE_HOST_ID_FK_idx");

                entity.Property(e => e.RemoteChromeosHostId)
                    .HasColumnName("REMOTE_CHROMEOS_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ChromeosId)
                    .HasColumnName("CHROMEOS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteChromeosHost)
                    .HasForeignKey(d => d.RemoteHostId)
                    .HasConstraintName("REMOTE_CHROMEOS_HOST_REMOTE_HOST_ID_FK");
            });

            modelBuilder.Entity<RemoteGSuiteHost>(entity =>
            {
                entity.ToTable("REMOTE_G_SUITE_HOST", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_G_SUITE_HOST_REMOTE_HOST_ID_FK_idx");

                entity.Property(e => e.RemoteGSuiteHostId)
                    .HasColumnName("REMOTE_G_SUITE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("RESOURCE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteGSuiteHost)
                    .HasForeignKey(d => d.RemoteHostId)
                    .HasConstraintName("REMOTE_G_SUITE_HOST_REMOTE_HOST_ID_FK");
            });

            modelBuilder.Entity<RemoteHost>(entity =>
            {
                entity.ToTable("REMOTE_HOST", "ORG1");

                entity.HasIndex(e => e.CredentialId)
                    .HasName("REMOTE_HOST_CREDENTIAL_ID");

                entity.HasIndex(e => e.Protocol)
                    .HasName("REMOTE_HOST_PROTOCOL_ID");

                entity.HasIndex(e => e.RelayMachineId)
                    .HasName("REMOTE_HOST_RELAY_MACHINE_ID_FK_idx");

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetSubtypeId)
                    .HasColumnName("ASSET_SUBTYPE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CredentialId)
                    .HasColumnName("CREDENTIAL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DnsServer)
                    .HasColumnName("DNS_SERVER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasColumnName("HOST_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogLevel)
                    .HasColumnName("LOG_LEVEL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Protocol)
                    .HasColumnName("PROTOCOL")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RelayMachineId)
                    .HasColumnName("RELAY_MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.ProtocolNavigation)
                    .WithMany(p => p.RemoteHost)
                    .HasForeignKey(d => d.Protocol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("REMOTE_HOST_PROTOCOL_ID_FK");

                entity.HasOne(d => d.RelayMachine)
                    .WithMany(p => p.RemoteHost)
                    .HasForeignKey(d => d.RelayMachineId)
                    .HasConstraintName("REMOTE_HOST_RELAY_MACHINE_ID_FK");
            });

            modelBuilder.Entity<RemoteHostKuid>(entity =>
            {
                entity.ToTable("REMOTE_HOST_KUID", "ORG1");

                entity.HasIndex(e => e.Kuid)
                    .HasName("REMOTE_HOST_KUID_IDX");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_HOST_KUID_HOST_ID_IDX");

                entity.Property(e => e.RemoteHostKuidId)
                    .HasColumnName("REMOTE_HOST_KUID_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Kuid)
                    .HasColumnName("KUID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastResult)
                    .HasColumnName("LAST_RESULT")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteHostKuid)
                    .HasForeignKey(d => d.RemoteHostId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("REMOTE_HOST_KUID_HOST_ID");
            });

            modelBuilder.Entity<RemoteHostProtocol>(entity =>
            {
                entity.ToTable("REMOTE_HOST_PROTOCOL", "ORG1");

                entity.Property(e => e.RemoteHostProtocolId)
                    .HasColumnName("REMOTE_HOST_PROTOCOL_ID")
                    .HasColumnType("bigint(2) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("SOURCE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RemoteKmmHost>(entity =>
            {
                entity.ToTable("REMOTE_KMM_HOST", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_KMM_HOST_REMOTE_HOST_ID_FK_idx");

                entity.Property(e => e.RemoteKmmHostId)
                    .HasColumnName("REMOTE_KMM_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KmmId)
                    .IsRequired()
                    .HasColumnName("KMM_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Realm)
                    .IsRequired()
                    .HasColumnName("REALM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteKmmHost)
                    .HasForeignKey(d => d.RemoteHostId)
                    .HasConstraintName("REMOTE_KMM_HOST_REMOTE_HOST_ID_FK");
            });

            modelBuilder.Entity<RemoteShellHost>(entity =>
            {
                entity.ToTable("REMOTE_SHELL_HOST", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_SHELL_HOST_REMOTE_HOST_ID_FK");

                entity.Property(e => e.RemoteShellHostId)
                    .HasColumnName("REMOTE_SHELL_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ExecutionShell)
                    .HasColumnName("EXECUTION_SHELL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OsType)
                    .HasColumnName("OS_TYPE")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ShellProtocol)
                    .HasColumnName("SHELL_PROTOCOL")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.SudoPasswordEnc)
                    .HasColumnName("SUDO_PASSWORD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.Validated)
                    .HasColumnName("VALIDATED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteShellHost)
                    .HasForeignKey(d => d.RemoteHostId)
                    .HasConstraintName("REMOTE_SHELL_HOST_REMOTE_HOST_ID_FK");
            });

            modelBuilder.Entity<RemoteSnmpHost>(entity =>
            {
                entity.ToTable("REMOTE_SNMP_HOST", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_SNMP_HOST_REMOTE_HOST_ID_FK");

                entity.Property(e => e.RemoteSnmpHostId)
                    .HasColumnName("REMOTE_SNMP_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeviceType)
                    .HasColumnName("DEVICE_TYPE")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.InventoryType)
                    .HasColumnName("INVENTORY_TYPE")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SnmpVersion)
                    .HasColumnName("SNMP_VERSION")
                    .HasColumnType("int(10) unsigned");

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteSnmpHost)
                    .HasForeignKey(d => d.RemoteHostId)
                    .HasConstraintName("REMOTE_SNMP_HOST_REMOTE_HOST_ID_FK");
            });

            modelBuilder.Entity<RemoteVmwareHost>(entity =>
            {
                entity.ToTable("REMOTE_VMWARE_HOST", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_VMWARE_HOST_REMOTE_HOST_ID_FK_idx");

                entity.Property(e => e.RemoteVmwareHostId)
                    .HasColumnName("REMOTE_VMWARE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.VmwareType)
                    .HasColumnName("VMWARE_TYPE")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteVmwareHost)
                    .HasForeignKey(d => d.RemoteHostId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("REMOTE_VMWARE_HOST_REMOTE_HOST_ID_FK");
            });

            modelBuilder.Entity<RemoteWsmanHost>(entity =>
            {
                entity.ToTable("REMOTE_WSMAN_HOST", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("REMOTE_WSMAN_HOST_REMOTE_HOST_ID_FK_idx");

                entity.Property(e => e.RemoteWsmanHostId)
                    .HasColumnName("REMOTE_WSMAN_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RequireKerberos)
                    .HasColumnName("REQUIRE_KERBEROS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transport)
                    .HasColumnName("TRANSPORT")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.RemoteWsmanHost)
                    .HasForeignKey(d => d.RemoteHostId)
                    .HasConstraintName("REMOTE_WSMAN_HOST_REMOTE_HOST_ID_FK");
            });

            modelBuilder.Entity<ReplicationShare>(entity =>
            {
                entity.ToTable("REPLICATION_SHARE", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdDestination)
                    .HasColumnName("CREDENTIAL_ID_DESTINATION")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdDownload)
                    .HasColumnName("CREDENTIAL_ID_DOWNLOAD")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DestinationDir)
                    .HasColumnName("DESTINATION_DIR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DoRepl1)
                    .HasColumnName("DO_REPL1")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DownloadDir)
                    .HasColumnName("DOWNLOAD_DIR")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ErrorCodeForHalt)
                    .HasColumnName("ERROR_CODE_FOR_HALT")
                    .HasColumnType("bigint(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FailoverToKbox)
                    .HasColumnName("FAILOVER_TO_KBOX")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.InventoryRequested)
                    .HasColumnName("INVENTORY_REQUESTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsUnc)
                    .HasColumnName("IS_UNC")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaximumBandwidth)
                    .HasColumnName("MAXIMUM_BANDWIDTH")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReplicateAllLstFiles)
                    .HasColumnName("REPLICATE_ALL_LST_FILES")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReplicateAppPatches)
                    .HasColumnName("REPLICATE_APP_PATCHES")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReplicateDellPackages)
                    .HasColumnName("REPLICATE_DELL_PACKAGES")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RestartTaskAutomatically)
                    .HasColumnName("RESTART_TASK_AUTOMATICALLY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RestrictedBandwidth)
                    .HasColumnName("RESTRICTED_BANDWIDTH")
                    .HasColumnType("bigint(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TodoBytes)
                    .HasColumnName("TODO_BYTES")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TodoFiles)
                    .HasColumnName("TODO_FILES")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ReportField>(entity =>
            {
                entity.ToTable("REPORT_FIELD", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Alias)
                    .HasColumnName("ALIAS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlwaysSubquery)
                    .HasColumnName("ALWAYS_SUBQUERY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BusinessObjectId)
                    .HasColumnName("BUSINESS_OBJECT_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CalculatedField)
                    .HasColumnName("CALCULATED_FIELD")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.FieldType)
                    .HasColumnName("FIELD_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasColumnName("FIELDNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupSequence)
                    .HasColumnName("GROUP_SEQUENCE")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideField)
                    .HasColumnName("HIDE_FIELD")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideWhere)
                    .HasColumnName("HIDE_WHERE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InternalDescription)
                    .IsRequired()
                    .HasColumnName("INTERNAL_DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.IsAdvancedSearch)
                    .HasColumnName("IS_ADVANCED_SEARCH")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsClassic)
                    .HasColumnName("IS_CLASSIC")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsSmarty)
                    .HasColumnName("IS_SMARTY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsSystem)
                    .HasColumnName("IS_SYSTEM")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JoinName)
                    .IsRequired()
                    .HasColumnName("JOIN_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SelectExpr)
                    .IsRequired()
                    .HasColumnName("SELECT_EXPR")
                    .IsUnicode(false);

                entity.Property(e => e.SortExpr)
                    .IsRequired()
                    .HasColumnName("SORT_EXPR")
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportFieldGroup>(entity =>
            {
                entity.ToTable("REPORT_FIELD_GROUP", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BusinessObjectId)
                    .HasColumnName("BUSINESS_OBJECT_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.InternalDescription)
                    .IsRequired()
                    .HasColumnName("INTERNAL_DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.IsAdvancedSearch)
                    .HasColumnName("IS_ADVANCED_SEARCH")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsClassic)
                    .HasColumnName("IS_CLASSIC")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsSmarty)
                    .HasColumnName("IS_SMARTY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsSystem)
                    .HasColumnName("IS_SYSTEM")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sequence)
                    .HasColumnName("SEQUENCE")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportJoin>(entity =>
            {
                entity.ToTable("REPORT_JOIN", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BusinessObjectId)
                    .HasColumnName("BUSINESS_OBJECT_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FilterLink)
                    .IsRequired()
                    .HasColumnName("FILTER_LINK")
                    .IsUnicode(false);

                entity.Property(e => e.FilterTables)
                    .IsRequired()
                    .HasColumnName("FILTER_TABLES")
                    .IsUnicode(false);

                entity.Property(e => e.Grouped)
                    .HasColumnName("GROUPED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InternalDescription)
                    .IsRequired()
                    .HasColumnName("INTERNAL_DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.IsClassic)
                    .HasColumnName("IS_CLASSIC")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsSmarty)
                    .HasColumnName("IS_SMARTY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsSystem)
                    .HasColumnName("IS_SYSTEM")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.JoinExpr)
                    .IsRequired()
                    .HasColumnName("JOIN_EXPR")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Requires)
                    .HasColumnName("REQUIRES")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportObject>(entity =>
            {
                entity.ToTable("REPORT_OBJECT", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.GroupbyColumn)
                    .HasColumnName("GROUPBY_COLUMN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdHint)
                    .HasColumnName("ID_HINT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InternalDescription)
                    .IsRequired()
                    .HasColumnName("INTERNAL_DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.IsAdvancedSearch)
                    .HasColumnName("IS_ADVANCED_SEARCH")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsClassic)
                    .HasColumnName("IS_CLASSIC")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsReporting)
                    .HasColumnName("IS_REPORTING")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsSmarty)
                    .HasColumnName("IS_SMARTY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsSystem)
                    .HasColumnName("IS_SYSTEM")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkTemplate)
                    .HasColumnName("LINK_TEMPLATE")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredJoins)
                    .HasColumnName("REQUIRED_JOINS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubsystemId)
                    .HasColumnName("SUBSYSTEM_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubsystemName)
                    .HasColumnName("SUBSYSTEM_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubtopicOnly)
                    .HasColumnName("SUBTOPIC_ONLY")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tablename)
                    .HasColumnName("TABLENAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Where)
                    .HasColumnName("WHERE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportSchedule>(entity =>
            {
                entity.ToTable("REPORT_SCHEDULE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentType)
                    .HasColumnName("ATTACHMENT_TYPE")
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CcList)
                    .HasColumnName("CC_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("FILE_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("HTML");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("LOCALE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.NextRun)
                    .HasColumnName("NEXT_RUN")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ReportId)
                    .HasColumnName("REPORT_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ReportType)
                    .HasColumnName("REPORT_TYPE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SendWhenResult)
                    .HasColumnName("SEND_WHEN_RESULT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SmartyReport)
                    .HasColumnName("SMARTY_REPORT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UseTimeZones)
                    .HasColumnName("USE_TIME_ZONES")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportSoftwareCatalogException>(entity =>
            {
                entity.HasKey(e => e.SamCatalogId);

                entity.ToTable("REPORT_SOFTWARE_CATALOG_EXCEPTION", "ORG1");

                entity.Property(e => e.SamCatalogId)
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SamAttachedFile>(entity =>
            {
                entity.ToTable("SAM_ATTACHED_FILE", "ORG1");

                entity.HasIndex(e => e.DontReplicate)
                    .HasName("REPLICATION_IX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Checksum)
                    .HasColumnName("CHECKSUM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DontReplicate)
                    .HasColumnName("DONT_REPLICATE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasColumnName("FILE_SIZE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MinorVersion)
                    .IsRequired()
                    .HasColumnName("MINOR_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SamCatalogId)
                    .IsRequired()
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SamCatalogFilter>(entity =>
            {
                entity.ToTable("SAM_CATALOG_FILTER", "ORG1");

                entity.HasIndex(e => new {e.Name, e.UserId})
                    .HasName("NAME_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FindFields)
                    .HasColumnName("FIND_FIELDS")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SamCatalogLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.SamCatalogId, e.LabelId});

                entity.ToTable("SAM_CATALOG_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.SamCatalogId)
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SamComplianceDetail>(entity =>
            {
                entity.ToTable("SAM_COMPLIANCE_DETAIL", "ORG1");

                entity.HasIndex(e => e.SamComplianceSummaryEditionId)
                    .HasName("SAM_COMPLIANCE_DETAIL_SAM_COMPLIANCE_SUMMARY_EDITION_ID_IX");

                entity.HasIndex(e => e.SamComplianceSummaryProductId)
                    .HasName("SAM_COMPLIANCE_DETAIL_SAM_COMPLIANCE_SUMMARY_PRODUCT_ID_IX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.InstallCount)
                    .HasColumnName("INSTALL_COUNT")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LicenseCount)
                    .HasColumnName("LICENSE_COUNT")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LicenseCoverage)
                    .IsRequired()
                    .HasColumnName("LICENSE_COVERAGE")
                    .HasColumnType("enum('original','downgrade','upgrade','none')")
                    .HasDefaultValueSql("none");

                entity.Property(e => e.MeteredCount)
                    .HasColumnName("METERED_COUNT")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MeteringEnabled)
                    .HasColumnName("METERING_ENABLED")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.NotUsed30)
                    .HasColumnName("NOT_USED_30")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NotUsed60)
                    .HasColumnName("NOT_USED_60")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NotUsed90)
                    .HasColumnName("NOT_USED_90")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Risk)
                    .HasColumnName("RISK")
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.SamCatalogId)
                    .IsRequired()
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.SamComplianceSummaryEditionId)
                    .HasColumnName("SAM_COMPLIANCE_SUMMARY_EDITION_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SamComplianceSummaryProductId)
                    .HasColumnName("SAM_COMPLIANCE_SUMMARY_PRODUCT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Surplus)
                    .HasColumnName("SURPLUS")
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.Usage30)
                    .HasColumnName("USAGE_30")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Usage60)
                    .HasColumnName("USAGE_60")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Usage90)
                    .HasColumnName("USAGE_90")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Variance)
                    .HasColumnName("VARIANCE")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<SamComplianceSummary>(entity =>
            {
                entity.ToTable("SAM_COMPLIANCE_SUMMARY", "ORG1");

                entity.HasIndex(e => e.Edition)
                    .HasName("EDITION_IX");

                entity.HasIndex(e => e.ProductName)
                    .HasName("PRODUCT_NAME_IX");

                entity.HasIndex(e => e.Publisher)
                    .HasName("PUBLISHER_IX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Edition)
                    .HasColumnName("EDITION")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.InstallCount)
                    .HasColumnName("INSTALL_COUNT")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsSuite)
                    .HasColumnName("IS_SUITE")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.LicenseCount)
                    .HasColumnName("LICENSE_COUNT")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MeteredCount)
                    .HasColumnName("METERED_COUNT")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MeteringEnabled)
                    .HasColumnName("METERING_ENABLED")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.MultiplePublishers)
                    .HasColumnName("MULTIPLE_PUBLISHERS")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.NegativeChildVariance)
                    .HasColumnName("NEGATIVE_CHILD_VARIANCE")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.NotUsed30)
                    .HasColumnName("NOT_USED_30")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NotUsed60)
                    .HasColumnName("NOT_USED_60")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NotUsed90)
                    .HasColumnName("NOT_USED_90")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("PRODUCT_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasColumnName("PUBLISHER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Risk)
                    .HasColumnName("RISK")
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.SummaryType)
                    .IsRequired()
                    .HasColumnName("SUMMARY_TYPE")
                    .HasColumnType("enum('Product','ProductEdition')");

                entity.Property(e => e.Surplus)
                    .HasColumnName("SURPLUS")
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.Usage30)
                    .HasColumnName("USAGE_30")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Usage60)
                    .HasColumnName("USAGE_60")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Usage90)
                    .HasColumnName("USAGE_90")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Variance)
                    .HasColumnName("VARIANCE")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<SamCount>(entity =>
            {
                entity.HasKey(e => new {e.SamCatalogId, e.SamType});

                entity.ToTable("SAM_COUNT", "ORG1");

                entity.Property(e => e.SamCatalogId)
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SamType)
                    .HasColumnName("SAM_TYPE")
                    .HasColumnType("enum('APPLICATION','SUITE','FILE','MOBILE_APPLICATION','MOBILE_FILE')")
                    .HasDefaultValueSql("APPLICATION");

                entity.Property(e => e.InstalledOn)
                    .HasColumnName("INSTALLED_ON")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecentlyAdded)
                    .HasColumnName("RECENTLY_ADDED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecentlyRemoved)
                    .HasColumnName("RECENTLY_REMOVED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SamMachineJt>(entity =>
            {
                entity.HasKey(e => new {e.MachineId, e.SamCatalogId, e.MinorVersion, e.AppV});

                entity.ToTable("SAM_MACHINE_JT", "ORG1");

                entity.HasIndex(e => e.SamCatalogId)
                    .HasName("IDX_CATALOG_ID");

                entity.HasIndex(e => new {e.MachineId, e.SamCatalogId})
                    .HasName("IDX_MACHINE_CATALOG");

                entity.HasIndex(e => new {e.SamCatalogId, e.MaxVersion, e.MachineId})
                    .HasName("SMJT_MAX");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SamCatalogId)
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.MinorVersion)
                    .HasColumnName("MINOR_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppV)
                    .HasColumnName("APP_V")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxVersion)
                    .HasColumnName("MAX_VERSION")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SuiteId)
                    .HasColumnName("SUITE_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SamMachineTerminatedApps>(entity =>
            {
                entity.ToTable("SAM_MACHINE_TERMINATED_APPS", "ORG1");

                entity.HasIndex(e => e.End)
                    .HasName("IDX_END");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.End)
                    .HasColumnName("END")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.IsMobile)
                    .HasColumnName("IS_MOBILE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TitledApplicationId)
                    .IsRequired()
                    .HasColumnName("TITLED_APPLICATION_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.UserData)
                    .HasColumnName("USER_DATA")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SamMeter>(entity =>
            {
                entity.ToTable("SAM_METER", "ORG1");

                entity.HasIndex(e => e.MachineId)
                    .HasName("SAM_METER_KEY")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LastReport)
                    .HasColumnName("LAST_REPORT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("2013-01-01 00:00:00 UTC");

                entity.Property(e => e.LastUpload)
                    .HasColumnName("LAST_UPLOAD")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SamMeterData>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.ServerDate});

                entity.ToTable("SAM_METER_DATA", "ORG1");

                entity.HasIndex(e => e.End)
                    .HasName("IDX_END");

                entity.HasIndex(e => e.LatestEntry)
                    .HasName("IDX_LATEST_ENTRY");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IDX_MACHINE");

                entity.HasIndex(e => e.ProcessId)
                    .HasName("IDX_PROCESS");

                entity.HasIndex(e => e.Start)
                    .HasName("IDX_START");

                entity.HasIndex(e => e.UserData)
                    .HasName("IDX_USER_DATA");

                entity.HasIndex(e => e.Version)
                    .HasName("IDX_VERSION");

                entity.HasIndex(e => new {e.MachineId, e.TitledApplicationId, e.IsMobile, e.End})
                    .HasName("IDX_METER_DETAIL");

                entity.HasIndex(e => new {e.MachineId, e.TitledApplicationId, e.LatestEntry, e.IsMobile, e.End})
                    .HasName("SAM_METER_MAX");

                entity.HasIndex(e => new {e.TitledApplicationId, e.IsMobile, e.ProcessId, e.Start, e.UserData, e.End})
                    .HasName("METER_KEY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ServerDate)
                    .HasColumnName("SERVER_DATE")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.End)
                    .HasColumnName("END")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.IsMobile)
                    .HasColumnName("IS_MOBILE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LatestEntry)
                    .HasColumnName("LATEST_ENTRY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Launches)
                    .HasColumnName("LAUNCHES")
                    .HasColumnType("smallint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProcessId)
                    .HasColumnName("PROCESS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondsUsed)
                    .HasColumnName("SECONDS_USED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Start)
                    .HasColumnName("START")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.TitledApplicationId)
                    .IsRequired()
                    .HasColumnName("TITLED_APPLICATION_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.UserData)
                    .HasColumnName("USER_DATA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SamMeterTitledApplication>(entity =>
            {
                entity.HasKey(e => new {e.TitledApplicationId, e.IsMobile});

                entity.ToTable("SAM_METER_TITLED_APPLICATION", "ORG1");

                entity.Property(e => e.TitledApplicationId)
                    .HasColumnName("TITLED_APPLICATION_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsMobile)
                    .HasColumnName("IS_MOBILE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MeterActivated)
                    .HasColumnName("METER_ACTIVATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");
            });

            modelBuilder.Entity<SamNotAllowed>(entity =>
            {
                entity.HasKey(e => new {e.TitledApplicationId, e.IsMobile});

                entity.ToTable("SAM_NOT_ALLOWED", "ORG1");

                entity.Property(e => e.TitledApplicationId)
                    .HasColumnName("TITLED_APPLICATION_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsMobile)
                    .HasColumnName("IS_MOBILE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SamRecentJt>(entity =>
            {
                entity.HasKey(e => new {e.SamCatalogId, e.MachineId, e.ChangeType});

                entity.ToTable("SAM_RECENT_JT", "ORG1");

                entity.Property(e => e.SamCatalogId)
                    .HasColumnName("SAM_CATALOG_ID")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasColumnType("enum('ADDED','REMOVED')");
            });

            modelBuilder.Entity<SavedSearch>(entity =>
            {
                entity.ToTable("SAVED_SEARCH", "ORG1");

                entity.HasIndex(e => new {e.Type, e.Name, e.UserId})
                    .HasName("NAME_USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FindFields)
                    .HasColumnName("FIND_FIELDS")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ScanFilter>(entity =>
            {
                entity.ToTable("SCAN_FILTER", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<ScanSettings>(entity =>
            {
                entity.ToTable("SCAN_SETTINGS", "ORG1");

                entity.HasIndex(e => e.RelayMachineId)
                    .HasName("SCAN_RELAY_MACHINE_ID_MACHINE_ID_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AwAutoProvision)
                    .HasColumnName("AW_AUTO_PROVISION")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AwEnabled)
                    .HasColumnName("AW_ENABLED")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.AwHost)
                    .HasColumnName("AW_HOST")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AwKeyEnc)
                    .HasColumnName("AW_KEY_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.CliEnabled)
                    .HasColumnName("CLI_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CliTimeout)
                    .HasColumnName("CLI_TIMEOUT")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CredentialIdAw)
                    .HasColumnName("CREDENTIAL_ID_AW")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdCli)
                    .HasColumnName("CREDENTIAL_ID_CLI")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdGSuite)
                    .HasColumnName("CREDENTIAL_ID_G_SUITE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdKmm)
                    .HasColumnName("CREDENTIAL_ID_KMM")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdSnmp)
                    .HasColumnName("CREDENTIAL_ID_SNMP")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdSnmpv3)
                    .HasColumnName("CREDENTIAL_ID_SNMPV3")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdVmware)
                    .HasColumnName("CREDENTIAL_ID_VMWARE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CredentialIdWinrm)
                    .HasColumnName("CREDENTIAL_ID_WINRM")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DnsLookupEnabled)
                    .HasColumnName("DNS_LOOKUP_ENABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DnsServer)
                    .HasColumnName("DNS_SERVER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DnsTimeout)
                    .HasColumnName("DNS_TIMEOUT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.GChromeosEnabled)
                    .HasColumnName("G_CHROMEOS_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GMobileEnabled)
                    .HasColumnName("G_MOBILE_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GSuiteAutoProvision)
                    .HasColumnName("G_SUITE_AUTO_PROVISION")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IpRange)
                    .HasColumnName("IP_RANGE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KmmAutoProvision)
                    .HasColumnName("KMM_AUTO_PROVISION")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KmmEnabled)
                    .HasColumnName("KMM_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KmmRealm)
                    .HasColumnName("KMM_REALM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LdapContext)
                    .HasColumnName("LDAP_CONTEXT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LdapPwdEnc)
                    .HasColumnName("LDAP_PWD_ENC")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.LdapServer)
                    .HasColumnName("LDAP_SERVER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LdapTestEnabled)
                    .HasColumnName("LDAP_TEST_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LdapUser)
                    .HasColumnName("LDAP_USER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogLevel)
                    .HasColumnName("LOG_LEVEL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NmapEnabled)
                    .HasColumnName("NMAP_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NmapFast)
                    .HasColumnName("NMAP_FAST")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NmapOsDetect)
                    .HasColumnName("NMAP_OS_DETECT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NmapTcpScan)
                    .HasColumnName("NMAP_TCP_SCAN")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NmapTimeout)
                    .HasColumnName("NMAP_TIMEOUT")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.NmapUdpScan)
                    .HasColumnName("NMAP_UDP_SCAN")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NodesInScan)
                    .HasColumnName("NODES_IN_SCAN")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.Notify)
                    .HasColumnName("NOTIFY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PingTestEnabled)
                    .HasColumnName("PING_TEST_ENABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PortScanEnabled)
                    .HasColumnName("PORT_SCAN_ENABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PortScanTimeout)
                    .HasColumnName("PORT_SCAN_TIMEOUT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Progress)
                    .HasColumnName("PROGRESS")
                    .HasColumnType("bigint(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RelayEnabled)
                    .HasColumnName("RELAY_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RelayMachineId)
                    .HasColumnName("RELAY_MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ScanState)
                    .HasColumnName("SCAN_STATE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.SnmpRetry)
                    .HasColumnName("SNMP_RETRY")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SnmpTestEnabled)
                    .HasColumnName("SNMP_TEST_ENABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SnmpTimeout)
                    .HasColumnName("SNMP_TIMEOUT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SnmpWalkEnabled)
                    .HasColumnName("SNMP_WALK_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketTestEnabled)
                    .HasColumnName("SOCKET_TEST_ENABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketTestPort)
                    .HasColumnName("SOCKET_TEST_PORT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketTestProtocol)
                    .HasColumnName("SOCKET_TEST_PROTOCOL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SocketTestTimeout)
                    .HasColumnName("SOCKET_TEST_TIMEOUT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TcpPortList)
                    .HasColumnName("TCP_PORT_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasColumnType("smallint(2) unsigned")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.UdpPortList)
                    .HasColumnName("UDP_PORT_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.VmwareEnabled)
                    .HasColumnName("VMWARE_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VmwareTimeout)
                    .HasColumnName("VMWARE_TIMEOUT")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.WinrmEnabled)
                    .HasColumnName("WINRM_ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WinrmPort)
                    .HasColumnName("WINRM_PORT")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.WinrmRequireKerberos)
                    .HasColumnName("WINRM_REQUIRE_KERBEROS")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WinrmTimeout)
                    .HasColumnName("WINRM_TIMEOUT")
                    .HasColumnType("bigint(10)");

                entity.HasOne(d => d.RelayMachine)
                    .WithMany(p => p.ScanSettings)
                    .HasForeignKey(d => d.RelayMachineId)
                    .HasConstraintName("SCAN_RELAY_MACHINE_ID_MACHINE_ID_FK");
            });

            modelBuilder.Entity<ScapBenchmark>(entity =>
            {
                entity.ToTable("SCAP_BENCHMARK", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ChecklistId)
                    .HasColumnName("CHECKLIST_ID")
                    .IsUnicode(false);

                entity.Property(e => e.DatastreamId)
                    .HasColumnName("DATASTREAM_ID")
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("IDENTIFIER")
                    .IsUnicode(false);

                entity.Property(e => e.ScapVersion)
                    .IsRequired()
                    .HasColumnName("SCAP_VERSION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("1.1");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnName("UPDATED");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.XmlFilePrefix)
                    .HasColumnName("XML_FILE_PREFIX")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScapGroup>(entity =>
            {
                entity.ToTable("SCAP_GROUP", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("IDENTIFIER")
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasColumnName("LEVEL")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentScapGroupId)
                    .HasColumnName("PARENT_SCAP_GROUP_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ScapProfileId)
                    .HasColumnName("SCAP_PROFILE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Seq)
                    .HasColumnName("SEQ")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScapProfile>(entity =>
            {
                entity.ToTable("SCAP_PROFILE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("IDENTIFIER")
                    .IsUnicode(false);

                entity.Property(e => e.OvalSteps)
                    .HasColumnName("OVAL_STEPS")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScapBenchmarkId)
                    .HasColumnName("SCAP_BENCHMARK_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScapResult>(entity =>
            {
                entity.ToTable("SCAP_RESULT", "ORG1");

                entity.HasIndex(e => e.ResultValue)
                    .HasName("RESULT_VALUE");

                entity.HasIndex(e => new {e.MachineId, e.ScapProfileId})
                    .HasName("MACHINE_IDX")
                    .IsUnique();

                entity.HasIndex(e => new {e.ScapProfileId, e.MachineId})
                    .HasName("SCAP_PROFILE_IDX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EndTime).HasColumnName("END_TIME");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResultValue)
                    .IsRequired()
                    .HasColumnName("RESULT_VALUE")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ScapProfileId)
                    .HasColumnName("SCAP_PROFILE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ScapResultRule>(entity =>
            {
                entity.HasKey(e => new {e.ScapResultId, e.RuleIdref});

                entity.ToTable("SCAP_RESULT_RULE", "ORG1");

                entity.HasIndex(e => new {e.ScapResultId, e.ResultValue})
                    .HasName("RESULT_VALUE");

                entity.Property(e => e.ScapResultId)
                    .HasColumnName("SCAP_RESULT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RuleIdref)
                    .HasColumnName("RULE_IDREF")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.RawXml)
                    .IsRequired()
                    .HasColumnName("RAW_XML")
                    .IsUnicode(false);

                entity.Property(e => e.ResultValue)
                    .IsRequired()
                    .HasColumnName("RESULT_VALUE")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScapResultScore>(entity =>
            {
                entity.HasKey(e => new {e.ScapResultId, e.System});

                entity.ToTable("SCAP_RESULT_SCORE", "ORG1");

                entity.Property(e => e.ScapResultId)
                    .HasColumnName("SCAP_RESULT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.System)
                    .HasColumnName("SYSTEM")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreMaximum)
                    .HasColumnName("SCORE_MAXIMUM")
                    .HasColumnType("decimal(18,2)")
                    .HasDefaultValueSql("100.00");

                entity.Property(e => e.ScoreValue)
                    .HasColumnName("SCORE_VALUE")
                    .HasColumnType("decimal(18,2)")
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<ScapRule>(entity =>
            {
                entity.ToTable("SCAP_RULE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasColumnName("IDENTIFIER")
                    .IsUnicode(false);

                entity.Property(e => e.RawXml)
                    .IsRequired()
                    .HasColumnName("RAW_XML")
                    .IsUnicode(false);

                entity.Property(e => e.ScapGroupId)
                    .HasColumnName("SCAP_GROUP_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ScapProfileId)
                    .HasColumnName("SCAP_PROFILE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Seq)
                    .HasColumnName("SEQ")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScapRuleIdent>(entity =>
            {
                entity.ToTable("SCAP_RULE_IDENT", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IdentSystem)
                    .IsRequired()
                    .HasColumnName("IDENT_SYSTEM")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.IdentValue)
                    .IsRequired()
                    .HasColumnName("IDENT_VALUE")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.ScapProfileId)
                    .HasColumnName("SCAP_PROFILE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ScapRuleId)
                    .HasColumnName("SCAP_RULE_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("SETTINGS", "ORG1");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SettingsHistory>(entity =>
            {
                entity.ToTable("SETTINGS_HISTORY", "ORG1");

                entity.HasIndex(e => e.ChangeType)
                    .HasName("CHANGE_TYPE_IDX");

                entity.HasIndex(e => e.Time)
                    .HasName("TIME_IDX");

                entity.HasIndex(e => e.TypeName)
                    .HasName("TYPE_NAME_IDX");

                entity.HasIndex(e => e.UserText)
                    .HasName("USER_TEXT_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnName("TIME");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserText)
                    .IsRequired()
                    .HasColumnName("USER_TEXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1)
                    .HasColumnName("VALUE1")
                    .IsUnicode(false);

                entity.Property(e => e.Value2)
                    .HasColumnName("VALUE2")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SettingsHistoryConfiguration>(entity =>
            {
                entity.HasKey(e => e.TypeName);

                entity.ToTable("SETTINGS_HISTORY_CONFIGURATION", "ORG1");

                entity.Property(e => e.TypeName)
                    .HasColumnName("TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SettingsHistoryFieldDefinition>(entity =>
            {
                entity.HasKey(e => new {e.TypeName, e.FieldName});

                entity.ToTable("SETTINGS_HISTORY_FIELD_DEFINITION", "ORG1");

                entity.HasIndex(e => e.FriendlyFieldName)
                    .HasName("FRIENDLY_FIELD_NAME_IDX");

                entity.Property(e => e.TypeName)
                    .HasColumnName("TYPE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldType)
                    .HasColumnName("FIELD_TYPE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FriendlyFieldName)
                    .HasColumnName("FRIENDLY_FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ignored)
                    .HasColumnName("IGNORED")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SmartyReport>(entity =>
            {
                entity.ToTable("SMARTY_REPORT", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AtleastOne)
                    .HasColumnName("ATLEAST_ONE")
                    .IsUnicode(false);

                entity.Property(e => e.BreakColumns)
                    .HasColumnName("BREAK_COLUMNS")
                    .IsUnicode(false);

                entity.Property(e => e.Breaks)
                    .HasColumnName("BREAKS")
                    .IsUnicode(false);

                entity.Property(e => e.BuiltIn)
                    .HasColumnName("BUILT_IN")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BusinessObjectId)
                    .HasColumnName("BUSINESS_OBJECT_ID")
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnsJson)
                    .HasColumnName("COLUMNS_JSON")
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CsvSupport)
                    .HasColumnName("CSV_SUPPORT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.FfJson)
                    .HasColumnName("FF_JSON")
                    .IsUnicode(false);

                entity.Property(e => e.Fieldlist)
                    .HasColumnName("FIELDLIST")
                    .IsUnicode(false);

                entity.Property(e => e.HtmlSupport)
                    .HasColumnName("HTML_SUPPORT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LineNumbers)
                    .HasColumnName("LINE_NUMBERS")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Orderby)
                    .HasColumnName("ORDERBY")
                    .IsUnicode(false);

                entity.Property(e => e.Orderseq)
                    .HasColumnName("ORDERSEQ")
                    .IsUnicode(false);

                entity.Property(e => e.PdfSupport)
                    .HasColumnName("PDF_SUPPORT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .IsUnicode(false);

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxtSupport)
                    .HasColumnName("TXT_SUPPORT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.XlsSupport)
                    .HasColumnName("XLS_SUPPORT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SnmpInventoryOids>(entity =>
            {
                entity.ToTable("SNMP_INVENTORY_OIDS", "ORG1");

                entity.HasIndex(e => e.SnmpInventorySettingsId)
                    .HasName("SIS_SIO_FK_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Mib)
                    .HasColumnName("MIB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Oid)
                    .IsRequired()
                    .HasColumnName("OID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OidExternalMap)
                    .HasColumnName("OID_EXTERNAL_MAP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OidInternalMap)
                    .HasColumnName("OID_INTERNAL_MAP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Property)
                    .IsRequired()
                    .HasColumnName("PROPERTY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SnmpInventorySettingsId)
                    .HasColumnName("SNMP_INVENTORY_SETTINGS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TableName)
                    .HasColumnName("TABLE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.SnmpInventorySettings)
                    .WithMany(p => p.SnmpInventoryOids)
                    .HasForeignKey(d => d.SnmpInventorySettingsId)
                    .HasConstraintName("SIS_ID_SIO_FK");
            });

            modelBuilder.Entity<SnmpInventorySettings>(entity =>
            {
                entity.ToTable("SNMP_INVENTORY_SETTINGS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetSubtypeId)
                    .HasColumnName("ASSET_SUBTYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("IS_DEFAULT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SnmpInventorySettingsDefault>(entity =>
            {
                entity.ToTable("SNMP_INVENTORY_SETTINGS_DEFAULT", "ORG1");

                entity.HasIndex(e => e.SnmpInventorySettingsId)
                    .HasName("INDEX_SNMP_INVENTORY_SETTINGS_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerializedOid)
                    .IsRequired()
                    .HasColumnName("SERIALIZED_OID")
                    .IsUnicode(false);

                entity.Property(e => e.SnmpInventorySettingsId)
                    .HasColumnName("SNMP_INVENTORY_SETTINGS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SnmpInventorySettingsJt>(entity =>
            {
                entity.HasKey(e => new {e.SnmpInventorySettingsId, e.RemoteHostId});

                entity.ToTable("SNMP_INVENTORY_SETTINGS_JT", "ORG1");

                entity.HasIndex(e => e.RemoteHostId)
                    .HasName("RH_SISJT_FK_IDX");

                entity.HasIndex(e => e.SnmpInventorySettingsId)
                    .HasName("SIS_SISJT_FK_IDX");

                entity.Property(e => e.SnmpInventorySettingsId)
                    .HasColumnName("SNMP_INVENTORY_SETTINGS_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RemoteHostId)
                    .HasColumnName("REMOTE_HOST_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.HasOne(d => d.RemoteHost)
                    .WithMany(p => p.SnmpInventorySettingsJt)
                    .HasForeignKey(d => d.RemoteHostId)
                    .HasConstraintName("RH_ID_SISJT_FK");

                entity.HasOne(d => d.SnmpInventorySettings)
                    .WithMany(p => p.SnmpInventorySettingsJt)
                    .HasForeignKey(d => d.SnmpInventorySettingsId)
                    .HasConstraintName("SIS_ID_SISJT_FK");
            });

            modelBuilder.Entity<SnoozeAlert>(entity =>
            {
                entity.ToTable("SNOOZE_ALERT", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DialogOptions)
                    .HasColumnName("DIALOG_OPTIONS")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DialogTimeout)
                    .HasColumnName("DIALOG_TIMEOUT")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.DialogTimeoutAction)
                    .HasColumnName("DIALOG_TIMEOUT_ACTION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LimitSnooze)
                    .HasColumnName("LIMIT_SNOOZE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SnoozeCount)
                    .HasColumnName("SNOOZE_COUNT")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.SnoozeDuration)
                    .HasColumnName("SNOOZE_DURATION")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<Software>(entity =>
            {
                entity.ToTable("SOFTWARE", "ORG1");

                entity.HasIndex(e => e.DisplayName)
                    .HasName("DISPLAY_NAME_IDX");

                entity.HasIndex(e => e.FileName)
                    .HasName("FILE_NAME_IDX");

                entity.HasIndex(e => e.InventoryRule)
                    .HasName("INVENTORY_RULE_IDX");

                entity.HasIndex(e => e.IsPatch)
                    .HasName("IS_PATCH_IDX");

                entity.HasIndex(e => e.Publisher)
                    .HasName("PUBLISHER_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Unknown");

                entity.Property(e => e.Checksum)
                    .HasColumnName("CHECKSUM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.CustomFieldValue0)
                    .HasColumnName("CUSTOM_FIELD_VALUE0")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue1)
                    .HasColumnName("CUSTOM_FIELD_VALUE1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue2)
                    .HasColumnName("CUSTOM_FIELD_VALUE2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue3)
                    .HasColumnName("CUSTOM_FIELD_VALUE3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue4)
                    .HasColumnName("CUSTOM_FIELD_VALUE4")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomFieldValue5)
                    .HasColumnName("CUSTOM_FIELD_VALUE5")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayVersion)
                    .HasColumnName("DISPLAY_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DontReplicate)
                    .HasColumnName("DONT_REPLICATE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasColumnName("FILE_SIZE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HelpLink)
                    .HasColumnName("HELP_LINK")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HelpTelephone)
                    .HasColumnName("HELP_TELEPHONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstallDate)
                    .HasColumnName("INSTALL_DATE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryRule)
                    .HasColumnName("INVENTORY_RULE")
                    .HasColumnType("text");

                entity.Property(e => e.IsManual)
                    .HasColumnName("IS_MANUAL")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPatch)
                    .HasColumnName("IS_PATCH")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasColumnName("PUBLISHER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuietUninstallString)
                    .HasColumnName("QUIET_UNINSTALL_STRING")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Readme)
                    .HasColumnName("README")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RuleDataType)
                    .HasColumnName("RULE_DATA_TYPE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RuleFlag)
                    .HasColumnName("RULE_FLAG")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Threat)
                    .HasColumnName("THREAT")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.UninstallString)
                    .HasColumnName("UNINSTALL_STRING")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UrlinfoAbout)
                    .HasColumnName("URLINFO_ABOUT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SoftwareFileJt>(entity =>
            {
                entity.ToTable("SOFTWARE_FILE_JT", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SamAttachedFileId)
                    .HasColumnName("SAM_ATTACHED_FILE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SOFTWARE_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<SoftwareLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.SoftwareId, e.LabelId});

                entity.ToTable("SOFTWARE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SOFTWARE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SoftwareOsJt>(entity =>
            {
                entity.ToTable("SOFTWARE_OS_JT", "ORG1");

                entity.HasIndex(e => new {e.SoftwareId, e.SelectionType})
                    .HasName("ALL_IDX");

                entity.HasIndex(e => new {e.SoftwareId, e.SelectionType, e.OsFamilyId})
                    .HasName("FAMILY_IDX");

                entity.HasIndex(e => new {e.SoftwareId, e.SelectionType, e.OsId})
                    .HasName("BUILD_IDX");

                entity.HasIndex(e => new {e.SoftwareId, e.SelectionType, e.OsFamilyId, e.OsProductId})
                    .HasName("PRODUCT_IDX");

                entity.HasIndex(e => new {e.SoftwareId, e.SelectionType, e.OsFamilyId, e.OsProductId, e.OsArch})
                    .HasName("ARCH_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OsArch)
                    .IsRequired()
                    .HasColumnName("OS_ARCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OsFamilyId)
                    .HasColumnName("OS_FAMILY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsId)
                    .HasColumnName("OS_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsProductId)
                    .HasColumnName("OS_PRODUCT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SelectionType)
                    .HasColumnName("SELECTION_TYPE")
                    .HasColumnType("enum('ALL','FAMILY','PRODUCT','ARCH','BUILD')")
                    .HasDefaultValueSql("ALL");

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SOFTWARE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<StartupprogramLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.StartupprogramId, e.LabelId});

                entity.ToTable("STARTUPPROGRAM_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.StartupprogramId)
                    .HasColumnName("STARTUPPROGRAM_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaskChain>(entity =>
            {
                entity.ToTable("TASK_CHAIN", "ORG1");

                entity.HasIndex(e => e.Enabled)
                    .HasName("ENABLED_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QueueDisconnected)
                    .HasColumnName("QUEUE_DISCONNECTED")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RunLoggedOff)
                    .HasColumnName("RUN_LOGGED_OFF")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetAllMachines)
                    .HasColumnName("TARGET_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaskChainLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.TaskChainId, e.LabelId});

                entity.ToTable("TASK_CHAIN_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.TaskChainId)
                    .HasColumnName("TASK_CHAIN_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaskChainOsJt>(entity =>
            {
                entity.ToTable("TASK_CHAIN_OS_JT", "ORG1");

                entity.HasIndex(e => new {e.TaskChainId, e.SelectionType})
                    .HasName("ALL_IDX");

                entity.HasIndex(e => new {e.TaskChainId, e.SelectionType, e.OsFamilyId})
                    .HasName("FAMILY_IDX");

                entity.HasIndex(e => new {e.TaskChainId, e.SelectionType, e.OsId})
                    .HasName("BUILD_IDX");

                entity.HasIndex(e => new {e.TaskChainId, e.SelectionType, e.OsFamilyId, e.OsProductId})
                    .HasName("PRODUCT_IDX");

                entity.HasIndex(e => new {e.TaskChainId, e.SelectionType, e.OsFamilyId, e.OsProductId, e.OsArch})
                    .HasName("ARCH_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OsArch)
                    .IsRequired()
                    .HasColumnName("OS_ARCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OsFamilyId)
                    .HasColumnName("OS_FAMILY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsId)
                    .HasColumnName("OS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsProductId)
                    .HasColumnName("OS_PRODUCT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SelectionType)
                    .HasColumnName("SELECTION_TYPE")
                    .HasColumnType("enum('ALL','FAMILY','PRODUCT','ARCH','BUILD')")
                    .HasDefaultValueSql("ALL");

                entity.Property(e => e.TaskChainId)
                    .HasColumnName("TASK_CHAIN_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TaskChainRun>(entity =>
            {
                entity.ToTable("TASK_CHAIN_RUN", "ORG1");

                entity.HasIndex(e => new {e.TaskChainId, e.Id})
                    .HasName("TASK_CHAIN_ID_IDX");

                entity.HasIndex(e => new {e.TaskChainId, e.StartTime})
                    .HasName("TASK_CHAIN_ID_START_TIME_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Failure)
                    .HasColumnName("FAILURE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Queued)
                    .HasColumnName("QUEUED")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Running)
                    .HasColumnName("RUNNING")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.StartTime)
                    .HasColumnName("START_TIME")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Success)
                    .HasColumnName("SUCCESS")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaskChainId)
                    .HasColumnName("TASK_CHAIN_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<TaskChainRunMachine>(entity =>
            {
                entity.HasKey(e => new {e.TaskChainRunId, e.MachineId});

                entity.ToTable("TASK_CHAIN_RUN_MACHINE", "ORG1");

                entity.Property(e => e.TaskChainRunId)
                    .HasColumnName("TASK_CHAIN_RUN_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("enum('QUEUED','RUNNING','ERROR','COMPLETE')")
                    .HasDefaultValueSql("QUEUED");

                entity.Property(e => e.StepOrdinal)
                    .HasColumnName("STEP_ORDINAL")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<TaskChainRunMachineCount>(entity =>
            {
                entity.ToTable("TASK_CHAIN_RUN_MACHINE_COUNT", "ORG1");

                entity.HasIndex(e => new {e.TaskChainRunId, e.StepOrdinal})
                    .HasName("STEP_IDX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Failure)
                    .HasColumnName("FAILURE")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Queued)
                    .HasColumnName("QUEUED")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Running)
                    .HasColumnName("RUNNING")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.StepOrdinal)
                    .HasColumnName("STEP_ORDINAL")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Success)
                    .HasColumnName("SUCCESS")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaskChainRunId)
                    .HasColumnName("TASK_CHAIN_RUN_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<TaskChainSteps>(entity =>
            {
                entity.HasKey(e => new {e.TaskChainId, e.Ordinal});

                entity.ToTable("TASK_CHAIN_STEPS", "ORG1");

                entity.Property(e => e.TaskChainId)
                    .HasColumnName("TASK_CHAIN_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AbortOnFailure)
                    .HasColumnName("ABORT_ON_FAILURE")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasColumnName("TASK_TYPE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaskTypeId)
                    .HasColumnName("TASK_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<Throttle>(entity =>
            {
                entity.ToTable("THROTTLE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ToadLicense>(entity =>
            {
                entity.ToTable("TOAD_LICENSE", "ORG1");

                entity.HasIndex(e => e.AssetId)
                    .HasName("ASSET_ID_IDX");

                entity.HasIndex(e => e.Hash)
                    .HasName("HASH_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AssetId)
                    .HasColumnName("ASSET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasColumnName("HASH")
                    .HasColumnType("char(64)");

                entity.Property(e => e.LicenseKey)
                    .IsRequired()
                    .HasColumnName("LICENSE_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("PROCESSED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<User>(entity =>
            {
                //entity.HasKey(e => new { e.Id, e.UserName });

                entity.HasKey(e => e.Id);

                entity.ToTable("USER", "ORG1");

                entity.HasIndex(e => e.LdapUid)
                    .HasName("IDX_LDAP_UID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IDX_PARENT");

                entity.HasIndex(e => e.Path)
                    .HasName("IDX_PATH");

                entity.HasIndex(e => e.UserName)
                    .HasName("IDX_NAME");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApiEnabled)
                    .HasColumnName("API_ENABLED")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("ARCHIVED_BY")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ArchivedDate)
                    .HasColumnName("ARCHIVED_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("BUDGET_CODE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.DeviceCount)
                    .HasColumnName("DEVICE_COUNT")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Domain)
                    .HasColumnName("DOMAIN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HdDefaultQueueId)
                    .HasColumnName("HD_DEFAULT_QUEUE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.HdDefaultView)
                    .HasColumnName("HD_DEFAULT_VIEW")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("HOME_PHONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsArchived)
                    .HasColumnName("IS_ARCHIVED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LdapImported)
                    .HasColumnName("LDAP_IMPORTED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LdapUid)
                    .HasColumnName("LDAP_UID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasColumnName("LEVEL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LinkedApplianceId)
                    .HasColumnName("LINKED_APPLIANCE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LocaleBrowserId)
                    .HasColumnName("LOCALE_BROWSER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LOCATION_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ManagerId)
                    .HasColumnName("MANAGER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("MOBILE_PHONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PagerPhone)
                    .HasColumnName("PAGER_PHONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Permissions)
                    .HasColumnName("PERMISSIONS")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PrimaryDeviceId)
                    .HasColumnName("PRIMARY_DEVICE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.RoleId)
                    .HasColumnName("ROLE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SalesNotifications)
                    .HasColumnName("SALES_NOTIFICATIONS")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SecurityNotifications)
                    .HasColumnName("SECURITY_NOTIFICATIONS")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Theme)
                    .HasColumnName("THEME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("WORK_PHONE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e._2faConfigured)
                    .HasColumnName("2FA_CONFIGURED")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e._2faCutoffDate)
                    .HasColumnName("2FA_CUTOFF_DATE")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e._2faRequired)
                    .HasColumnName("2FA_REQUIRED")
                    .HasColumnType("tinyint(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e._2faSecret)
                    .HasColumnName("2FA_SECRET")
                    .HasColumnType("tinyblob");
            });

            modelBuilder.Entity<UserAdditionalEmail>(entity =>
            {
                entity.ToTable("USER_ADDITIONAL_EMAIL", "ORG1");

                entity.HasIndex(e => e.UserId)
                    .HasName("IDX_F0FAD2D6A8B90465");

                entity.HasIndex(e => new {e.UserId, e.Email})
                    .HasName("UNIQUE_USER_ID_EMAIL")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sorting)
                    .HasColumnName("SORTING")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<UserAutoRefresh>(entity =>
            {
                entity.HasKey(e => new {e.UserId, e.Page});

                entity.ToTable("USER_AUTO_REFRESH", "ORG1");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Page)
                    .HasColumnName("PAGE")
                    .HasMaxLength(384)
                    .IsUnicode(false);

                entity.Property(e => e.AutoRefreshInterval)
                    .HasColumnName("AUTO_REFRESH_INTERVAL")
                    .HasColumnType("bigint(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserDownloadApprovalHistory>(entity =>
            {
                entity.ToTable("USER_DOWNLOAD_APPROVAL_HISTORY", "ORG1");

                entity.HasIndex(e => e.PortalId)
                    .HasName("USER_DOWNLOAD_APPROVAL_HISTORY_IDX_1");

                entity.HasIndex(e => new {e.PortalId, e.UserId})
                    .HasName("USER_DOWNLOAD_APPROVAL_HISTORY_IDX_2");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.HdTicketId)
                    .HasColumnName("HD_TICKET_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsComplete)
                    .HasColumnName("IS_COMPLETE")
                    .HasColumnType("smallint(1) unsigned");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .IsUnicode(false);

                entity.Property(e => e.PortalId)
                    .HasColumnName("PORTAL_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<UserFieldDefinition>(entity =>
            {
                entity.ToTable("USER_FIELD_DEFINITION", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultValue)
                    .IsRequired()
                    .HasColumnName("DEFAULT_VALUE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Required)
                    .HasColumnName("REQUIRED")
                    .HasColumnType("int(1) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserFieldValue>(entity =>
            {
                entity.HasKey(e => new {e.FieldId, e.UserId});

                entity.ToTable("USER_FIELD_VALUE", "ORG1");

                entity.HasIndex(e => e.FieldId)
                    .HasName("FIELD_ID");

                entity.Property(e => e.FieldId)
                    .HasColumnName("FIELD_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FieldValue)
                    .IsRequired()
                    .HasColumnName("FIELD_VALUE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.UserFieldValue)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("FIELD_ID");
            });

            modelBuilder.Entity<UserHistory>(entity =>
            {
                entity.ToTable("USER_HISTORY", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.KbotRunId)
                    .HasColumnName("KBOT_RUN_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MACHINE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PkgId)
                    .HasColumnName("PKG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PkgName)
                    .HasColumnName("PKG_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PkgVersion)
                    .HasColumnName("PKG_VERSION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserKeys>(entity =>
            {
                entity.ToTable("USER_KEYS", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PkgId)
                    .HasColumnName("PKG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PkgName)
                    .HasColumnName("PKG_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PkgVersion)
                    .HasColumnName("PKG_VERSION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductKey)
                    .HasColumnName("PRODUCT_KEY")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.UserId, e.LabelId});

                entity.ToTable("USER_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserProfileFields>(entity =>
            {
                entity.ToTable("USER_PROFILE_FIELDS", "ORG1");

                entity.HasIndex(e => e.FieldId)
                    .HasName("FIELD_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.EditMask)
                    .HasColumnName("EDIT_MASK")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FieldId)
                    .IsRequired()
                    .HasColumnName("FIELD_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VisibleMask)
                    .HasColumnName("VISIBLE_MASK")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("USER_ROLE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeAllMachines)
                    .HasColumnName("SCOPE_ALL_MACHINES")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SystemRoleId)
                    .HasColumnName("SYSTEM_ROLE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserRoleDeviceLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.UserRoleId, e.LabelId});

                entity.ToTable("USER_ROLE_DEVICE_LABEL_JT", "ORG1");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.UserRoleId)
                    .HasColumnName("USER_ROLE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserimportSchedule>(entity =>
            {
                entity.ToTable("USERIMPORT_SCHEDULE", "ORG1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Attrib)
                    .HasColumnName("ATTRIB")
                    .IsUnicode(false);

                entity.Property(e => e.AuthServerId)
                    .HasColumnName("AUTH_SERVER_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.BinAttrib)
                    .HasColumnName("BIN_ATTRIB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CcList)
                    .HasColumnName("CC_LIST")
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImportLabels)
                    .HasColumnName("IMPORT_LABELS")
                    .IsUnicode(false);

                entity.Property(e => e.ImportRoleId)
                    .HasColumnName("IMPORT_ROLE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.LabelAttrib)
                    .HasColumnName("LABEL_ATTRIB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LabelPrefix)
                    .HasColumnName("LABEL_PREFIX")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mapping)
                    .HasColumnName("MAPPING")
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.NextRun)
                    .HasColumnName("NEXT_RUN")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.RowLimit)
                    .HasColumnName("ROW_LIMIT")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VariableHandler>(entity =>
            {
                entity.HasKey(e => new {e.WorkflowId, e.Class});

                entity.ToTable("variable_handler", "ORG1");

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("workflow_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Variable)
                    .IsRequired()
                    .HasColumnName("variable")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.ToTable("workflow", "ORG1");

                entity.HasIndex(e => new {e.WorkflowName, e.WorkflowVersion})
                    .HasName("name_version")
                    .IsUnique();

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("workflow_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.WorkflowCreated)
                    .HasColumnName("workflow_created")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkflowName)
                    .IsRequired()
                    .HasColumnName("workflow_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowVersion)
                    .HasColumnName("workflow_version")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("1");
            });
        }
    }
}