using System;

namespace Algoritimos_Origin
{
    public class CapturaData
    {
        public static void Executar()
        {
            Console.Write("Entre com ddmmaa: ");
            int data = int.Parse(Console.ReadLine());

            int dia = (int) data / 10000;
            int mes = (int) data % 1000 / 100;
            int ano = (int) data % 1000 % 100;

            Console.WriteLine($"Dia: {dia}");
            Console.WriteLine($"Mes: {mes}");
            Console.WriteLine($"Ano: {ano}");
        }
    }
}