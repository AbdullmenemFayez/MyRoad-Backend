﻿namespace MyRoad.API.Payments.SupplierPayments.RequestDto
{
    public class CreateSupplierPaymentDto
    {
        public decimal Amount { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string? Notes { get; set; }
        public long SupplierId { get; set; }
    }
}
