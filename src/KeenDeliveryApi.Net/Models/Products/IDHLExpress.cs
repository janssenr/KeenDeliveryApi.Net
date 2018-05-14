using KeenDeliveryApi.Net.Models.Shipments;

namespace KeenDeliveryApi.Net.Models.Products
{
    public interface IDhlExpress
    {
        //ShipmentService Service { get; set; }
        int Weight { get; set; }
        bool? SaturdayDelivery { get; set; }
        int? Length { get; set; }
        int? Width { get; set; }
        int? Height { get; set; }
        bool? NonStandardPickup { get; set; }
        bool? DutiesAndTaxesPaid { get; set; }
        bool? NeutralDelivery { get; set; }
        string Insurance { get; set; }
        bool? SendTrackAndTraceEmail { get; set; }
        string BccEmail { get; set; }
        string Dutiable { get; set; }

        ShipmentDuty Duty { get; set; }
    }
}
