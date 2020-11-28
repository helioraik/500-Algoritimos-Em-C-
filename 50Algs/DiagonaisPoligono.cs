using System;
using System.Globalization;


namespace Algoritimos_Origin
{
    public class DiagonaisPoligono
    {
        public static void Executar()
        {
            Console.Write("Quantos lados tem o poligono: ");
            int lados = int.Parse(Console.ReadLine());

            double ladosDiferentes = lados * (lados - 3) / 2;

            Console.WriteLine($"\nLados diferentes: {ladosDiferentes}");
        }
    }
}