﻿using System;
namespace Domain;

public class OrderItem
{
    public int Id { get; set; }
    public required string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

