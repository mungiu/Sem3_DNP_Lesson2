using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxationLibrary
{
    public class FixedProperty
    {
        string location;
        bool inCity;
        decimal estimatedValue;

        public FixedProperty(string location, bool inCity, decimal estimatedValue)
        {
            this.location = location;
            this.inCity = inCity;
            this.estimatedValue = estimatedValue;
        }
    }
}
