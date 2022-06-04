using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yas meselesi

            Console.WriteLine("Yasiniz: ");
            long y = Convert.ToInt64(Console.ReadLine());
            if (y < 30 && y >= 0)
            {
                Console.WriteLine(y * y);
            }
            else if (y >= 30 && y <= 40)
            {
                Console.WriteLine(y % 10);
            }
            else
            {
                Console.WriteLine("Düzgün melumat daxil etmemisiniz");
            }
        }
    }
}
