using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, z = 0, x = 1, y = 0;
            bool valor;

            Console.WriteLine("\nSequência de Fibonacci\n");

            Console.Write("Quantos termos (>= 2)? ");
            valor = Int32.TryParse(Console.ReadLine(), out numero);

            for (int finish = 0; finish < numero; finish++)
            {               
                z = y;
                Console.WriteLine(z);
                y = x;
                x = y + z;
            }
            if (numero < 2 || !valor)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Número invalido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }
        }
    }
}
