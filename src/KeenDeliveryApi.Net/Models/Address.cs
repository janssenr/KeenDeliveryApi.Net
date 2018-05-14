using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models
{
    [DataContract]
    public class Address
    {
        /// <summary>
        /// Name of the company, when no company name available contact name is accepted
        /// </summary>
        [DataMember(Name = "company_name", EmitDefaultValue = false, IsRequired = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "vat_number", EmitDefaultValue = false, IsRequired = false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "street_line_1", EmitDefaultValue = false, IsRequired = true)]
        public string StreetLine1 { get; set; }

        /// <summary>
        /// House number might include additions
        /// </summary>
        [DataMember(Name = "number_line_1", EmitDefaultValue = false, IsRequired = true)]
        public string NumberLine1 { get; set; }

        /// <summary>
        /// Use this field to add a house number addition like a or an extra number
        /// </summary>
        [DataMember(Name = "number_line_1_addition", EmitDefaultValue = false, IsRequired = false)]
        public string NumberLine1Addition { get; set; }

        /// <summary>
        /// Will be shown on label, can be used for second address rule
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false, IsRequired = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Must meet the country standards or the request will fail
        /// </summary>
        [DataMember(Name = "zip_code", EmitDefaultValue = false, IsRequired = true)]
        public string ZipCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false, IsRequired = true)]
        public string City { get; set; }

        /// <summary>
        /// Name of the contact person
        /// </summary>
        [DataMember(Name = "contact_person", EmitDefaultValue = false, IsRequired = false)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Optional but might be mandatory based on the selected product
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false, IsRequired = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Optional but might be mandatory based on the selected product
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = false)]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "state_id", EmitDefaultValue = false, IsRequired = false)]
        public int? StateId { get; set; }

        /// <summary>
        /// Must be the ISO_3166-1 two letter code
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false, IsRequired = true)]
        public string Country { get; set; }
    }
}
