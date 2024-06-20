using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PPU6
{
    internal class Store
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int PriceValue { get; set; }

        public Store(string storeName, string type, int priceValue)
        {
            Name = storeName;    
            Type = type;    
            PriceValue = priceValue;
        }

        

    }
}
