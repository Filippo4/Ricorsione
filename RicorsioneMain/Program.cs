using System;

namespace RicorsioneMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la x");
            uint x = uint.Parse(Console.ReadLine());
            Console.WriteLine("inserisci la y");
            uint y = uint.Parse(Console.ReadLine());
            uint somma = Somma(x, y);
            uint prodotto = Prodotto(x, y);
            Console.WriteLine($"la somma è {somma}");
            Console.WriteLine($"la prodotto è {prodotto}");
            Console.ReadLine();
        }
        private static uint Somma(uint x, uint y)
        {   
            if (y == 0)
                return x;
            else
                return 1 + (Somma(x, y - 1));
        }
        private static uint Prodotto (uint x , uint y)
        {
            if (y == 0)
                return 0;
            else
                return Somma(x,Prodotto(x, y - 1));
        }
    }
}
