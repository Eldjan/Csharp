using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 le verilmiş ədəd arasındaki ədədlərin hasili ilə cəminin fərqi

            Console.WriteLine("Enter the number");

            int a = Convert.ToInt32((Console.ReadLine()));

            int mul = 1;
            int sum = 0;
            int res = 0;

            for (int i = 2; i <= a; i++)
            {

                mul *= i;

            }
            Console.WriteLine("Hasilleri:" + mul);


            for (int j = 1; j <= a; j++)
            {
                sum += j;
            }
            Console.WriteLine("Cemleri:" + sum);

            res = mul - sum;

            Console.WriteLine("Hasilleri ve cemlerinin ferqi:"+ res);
            Console.ReadLine();
        }
    }
}
