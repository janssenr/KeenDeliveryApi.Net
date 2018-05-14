using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Shipments
{
    [DataContract]
    public class ShipmentService
    {
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public string Value { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "cod", EmitDefaultValue = false, IsRequired = false)]
        public string Cod { get; set; }

        [DataMember(Name = "return", EmitDefaultValue = false, IsRequired = false)]
        public bool? Return { get; set; }

        [DataMember(Name = "saturday_delivery", EmitDefaultValue = false, IsRequired = false)]
        public bool? SaturdayDelivery { get; set; }
    }
}
