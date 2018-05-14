using System;
using System.Runtime.Serialization;
using KeenDeliveryApi.Net.Models.Products;

namespace KeenDeliveryApi.Net.Models.Shipments
{
    [DataContract]
    public class ShipmentData : ShipmentDefaultData, IDhl, IDhlExpress, IDhlPallet, IDhlParcelshop, IDpd, IJetVerzendtPallets, IKeenSpecials, IMendrix, IPostNlPackage, IPostNlMailbox, ITnt
    {
        [DataMember(Name = "package_type", EmitDefaultValue = false, IsRequired = false)]
        public string PackageType { get; set; }

        [DataMember(Name = "method", EmitDefaultValue = false, IsRequired = false)]
        public ShipmentMethod Method { get; set; }

        [DataMember(Name = "service", EmitDefaultValue = false, IsRequired = true)]
        public ShipmentService Service { get; set; }

        [DataMember(Name = "comment", EmitDefaultValue = false, IsRequired = false)]
        public string Comment { get; set; }


        [DataMember(Name = "package_description", EmitDefaultValue = false, IsRequired = false)]
        public string PackageDescription { get; set; }

        [DataMember(Name = "delivery_instruction", EmitDefaultValue = false, IsRequired = false)]
        public string DeliveryInstruction { get; set; }

        [DataMember(Name = "length", EmitDefaultValue = false, IsRequired = false)]
        public int? Length { get; set; }

        [DataMember(Name = "product_description", EmitDefaultValue = false, IsRequired = false)]
        public string ProductDescription { get; set; }

        [DataMember(Name = "priority", EmitDefaultValue = false, IsRequired = false)]
        public bool? Priority { get; set; }

        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public int? Width { get; set; }

        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public int? Height { get; set; }

        [DataMember(Name = "non_standard_pickup", EmitDefaultValue = false, IsRequired = false)]
        public bool? NonStandardPickup { get; set; }

        [DataMember(Name = "duties_and_taxes_paid", EmitDefaultValue = false, IsRequired = false)]
        public bool? DutiesAndTaxesPaid { get; set; }

        [DataMember(Name = "neutral_delivery", EmitDefaultValue = false, IsRequired = false)]
        public bool? NeutralDelivery { get; set; }

        [DataMember(Name = "insurance", EmitDefaultValue = false, IsRequired = false)]
        public string Insurance { get; set; }

        [DataMember(Name = "goods_value", EmitDefaultValue = false, IsRequired = false)]
        public string GoodsValue { get; set; }

        [DataMember(Name = "dutiable", EmitDefaultValue = false, IsRequired = false)]
        public string Dutiable { get; set; }

        [DataMember(Name = "duty", EmitDefaultValue = false, IsRequired = false)]
        public ShipmentDuty Duty { get; set; }

        [DataMember(Name = "loading_meters", EmitDefaultValue = false, IsRequired = false)]
        public int? LoadingMeters { get; set; }

        [DataMember(Name = "product_type", EmitDefaultValue = false, IsRequired = false)]
        public int? ProductType { get; set; }

        [DataMember(Name = "predict", EmitDefaultValue = false, IsRequired = false)]
        public int? Predict { get; set; }

        [DataMember(Name = "use_tailgate", EmitDefaultValue = false, IsRequired = false)]
        public bool? UseTailGate { get; set; }

        [DataMember(Name = "extra_insurance", EmitDefaultValue = false, IsRequired = false)]
        public bool? ExtraInsurance { get; set; }

        [DataMember(Name = "cod", EmitDefaultValue = false, IsRequired = false)]
        public string Cod { get; set; }

        [DataMember(Name = "return", EmitDefaultValue = false, IsRequired = false)]
        public bool? Return { get; set; }

        [DataMember(Name = "saturday_delivery", EmitDefaultValue = false, IsRequired = false)]
        public bool? SaturdayDelivery { get; set; }

        [DataMember(Name = "dpd_depot", EmitDefaultValue = false, IsRequired = false)]
        public string DpdDepot { get; set; }

        [DataMember(Name = "parcel_shop_id", EmitDefaultValue = false, IsRequired = false)]
        public string ParcelShopId { get; set; }

        [DataMember(Name = "parcel_shop_harmonised_id", EmitDefaultValue = false, IsRequired = false)]
        public string ParcelShopHarmonisedId { get; set; }

        [DataMember(Name = "pallet", EmitDefaultValue = false, IsRequired = false)]
        public string Pallet { get; set; }

        //[DataMember(Name = "pickup_date", EmitDefaultValue = false, IsRequired = false)]
        //public DateTime? PickupDate { get; set; }

        [DataMember(Name = "pickup_time_from", EmitDefaultValue = false, IsRequired = false)]
        public string PickupTimeFrom { get; set; }

        [DataMember(Name = "pickup_time_till", EmitDefaultValue = false, IsRequired = false)]
        public string PickupTimeTill { get; set; }

