using kace_api_netcore.Entities.K2000.Models;
using Microsoft.EntityFrameworkCore;

namespace kace_api_netcore.Entities.K2000
{
    public class KBDBContext : DbContext
    {
        public KBDBContext(DbContextOptions<KBDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessStats> AccessStats { get; set; }
        public virtual DbSet<Authentication> Authentication { get; set; }
        public virtual DbSet<BackupKeys> BackupKeys { get; set; }
        public virtual DbSet<BackupSubs> BackupSubs { get; set; }
        public virtual DbSet<BackupTables> BackupTables { get; set; }
        public virtual DbSet<CrServerCrash> CrServerCrash { get; set; }
        public virtual DbSet<Dashboard> Dashboard { get; set; }
        public virtual DbSet<DashboardBaseWidgets> DashboardBaseWidgets { get; set; }
        public virtual DbSet<DashboardCache> DashboardCache { get; set; }
        public virtual DbSet<DashboardCustomWidgets> DashboardCustomWidgets { get; set; }
        public virtual DbSet<DashboardDatasources> DashboardDatasources { get; set; }
        public virtual DbSet<DashboardWidgetTypes> DashboardWidgetTypes { get; set; }
        public virtual DbSet<DiskUsage> DiskUsage { get; set; }
        public virtual DbSet<Export> Export { get; set; }
        public virtual DbSet<GridColumnsOverrides> GridColumnsOverrides { get; set; }
        public virtual DbSet<ImBinlDriverCache> ImBinlDriverCache { get; set; }
        public virtual DbSet<ImBootAction> ImBootAction { get; set; }
        public virtual DbSet<ImBootActionNode> ImBootActionNode { get; set; }
        public virtual DbSet<ImBootActionRun> ImBootActionRun { get; set; }
        public virtual DbSet<ImBootActionRunNode> ImBootActionRunNode { get; set; }
        public virtual DbSet<ImBootActionUserState> ImBootActionUserState { get; set; }
        public virtual DbSet<ImBuiltinDrivers> ImBuiltinDrivers { get; set; }
        public virtual DbSet<ImCron> ImCron { get; set; }
        public virtual DbSet<ImDeletedNode> ImDeletedNode { get; set; }
        public virtual DbSet<ImDeployment> ImDeployment { get; set; }
        public virtual DbSet<ImDeploymentData> ImDeploymentData { get; set; }
        public virtual DbSet<ImDeploymentLabelJt> ImDeploymentLabelJt { get; set; }
        public virtual DbSet<ImDeploymentLog> ImDeploymentLog { get; set; }
        public virtual DbSet<ImDeploymentTaskLog> ImDeploymentTaskLog { get; set; }
        public virtual DbSet<ImDeploymentType> ImDeploymentType { get; set; }
        public virtual DbSet<ImDriverFeed> ImDriverFeed { get; set; }
        public virtual DbSet<ImDriverPatterns> ImDriverPatterns { get; set; }
        public virtual DbSet<ImDrivers> ImDrivers { get; set; }
        public virtual DbSet<ImInstallConfigs> ImInstallConfigs { get; set; }
        public virtual DbSet<ImInstallKeys> ImInstallKeys { get; set; }
        public virtual DbSet<ImInstallationSource> ImInstallationSource { get; set; }
        public virtual DbSet<ImInstallationSourceCategory> ImInstallationSourceCategory { get; set; }
        public virtual DbSet<ImInstallationSourceCd> ImInstallationSourceCd { get; set; }
        public virtual DbSet<ImInstallationSourceFingerprints> ImInstallationSourceFingerprints { get; set; }
        public virtual DbSet<ImInstallationSourceRepos> ImInstallationSourceRepos { get; set; }
        public virtual DbSet<ImInstallationSourceType> ImInstallationSourceType { get; set; }
        public virtual DbSet<ImLogImageCapture> ImLogImageCapture { get; set; }
        public virtual DbSet<ImLogRecoveryConsoleBoot> ImLogRecoveryConsoleBoot { get; set; }
        public virtual DbSet<ImManagedNode> ImManagedNode { get; set; }
        public virtual DbSet<ImNetworkScan> ImNetworkScan { get; set; }
        public virtual DbSet<ImNode> ImNode { get; set; }
        public virtual DbSet<ImNodeHardwareDetail> ImNodeHardwareDetail { get; set; }
        public virtual DbSet<ImNodeHardwareDevices> ImNodeHardwareDevices { get; set; }
        public virtual DbSet<ImNodeLabelJt> ImNodeLabelJt { get; set; }
        public virtual DbSet<ImRemoteSite> ImRemoteSite { get; set; }
        public virtual DbSet<ImRemoteSiteDeploymentJt> ImRemoteSiteDeploymentJt { get; set; }
        public virtual DbSet<ImRemoteSiteDriversJt> ImRemoteSiteDriversJt { get; set; }
        public virtual DbSet<ImRemoteSiteInstallationSourceJt> ImRemoteSiteInstallationSourceJt { get; set; }
        public virtual DbSet<ImRemoteSiteTaskJt> ImRemoteSiteTaskJt { get; set; }
        public virtual DbSet<ImRemoteSiteUserStateJt> ImRemoteSiteUserStateJt { get; set; }
        public virtual DbSet<ImServerTaskQueue> ImServerTaskQueue { get; set; }
        public virtual DbSet<ImSystemImageEdits> ImSystemImageEdits { get; set; }
        public virtual DbSet<ImTask> ImTask { get; set; }
        public virtual DbSet<ImTaskGroup> ImTaskGroup { get; set; }
        public virtual DbSet<ImTaskGroupJt> ImTaskGroupJt { get; set; }
        public virtual DbSet<ImTaskRuntimeEnvironment> ImTaskRuntimeEnvironment { get; set; }
        public virtual DbSet<ImTaskType> ImTaskType { get; set; }
        public virtual DbSet<ImUserState> ImUserState { get; set; }
        public virtual DbSet<ImUserStateLabelJt> ImUserStateLabelJt { get; set; }
        public virtual DbSet<ImUsmtScanTemplate> ImUsmtScanTemplate { get; set; }
        public virtual DbSet<ImUsmtTemplateLabelJt> ImUsmtTemplateLabelJt { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<KboxAlert> KboxAlert { get; set; }
        public virtual DbSet<KboxAlertUserHideJt> KboxAlertUserHideJt { get; set; }
        public virtual DbSet<KboxLicense> KboxLicense { get; set; }
        public virtual DbSet<KboxUpgrade> KboxUpgrade { get; set; }
        public virtual DbSet<KboxVersion> KboxVersion { get; set; }
        public virtual DbSet<Label> Label { get; set; }
        public virtual DbSet<LinkedAppliance> LinkedAppliance { get; set; }
        public virtual DbSet<LocaleBrowser> LocaleBrowser { get; set; }
        public virtual DbSet<Restore> Restore { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SslCert> SslCert { get; set; }
        public virtual DbSet<SslCsr> SslCsr { get; set; }
        public virtual DbSet<SslPrivatekey> SslPrivatekey { get; set; }
        public virtual DbSet<TimeZone> TimeZone { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAutoRefresh> UserAutoRefresh { get; set; }
        public virtual DbSet<UserLabelJt> UserLabelJt { get; set; }
        public virtual DbSet<UserLoginToken> UserLoginToken { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccessStats>(entity =>
            {
                entity.HasKey(e => e.Filename);

                entity.ToTable("ACCESS_STATS", "KBDB");

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FirstAccess)
                    .HasColumnName("FIRST_ACCESS")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.LastAccess)
                    .HasColumnName("LAST_ACCESS")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.RequestCount)
                    .HasColumnName("REQUEST_COUNT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Authentication>(entity =>
            {
                entity.ToTable("AUTHENTICATION", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AuthType)
                    .HasColumnName("AUTH_TYPE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Dn)
                    .HasColumnName("DN")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ExternalServer)
                    .HasColumnName("EXTERNAL_SERVER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LdapEncryption)
                    .HasColumnName("LDAP_ENCRYPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LdapLogin)
                    .HasColumnName("LDAP_LOGIN")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LdapPasswordEnc)
                    .HasColumnName("LDAP_PASSWORD_ENC")
                    .HasColumnType("tinyblob")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Ordinal)
                    .HasColumnName("ORDINAL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Permissions)
                    .HasColumnName("PERMISSIONS")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RequiresSsl)
                    .HasColumnName("REQUIRES_SSL")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SearchFilter)
                    .HasColumnName("SEARCH_FILTER")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<BackupKeys>(entity =>
            {
                entity.ToTable("BACKUP_KEYS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.KeyName)
                    .HasColumnName("KEY_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PayloadKey)
                    .HasColumnName("PAYLOAD_KEY")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TableField)
                    .HasColumnName("TABLE_FIELD")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TableName)
                    .HasColumnName("TABLE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<BackupSubs>(entity =>
            {
                entity.ToTable("BACKUP_SUBS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FieldName)
                    .HasColumnName("FIELD_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubVariable)
                    .HasColumnName("SUB_VARIABLE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TableName)
                    .HasColumnName("TABLE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<BackupTables>(entity =>
            {
                entity.ToTable("BACKUP_TABLES", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TableName)
                    .HasColumnName("TABLE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CrServerCrash>(entity =>
            {
                entity.ToTable("CR_SERVER_CRASH", "KBDB");

                entity.HasIndex(e => e.ExceptionText)
                    .HasName("EXCEPTION_TEXT_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CrashTime)
                    .HasColumnName("CRASH_TIME")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ExceptionText)
                    .HasColumnName("EXCEPTION_TEXT")
                    .HasColumnType("text")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LineNumber)
                    .HasColumnName("LINE_NUMBER")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.QueryString)
                    .HasColumnName("QUERY_STRING")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ScriptFilename)
                    .HasColumnName("SCRIPT_FILENAME")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ServerPath)
                    .HasColumnName("SERVER_PATH")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.UploadedAt)
                    .HasColumnName("UPLOADED_AT")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.ToTable("DASHBOARD", "KBDB");

                entity.HasIndex(e => e.UserId)
                    .HasName("DASHBOARD_USER_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DashboardDef)
                    .HasColumnName("DASHBOARD_DEF")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<DashboardBaseWidgets>(entity =>
            {
                entity.ToTable("DASHBOARD_BASE_WIDGETS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WidgetChartlabel)
                    .HasColumnName("WIDGET_CHARTLABEL")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetClass)
                    .IsRequired()
                    .HasColumnName("WIDGET_CLASS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WidgetData)
                    .HasColumnName("WIDGET_DATA")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetDatasource)
                    .IsRequired()
                    .HasColumnName("WIDGET_DATASOURCE")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WidgetHeight)
                    .HasColumnName("WIDGET_HEIGHT")
                    .HasColumnType("int(2)");

                entity.Property(e => e.WidgetInfo)
                    .HasColumnName("WIDGET_INFO")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetLinkurl)
                    .HasColumnName("WIDGET_LINKURL")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetPermissions)
                    .HasColumnName("WIDGET_PERMISSIONS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetSubtitle)
                    .HasColumnName("WIDGET_SUBTITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetTitle)
                    .IsRequired()
                    .HasColumnName("WIDGET_TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WidgetTypeId)
                    .HasColumnName("WIDGET_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WidgetUuid)
                    .IsRequired()
                    .HasColumnName("WIDGET_UUID")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.WidgetWidth)
                    .HasColumnName("WIDGET_WIDTH")
                    .HasColumnType("int(2)");
            });

            modelBuilder.Entity<DashboardCache>(entity =>
            {
                entity.ToTable("DASHBOARD_CACHE", "KBDB");

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DatasourceLastTime)
                    .HasColumnName("DATASOURCE_LAST_TIME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LocaleBrowserId)
                    .HasColumnName("LOCALE_BROWSER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<DashboardCustomWidgets>(entity =>
            {
                entity.ToTable("DASHBOARD_CUSTOM_WIDGETS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WidgetChartlabel)
                    .HasColumnName("WIDGET_CHARTLABEL")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetClass)
                    .IsRequired()
                    .HasColumnName("WIDGET_CLASS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WidgetData)
                    .HasColumnName("WIDGET_DATA")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetDatasource)
                    .IsRequired()
                    .HasColumnName("WIDGET_DATASOURCE")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WidgetHeight)
                    .HasColumnName("WIDGET_HEIGHT")
                    .HasColumnType("int(2)");

                entity.Property(e => e.WidgetInfo)
                    .HasColumnName("WIDGET_INFO")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetLinkurl)
                    .HasColumnName("WIDGET_LINKURL")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetPermissions)
                    .HasColumnName("WIDGET_PERMISSIONS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetSubtitle)
                    .HasColumnName("WIDGET_SUBTITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetTitle)
                    .IsRequired()
                    .HasColumnName("WIDGET_TITLE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WidgetTypeId)
                    .HasColumnName("WIDGET_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WidgetUuid)
                    .IsRequired()
                    .HasColumnName("WIDGET_UUID")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.WidgetWidth)
                    .HasColumnName("WIDGET_WIDTH")
                    .HasColumnType("int(2)");
            });

            modelBuilder.Entity<DashboardDatasources>(entity =>
            {
                entity.ToTable("DASHBOARD_DATASOURCES", "KBDB");

                entity.HasIndex(e => e.DatasourceName)
                    .HasName("DATASOURCE_NAME");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DatasourceCachehits)
                    .HasColumnName("DATASOURCE_CACHEHITS")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DatasourceDataType)
                    .IsRequired()
                    .HasColumnName("DATASOURCE_DATA_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DatasourceDemoResult)
                    .IsRequired()
                    .HasColumnName("DATASOURCE_DEMO_RESULT")
                    .IsUnicode(false);

                entity.Property(e => e.DatasourceLifeMinutes)
                    .HasColumnName("DATASOURCE_LIFE_MINUTES")
                    .HasColumnType("int(6)");

                entity.Property(e => e.DatasourceName)
                    .IsRequired()
                    .HasColumnName("DATASOURCE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DatasourceQueryData)
                    .IsRequired()
                    .HasColumnName("DATASOURCE_QUERY_DATA")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DatasourceQueryType)
                    .IsRequired()
                    .HasColumnName("DATASOURCE_QUERY_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RequiredFeature)
                    .IsRequired()
                    .HasColumnName("REQUIRED_FEATURE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashboardWidgetTypes>(entity =>
            {
                entity.ToTable("DASHBOARD_WIDGET_TYPES", "KBDB");

                entity.HasIndex(e => e.WidgetType)
                    .HasName("WIDGET_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.WidgetClass)
                    .IsRequired()
                    .HasColumnName("WIDGET_CLASS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WidgetDefUrl)
                    .HasColumnName("WIDGET_DEF_URL")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetThumbInactiveUrl)
                    .HasColumnName("WIDGET_THUMB_INACTIVE_URL")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetThumbUrl)
                    .HasColumnName("WIDGET_THUMB_URL")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.WidgetType)
                    .IsRequired()
                    .HasColumnName("WIDGET_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiskUsage>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("DISK_USAGE", "KBDB");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Export>(entity =>
            {
                entity.ToTable("EXPORT", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CronId)
                    .HasColumnName("CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Removable)
                    .HasColumnName("REMOVABLE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TargetId)
                    .HasColumnName("TARGET_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetType)
                    .HasColumnName("TARGET_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<GridColumnsOverrides>(entity =>
            {
                entity.ToTable("GRID_COLUMNS_OVERRIDES", "KBDB");

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

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

            modelBuilder.Entity<ImBinlDriverCache>(entity =>
            {
                entity.HasKey(e => new {e.ImInstallationSourceTypeId, e.HardwareClass, e.HardwareId});

                entity.ToTable("IM_BINL_DRIVER_CACHE", "KBDB");

                entity.HasIndex(e => e.HardwareId)
                    .HasName("HARDWARE_IDX");

                entity.Property(e => e.ImInstallationSourceTypeId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HardwareClass)
                    .HasColumnName("HARDWARE_CLASS")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HardwareId)
                    .HasColumnName("HARDWARE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BusType)
                    .HasColumnName("BUS_TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Characteristics)
                    .HasColumnName("CHARACTERISTICS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DriverPath)
                    .HasColumnName("DRIVER_PATH")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InfPath)
                    .HasColumnName("INF_PATH")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RequiredFiles)
                    .HasColumnName("REQUIRED_FILES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ServiceName)
                    .HasColumnName("SERVICE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImBootAction>(entity =>
            {
                entity.ToTable("IM_BOOT_ACTION", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FromRemoteSiteId)
                    .HasColumnName("FROM_REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImDeploymentId)
                    .HasColumnName("IM_DEPLOYMENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.MulticastDeployment)
                    .HasColumnName("MULTICAST_DEPLOYMENT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OfflineUsmtDeployOption)
                    .HasColumnName("OFFLINE_USMT_DEPLOY_OPTION")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScheduleType)
                    .HasColumnName("SCHEDULE_TYPE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsmtTemplateId)
                    .HasColumnName("USMT_TEMPLATE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ImBootActionNode>(entity =>
            {
                entity.ToTable("IM_BOOT_ACTION_NODE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ImBootActionId)
                    .HasColumnName("IM_BOOT_ACTION_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImBootActionRun>(entity =>
            {
                entity.ToTable("IM_BOOT_ACTION_RUN", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeployCompleted)
                    .HasColumnName("DEPLOY_COMPLETED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeployStarted)
                    .HasColumnName("DEPLOY_STARTED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ImBootActionId)
                    .HasColumnName("IM_BOOT_ACTION_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Scheduled)
                    .HasColumnName("SCHEDULED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImBootActionRunNode>(entity =>
            {
                entity.ToTable("IM_BOOT_ACTION_RUN_NODE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Booted)
                    .HasColumnName("BOOTED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImBootActionRunId)
                    .HasColumnName("IM_BOOT_ACTION_RUN_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImBootActionUserState>(entity =>
            {
                entity.ToTable("IM_BOOT_ACTION_USER_STATE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ImBootActionId)
                    .HasColumnName("IM_BOOT_ACTION_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImUserStateId)
                    .HasColumnName("IM_USER_STATE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImBuiltinDrivers>(entity =>
            {
                entity.HasKey(e => new {e.ImInstallationSourceTypeId, e.HardwareId});

                entity.ToTable("IM_BUILTIN_DRIVERS", "KBDB");

                entity.HasIndex(e => e.HardwareId)
                    .HasName("HARDWARE_IDX");

                entity.Property(e => e.ImInstallationSourceTypeId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HardwareId)
                    .HasColumnName("HARDWARE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InfPath)
                    .HasColumnName("INF_PATH")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServiceName)
                    .HasColumnName("SERVICE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImCron>(entity =>
            {
                entity.ToTable("IM_CRON", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Command)
                    .HasColumnName("COMMAND")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DaysOfMonth)
                    .HasColumnName("DAYS_OF_MONTH")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DaysOfWeek)
                    .HasColumnName("DAYS_OF_WEEK")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Minutes)
                    .HasColumnName("MINUTES")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Months)
                    .HasColumnName("MONTHS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImDeletedNode>(entity =>
            {
                entity.ToTable("IM_DELETED_NODE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DateDeleted)
                    .HasColumnName("DATE_DELETED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImDeployment>(entity =>
            {
                entity.ToTable("IM_DEPLOYMENT", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Architecture)
                    .HasColumnName("ARCHITECTURE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AutoLogonCount)
                    .HasColumnName("AUTO_LOGON_COUNT")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CalculateLogonCount)
                    .HasColumnName("CALCULATE_LOGON_COUNT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CaptureCompleted)
                    .HasColumnName("CAPTURE_COMPLETED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CaptureStarted)
                    .HasColumnName("CAPTURE_STARTED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasColumnName("CLASS_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeployOptions)
                    .HasColumnName("DEPLOY_OPTIONS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DirectCapture)
                    .HasColumnName("DIRECT_CAPTURE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dirty)
                    .HasColumnName("DIRTY")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImDeploymentTypeId)
                    .HasColumnName("IM_DEPLOYMENT_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImInstallationSourceId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.MemdiskBoot)
                    .HasColumnName("MEMDISK_BOOT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RemoteSiteId)
                    .HasColumnName("REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemoteSiteSize)
                    .HasColumnName("REMOTE_SITE_SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShowCancel)
                    .HasColumnName("SHOW_CANCEL")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShutdownAfterLastTask)
                    .HasColumnName("SHUTDOWN_AFTER_LAST_TASK")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Size)
                    .HasColumnName("SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Sysprepped)
                    .HasColumnName("SYSPREPPED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ImDeploymentData>(entity =>
            {
                entity.HasKey(e => new {e.ImDeploymentId, e.Name});

                entity.ToTable("IM_DEPLOYMENT_DATA", "KBDB");

                entity.Property(e => e.ImDeploymentId)
                    .HasColumnName("IM_DEPLOYMENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImDeploymentLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.ImDeploymentId, e.LabelId});

                entity.ToTable("IM_DEPLOYMENT_LABEL_JT", "KBDB");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.ImDeploymentId)
                    .HasColumnName("IM_DEPLOYMENT_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImDeploymentLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("IM_DEPLOYMENT_LOG", "KBDB");

                entity.HasIndex(e => e.ImDeploymentId)
                    .HasName("IM_DEPLOYMENT_ID");

                entity.HasIndex(e => e.ImNodeId)
                    .HasName("IM_NODE_ID");

                entity.Property(e => e.LogId)
                    .HasColumnName("LOG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DeployCompleted)
                    .HasColumnName("DEPLOY_COMPLETED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeployStarted)
                    .HasColumnName("DEPLOY_STARTED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ImBootActionRunId)
                    .HasColumnName("IM_BOOT_ACTION_RUN_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImDeploymentId)
                    .HasColumnName("IM_DEPLOYMENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerIp)
                    .HasColumnName("SERVER_IP")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.HasOne(e => e.ImNode)
                    .WithMany(n => n.ImDeploymentLogs)
                    .HasForeignKey(l => l.ImNodeId);

                entity.HasOne(e => e.ImDeployment)
                    .WithMany(n => n.ImDeploymentLogs)
                    .HasForeignKey(l => l.ImDeploymentId);
            });

            modelBuilder.Entity<ImDeploymentTaskLog>(entity =>
            {
                entity.ToTable("IM_DEPLOYMENT_TASK_LOG", "KBDB");

                entity.HasIndex(e => e.ImDeploymentLogId)
                    .HasName("IM_DEPLOYMENT_LOG_ID");

                entity.HasIndex(e => e.ImTaskId)
                    .HasName("IM_TASK_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DateCompleted).HasColumnName("DATE_COMPLETED");

                entity.Property(e => e.ImDeploymentLogId)
                    .HasColumnName("IM_DEPLOYMENT_LOG_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImTaskId)
                    .HasColumnName("IM_TASK_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstallOrder)
                    .HasColumnName("INSTALL_ORDER")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ReturnCode)
                    .HasColumnName("RETURN_CODE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("-1");
            });

            modelBuilder.Entity<ImDeploymentType>(entity =>
            {
                entity.ToTable("IM_DEPLOYMENT_TYPE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("ALIAS")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImDriverFeed>(entity =>
            {
                entity.ToTable("IM_DRIVER_FEED", "KBDB");

                entity.HasIndex(e => e.ImInstallationSourceTypeId)
                    .HasName("OS_IDX");

                entity.HasIndex(e => e.Path)
                    .HasName("PATH_IDX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CurrentVersion)
                    .IsRequired()
                    .HasColumnName("CURRENT_VERSION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImInstallationSourceTypeId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstalledVersion)
                    .IsRequired()
                    .HasColumnName("INSTALLED_VERSION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("MODEL")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("PATH")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PayloadChecksum)
                    .IsRequired()
                    .HasColumnName("PAYLOAD_CHECKSUM")
                    .HasColumnType("char(64)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PayloadPathRegex)
                    .HasColumnName("PAYLOAD_PATH_REGEX")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PayloadSize)
                    .HasColumnName("PAYLOAD_SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PayloadUpdated)
                    .HasColumnName("PAYLOAD_UPDATED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PayloadUrl)
                    .IsRequired()
                    .HasColumnName("PAYLOAD_URL")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImDriverPatterns>(entity =>
            {
                entity.ToTable("IM_DRIVER_PATTERNS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ImInstallationSourceTypeId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pattern)
                    .HasColumnName("PATTERN")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ImDrivers>(entity =>
            {
                entity.ToTable("IM_DRIVERS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Directory)
                    .IsRequired()
                    .HasColumnName("DIRECTORY")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ImInstallationSourceTypeId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RemoteSiteSize)
                    .HasColumnName("REMOTE_SITE_SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ImInstallConfigs>(entity =>
            {
                entity.ToTable("IM_INSTALL_CONFIGS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Contents)
                    .HasColumnName("CONTENTS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ImInstallKeys>(entity =>
            {
                entity.ToTable("IM_INSTALL_KEYS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ImInstallationSourceTypeId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImInstallationSource>(entity =>
            {
                entity.ToTable("IM_INSTALLATION_SOURCE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BootEnvironmentId)
                    .HasColumnName("BOOT_ENVIRONMENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImInstallationSourceCategoryId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_CATEGORY_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImInstallationSourceTypeId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_TYPE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RemoteSiteSize)
                    .HasColumnName("REMOTE_SITE_SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalCds)
                    .HasColumnName("TOTAL_CDS")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ImInstallationSourceCategory>(entity =>
            {
                entity.ToTable("IM_INSTALLATION_SOURCE_CATEGORY", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ImInstallationSourceCd>(entity =>
            {
                entity.HasKey(e => new {e.ImInstallationSourceId, e.Number});

                entity.ToTable("IM_INSTALLATION_SOURCE_CD", "KBDB");

                entity.Property(e => e.ImInstallationSourceId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Number)
                    .HasColumnName("NUMBER")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Md5Checksum)
                    .HasColumnName("MD5_CHECKSUM")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Sha1Checksum)
                    .HasColumnName("SHA1_CHECKSUM")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Size)
                    .HasColumnName("SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ImInstallationSourceFingerprints>(entity =>
            {
                entity.ToTable("IM_INSTALLATION_SOURCE_FINGERPRINTS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DefaultAutoinstall)
                    .HasColumnName("DEFAULT_AUTOINSTALL")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Family)
                    .IsRequired()
                    .HasColumnName("FAMILY")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InitrdFile)
                    .HasColumnName("INITRD_FILE")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.KernelArch)
                    .HasColumnName("KERNEL_ARCH")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.KernelArchRegex)
                    .HasColumnName("KERNEL_ARCH_REGEX")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.KernelFile)
                    .HasColumnName("KERNEL_FILE")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Signatures)
                    .HasColumnName("SIGNATURES")
                    .HasColumnType("longtext")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SubFamily)
                    .IsRequired()
                    .HasColumnName("SUB_FAMILY")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SupportedArches)
                    .HasColumnName("SUPPORTED_ARCHES")
                    .HasColumnType("longtext")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VersionFile)
                    .HasColumnName("VERSION_FILE")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VersionFileRegex)
                    .HasColumnName("VERSION_FILE_REGEX")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImInstallationSourceRepos>(entity =>
            {
                entity.ToTable("IM_INSTALLATION_SOURCE_REPOS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Default)
                    .HasColumnName("DEFAULT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImInstallationSourceId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RepoUrl)
                    .HasColumnName("REPO_URL")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImInstallationSourceType>(entity =>
            {
                entity.ToTable("IM_INSTALLATION_SOURCE_TYPE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Alias)
                    .HasColumnName("ALIAS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Architecture)
                    .HasColumnName("ARCHITECTURE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BootEnvironmentName)
                    .HasColumnName("BOOT_ENVIRONMENT_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ImInstallationSourceFingerprintId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_FINGERPRINT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IsBootEnv)
                    .HasColumnName("IS_BOOT_ENV")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsScriptedInstall)
                    .HasColumnName("IS_SCRIPTED_INSTALL")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsWindowsBootEnv)
                    .HasColumnName("IS_WINDOWS_BOOT_ENV")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShortName)
                    .HasColumnName("SHORT_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ImLogImageCapture>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("IM_LOG_IMAGE_CAPTURE", "KBDB");

                entity.HasIndex(e => e.ImDeploymentId)
                    .HasName("IM_SYSTEM_IMAGE_ID");

                entity.HasIndex(e => e.ImNodeId)
                    .HasName("IM_NODE_ID");

                entity.Property(e => e.LogId)
                    .HasColumnName("LOG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CaptureCompleted)
                    .HasColumnName("CAPTURE_COMPLETED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CaptureStarted)
                    .HasColumnName("CAPTURE_STARTED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ImDeploymentId)
                    .HasColumnName("IM_DEPLOYMENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerIp)
                    .HasColumnName("SERVER_IP")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImLogRecoveryConsoleBoot>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("IM_LOG_RECOVERY_CONSOLE_BOOT", "KBDB");

                entity.HasIndex(e => e.ImDeploymentId)
                    .HasName("IM_BOOT_IMAGE_ID");

                entity.HasIndex(e => e.ImNodeId)
                    .HasName("IM_NODE_ID");

                entity.Property(e => e.LogId)
                    .HasColumnName("LOG_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BootTime)
                    .HasColumnName("BOOT_TIME")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ImDeploymentId)
                    .HasColumnName("IM_DEPLOYMENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerIp)
                    .HasColumnName("SERVER_IP")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImManagedNode>(entity =>
            {
                entity.ToTable("IM_MANAGED_NODE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasColumnType("char(15)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<ImNetworkScan>(entity =>
            {
                entity.ToTable("IM_NETWORK_SCAN", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DnsLookupEnabled)
                    .HasColumnName("DNS_LOOKUP_ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DnsLookupTimeout)
                    .HasColumnName("DNS_LOOKUP_TIMEOUT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Enabled)
                    .HasColumnName("ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PingProbeEnabled)
                    .HasColumnName("PING_PROBE_ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PingProbeTimeout)
                    .HasColumnName("PING_PROBE_TIMEOUT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.PortProbeEnabled)
                    .HasColumnName("PORT_PROBE_ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PortProbeTcpConfiguration)
                    .HasColumnName("PORT_PROBE_TCP_CONFIGURATION")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PortProbeTimeout)
                    .HasColumnName("PORT_PROBE_TIMEOUT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.PortProbeUdpConfiguration)
                    .HasColumnName("PORT_PROBE_UDP_CONFIGURATION")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ProbeRangeEnd)
                    .HasColumnName("PROBE_RANGE_END")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProbeRangeStart)
                    .HasColumnName("PROBE_RANGE_START")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ImNode>(entity =>
            {
                entity.ToTable("IM_NODE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Firmware)
                    .HasColumnName("FIRMWARE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'BIOS'");

                entity.Property(e => e.HostName)
                    .HasColumnName("HOST_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Mac)
                    .IsRequired()
                    .HasColumnName("MAC")
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PingProbeResult)
                    .HasColumnName("PING_PROBE_RESULT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Platform)
                    .HasColumnName("PLATFORM")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PortProbeResult)
                    .HasColumnName("PORT_PROBE_RESULT")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PxeProbeResult)
                    .HasColumnName("PXE_PROBE_RESULT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecoveryConsoleBootTime)
                    .HasColumnName("RECOVERY_CONSOLE_BOOT_TIME")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<ImNodeHardwareDetail>(entity =>
            {
                entity.HasKey(e => e.ImNodeId);

                entity.ToTable("IM_NODE_HARDWARE_DETAIL", "KBDB");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BiosDescription)
                    .IsRequired()
                    .HasColumnName("BIOS_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BiosManufacturer)
                    .IsRequired()
                    .HasColumnName("BIOS_MANUFACTURER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BiosName)
                    .IsRequired()
                    .HasColumnName("BIOS_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BiosSerialNumber)
                    .IsRequired()
                    .HasColumnName("BIOS_SERIAL_NUMBER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BiosVersion)
                    .IsRequired()
                    .HasColumnName("BIOS_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Disk)
                    .HasColumnName("DISK")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Memory)
                    .HasColumnName("MEMORY")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("MODEL")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.NetworkAdapter)
                    .HasColumnName("NETWORK_ADAPTER")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Processor)
                    .HasColumnName("PROCESSOR")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ImNodeHardwareDevices>(entity =>
            {
                entity.HasKey(e => new {e.ImNodeId, e.InstanceId});

                entity.ToTable("IM_NODE_HARDWARE_DEVICES", "KBDB");

                entity.HasIndex(e => e.InstanceId)
                    .HasName("INSTANCE_IDX");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("INSTANCE_ID")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CompatibleIds)
                    .HasColumnName("COMPATIBLE_IDS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasColumnName("DEVICE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HardwareIds)
                    .HasColumnName("HARDWARE_IDS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Upgraded)
                    .HasColumnName("UPGRADED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImNodeLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.ImNodeId, e.LabelId});

                entity.ToTable("IM_NODE_LABEL_JT", "KBDB");

                entity.HasIndex(e => e.LabelId)
                    .HasName("LABEL_IDX");

                entity.Property(e => e.ImNodeId)
                    .HasColumnName("IM_NODE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImRemoteSite>(entity =>
            {
                entity.ToTable("IM_REMOTE_SITE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BandwidthLimit)
                    .HasColumnName("BANDWIDTH_LIMIT")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BandwidthLimitEnabled)
                    .HasColumnName("BANDWIDTH_LIMIT_ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImCronId)
                    .HasColumnName("IM_CRON_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastCheck)
                    .HasColumnName("LAST_CHECK")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LastSync)
                    .HasColumnName("LAST_SYNC")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LinkedApplianceId)
                    .HasColumnName("LINKED_APPLIANCE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("SERIAL_NUMBER")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Ssh2DsaHostKey)
                    .HasColumnName("SSH_2_DSA_HOST_KEY")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Ssh2RsaHostKey)
                    .HasColumnName("SSH_2_RSA_HOST_KEY")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SyncProgress)
                    .HasColumnName("SYNC_PROGRESS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.UpgradeStatus)
                    .HasColumnName("UPGRADE_STATUS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("VERSION")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ImRemoteSiteDeploymentJt>(entity =>
            {
                entity.HasKey(e => new {e.ImRemoteSiteId, e.ImDeploymentId});

                entity.ToTable("IM_REMOTE_SITE_DEPLOYMENT_JT", "KBDB");

                entity.Property(e => e.ImRemoteSiteId)
                    .HasColumnName("IM_REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImDeploymentId)
                    .HasColumnName("IM_DEPLOYMENT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DefaultBoot)
                    .HasColumnName("DEFAULT_BOOT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImRemoteSiteDriversJt>(entity =>
            {
                entity.HasKey(e => new {e.ImRemoteSiteId, e.ImDriversId});

                entity.ToTable("IM_REMOTE_SITE_DRIVERS_JT", "KBDB");

                entity.Property(e => e.ImRemoteSiteId)
                    .HasColumnName("IM_REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImDriversId)
                    .HasColumnName("IM_DRIVERS_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImRemoteSiteInstallationSourceJt>(entity =>
            {
                entity.HasKey(e => new {e.ImRemoteSiteId, e.ImInstallationSourceId});

                entity.ToTable("IM_REMOTE_SITE_INSTALLATION_SOURCE_JT", "KBDB");

                entity.Property(e => e.ImRemoteSiteId)
                    .HasColumnName("IM_REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImInstallationSourceId)
                    .HasColumnName("IM_INSTALLATION_SOURCE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImRemoteSiteTaskJt>(entity =>
            {
                entity.HasKey(e => new {e.ImRemoteSiteId, e.ImTaskId});

                entity.ToTable("IM_REMOTE_SITE_TASK_JT", "KBDB");

                entity.Property(e => e.ImRemoteSiteId)
                    .HasColumnName("IM_REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImTaskId)
                    .HasColumnName("IM_TASK_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImRemoteSiteUserStateJt>(entity =>
            {
                entity.HasKey(e => new {e.ImRemoteSiteId, e.ImUserStateId});

                entity.ToTable("IM_REMOTE_SITE_USER_STATE_JT", "KBDB");

                entity.Property(e => e.ImRemoteSiteId)
                    .HasColumnName("IM_REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImUserStateId)
                    .HasColumnName("IM_USER_STATE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImServerTaskQueue>(entity =>
            {
                entity.ToTable("IM_SERVER_TASK_QUEUE", "KBDB");

                entity.HasIndex(e => e.Command)
                    .HasName("COMMAND_IDX");

                entity.HasIndex(e => e.TimeCompleted)
                    .HasName("TIME_COMPLETED_IDX");

                entity.HasIndex(e => e.TimeLaunched)
                    .HasName("TIME_LAUNCHED_IDX");

                entity.HasIndex(e => new {e.Queue, e.TimeLaunched})
                    .HasName("QUEUE_IDX");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Command)
                    .HasColumnName("COMMAND")
                    .HasColumnType("text")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ExitStatus)
                    .HasColumnName("EXIT_STATUS")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnName("QUEUE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TimeCompleted)
                    .HasColumnName("TIME_COMPLETED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TimeLaunched)
                    .HasColumnName("TIME_LAUNCHED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<ImSystemImageEdits>(entity =>
            {
                entity.ToTable("IM_SYSTEM_IMAGE_EDITS", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommandType)
                    .IsRequired()
                    .HasColumnName("COMMAND_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DestPath)
                    .HasColumnName("DEST_PATH")
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ImDeploymentId)
                    .HasColumnName("IM_DEPLOYMENT_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SourcePath)
                    .HasColumnName("SOURCE_PATH")
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ImTask>(entity =>
            {
                entity.ToTable("IM_TASK", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("ACCESS_LEVEL")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CommandLine)
                    .HasColumnName("COMMAND_LINE")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DownloadStatus)
                    .IsRequired()
                    .HasColumnName("DOWNLOAD_STATUS")
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Filesize)
                    .HasColumnName("FILESIZE")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hidden)
                    .HasColumnName("HIDDEN")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImTaskTypeId)
                    .HasColumnName("IM_TASK_TYPE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.K1AutoUpdate)
                    .HasColumnName("K1_AUTO_UPDATE")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.K1DisplayVersion)
                    .HasColumnName("K1_DISPLAY_VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.K1LinkId)
                    .HasColumnName("K1_LINK_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.K1MiId)
                    .HasColumnName("K1_MI_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.K1OrgName)
                    .HasColumnName("K1_ORG_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RebootRequired)
                    .HasColumnName("REBOOT_REQUIRED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemoteSiteSize)
                    .HasColumnName("REMOTE_SITE_SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RuntimeEnvironment)
                    .IsRequired()
                    .HasColumnName("RUNTIME_ENVIRONMENT")
                    .HasColumnType(
                        "enum('kbe_windows','kbe_macosx','windows','macosx','linux','kbe_linux','rpm','ubudeb')")
                    .HasDefaultValueSql("'windows'");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ImTaskGroup>(entity =>
            {
                entity.ToTable("IM_TASK_GROUP", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RuntimeEnvironment)
                    .IsRequired()
                    .HasColumnName("RUNTIME_ENVIRONMENT")
                    .HasColumnType("enum('windows','macosx','linux')")
                    .HasDefaultValueSql("'windows'");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ImTaskGroupJt>(entity =>
            {
                entity.HasKey(e => new {e.ImTaskGroupId, e.ImTaskId, e.InstallOrder});

                entity.ToTable("IM_TASK_GROUP_JT", "KBDB");

                entity.Property(e => e.ImTaskGroupId)
                    .HasColumnName("IM_TASK_GROUP_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImTaskId)
                    .HasColumnName("IM_TASK_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InstallOrder)
                    .HasColumnName("INSTALL_ORDER")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImTaskRuntimeEnvironment>(entity =>
            {
                entity.ToTable("IM_TASK_RUNTIME_ENVIRONMENT", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ImTaskType>(entity =>
            {
                entity.ToTable("IM_TASK_TYPE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImUserState>(entity =>
            {
                entity.ToTable("IM_USER_STATE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Arch)
                    .HasColumnName("ARCH")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Domain)
                    .HasColumnName("DOMAIN")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HostName)
                    .HasColumnName("HOST_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.InstallationSourceType)
                    .IsRequired()
                    .HasColumnName("INSTALLATION_SOURCE_TYPE")
                    .IsUnicode(false);

                entity.Property(e => e.LocalUser)
                    .HasColumnName("LOCAL_USER")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ProfileName)
                    .HasColumnName("PROFILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RemoteSiteId)
                    .HasColumnName("REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RemoteSiteSize)
                    .HasColumnName("REMOTE_SITE_SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Size)
                    .HasColumnName("SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TEMPLATE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsmtVersion)
                    .HasColumnName("USMT_VERSION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ImUserStateLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.ImUserStateId, e.LabelId});

                entity.ToTable("IM_USER_STATE_LABEL_JT", "KBDB");

                entity.Property(e => e.ImUserStateId)
                    .HasColumnName("IM_USER_STATE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ImUsmtScanTemplate>(entity =>
            {
                entity.ToTable("IM_USMT_SCAN_TEMPLATE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CmdLine)
                    .HasColumnName("CMD_LINE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ConfigFile)
                    .HasColumnName("CONFIG_FILE")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExcludeFiles)
                    .HasColumnName("EXCLUDE_FILES")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExcludeUsers)
                    .HasColumnName("EXCLUDE_USERS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RemoteSiteId)
                    .HasColumnName("REMOTE_SITE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScanAllUsers)
                    .HasColumnName("SCAN_ALL_USERS")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ImUsmtTemplateLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.ImUsmtScanTemplateId, e.LabelId});

                entity.ToTable("IM_USMT_TEMPLATE_LABEL_JT", "KBDB");

                entity.Property(e => e.ImUsmtScanTemplateId)
                    .HasColumnName("IM_USMT_SCAN_TEMPLATE_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LABEL_ID")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.ToTable("JOURNAL", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DbSchema)
                    .HasColumnName("DB_SCHEMA")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("FILENAME")
                    .IsUnicode(false);

                entity.Property(e => e.Ran)
                    .HasColumnName("RAN")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("enum('succeeded','failed','bootstrapped')");
            });

            modelBuilder.Entity<KboxAlert>(entity =>
            {
                entity.ToTable("KBOX_ALERT", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("TAG")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("enum('alert','info','error')")
                    .HasDefaultValueSql("'alert'");
            });

            modelBuilder.Entity<KboxAlertUserHideJt>(entity =>
            {
                entity.HasKey(e => new {e.KboxAlertId, e.UserId});

                entity.ToTable("KBOX_ALERT_USER_HIDE_JT", "KBDB");

                entity.Property(e => e.KboxAlertId)
                    .HasColumnName("KBOX_ALERT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<KboxLicense>(entity =>
            {
                entity.ToTable("KBOX_LICENSE", "KBDB");

                entity.HasIndex(e => e.LicenseKey)
                    .HasName("LICENSE_KEY")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ActivationStatus)
                    .IsRequired()
                    .HasColumnName("ACTIVATION_STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ActivationTime)
                    .HasColumnName("ACTIVATION_TIME")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LicenseKey)
                    .IsRequired()
                    .HasColumnName("LICENSE_KEY")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<KboxUpgrade>(entity =>
            {
                entity.ToTable("KBOX_UPGRADE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.NewVersion)
                    .HasColumnName("NEW_VERSION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OldVersion)
                    .HasColumnName("OLD_VERSION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpgradeCompleted)
                    .HasColumnName("UPGRADE_COMPLETED")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.UpgradeStarted)
                    .HasColumnName("UPGRADE_STARTED")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<KboxVersion>(entity =>
            {
                entity.ToTable("KBOX_VERSION", "KBDB");

                entity.HasIndex(e => new {e.Major, e.Minor, e.Build, e.Package})
                    .HasName("VERSION")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Build)
                    .HasColumnName("BUILD")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Major)
                    .HasColumnName("MAJOR")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Minor)
                    .HasColumnName("MINOR")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Package)
                    .HasColumnName("PACKAGE")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.UiOrder)
                    .HasColumnName("UI_ORDER")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("LABEL", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.KaceAltLocation)
                    .HasColumnName("KACE_ALT_LOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.KaceAltLocationPassword)
                    .HasColumnName("KACE_ALT_LOCATION_PASSWORD")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.KaceAltLocationUser)
                    .HasColumnName("KACE_ALT_LOCATION_USER")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<LinkedAppliance>(entity =>
            {
                entity.ToTable("LINKED_APPLIANCE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DefaultOrgName)
                    .HasColumnName("DEFAULT_ORG_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HostName)
                    .HasColumnName("HOST_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.PublicKey)
                    .HasColumnName("PUBLIC_KEY")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PublicKeyFingerprint)
                    .HasColumnName("PUBLIC_KEY_FINGERPRINT")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SslEnabled)
                    .HasColumnName("SSL_ENABLED")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<LocaleBrowser>(entity =>
            {
                entity.ToTable("LOCALE_BROWSER", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("ACTIVE")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Konfig)
                    .HasColumnName("KONFIG")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.KonfigSortOrder)
                    .HasColumnName("KONFIG_SORT_ORDER")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocaleCollationRuleId)
                    .HasColumnName("LOCALE_COLLATION_RULE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocaleName)
                    .IsRequired()
                    .HasColumnName("LOCALE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LocaleTimeFormatId)
                    .HasColumnName("LOCALE_TIME_FORMAT_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessagesLocaleId)
                    .HasColumnName("MESSAGES_LOCALE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SearchCriteria)
                    .IsRequired()
                    .HasColumnName("SEARCH_CRITERIA")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SortOrder)
                    .HasColumnName("SORT_ORDER")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Restore>(entity =>
            {
                entity.ToTable("RESTORE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsManagedInstallImport)
                    .HasColumnName("IS_MANAGED_INSTALL_IMPORT")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkedApplianceId)
                    .HasColumnName("LINKED_APPLIANCE_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ManagedInstallId)
                    .HasColumnName("MANAGED_INSTALL_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ManagedInstallSize)
                    .HasColumnName("MANAGED_INSTALL_SIZE")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .HasColumnName("ORG_NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("SETTINGS", "KBDB");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SslCert>(entity =>
            {
                entity.ToTable("SSL_CERT", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Cert)
                    .HasColumnName("CERT")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Selfsigned)
                    .HasColumnName("SELFSIGNED")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<SslCsr>(entity =>
            {
                entity.ToTable("SSL_CSR", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Commonname)
                    .IsRequired()
                    .HasColumnName("COMMONNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Countryname)
                    .IsRequired()
                    .HasColumnName("COUNTRYNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Localityname)
                    .IsRequired()
                    .HasColumnName("LOCALITYNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Orgname)
                    .IsRequired()
                    .HasColumnName("ORGNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Request)
                    .HasColumnName("REQUEST")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Statename)
                    .IsRequired()
                    .HasColumnName("STATENAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Unitname)
                    .IsRequired()
                    .HasColumnName("UNITNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<SslPrivatekey>(entity =>
            {
                entity.ToTable("SSL_PRIVATEKEY", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(8) unsigned");

                entity.Property(e => e.Cert)
                    .HasColumnName("CERT")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Privatekey)
                    .HasColumnName("PRIVATEKEY")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.ToTable("TIME_ZONE", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Tz)
                    .IsRequired()
                    .HasColumnName("TZ")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TzNote)
                    .HasColumnName("TZ_NOTE")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new {e.Id, e.UserName});

                entity.ToTable("USER", "KBDB");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BudgetCode)
                    .HasColumnName("BUDGET_CODE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Domain)
                    .HasColumnName("DOMAIN")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LdapImported)
                    .HasColumnName("LDAP_IMPORTED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Modified)
                    .HasColumnName("MODIFIED")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Permissions)
                    .HasColumnName("PERMISSIONS")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Theme)
                    .HasColumnName("THEME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'light'");
            });

            modelBuilder.Entity<UserAutoRefresh>(entity =>
            {
                entity.HasKey(e => new {e.UserId, e.Page});

                entity.ToTable("USER_AUTO_REFRESH", "KBDB");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Page)
                    .HasColumnName("PAGE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AutoRefreshInterval)
                    .HasColumnName("AUTO_REFRESH_INTERVAL")
                    .HasColumnType("bigint(10) unsigned")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserLabelJt>(entity =>
            {
                entity.HasKey(e => new {e.UserId, e.LabelId});

                entity.ToTable("USER_LABEL_JT", "KBDB");

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

            modelBuilder.Entity<UserLoginToken>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("USER_LOGIN_TOKEN", "KBDB");

                entity.HasIndex(e => e.Token)
                    .HasName("TOKEN")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("TOKEN")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<UserSettings>(entity =>
            {
                entity.HasKey(e => new {e.Name, e.UserId});

                entity.ToTable("USER_SETTINGS", "KBDB");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserId)
                    .HasColumnName("USER_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .IsUnicode(false);
            });
        }
    }
}