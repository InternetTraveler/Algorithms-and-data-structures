using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = sumOfEvenDegitOfNumbers(1, 100);
            Console.WriteLine(res);
        }

        static int sumOfEvenDegitOfNumbers(int left, int right)
        {
            int tmp, sum = 0;

            for (int number = left; number <= right; number++)
            {
                tmp = number;

                while(tmp > 0)
                {
                    if (tmp % 2 == 0)
                        sum += tmp % 10;

                    tmp /= 10;
                }
            }

            return sum;
        }
    }
}
