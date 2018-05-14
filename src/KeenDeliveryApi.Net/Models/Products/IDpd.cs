namespace KeenDeliveryApi.Net.Models.Products
{
    public interface IDpd
    {
        //ShipmentService Service { get; set; }
        int? ProductType { get; set; }
        int? Predict { get; set; }
        string Cod { get; set; }
        bool? Return { get; set; }
        bool? SaturdayDelivery { get; set; }
        string DpdDepot { get; set; }
        string ParcelShopId { get; set; }
        bool? SendTrackAndTraceEmail { get; set; }
        //bool? PickupDate { get; set; }
        string BccEmail { get; set; }
    }
}
