using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class VolumeCilindro
    {
        public static void Executar()
        {
            Console.Write("Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"\nVolume do cilindro: {volume.ToString("F2")}");
        }
    }
}