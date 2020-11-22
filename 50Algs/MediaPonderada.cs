using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class MediaPonderada
    {
        public static void Executar()
        {
            Console.Write("Entre com um valor: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com outro valor: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com outro valor: ");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com outro valor: ");
            double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaPond = (n1 * 1 + n2 * 2 + n3 * 3 + n4 * 4) / 10;

            Console.WriteLine($"\nMedia Ponderada: {mediaPond.ToString("F2")}");
        }
    }
}