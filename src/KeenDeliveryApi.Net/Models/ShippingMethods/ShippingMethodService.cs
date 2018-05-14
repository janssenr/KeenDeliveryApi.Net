using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.ShippingMethods
{
    [DataContract]
    public class ShippingMethodService
    {
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public string Value { get; set; }

        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = true)]
        public string Text { get; set; }

        [DataMember(Name = "options", EmitDefaultValue = false, IsRequired = true)]
        public Dictionary<string, ShippingMethodServiceOption> Options { get; set; }
    }
}
