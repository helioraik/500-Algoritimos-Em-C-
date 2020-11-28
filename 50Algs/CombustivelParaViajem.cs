using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class CombustivelParaViajem
    {
        public static void Executar()
        {
            Console.Write("Tempo na viajem: ");
            double tempo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Velocidade média: ");
            double velocidadeMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double distancia = tempo * velocidadeMedia;
            double litrosUsados = distancia / 12;

            Console.WriteLine($"\nDistancia percorrida: {distancia.ToString("F0")} km");
            Console.WriteLine($"Litros usados: {litrosUsados.ToString("F2")} lts");

        }
    }
}