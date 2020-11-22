using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class DivisaoEmDetalhes
    {
        public static void Executar()
        {
            Console.Write("Dividendo: ");
            double dividendo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Divisor: ");
            double divisor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = dividendo / divisor;
            double resto = dividendo % divisor;

            Console.WriteLine($"\nDividendo: {dividendo}");
            Console.WriteLine($"Divisor: {divisor}");
            Console.WriteLine($"Resto: {resto}");
            Console.WriteLine($"Resultado: {resultado}");
        }
        
    }
}