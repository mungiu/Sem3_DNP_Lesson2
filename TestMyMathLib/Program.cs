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

            MathLib.MathLib myMathLib = new MathLib.MathLib();

            int result = myMathLib.Add(2, 3);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
