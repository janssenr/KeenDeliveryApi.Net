using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Shipments
{
    [DataContract]
    public class ShipmentDefaultData
    {
        [DataMember(Name = "amount", EmitDefaultValue = false, IsRequired = true)]
        public int Amount { get; set; }

        [DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = false)]
        public int Weight { get; set; }

        [DataMember(Name = "reference", EmitDefaultValue = false, IsRequired = true)]
        public string Reference { get; set; }

        [DataMember(Name = "internal_reference", EmitDefaultValue = false, IsRequired = true)]
        public string InternalReference { get; set; }
    }
}
