using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( IsPrime(19));
        }
        public static bool IsPrime(int x)
        {
            for(int i = 2; i < x/2+1; i++)
            {
                if(x%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
