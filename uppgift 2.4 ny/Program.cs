using System;
namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in lönen för arbetaren 1");
            string x = Console.ReadLine();
            int a = Convert.ToInt32(x);
            Console.WriteLine("Skriv in lönen för arbetaren 2");
            string y = Console.ReadLine();
            int b = Convert.ToInt32(y);
            Console.WriteLine("Skriv in lönen för arbetaren 3");
            string z = Console.ReadLine();
            int c = Convert.ToInt32(z);
            int summa = a + b + c;
            int medel = summa / 3;
            Console.WriteLine("Medellönen för arbetarna är: " + medel);
        }
    }
}