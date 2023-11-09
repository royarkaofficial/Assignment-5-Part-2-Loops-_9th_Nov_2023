using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop_10_odd_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 Odd Natural Numbers using do-while loop:");
            int oddCount = 0;
            int oddNumber = 1;
            do
            {
                Console.Write(oddNumber + " ");
                oddNumber += 2;
                oddCount++;
            } while (oddCount < 10);

            Console.WriteLine();
        }
    }
}
