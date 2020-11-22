using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class RaizAndQuadrado
    {
        public static void Executar()
        {
            Console.Write("Entre com um numero: ");
            double numero = double.Parse(Console.ReadLine());
            
            double raizQuadrada = Math.Sqrt(numero);
            double quadrado = Math.Pow(numero, 2);

            Console.WriteLine($"\nRaiz quadrada: {raizQuadrada}");
            Console.WriteLine($"Quadrado: {quadrado}");
        }
    }
}