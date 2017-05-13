using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenth =     int.Parse(Console.ReadLine());
            decimal width =  int.Parse(Console.ReadLine());

            decimal lenthC =    lenth * 100;
            decimal rem =  lenthC % width;

            if ( rem != 0)
            {
                var percent = Math.Round(lenthC / width *100, 2);
                Console.WriteLine(percent+"%");
            }
            else
            {
                decimal product = Math.Round(width * lenthC, 2);
                       
                Console.WriteLine(product.ToString("0.00"));
            }
        }
    }
}
