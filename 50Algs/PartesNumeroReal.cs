using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class PartesNumeroReal
    {
        public static void Executar()
        {
            Console.Write("Entre com um numero: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int parteInteira = (int) numero;
            double parteFracionaria = parteInteira - numero;
            double numeroArredondado = Math.Ceiling(numero);

            Console.WriteLine($"\nParte interira: {parteInteira}");
            Console.WriteLine($"Parte fracionario: {parteFracionaria}");
            Console.WriteLine($"Numero arredondado: {numeroArredondado}");
        }
    }
}