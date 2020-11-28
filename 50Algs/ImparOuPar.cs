using System;

namespace Algoritimos_Origin
{
    public class ImparOuPar
    {
        public static void Executar()
        {
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("\nNumero é par.");
            }
            else
            {
                Console.WriteLine("\nNumero é impar.");
            }

        }
    }
}