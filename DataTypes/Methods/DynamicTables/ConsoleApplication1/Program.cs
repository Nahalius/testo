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
            Console.WriteLine("Enter the number of colums:");
            int colums = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Table ");
            for (int i = 0; i < colums; i++)
            {
                Console.Write("c ");
            }
            Console.Write("Total");
            Console.WriteLine("");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("row.N");
                for (int f = 0; f < colums; f++)
                {
                    Console.Write(" r ");
                }
                Console.Write(colums + rows);
                Console.WriteLine("");
            }

            Console.Write("Total ");
            for (int i = 0; i < colums; i++)
            {
                Console.Write(colums + rows + " ");
            }
            Console.Write("Total");
            Console.WriteLine(""); 
        }
    }
}
