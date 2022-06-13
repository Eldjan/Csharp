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
            
        }
        public static void SumNumbers(int a)
        {
            
            int count = a.ToString().Length;
            int[] arr= new int[count];
            int index = 0;
            for (int i = 1; i <= Length(count); i *= 10)
            {
                int b = a / i;
                int c = b % 10;
                arr[index] = c;
                index++;
            }
            Console.WriteLine(resault);
        }

        public static int Length(int count)
        {
            int length = 1;
            for (int i = 0; i < count; i++)
            {
                length *= 10;
            }
            return length;
        }



    }
}


