using System;

namespace Algoritimos_Origin
{
    public class MultiploDeTres
    {
        public static void Executar()
        {
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 3 == 0)
            {
                Console.WriteLine("É multiplo de 3.");
            } 
            else
            {
                Console.WriteLine("Não é multiplo de 3.");
            }
        }
    }
}