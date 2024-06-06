using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventor_manager
{
    internal interface IProduct
    {
        double Price { get; set; }
        int Quantity { get; set; }
        string Mark { get; set; }
        string ToString();

    }
}
