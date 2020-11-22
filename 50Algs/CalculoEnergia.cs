using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class CalculoEnergia
    {
        public static void Executar()
        {
            Console.Write("Salario minimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quilowatt: ");
            double kwHr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double unidadeKwh = salarioMinimo / 7 / 100;
            double contaEnergia = kwHr * unidadeKwh;

            Console.WriteLine($"Custo de kwh por unidade: R$ {unidadeKwh.ToString("F2")}");
            Console.WriteLine($"Valor conta: R$ {contaEnergia.ToString("F2")}");
            Console.WriteLine($"Valor com desconto de 10%: R$ {(contaEnergia * 0.90).ToString("F2")}");
        }
    }
}