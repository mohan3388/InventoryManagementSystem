using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockDetails
    {
        public String StockName { get; set; }
        public int NumberOFShare { get; set; }
        public decimal SharePrice { get; set; }
    }
}