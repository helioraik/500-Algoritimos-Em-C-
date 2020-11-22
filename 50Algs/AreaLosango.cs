using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class AreaLosango
    {
        public static void Executar()
        {
            Console.Write("Medida digaonal maior: ");
            double diagMaior = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Medida diagonal menor: ");
            double diagMenor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = (diagMenor - diagMaior) / 2;

            Console.WriteLine($"\nArea: {area.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}