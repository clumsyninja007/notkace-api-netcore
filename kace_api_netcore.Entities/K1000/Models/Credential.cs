using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Credential
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int CredentialType { get; set; }
        public string Notes { get; set; }
        public DateTimeOffset Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public string UpUsername { get; set; }
        public string UpDomainname { get; set; }
        public byte[] UpPwEnc { get; set; }
        public int? UpTargets { get; set; }
        public string GoogleClientId { get; set; }
        public byte[] GoogleClientSecretEnc { get; set; }
        public byte[] GoogleAccessTokenEnc { get; set; }
        public string SnmpCommunity { get; set; }
        public string Snmpv3User { get; set; }
        public string Snmpv3SecurityLevel { get; set; }
        public string Snmpv3AuthProtocol { get; set; }
        public byte[] Snmpv3AuthPwEnc { get; set; }
        public string Snmpv3PrivacyProtocol { get; set; }
        public byte[] Snmpv3PrivacyPwEnc { get; set; }
        public byte[] SkSecretEnc { get; set; }
    }
}