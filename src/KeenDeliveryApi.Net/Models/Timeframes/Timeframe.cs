using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Timeframes
{
    [DataContract]
    public class Timeframe
    {
        [DataMember(Name = "date", EmitDefaultValue = false, IsRequired = true)]
        public DateTime Date { get; set; }

        [DataMember(Name = "from", EmitDefaultValue = false, IsRequired = true)]
        public string From { get; set; }

        [DataMember(Name = "to", EmitDefaultValue = false, IsRequired = true)]
        public string To { get; set; }

        [DataMember(Name = "options", EmitDefaultValue = false, IsRequired = true)]
        public Dictionary<string, string> Options { get; set; }
    }
}
