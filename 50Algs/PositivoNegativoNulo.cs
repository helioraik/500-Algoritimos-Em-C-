using System;

namespace Algoritimos_Origin
{
    public class PositivoNegativoNulo
    {
        public static void Executar()
        {
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                Console.WriteLine("Positivo");
            } 
            else if(numero < 0) 
            {
                Console.WriteLine("Negativo");
            } 
            else
            {
                Console.WriteLine("Nulo");
            }
        }
    }
}