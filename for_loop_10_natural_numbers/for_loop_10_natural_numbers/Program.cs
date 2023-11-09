using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_10_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 Natural Numbers using for loop:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
