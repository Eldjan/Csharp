using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aptek;

namespace Generics
{
    internal class Pharmacy
    {
        public List<Medicine> Medicines = new List<Medicine>();
        public List<List<int>> Sells = new List<List<int>>();


        public void AddMedicine(string name, double price, int count)
        {

            bool DoesNotExist = true;
            foreach (Medicine m in Medicines)
            {
                if (m.Name == name)
                {
                    DoesNotExist = false;
                }
            }
            if (DoesNotExist)
            {
                Medicines.Add(new Medicine(name, price, count));

            }

        }

        public void FindMedicineByName(string name)
        {
            foreach (var m in Medicines)
            {
                int count = 0;
                if (m.Name.ToUpper() == name.ToUpper())
                {
                    Console.WriteLine(++count + " " + m.Name);
                }
            }
        }

        private int FindMedicineByNameretid(string name)
        {
            int id = -1;
            foreach (var m in Medicines)
            {
                int count = 0;
                if (m.Name.ToUpper() == name.ToUpper())
                {
                    Console.WriteLine(++count + " " + m.Name);
                    id = m.Id;
                }
            }
            return id;
        }
        public void Sell(string name, int count)
        {
            List<int> sell = new List<int>();
            int id = FindMedicineByNameretid(name);
            sell.Add(id);
            sell.Add(count);
            Sells.Add(sell);
        }
        public void TotalIncome()
        {
            double money = 0;
            foreach (List<int> Total in Sells)
            {
                int id = Total[0];
                int count = Total[1];
                foreach (Medicine m in Medicines)
                {
                    if (m.Id == id)
                    {
                        money += count * m.Price;
                    }
                }
            }
            Console.WriteLine(money + "$");
        }
    }
}
