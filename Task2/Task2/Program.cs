using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ile verilmis ededin kvadratlari cemi

            Console.WriteLine("Enter the number:");

            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
         
            for (int i = 1; i <= a; i++)
            {
                sum += i * i;   
            }
            Console.WriteLine("Result:\t" + sum);

            Console.ReadLine();
        }
    }
}
