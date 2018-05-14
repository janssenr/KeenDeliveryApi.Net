using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Shipments
{
    [DataContract]
    public class ShipmentMethod
    {
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "class", EmitDefaultValue = false, IsRequired = true)]
        public string Class { get; set; }

        [DataMember(Name = "has_delivery_status", EmitDefaultValue = false, IsRequired = false)]
        public bool HasDeliveryStatus { get; set; }

        [DataMember(Name = "has_import", EmitDefaultValue = false, IsRequired = false)]
        public bool HasImport { get; set; }

        [DataMember(Name = "has_documents", EmitDefaultValue = false, IsRequired = false)]
        public bool HasDocuments { get; set; }

        [DataMember(Name = "order", EmitDefaultValue = false, IsRequired = false)]
        public string Order { get; set; }

        [DataMember(Name = "has_zones", EmitDefaultValue = false, IsRequired = false)]
        public bool HasZones { get; set; }
    }
}
