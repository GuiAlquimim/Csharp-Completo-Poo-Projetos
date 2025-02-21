﻿using System;
using System.Globalization;

namespace _132_exercicio_proposto_enumeracoes_composicao.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price.ToString("f2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, SubTotal: ${SubTotal().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
