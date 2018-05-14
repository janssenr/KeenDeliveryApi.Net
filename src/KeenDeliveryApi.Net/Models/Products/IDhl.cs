namespace KeenDeliveryApi.Net.Models.Products
{
    public interface IDhl
    {
        int Weight { get; set; }
        bool? SaturdayDelivery { get; set; }
        bool? SignatureRequired { get; set; }
        bool? NotByNeighbours { get; set; }
        bool? Evening { get; set; }
        bool? ExtraInsurance { get; set; }
        string Cod { get; set; }
        string Insurance { get; set; }
        bool? SendTrackAndTraceEmail { get; set; }
        string ParcelShopId { get; set; }
    }
}
