using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ededin sade olub olmamasi

            IsPrime(11);
        }
        public static void IsPrime(int x)
        {

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    //sade deyil
                    Console.WriteLine("False");
                    break;
                }
                else
                {
                    //sadedir
                    Console.WriteLine("True");
                    break;
                }
            }

        }

    }
}