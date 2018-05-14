using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Shipments
{
    [DataContract]
    public class Shipment
    {
        [DataMember(Name = "shipment_id", EmitDefaultValue = false, IsRequired = true)]
        public int ShipmentId { get; set; }

        [DataMember(Name = "shipment_method", EmitDefaultValue = false, IsRequired = true)]
        public ShipmentMethod ShipmentMethod { get; set; }

        [DataMember(Name = "label", EmitDefaultValue = false, IsRequired = true)]
        public string Label { get; set; }

        [DataMember(Name = "track_and_trace", EmitDefaultValue = false, IsRequired = true)]
        public Dictionary<string, string> TrackAndTrace { get; set; }
    }
}
