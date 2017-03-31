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
            Console.WriteLine("Write a number between 0 to +21");
            var number = int.Parse(Console.ReadLine());
            string text = "your number"; //String.Format("Hello {0}",text) - for display
            
            OutputData(number); //With number
            IfStatement(number);
            ForLoop(number,text);
        }

        static void ForLoop(int number, string text)
        {
            for (int i = 1; i < number; i++) 
            { 
                Console.Write("This text is {0} minus one times your {1} " ,number, text);
                Console.WriteLine();
            }
        }

        static void OutputData(int number)
        {
            Console.WriteLine("Your number is " + number);   
        }
        static void IfStatement(int number)
        {
             if (number > 0)  
                {  
                 Console.WriteLine("Positive");  
                }  
             else if (number < 0)
                { 
                 Console.WriteLine("Negative"); 
                }
             else 
                { 
                 Console.WriteLine("Zero"); 
                } 
        }
    }
}
