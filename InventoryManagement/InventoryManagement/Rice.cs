using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Rice
    {
        public List<TypesofRice> typesofRice;
    }

    public class TypesofRice
    {
        public string name;
        public int weight;
        public int price;
    }
}
