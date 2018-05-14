using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.DeliverySchedules
{
    [DataContract]
    public class DeliverySchedule
    {
        [DataMember(Name = "from", EmitDefaultValue = false, IsRequired = true)]
        public string From { get; set; }

        [DataMember(Name = "to", EmitDefaultValue = false, IsRequired = true)]
        public string To { get; set; }
    }
}
