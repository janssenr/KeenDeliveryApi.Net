using System.Collections.Generic;
using System.Runtime.Serialization;
using KeenDeliveryApi.Net.Models.DeliverySchedules;
using KeenDeliveryApi.Net.Models.ParcelShops;
using KeenDeliveryApi.Net.Models.ShippingMethods;
using KeenDeliveryApi.Net.Models.Timeframes;

namespace KeenDeliveryApi.Net.Wrappers
{
    [DataContract]
    public class DataWrapper
    {
        //[DataMember(Name = "labels", EmitDefaultValue = false, IsRequired = false)]
        //public string Labels { get; set; }

        [DataMember(Name = "parcel_shops", EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, ParcelShop[]> ParcelShops { get; set; }

        [DataMember(Name = "schedule", EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string, Dictionary<string, DeliverySchedule[]>> DeliverySchedules { get; set; }

        [DataMember(Name = "shipping_methods", EmitDefaultValue = false, IsRequired = false)]
        public ShippingMethod[] ShippingMethods { get; set; }

        [DataMember(Name = "timeframes", EmitDefaultValue = false, IsRequired = false)]
        public TimeframeData Timeframes { get; set; }
    }
}
