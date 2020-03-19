using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Beverage
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Decimal Price { get; set; }
        public bool Alcoholic { get; set; }
        public int TotalSold { get; set; }
        public Decimal Revenue { get; set; }
        public Decimal TotalTax { get; set; }
        public int Stock { get; set; }

    }
}
