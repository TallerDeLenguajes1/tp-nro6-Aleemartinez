using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            long N, res = 0;

            Console.WriteLine("Ingrese Numero a invertir");
            linea = Console.ReadLine();
            N = long.Parse(linea);
            while (N > 0)
            {
                res = (res * 10) + (N % 10);

                N = N / 10;
            }
            Console.Write("El numero invertido es: " + res);
        }
    }
}
