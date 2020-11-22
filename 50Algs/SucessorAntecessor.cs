using System;
namespace Algoritimos_Origin
{
    public class SucessorAntecessor
    {
        public static void Executar()
        {
            Console.Write("Entre com um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            int sucessor = numero + 1;
            int antecessor = numero - 1;
            
            // sucessor = numero + 1;
            // antecessor = numero--;

            Console.WriteLine($"Sucessor: {sucessor} Antecessor: {antecessor}");
        }
    }
}