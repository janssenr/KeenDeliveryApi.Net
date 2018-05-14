namespace KeenDeliveryApi.Net.Models.Products
{
    public interface IKeenSpecials
    {
        string PackageType { get; set; }
        int Weight { get; set; }
        string ProductDescription { get; set; }
        int? Width { get; set; }
        int? Length { get; set; }
        int? Height { get; set; }
        string Reference { get; set; }
        bool? SendTrackAndTraceEmail { get; set; }
    }
}
