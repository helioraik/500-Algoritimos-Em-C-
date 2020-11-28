using System;

namespace Algoritimos_Origin
{
    public class PGQuintoTermo
    {
        public static void Executar()
        {
            Console.Write("Entre com o 1º termo: ");
            int termo = int.Parse(Console.ReadLine());

            Console.Write("Entre com a razao: ");
            int razao = int.Parse(Console.ReadLine());

            int quinto = (int) Math.Pow(termo * razao, 4);

            Console.WriteLine($"\nQuinto termo desta P.G: {quinto}"); 
        }
    }
}