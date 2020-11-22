using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class TercaPartNum
    {
        public static void Executar()
        {
            Console.Write("Entre com um numero real: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tercaParte = numero / 3.0;

            Console.WriteLine($"Terça parte: {tercaParte}");
        }
    }
}