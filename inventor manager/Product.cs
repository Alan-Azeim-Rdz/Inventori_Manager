using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventor_manager
{
    internal class Product
    {
        protected int _price;
        protected int _quantity;
        protected string _mark;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public Product()
        {
            _price = 0;
            _quantity = 0;
            _mark = "";
        }

        public Product(int price, int quantity, string mark)
        {
           _price = price;
           _quantity = quantity;
           _mark = mark;
            
        }

        public override string ToString()
        {
            return "$" + _price + " " + _quantity  +" "+_mark;
        }
    }
}
