using System;

namespace Algoritimos_Origin
{
    public class DecisoesNegPos
    {
        public static void Executar()
        {
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine($"\nRaiz quadrada: {raiz}");
            }
            else
            {
                double quadrado = numero * numero;
                Console.WriteLine($"\nQuadrado do numero: {quadrado}");
            }
        }
    }
}