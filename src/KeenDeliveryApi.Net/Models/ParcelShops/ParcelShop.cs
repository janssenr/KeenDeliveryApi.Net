using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.ParcelShops
{
    [DataContract]
    public class ParcelShop
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Name = "street", EmitDefaultValue = false, IsRequired = true)]
        public string Street { get; set; }

        [DataMember(Name = "house_number", EmitDefaultValue = false, IsRequired = true)]
        public string HouseNumber { get; set; }

        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = true)]
        public string Country { get; set; }

        [DataMember(Name = "zip_code", EmitDefaultValue = false, IsRequired = true)]
        public string ZipCode { get; set; }

        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = true)]
        public string City { get; set; }

        [DataMember(Name = "longitude", EmitDefaultValue = false, IsRequired = true)]
        public double Longitude { get; set; }

        [DataMember(Name = "latitude", EmitDefaultValue = false, IsRequired = true)]
        public double Latitude { get; set; }

        [DataMember(Name = "opening_hours", EmitDefaultValue = false, IsRequired = true)]
        public OpeningHour[] OpeningHours { get; set; }
    }
}
