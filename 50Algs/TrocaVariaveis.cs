using System.Runtime.InteropServices.ComTypes;
using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class TrocaVariaveis
    {
        public static void Executar()
        {
            Console.Write("Digite um numero: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite outro numero: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double aux = n1;
            n1 = n2;
            n2 = aux;

            Console.WriteLine($"\nN1 : {n1}");
            Console.WriteLine($"N2 : {n2}");
        }
    }
}