namespace KeenDeliveryApi.Net.Models.Products
{
    public interface IPostNlMailbox
    {
        //ShipmentService Service { get; set; }
        int Amount { get; set; }
        int Weight { get; set; }
        string Reference { get; set; }
        string InternalReference { get; set; }
        bool? SendTrackAndTraceEmail { get; set; }
        string BccEmail { get; set; }
    }
}
