using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.ShippingMethods
{
    [DataContract]
    public class ShippingMethod
    {
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public string Value { get; set; }

        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = true)]
        public string Text { get; set; }

        [DataMember(Name = "services", EmitDefaultValue = false, IsRequired = true)]
        public Dictionary<string, ShippingMethodService> Services { get; set; }
    }
}
