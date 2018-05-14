using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Labels
{
    [DataContract]
    public class Label
    {
        [DataMember(Name = "labels", EmitDefaultValue = false, IsRequired = true)]
        public string Labels { get; set; }
    }
}
