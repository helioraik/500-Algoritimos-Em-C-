using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class MediaDoisNumeros
    {
        public static void Executar()
        {
            Console.Write("Entre com um numero: ");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com um numero: ");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (num1 + num2) / 2;

            Console.WriteLine($"A media entre os valores é: {media}");
        }
    }
}