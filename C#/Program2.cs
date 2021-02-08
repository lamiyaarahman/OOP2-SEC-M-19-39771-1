using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask3_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfOdd = 0;
            int sumOfEven = 0;

          
                 for (int i = 1; i <= 100; i++)
                    if (i % 2 == 0)
                        sumOfEven += i;
                    else
                        sumOfOdd += i;

            Console.WriteLine("Sum of Even Number: {0}\nSum of Odd Number: {1}", sumOfEven, sumOfOdd);




        }
    }
}
          