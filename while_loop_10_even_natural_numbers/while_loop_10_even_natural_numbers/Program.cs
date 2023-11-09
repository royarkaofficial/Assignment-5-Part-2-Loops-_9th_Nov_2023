using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop_10_even_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 Even Natural Numbers using while loop:");
            int evenCount = 0;
            int number = 2;
            while (evenCount < 10)
            {
                Console.Write(number + " ");
                number += 2;
                evenCount++;
            }
            Console.WriteLine();
        }
    }
}
