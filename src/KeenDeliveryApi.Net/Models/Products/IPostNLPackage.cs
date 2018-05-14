namespace KeenDeliveryApi.Net.Models.Products
{
    public interface IPostNlPackage
    {
        //ShipmentService Service { get; set; }
        int Amount { get; set; }
        int Weight { get; set; }
        string Reference { get; set; }
        string InternalReference { get; set; }
        string Email { get; set; }
        bool? SendTrackAndTraceEmail { get; set; }
        string BccEmail { get; set; }
        bool? OnlyHomeAddress { get; set; }
        bool? IncreasedLiability { get; set; }
        int? InsuredAmount { get; set; }
        string DeliveryDay { get; set; }
        string DeliveryTime { get; set; }
        bool? PaymentOnReceipt { get; set; }
        int? PaymentAmount { get; set; }
        string IbanNumber { get; set; }
        string IbanName { get; set; }
        bool? SignatureRequired { get; set; }
        bool? AgeVerification18Plus { get; set; }
        bool? BirthdateVerification { get; set; }
        string ReceiverDateOfBirth { get; set; }
        bool? IdVerification { get; set; }
        string IdType { get; set; }
        string IdNumber { get; set; }
        string IdExpirationDate { get; set; }
        string PostnlShipmentOptions { get; set; }
        string ReceiverMobile { get; set; }
    }
}
