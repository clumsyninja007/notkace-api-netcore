using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonAlert
    {
        public long KmonAlertId { get; set; }
        public long? KmonMonitoredDeviceId { get; set; }
        public long? KmonConditionId { get; set; }
        public long RepeatCount { get; set; }
        public DateTime ClientCreateTime { get; set; }
        public DateTime ClientRepeatTime { get; set; }
        public DateTimeOffset ServerCreateTime { get; set; }
        public DateTimeOffset ServerRepeatTime { get; set; }
        public byte? Acknowledged { get; set; }
        public string Message { get; set; }
        public string DynamicMessage { get; set; }
        public string MessageConstant { get; set; }

        public virtual KmonCondition KmonCondition { get; set; }
        public virtual KmonMonitoredDevice KmonMonitoredDevice { get; set; }
    }
}