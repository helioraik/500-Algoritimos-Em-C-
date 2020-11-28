using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class PrestacaoAtraso
    {
        public static void Executar()
        {
            Console.Write("Valor: ");
            double valorPrestacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Taxa: ");
            double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Meses de atraso: ");
            int mesesAtraso = int.Parse(Console.ReadLine());

            double prestacaoComReajuste = valorPrestacao + (valorPrestacao * (taxa / 100) * mesesAtraso);

            Console.WriteLine($"\nPrestacao com reajuste: R$ {prestacaoComReajuste.ToString("F2")}");
        }
    }
}