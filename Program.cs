using System;

namespace Covertitore
{
    class Program
    {
        static void Main(string[] args)
        {
            double resto;
            string numeroconvertito = "";
            Console.WriteLine("Inserisci un numero decimale:");
            int numerodecimale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un divisore:");
            int divisore = Convert.ToInt32(Console.ReadLine());
            while (numerodecimale > 0)
            {
                resto = numerodecimale % divisore;
                numerodecimale = numerodecimale / 2;
                numeroconvertito = Convert.ToString(resto) + numeroconvertito;
            }
            Console.WriteLine("{0}", numeroconvertito);
            Console.ReadLine();
        }
    }
}
