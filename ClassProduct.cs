using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast02
{
    internal class ClassProduct
    {
        public string Product { set; get; }
        public string Quantity { set; get; }

        public ClassProduct(string product, string quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
