using System;

namespace Algoritimos_Origin
{
    public class FuncoesString
    {
        public static void Executar()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Primeiro caractere: " + char.ToString(nome[0]));
            Console.WriteLine("Primeiro ao terceiro: " + nome.Substring(0, 3));
            Console.WriteLine("Ultimo caractere: " + char.ToString(nome[nome.Length - 1]));
            Console.WriteLine("Todos menos o primeiro: " + nome.Substring(1, nome.Length - 1));
            Console.WriteLine("Os dois ultimos: " + nome.Substring(nome.Length - 2, 2));
        }
    }
}