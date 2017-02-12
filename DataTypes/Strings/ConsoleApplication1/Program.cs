using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ime         = Console.ReadLine();
            var secondName  = Console.ReadLine();
            var age         = int.Parse(Console.ReadLine());

            var result = string.Format("Hello {0} {1} you are {2} years old",ime, secondName,age*1.2);

            Console.WriteLine(result);

        }
    }
}
