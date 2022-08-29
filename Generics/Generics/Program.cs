using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Console.WriteLine("Enter numbers:\n");

            //List<int> items = new List<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    string userInput;

            //    int newItem = 0;

            //    Console.Write(string.Format("Enter item {0}: ", i));


            //    userInput = Console.ReadLine();

            //    items.Add(newItem);


            //}
            #endregion task1
            Pharmacy ph = new Pharmacy();
            ph.AddMedicine("TylolHot", 5, 1);


            ph.FindMedicineByName("tylol");
            ph.Sell("TylolHot", 2);
            ph.TotalIncome();




        }


    }
}
