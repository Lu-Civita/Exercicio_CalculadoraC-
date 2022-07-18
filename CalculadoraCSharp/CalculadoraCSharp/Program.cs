using System;

namespace CalculadoraCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Informe o número para a tabuada: ");
            
            numero = Double.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
                {
                double total = numero * i;
                Console.WriteLine( numero + " X " + i + " = " + total);

                }
        }
    }
}
