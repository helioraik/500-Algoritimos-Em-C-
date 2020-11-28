using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class DescontoNovePorCento
    {
        public static void Executar()
        {
            Console.Write("Valor produto: ");
            double valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // double novoPreco = valorProduto * 0.91
            double desconto = valorProduto * 0.09;
            double novoPreco = valorProduto - desconto;

            Console.WriteLine($"\nPreco com desconto de 9%: R$ {novoPreco.ToString("F2", CultureInfo.CurrentCulture)}");
        }
    }
}