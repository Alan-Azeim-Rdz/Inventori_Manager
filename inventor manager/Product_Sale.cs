﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventor_manager
{
    internal class Product_Sale
    {
        public string Name { get; }


        public int Stock
        {
            set
            {
                quantity = value;
            }
        }



        public double Price { get; set; }

        private int quantity;



        // Constructor 
        public Product_Sale()
        {
            Name = "";
            Price = 0;
            quantity = 0;
        }



        // Constructor with Parameters
        public Product_Sale(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Stock = quantity; // Enforces stock validation through the setter
        }



        // Method to Reduce Stock (assuming a sale)
        public void ReduceStock(int soldQuantity)
        {
            if (soldQuantity <= quantity)
            {
                quantity -= soldQuantity;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Sold quantity cannot exceed available stock.");
            }
        }

        // Method to Increase Stock (e.g., if a sale is removed)
        public void IncreaseStock(int quantityToAdd)
        {
            quantity += quantityToAdd;
        }



        public override string ToString() 
        {
            return "el producto " + Name + " tiene a la venta " + quantity + " artuculos disponibles " + "y el precio de cada uno es "+ Price;
        }
    }
}
