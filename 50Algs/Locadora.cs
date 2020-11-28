using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class Locadora
    {
        public static void Executar()
        {
            Console.Write("Quantidade de fitas: ");
            int quantFitas = int.Parse(Console.ReadLine());

            Console.Write("Valor aluguel: ");
            double aluguel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double alugadasMes = (quantFitas / 3);
            double faturaAnual =  alugadasMes * aluguel * 12;
            double faturaMultas = ((alugadasMes / 10) * 12) * (aluguel * 1.10);
            double estoqueFinalAno = (quantFitas * 0.98) + (quantFitas * 0.10);

            Console.WriteLine($"\nFitas alugadas mês: {alugadasMes}");
            Console.WriteLine($"Faturamento anual: R$ {faturaAnual.ToString("F2")}");
            Console.WriteLine($"Faturamento de multas: R$ {faturaMultas.ToString("F2")}");
            Console.WriteLine($"Estoque final de ano: {estoqueFinalAno}");

        }
    }
}