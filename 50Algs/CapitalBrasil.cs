using System;

namespace Algoritimos_Origin
{
    public class CapitalBrasil
    {
        public static void Executar()
        {
            Console.Write("Qual a capital do Brasil? ");
            string capital = Console.ReadLine();

            if(capital == "Brasília") {
                Console.WriteLine("Certo! Parabens a capital do Brasil é Brasília");
            } 
            else if(capital == "brasília" || capital == "BRASÍLIA" || capital == "brasilia" || capital == "BRASILIA" || capital == "Brasilia")
            {
                Console.WriteLine("Certo! Mais deve prestar atenção na ortografia o correto é Brasília");
            } 
            else
            {
                Console.WriteLine("Errado! Por favor estude mais.");
            }
        }
    }
}