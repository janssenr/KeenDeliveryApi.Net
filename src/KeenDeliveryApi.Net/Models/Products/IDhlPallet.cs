using System;

namespace KeenDeliveryApi.Net.Models.Products
{
    public interface IDhlPallet
    {
        int? Length { get; set; }
        int? Width { get; set; }
        int? Height { get; set; }
        bool? SaturdayDelivery { get; set; }
        int Weight { get; set; }
        //DateTime? PickupDate { get; set; }
    }
}
