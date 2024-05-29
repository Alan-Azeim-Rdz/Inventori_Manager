using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventor_manager
{
    internal class Producto_Sale
    {
        public string Name { get; }

        public int Stock
        {
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("El Inventario no puede ser negativo");
                }
            }
        }

        public double Price { get; set; }

        private int quantity;


        // Constructor 
        public Producto_Sale()
        {
            Name = "";
            Price = 0;
            quantity = 0;
        }

        // Constructor with Parameters
        public Producto_Sale(string name, double price, int quantity)
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

        public override string ToString() 
        {
            return "el producto " + Name + " tiene a la venta " + quantity + " artuculos disponibles " + "y el precio de cada uno es "+ Price;
        }
    }
}
