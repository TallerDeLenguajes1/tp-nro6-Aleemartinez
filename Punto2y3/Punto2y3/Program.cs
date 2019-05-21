using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            string op2 = "";
            int op = 0, a = 1;
            float res = 0, n1 = 0, n2 = 0;
            while (a == 1)
            {
                while (op > 4 || op < 1)
                {
                    Console.WriteLine("¿Que operacion desea realizar?\n" +
                        "1-Suma (+)\n" +
                        "2-Resta (-)\n" +
                        "3-Multiplicacion (*)\n" +
                        "4-Division(/)\n" +
                        "Elegir numero correspondiente a la operacion: ");
                    op = int.Parse(Console.ReadLine());
                }
                Console.Write("Inregese el primer numero: ");
                n1 = float.Parse(Console.ReadLine());
                Console.Write("ingrese el segundo numero: ");
                n2 = float.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        op2 = "+";
                        res = n1 + n2;
                        break;
                    case 2:
                        op2 = "-";
                        res = n1 - n2;
                        break;
                    case 3:
                        op2 = "*";
                        res = n1 * n2;
                        break;
                    case 4:
                        op2 = "/";
                        if (n2 != 0)
                        {
                            res = n1 / n2;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                }
                Console.Write(n1 + op2 + n2 + "=" + res + "\n");
                Console.Write("ingrese '1' si desea seguir calculando o '0' si desea terminar: ");
                a = int.Parse(Console.ReadLine());
                op = 0;
            }

            Console.WriteLine("Ingrese un numero para ser analizado: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Numero:" + n1 +
                "\nValor Absoluto: " + Math.Abs(n1) +
                "\nCuadrado: " + Math.Pow(n1, 2) +
                "\nRaiz Cuadrada: " + Math.Sqrt(n1) +
                "\nSeno: " + Math.Sin(n1) +
                "\nCoseno: " + Math.Cos(n1) +
                "\nParte entera: " + Math.Truncate(n1));

            Console.WriteLine("\nIngrese primer numero: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese segundo numero: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("\nEl numero Mayor es: " + Math.Max(n1, n2) + "\nEl Numero menor es: " + Math.Min(n1, n2));
        }

    }
}
