using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Shipments
{
    [DataContract]
    public class ShipmentDuty
    {
        [DataMember(Name = "declared_value", EmitDefaultValue = false, IsRequired = true)]
        public int DeclaredValue { get; set; }

        [DataMember(Name = "enabled", EmitDefaultValue = false, IsRequired = true)]
        public bool Enabled { get; set; }

        [DataMember(Name = "duties_and_taxes_paid", EmitDefaultValue = false, IsRequired = true)]
        public bool DutiesAndTaxesPaid { get; set; }
    }
}
