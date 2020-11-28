using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class CalculaMinutosPassados
    {
        public static void Executar()
        {
            Console.Write("Horas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            double minutosPassados = horas * 60 + minutos;

            Console.WriteLine($"\nAté agora se passou {minutosPassados} minutos");
        }
    }
}