        [DataMember(Name = "pickup_comment", EmitDefaultValue = false, IsRequired = false)]
        public string PickupComment { get; set; }

        [DataMember(Name = "delivery_date", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? DeliveryDate { get; set; }

        [DataMember(Name = "delivery_time_from", EmitDefaultValue = false, IsRequired = false)]
        public string DeliveryTimeFrom { get; set; }

        [DataMember(Name = "delivery_time_till", EmitDefaultValue = false, IsRequired = false)]
        public string DeliveryTimeTill { get; set; }

        [DataMember(Name = "delivery_comment", EmitDefaultValue = false, IsRequired = false)]
        public string DeliveryComment { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false, IsRequired = false)]
        public string Email { get; set; }

        [DataMember(Name = "send_track_and_trace_email", EmitDefaultValue = false, IsRequired = false)]
        public bool? SendTrackAndTraceEmail { get; set; }

        [DataMember(Name = "from_time", EmitDefaultValue = false, IsRequired = false)]
        public string FromTime { get; set; }

        [DataMember(Name = "to_time", EmitDefaultValue = false, IsRequired = false)]
        public string ToTime { get; set; }

        [DataMember(Name = "bcc_email", EmitDefaultValue = false, IsRequired = false)]
        public string BccEmail { get; set; }

        [DataMember(Name = "only_home_address", EmitDefaultValue = false, IsRequired = false)]
        public bool? OnlyHomeAddress { get; set; }

        [DataMember(Name = "increased_liability", EmitDefaultValue = false, IsRequired = false)]
        public bool? IncreasedLiability { get; set; }

        [DataMember(Name = "insured_amount", EmitDefaultValue = false, IsRequired = false)]
        public int? InsuredAmount { get; set; }

        [DataMember(Name = "delivery_day", EmitDefaultValue = false, IsRequired = false)]
        public string DeliveryDay { get; set; }

        [DataMember(Name = "delivery_time", EmitDefaultValue = false, IsRequired = false)]
        public string DeliveryTime { get; set; }

        [DataMember(Name = "payment_on_receipt", EmitDefaultValue = false, IsRequired = false)]
        public bool? PaymentOnReceipt { get; set; }

        [DataMember(Name = "payment_amount", EmitDefaultValue = false, IsRequired = false)]
        public int? PaymentAmount { get; set; }

        [DataMember(Name = "iban_number", EmitDefaultValue = false, IsRequired = false)]
        public string IbanNumber { get; set; }

        [DataMember(Name = "iban_name", EmitDefaultValue = false, IsRequired = false)]
        public string IbanName { get; set; }

        [DataMember(Name = "signature_required", EmitDefaultValue = false, IsRequired = false)]
        public bool? SignatureRequired { get; set; }

        [DataMember(Name = "not_by_neighbours", EmitDefaultValue = false, IsRequired = false)]
        public bool? NotByNeighbours { get; set; }

        [DataMember(Name = "evening", EmitDefaultValue = false, IsRequired = false)]
        public bool? Evening { get; set; }

        [DataMember(Name = "age_verification_18plus", EmitDefaultValue = false, IsRequired = false)]
        public bool? AgeVerification18Plus { get; set; }

        [DataMember(Name = "birthdate_verification", EmitDefaultValue = false, IsRequired = false)]
        public bool? BirthdateVerification { get; set; }

        [DataMember(Name = "receiver_date_of_birth", EmitDefaultValue = false, IsRequired = false)]
        public string ReceiverDateOfBirth { get; set; }

        [DataMember(Name = "id_verification", EmitDefaultValue = false, IsRequired = false)]
        public bool? IdVerification { get; set; }

        [DataMember(Name = "id_type", EmitDefaultValue = false, IsRequired = false)]
        public string IdType { get; set; }

        [DataMember(Name = "id_number", EmitDefaultValue = false, IsRequired = false)]
        public string IdNumber { get; set; }

        [DataMember(Name = "id_expiration_date", EmitDefaultValue = false, IsRequired = false)]
        public string IdExpirationDate { get; set; }

        [DataMember(Name = "postnl_shipment_options", EmitDefaultValue = false, IsRequired = false)]
        public string PostnlShipmentOptions { get; set; }

        [DataMember(Name = "receiver_mobile", EmitDefaultValue = false, IsRequired = false)]
        public string ReceiverMobile { get; set; }


        [DataMember(Name = "dhl_account_number", EmitDefaultValue = false, IsRequired = false)]
        public string DhlAccountNumber { get; set; }

        [DataMember(Name = "dhl_depot", EmitDefaultValue = false, IsRequired = false)]
        public string DhlDepot { get; set; }

        [DataMember(Name = "return_label", EmitDefaultValue = false, IsRequired = false)]
        public bool? ReturnLabel { get; set; }
    }
}
