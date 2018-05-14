using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.ShippingMethods
{
    [DataContract]
    public class ShippingMethodServiceOptionChoice
    {
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = true)]
        public string Value { get; set; }

        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = true)]
        public string Text { get; set; }
    }
}
