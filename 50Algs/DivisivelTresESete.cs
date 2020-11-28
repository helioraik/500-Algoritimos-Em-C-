using System;

namespace Algoritimos_Origin
{
    public class DivisivelTresESete
    {
        public static void Executar()
        {
            Console.Write("Entre com numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 3 == 0 && numero % 7 == 0)
            {
                Console.WriteLine("\nÉ divisivel por 3 e por 7.");
            }
            else
            {
                Console.WriteLine("\nNão é divisivel por 3 e 7.");
            }
        }
    }
}