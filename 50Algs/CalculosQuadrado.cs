using System;
using System.Globalization;
namespace Algoritimos_Origin
{
    public class CalculosQuadrado
    {
        public static void Executar()
        {
            Console.Write("Entre com o lado de um quadrado: ");
            double lado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double perimetro = 4 * lado;
            double area = Math.Pow(lado,2);
            double diagonal = lado * Math.Sqrt(2);

            Console.WriteLine($"\nPerimetro: {perimetro.ToString("F2")}");
            Console.WriteLine($"Area: {area.ToString("F2")}");
            Console.WriteLine($"Diagonal: {diagonal.ToString("F2")}");
        }
    }
}