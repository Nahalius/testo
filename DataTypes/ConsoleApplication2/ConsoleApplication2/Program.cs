﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main2(string[] args)
        {
            ///Integer Types

            /// sbyte [-128 …127]: signed 8-bit [-27 … 27-1]
            /// byte [0 … 255]: unsigned 8-bit [0 … 28-1]
            /// short [-32 768 … 32 767]: signed 16-bit [-215 … 215-1]
            /// ushort [0 … 65 535]: unsigned 16-bit [0 … 216-1]
            /// int [-2 147 483 648 … 2 147 483 647]: signed 32-bit [-231 … 231-1]
            /// uint [0 … 4 294 967 295]: unsigned 32-bit [0 … 232-1]
            /// long [-9 223 372 036 854 775 808 … 9 223 372 036 854 775 807]: signed 64-bit [-263 … 263-1]
            /// ulong [0 … 18 446 744 073 709 551 615]: unsigned 64-bit [0 … 264-1]
            /// 

            byte years = 20;        // A small number (up to 255)
            ushort days = 7300;    // A small number (up to 32767)
            uint hours = 175200;     // A large number (up to 4.3 billions)
            ulong minutes = 10512000; // A very big number (up to 18.4*10^18)
            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", years, days, hours, minutes);

            Console.WriteLine(days.GetType());      // Use GetTypes to print the data types 

            Console.WriteLine("Raboti aideS");
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
