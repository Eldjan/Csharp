using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Proqramalaşdırma nə qədər çox şey bildiyinizlə yox, bildiyinizlə ortaya çıxardığınız işlərlə maraqlanır";
            Character(str);

        }
        #region character
        public static void Character(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        #endregion

    }
    

}
