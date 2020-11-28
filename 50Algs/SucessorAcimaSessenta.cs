using System.Runtime.InteropServices.ComTypes;
using System;

namespace Algoritimos_Origin
{
    public class SucessorAcimaSessenta
    {
        public static void Executar()
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            int sucessor = (numero + 1)% 61;

            Console.WriteLine($"\nSucessor: {sucessor}");
            
        }
    }
}