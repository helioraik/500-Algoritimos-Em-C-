using System;

namespace Algoritimos_Origin
{
    public class AlgarismosDasDezenas
    {
        public static void Executar()
        {
            Console.Write("Entre com numero de 3 algarismos: ");
            double numero = double.Parse(Console.ReadLine());

            int numeroDezenas = (int) numero % 100 / 10;

            Console.WriteLine($"Numero das dezenas {numeroDezenas}");
        }
    }
}