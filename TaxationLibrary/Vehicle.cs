using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxationLibrary
{
    public class Vehicle
    {
        int registrationNumber;
        double maxVelocity;
        decimal value;

        public Vehicle(int registrationNumber, double maxVelocity, decimal value)
        {
            this.registrationNumber = registrationNumber;
            this.maxVelocity = maxVelocity;
            this.value = value;
        }
    }
}
