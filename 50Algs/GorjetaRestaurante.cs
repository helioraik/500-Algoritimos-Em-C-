using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class GorjetaRestaurante
    {
        public static void Executar()
        {
            Console.Write("Valor gasto: ");
            double valorGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double gorjeta = valorGasto * 0.10;
            double valorTotal = valorGasto + gorjeta;

            Console.WriteLine($"\nGorjeta: R$ {gorjeta.ToString("F2")}");
            Console.WriteLine($"Gasto total: R$ {valorTotal.ToString("F2")}");

        }
    }
}