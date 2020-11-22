using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class AreaTriangulo
    {
        public static void Executar()
        {
            Console.Write("Entre com base: ");
            double baseT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com altura do triangulo: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = (baseT * altura) / 2;

            Console.WriteLine($"\nArea: {area.ToString("F2", CultureInfo.InvariantCulture)}");            
        }
    }
}