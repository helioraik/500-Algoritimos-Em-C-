using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class QuadradoDaDiferenca
    {
        public static void Executar()
        {
            Console.Write("Numero 1: ");
            double numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Numero 2: ");
            double numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double quadradoDif = Math.Pow(numero1 - numero2, 2);
            double difQuadrados = Math.Pow(numero1, 2) - Math.Pow(numero2, 2);

            Console.WriteLine($"\nQuadrado da diferença: {quadradoDif}");
            Console.WriteLine($"\nDiferença dos quadrados: {difQuadrados}");

        }
    }
}