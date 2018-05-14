namespace KeenDeliveryApi.Net.Models.Products
{
    public interface ITnt
    {
        string PackageType { get; set; }
        int Weight { get; set; }
        string PackageDescription { get; set; }
        string DeliveryInstruction { get; set; }
        string Insurance { get; set; }
        string GoodsValue { get; set; }
        bool? Priority { get; set; }
        int? Width { get; set; }
        int? Length { get; set; }
        int? Height { get; set; }
        string Reference { get; set; }
        bool? SendTrackAndTraceEmail { get; set; }
        string FromTime { get; set; }
        string ToTime { get; set; }
    }
}
