using System;

namespace Algoritimos_Origin
{
    public class SomaSimples
    {
        public static void Executar()
        {
            Console.Write("Entre com um numero inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com outro numero inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine($"Soma: {soma}");
        }
    }
}