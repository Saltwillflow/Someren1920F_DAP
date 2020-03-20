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
        public Decimal Revenue
        {
            get
            {
                return TotalSold * Price;
            }
        }
        public Decimal TotalTax
        {
            get
            {
                if (Alcoholic)
                {
                    return Revenue * 0.21M;
                }
                else return Revenue * 0.06M;
            }
        }
        public int Stock { get; set; }

    }
}
