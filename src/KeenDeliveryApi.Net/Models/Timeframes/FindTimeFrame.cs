using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Timeframes
{
    [DataContract]
    public class FindTimeFrame
    {
        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = true)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "zip_code", EmitDefaultValue = false, IsRequired = true)]
        public string ZipCode { get; set; }
    }
}
