using System;
using System.Data.SqlTypes;

namespace prgConvertitore
{
    class Program
    {
        static void Main(string[] args)
        {
            double resto;
            string numeroconvertito = "";
            Console.WriteLine("Inserisci un numero decimale");
            int numerodecimale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un divisore");
            int divisore = Convert.ToInt32(Console.ReadLine());
            while (numerodecimale > 0) 
            {
                resto = numerodecimale % divisore;
                numerodecimale = numerodecimale / divisore;
                
                if(resto == 10)
                {
                    numeroconvertito = "A" + numeroconvertito;
                }
                else if(resto == 11)
                {
                    numeroconvertito = "B" + numeroconvertito;
                }
                else if(resto == 12)
                {
                    numeroconvertito = "C" + numeroconvertito;
                }
                else if(resto == 13)
                {
                    numeroconvertito = "D" + numeroconvertito;
                }
                else if (resto == 14)
                {
                    numeroconvertito = "E" + numeroconvertito;
                }
                else if (resto == 15)
                {
                    numeroconvertito = "F" + numeroconvertito;
                }
                else 
                {
                    numeroconvertito = Convert.ToString(resto) + numeroconvertito;
                }
            }
            Console.WriteLine("{0}", numeroconvertito );
            Console.ReadLine();
        }
    }
}
