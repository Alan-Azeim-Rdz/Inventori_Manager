using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventor_manager
{
    internal class Not_Perishable : IProduct
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Mark { get; set; }

        public Not_Perishable(double price, int quantity, string mark)
        {
            Price = price;
            Quantity = quantity;
            Mark = mark;
        }

        public override string ToString()
        {
            return Price + " " + Quantity + " " + Mark.Replace(" ", "-");
        }

    }
}
