using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Timeframes
{
    [DataContract]
    public class ReasonNoTimeframe
    {
        [DataMember(Name = "code", EmitDefaultValue = false, IsRequired = true)]
        public string Code { get; set; }

        [DataMember(Name = "date", EmitDefaultValue = false, IsRequired = true)]
        public DateTime Date { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = true)]
        public string Description { get; set; }

        [DataMember(Name = "options", EmitDefaultValue = false, IsRequired = true)]
        public Dictionary<string, string> Options { get; set; }
    }
}
