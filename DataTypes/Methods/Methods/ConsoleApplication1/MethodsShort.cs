using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MethodsShort
    {
        static void Main(string[] args)
        {
            var number = 5;
            string text = "some text"; //String.Format("Hello {0}",text) - for display
            InputData();
            OutputData(number); //With number
            IfStatement();
        }

        static void InputData()
        {

            Console.ReadLine();
        }
        static void OutputData(int number)
        {
            Console.WriteLine(number);
            
        }
        static void IfStatement()
        {
            
         
        }


    }
}
