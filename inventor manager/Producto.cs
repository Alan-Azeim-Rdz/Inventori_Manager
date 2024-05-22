using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventor_manager
{
    internal class Producto
    {
        protected string _price;
        protected string _quantity;
        protected string _mark;

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public Producto()
        {
            _price = "";
            _quantity = "";
            _mark = "";
        }

        public Producto(string price, string quantity, string mark)
        {
           _price = price;
           _quantity = quantity;
           _mark = mark;
            
        }

        public override string ToString()
        {
            return _price+ _quantity +_mark;
        }
    }
}
