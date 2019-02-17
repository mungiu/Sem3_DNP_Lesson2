using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxationLibrary;

namespace TestTaxationLibrary
{
    class Program
    {

        static void Main(string[] args)
        {
            List<TaxationLibrary.ITaxable> taxableList = new List<TaxationLibrary.ITaxable>();
            TaxationLibrary.House myHouse = new TaxationLibrary.House("home", true, 70000, 150.53);
            TaxationLibrary.Bus myBus = new TaxationLibrary.Bus(123456, 180.53, 5000, 7);

            taxableList.Add(myHouse);
            taxableList.Add(myBus);

            foreach (TaxationLibrary.ITaxable item  in taxableList)
            {
                Console.WriteLine("The tax value is {0}", item.TaxValue());
            }

            Console.ReadKey();
        }
    }
}
