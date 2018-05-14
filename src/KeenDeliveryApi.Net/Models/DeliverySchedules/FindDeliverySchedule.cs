using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.DeliverySchedules
{
    [DataContract]
    public class FindDeliverySchedule
    {
        /// <summary>
        /// Zip code (required when no street name is set)
        /// </summary>
        [DataMember(Name = "zip_code", EmitDefaultValue = false, IsRequired = true)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Use the product names (i.e. DHL, DPD)
        /// </summary>
        [DataMember(Name = "products", EmitDefaultValue = false, IsRequired = true)]
        public string[] Products { get; set; }
    }
}
