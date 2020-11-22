using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class CalculosRetangulo
    {
        public static void Executar()
        {
            Console.Write("Base: ");
            double baseR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double perimetro = 2 * (baseR + altura);
            double area = baseR * altura;
            double diagonal = Math.Sqrt(Math.Pow(baseR, 2) + Math.Pow(altura,2));

            Console.WriteLine($"\nPerimetro: {perimetro.ToString("F2")}");
            Console.WriteLine($"Base: {baseR.ToString("F2")}");
            Console.WriteLine($"Diagonal: {diagonal.ToString("F2")}");
        }
    }
}