using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.ShippingMethods
{
    [DataContract]

    public class ShippingMethodServiceOption
    {
        [DataMember(Name = "field", EmitDefaultValue = false, IsRequired = true)]
        public string Field { get; set; }

        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = true)]
        public string Text { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = true)]
        public string Type { get; set; }

        [DataMember(Name = "mandatory", EmitDefaultValue = false, IsRequired = true)]
        public bool Mandotary { get; set; }

        [DataMember(Name = "choices", EmitDefaultValue = false, IsRequired = true)]
        public Dictionary<string, ShippingMethodServiceOptionChoice> Choices { get; set; }
    }
}
