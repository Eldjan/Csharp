using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_digit_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumNumbers(1298);

        }
        public static void SumNumbers(int a)
        {
            
            int resault = 0;

            for (int i = 1; i <= 1000; i *= 10)
            {
                int b = a /i;
                int c = b % 10;
                resault = c+resault;
            }
            Console.WriteLine(resault);
        }
    }

}
