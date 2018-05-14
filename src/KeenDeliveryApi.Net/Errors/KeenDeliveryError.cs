using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Errors
{
    [DataContract]
    public class KeenDeliveryError
    {
        [DataMember(Name = "error", EmitDefaultValue = false, IsRequired = true)]
        public string Error { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false, IsRequired = false)]
        public string Message { get; set; }
    }
}
