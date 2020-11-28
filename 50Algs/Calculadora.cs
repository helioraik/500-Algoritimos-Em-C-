using System;

namespace Algoritimos_Origin
{
    public class Calculadora
    {
        public static void Executar()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine(" + para somar");
            Console.WriteLine(" - para subtrair");
            Console.WriteLine(" * para multiplicar");
            Console.WriteLine(" / para dividir");
            Console.Write("Operador: ");
            char operador = char.Parse(Console.ReadLine());

            Console.Write("\nNum 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            if(operador == '+')
            {
                result = num1 + num2;
            }
            else if(operador == '-')
            {
                result = num1 - num2;
            }
            else if(operador == '*')
            {
                result = num1 * num2;
            }
            else if(operador == '/')
            {
                result = num1 * num2;
            }
            else
            {
                Console.WriteLine("Operador inexistente");
            }

            if(result != 0)
            {
                Console.WriteLine($"Resultado: {result}");
            }
            else
            {
                Console.WriteLine("Fim do programa!");
            }
        }
    }
}