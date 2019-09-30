using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoSmallestNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 19, 5, 42, 2, 77 };
            Console.WriteLine(sumTwoSmallestNumbers(numbers));
            Console.WriteLine(sumTwoSmallestNumbersII(numbers));
        }
        static int sumTwoSmallestNumbers(int[] numbers)
        {
            // sort the array 
            var data = numbers.OrderBy(x => x).ToArray();
            return data[0] + data[1];
        }

        static int sumTwoSmallestNumbersII(int[] numbers)
        {
            return numbers.OrderBy(x => x).Take(2).Sum();
        }
    }
}
