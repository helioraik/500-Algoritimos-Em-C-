using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class CalculosCirculo
    {
        public static void Executar()
        {
            Console.Write("Entre com o raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double perimetro = 2 * Math.PI * raio;
            double area = Math.Pow(Math.PI * raio, 2);

            Console.WriteLine($"\nPerimetro: {perimetro.ToString("F2")}");
            Console.WriteLine($"Area: {area.ToString("F2")}");

            
        }
    }
}