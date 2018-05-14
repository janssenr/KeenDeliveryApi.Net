using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.ParcelShops
{
    [DataContract]
    public class OpeningHour
    {
        [DataMember(Name = "afternoon_close", EmitDefaultValue = false, IsRequired = true)]
        public string AfternoonClose { get; set; }

        [DataMember(Name = "afternoon_open", EmitDefaultValue = false, IsRequired = true)]
        public string AfternoonOpen { get; set; }

        [DataMember(Name = "morning_open", EmitDefaultValue = false, IsRequired = true)]
        public string MorningOpen { get; set; }

        [DataMember(Name = "morning_close", EmitDefaultValue = false, IsRequired = true)]
        public string MorningClose { get; set; }

        [DataMember(Name = "weekday", EmitDefaultValue = false, IsRequired = true)]
        public int Weekday { get; set; }
    }
}
