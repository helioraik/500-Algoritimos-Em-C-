using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class CalcHipotenusa
    {
        public static void Executar()
        {
            Console.Write("Entre com cateto 1: ");
            double cateto1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com cateto 2: ");
            double cateto2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            Console.WriteLine($"\nHipotenusa: {hipotenusa.ToString("F5")}");
        }
    }
}