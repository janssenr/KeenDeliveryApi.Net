using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Labels
{
    [DataContract]
    public class CreateLabel
    {
        [DataMember(Name = "shipments", EmitDefaultValue = false, IsRequired = true)]
        public int[] Shipments { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = true)]
        public string Type { get; set; }
    }
}
