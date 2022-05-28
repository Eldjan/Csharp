using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ededin vurma cedveli

            Console.WriteLine("Enter the number");
            
            int a=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i + "x" + a + "=" + (i*a));
            }
            Console.ReadLine();
        }
    }
}
