using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class MediaFinalDuasNotas
    {
        public static void Executar()
        {
            Console.Write("Entre com PR1: ");
            double pr1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com PR2: ");
            double pr2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaTruncada = Math.Truncate((pr1 + pr2) / 2);
            double mediaArredondada = Math.Ceiling((pr1 + pr2) / 2);

            Console.WriteLine($"Media truncada: {mediaTruncada.ToString("F2")}");
            Console.WriteLine($"Media arredondada: {mediaArredondada.ToString("F2")}");

        }
    }
}