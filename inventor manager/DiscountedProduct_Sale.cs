using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventor_manager
{
    internal class DiscountedProduct_Sale : Product_Sale
    {
        public double DiscountPercentage { get; set; }

        public DiscountedProduct_Sale(string name, double price, int quantity, double discountPercentage)
            : base(name, price, quantity)
        {
            DiscountPercentage = discountPercentage;
        }

        public double GetDiscountedPrice()
        {
            return Price * (1 - DiscountPercentage);
        }

        public override string ToString()
        {
            return "El producto" + Name + "tiene un descuento de 10%" 
                + " y su precio final es " + GetDiscountedPrice().ToString("F2");
        }

    }
}
