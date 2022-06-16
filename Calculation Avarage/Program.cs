using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_Avarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10,20 ,30};
            
            int resault=CalcAvg(arr);
            Console.WriteLine(resault);
            if(resault>60)
            {
                Console.WriteLine("kecdin");
            }
            else
            {
                Console.WriteLine("kecmedin");
            }

        }
        public static int CalcAvg(int[] arr)
        {
            int sum = 0;
            int avg = 0;
            foreach (var item in arr)
            {
              sum+=item;
               
            }
            avg = sum / arr.Length;
            return avg;
            
        }
    }
}
