using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxationLibrary
{
    public class Bus : Vehicle, ITaxable
    {
        int numberOfSeats;

        public Bus(int registrationNumber, double maxVelocity, decimal value, int numberOfSeats) : base(registrationNumber, maxVelocity, value)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public decimal TaxValue()
        {
            return (decimal)(numberOfSeats * 1.5);
        }
    }
}
