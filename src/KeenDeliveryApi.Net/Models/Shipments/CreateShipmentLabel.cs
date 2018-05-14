using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Shipments
{
    [DataContract]
    public class CreateShipmentLabel
    {
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = true)]
        public string Type { get; set; }

        [DataMember(Name = "size", EmitDefaultValue = false, IsRequired = false)]
        public string Size { get; set; }
    }
}
