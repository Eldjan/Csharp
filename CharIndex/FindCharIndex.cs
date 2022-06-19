
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            FindCharIndex("salam",'a');
        }
        public static void FindCharIndex(string str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (i == str.Length - 1)
                {
                    Console.WriteLine("-1");
                }
            }
        }
           
        }
}

