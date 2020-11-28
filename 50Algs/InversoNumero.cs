using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class InversoNumero
    {
        public static void Executar()
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                numero = numero * -1;
                Console.WriteLine($"\nInverso : {numero}");
            }
            else
            {
                numero = Math.Abs(numero);
                Console.WriteLine($"\nAbsoluto: {numero}");
            }

            
        }
    }
}