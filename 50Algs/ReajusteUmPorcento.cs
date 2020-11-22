using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class ReajusteUmPorcento
    {
        public static void Executar()
        {
            Console.Write("Entre com o seu saldo: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double novoSaldo = saldo * 1.01;

            Console.WriteLine($"Novo saldo com ajuste de 1% : R$ {novoSaldo}");
        }
    }
}