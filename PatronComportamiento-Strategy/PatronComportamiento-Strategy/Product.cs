using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComportamiento_Strategy
{
    public class Product
    {
        private string v1;
        private decimal v2;
        public Product(string n,int p)
        {
            ProductName = n;
            Price = p;
        }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
