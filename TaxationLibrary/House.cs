using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxationLibrary
{
    public class House : FixedProperty, ITaxable
    {
        double area;

        public House(string location, bool inCity, decimal estimatedValue, double area) : base(location, inCity, estimatedValue)
        {
            this.area = area;
        }

        public decimal TaxValue()
        {
            return (decimal)(1.5 * area);
        }
    }
}
