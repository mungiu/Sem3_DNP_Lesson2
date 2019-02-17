using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyMathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey students");

            MyNamespace.MyMathLibClass myMathLib = new MyNamespace.MyMathLibClass();

            int result = myMathLib.Add(2, 3);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
