using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] array= { 9,3,1,4,2,5,7,6,8,12 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        n = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = n;
                    }
                }
            }
            Console.WriteLine(array[0]);
            Console.ReadLine();
            
        }
        
    }
}
