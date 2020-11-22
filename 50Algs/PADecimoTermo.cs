using System;

namespace Algoritimos_Origin
{
    public class PADecimoTermo
    {
        public static void Executar()
        {
            Console.Write("Entre com 1º termo: ");
            int termo = int.Parse(Console.ReadLine());

            Console.Write("Entre com a razao: ");
            int razao = int.Parse(Console.ReadLine());

            int decimo = termo + 9 * razao;

            Console.WriteLine($"\nTermo desta P.A: {decimo}");
        }
    }
}