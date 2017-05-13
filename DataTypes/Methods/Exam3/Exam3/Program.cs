using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();                 
            List<string> items = values.Split(' ').ToList();
            List<int> nums = new List<int>();
            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }
            var count = 0;
            var count2 = 0;
            var counter = 0;
            
            for (int index = counter; index < items.Count; index++) 
            {
                
                int lineItem = Int32.Parse(items[index]); 

                if (lineItem > 0)
                {
                    
                    lineItem = 0;
                    continue;
                }
                else
                {
                  count++;
                }
                
                
            }
            var count3 = count + count2;
            Console.WriteLine(count3);
            

        }
    }
}
