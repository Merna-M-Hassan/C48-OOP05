using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_C__OOP
{
    internal static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("==========================================");
        }

        public static void PrintSystemTitle(string message)
        {
            PrintSeparator();
            Console.WriteLine(message);
            PrintSeparator();
        }
    }
}
