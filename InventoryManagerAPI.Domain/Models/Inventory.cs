﻿using System.Runtime.CompilerServices;
using CsvHelper.Configuration.Attributes;

namespace InventoryManagerAPI.Domain.Models;

public class Inventory
{
    public int ProductId { get; set; }
    public string? Sku { get; set; }
    public string? Unit { get; set; }
    public decimal Qty { get; set; }
    public string? Manufacturer { get; set; }
    public string Shipping { get; set; }
    public decimal? ShippingCost { get; set; }
}