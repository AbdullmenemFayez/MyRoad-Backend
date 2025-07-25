﻿using System.Text.Json.Serialization;

namespace MyRoad.API.Suppliers.RequestDto
{
    public class CreateSuppliersDto
    {
        [JsonPropertyName("supplierName")] public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}
