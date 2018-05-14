using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.ParcelShops
{
    [DataContract]
    public class FindParcelShop
    {
        /// <summary>
        /// Street name (required when no zip code is set)
        /// </summary>
        [DataMember(Name = "street_line_1", EmitDefaultValue = false, IsRequired = false)]
        public string StreetLine1 { get; set; }

        /// <summary>
        /// House number
        /// </summary>
        [DataMember(Name = "number_line_1", EmitDefaultValue = false, IsRequired = true)]
        public string NumberLine1 { get; set; }

        /// <summary>
        /// Zip code (required when no street name is set)
        /// </summary>
        [DataMember(Name = "zip_code", EmitDefaultValue = false, IsRequired = false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = true)]
        public string City { get; set; }

        /// <summary>
        /// Must be the ISO 639-1 two letter code
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = true)]
        public string Country { get; set; }

        /// <summary>
        /// How many shops should be displayed per product (default 5)
        /// </summary>
        [DataMember(Name = "limit", EmitDefaultValue = false, IsRequired = false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Use the product names (i.e. DHL, DPD)
        /// </summary>
        [DataMember(Name = "products", EmitDefaultValue = false, IsRequired = true)]
        public string[] Products { get; set; }

        /// <summary>
        /// Latitude of GEO location (required when no zip code or street set)
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false, IsRequired = false)]
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude of the GEO location (required when no zip code or street set)
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false, IsRequired = false)]
        public string Longitude { get; set; }
    }
}
