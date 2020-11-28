using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class CelsiusConvertFahrenheit
    {
        public static void Executar()
        {
            Console.Write("Celsius: ");
            double celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"\nGraus fahrenheit: {fahrenheit.ToString("F2")}º");
        }
    }
}