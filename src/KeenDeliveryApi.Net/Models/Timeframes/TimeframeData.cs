using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Timeframes
{
    [DataContract]
    public class TimeframeData
    {
        [DataMember(Name = "reason_no_timeframe", EmitDefaultValue = false, IsRequired = true)]
        public ReasonNoTimeframe[] ReasonNoTimeframe { get; set; }

        [DataMember(Name = "timeframes", EmitDefaultValue = false, IsRequired = true)]
        public Timeframe[] Timeframes { get; set; }
    }
}
