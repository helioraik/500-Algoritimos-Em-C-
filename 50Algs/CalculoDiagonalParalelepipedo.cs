using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class CalculoDiagonalParalelepipedo
    {
        public static void Executar()
        {
            Console.Write("Entre com base: ");
            double baseP = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com profundidade: ");
            double profundidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double diagonal = Math.Sqrt(Math.Pow(baseP, 2) + Math.Pow(altura, 2) + Math.Pow(profundidade, 2));

            Console.WriteLine($"\nDiagonal: {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}