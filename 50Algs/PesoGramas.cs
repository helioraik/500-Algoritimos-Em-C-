using System;

namespace Algoritimos_Origin
{
    public class PesoGramas
    {
        public static void Executar()
        {
            Console.Write("Entre com peso: ");
            int peso = int.Parse(Console.ReadLine());

            int pesoGramas = peso * 1000;
            double pesoEngordar = pesoGramas * 1.12;

            Console.WriteLine($"\nPeso em gramas: {pesoGramas}");
            Console.WriteLine($"Peso em gramas se engordar 12%: {pesoEngordar}");
        }
    }
}