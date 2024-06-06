using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventor_manager
{
    internal class Perishable : IProduct
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Mark { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Perishable(double price, int quantity, string mark, DateTime expirationDate)
        {
            Price = price;
            Quantity = quantity;
            Mark = mark;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return Price + " " + Quantity + " " + Mark.Replace(" ", "-") + " " + ExpirationDate;
        }

    }
}
