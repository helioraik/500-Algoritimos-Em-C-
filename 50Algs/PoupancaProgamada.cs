using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class PoupancaProgamada
    {
        public static void Executar()
        {
            Console.Write("Aplicacao mensal: ");
            double aplicacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Numero de meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.Write("Taxa: ");
            double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorAcumulado = aplicacao * Math.Pow((1 + taxa), meses) - 1 / taxa;

            Console.WriteLine($"\nValor acumulado: {valorAcumulado.ToString("F2", CultureInfo.CurrentCulture)}");
        }
    }
}