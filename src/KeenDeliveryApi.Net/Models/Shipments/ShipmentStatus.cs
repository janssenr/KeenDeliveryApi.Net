using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KeenDeliveryApi.Net.Models.Shipments
{
    [DataContract]
    public class ShipmentStatus
    {
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Name = "pickup_date", EmitDefaultValue = false, IsRequired = true)]
        public DateTime? PickupDate { get; set; }

        [DataMember(Name = "amount", EmitDefaultValue = false, IsRequired = true)]
        public int Amount { get; set; }

        [DataMember(Name = "input", EmitDefaultValue = false, IsRequired = true)]
        public int Input { get; set; }

        [DataMember(Name = "ticket_number", EmitDefaultValue = false, IsRequired = true)]
        public string TicketNumber { get; set; }

        [DataMember(Name = "reference", EmitDefaultValue = false, IsRequired = true)]
        public string Reference { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false, IsRequired = true)]
        public ShipmentData Data { get; set; }

        [DataMember(Name = "return_data", EmitDefaultValue = false, IsRequired = true)]
        public ShipmentData ReturnData { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false, IsRequired = true)]
        public int Status { get; set; }

        [DataMember(Name = "label_printed", EmitDefaultValue = false, IsRequired = true)]
        public bool LabelPrinted { get; set; }

        [DataMember(Name = "invoice_status", EmitDefaultValue = false, IsRequired = true)]
        public int InvoiceStatus { get; set; }

        [DataMember(Name = "on_day_list", EmitDefaultValue = false, IsRequired = true)]
        public bool OnDayList { get; set; }

        [DataMember(Name = "delivered", EmitDefaultValue = false, IsRequired = true)]
        public bool Delivered { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false, IsRequired = true)]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "processed_at", EmitDefaultValue = false, IsRequired = true)]
        public DateTime? ProcessedAt { get; set; }

        [DataMember(Name = "updated_at", EmitDefaultValue = false, IsRequired = true)]
        public DateTime UpdatedAt { get; set; }

        [DataMember(Name = "weight", EmitDefaultValue = false, IsRequired = true)]
        public int Weight { get; set; }

        [DataMember(Name = "from_address", EmitDefaultValue = false, IsRequired = true)]
        public Address FromAddress { get; set; }

        [DataMember(Name = "to_address", EmitDefaultValue = false, IsRequired = true)]
        public Address ToAddress { get; set; }

        [DataMember(Name = "shipment_method", EmitDefaultValue = false, IsRequired = true)]
        public ShipmentMethod ShipmentMethod { get; set; }

        [DataMember(Name = "track_and_trace", EmitDefaultValue = false, IsRequired = true)]
        public Dictionary<string, string> TrackAndTrace { get; set; }
    }
}
