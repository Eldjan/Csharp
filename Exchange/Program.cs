using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum CurrencyType
    {
        USD,
        EUR,
        TL
    }

    internal class ValutaExchanger
    {
        static void Main(string[] args)
        {

           
            for (int i=0;i<=6;i++)
            {
                Console.WriteLine("Choose for exhange:");
                Console.WriteLine("1: AZN to USD");
                Console.WriteLine("2: AZN to EUR");
                Console.WriteLine("3: AZN to TL");
                Console.WriteLine("4: USD TO AZN");
                Console.WriteLine("5: EUR TO AZN");
                Console.WriteLine("6: TL TO AZN");
                int which = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cevirmek istediyiniz  meblegi yazin");
                double money = Convert.ToDouble(Console.ReadLine());
                switch (which)
                {
                    case 1:
                        ValutaExchanger.Exchange(CurrencyType.USD, money);
                        break;
                    case 2:
                        ValutaExchanger.Exchange(CurrencyType.EUR, money);
                        break;
                    case 3:
                        ValutaExchanger.Exchange(CurrencyType.TL, money);
                        break;
                    case 4:
                        ValutaExchanger.ExchangeOp(CurrencyType.USD, money);
                        break;
                    case 5:
                        ValutaExchanger.ExchangeOp(CurrencyType.EUR, money);
                        break;
                    case 6:
                        ValutaExchanger.ExchangeOp(CurrencyType.TL, money);
                        break;
                    default:
                        Console.WriteLine("Error.Please select correct excgan");
                        break;



                }

               
            }


        }
        public static Dictionary<CurrencyType, double> currencies = new Dictionary<CurrencyType, double>()
        {
          {CurrencyType.USD,1.70},
          { CurrencyType.TL,0.09},
          { CurrencyType.EUR,1.69}
            };

        public static void Exchange(CurrencyType type, double amount)
    {
        double exchanged = amount * currencies[type];
        Console.WriteLine(amount + " AZN to " + type + " = " + exchanged);
    }
    public static void ExchangeOp(CurrencyType type, double amount)
    {
        double exchanged = amount / currencies[type];
        Console.WriteLine(amount + " " + type + "to AZN   = " + exchanged);
    }








    }
}
