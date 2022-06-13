using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation(1, 2, 3,4);
        }
        public static void Calculation(params int[] arr)
        {
            int sum = 0;
            int mul = 1;
            int res = 0;
            foreach(var item in arr)
            {
                sum += item;
                mul *= item;
            }
            res = mul - sum;
            Console.WriteLine( res );


        }
        
        
    }
}
