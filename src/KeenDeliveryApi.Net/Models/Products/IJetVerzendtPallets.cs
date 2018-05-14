using System;

namespace KeenDeliveryApi.Net.Models.Products
{
    public interface IJetVerzendtPallets
    {
        //ShipmentService Service { get; set; }
        int? Length { get; set; }
        int? Width { get; set; }
        int? Height { get; set; }
        int? LoadingMeters { get; set; }
        bool? SaturdayDelivery { get; set; }
        string Pallet { get; set; }
        //DateTime? PickupDate { get; set; }
        string PickupTimeFrom { get; set; }
        string PickupTimeTill { get; set; }
        string PickupComment { get; set; }
        DateTime? DeliveryDate { get; set; }
        string DeliveryTimeFrom { get; set; }
        string DeliveryTimeTill { get; set; }
        string DeliveryComment { get; set; }

        bool? UseTailGate { get; set; }
        string Cod { get; set; }
    }
}
