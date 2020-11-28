using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class GravidadePlanetas
    {
        public static void Executar()
        {
            char opcao = ' ';

            Console.Write("Peso da terra: ");
            double pesoTerra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("#\t\tgravidade relativa\t\t\tPlaneta");
            Console.WriteLine("1\t\t\t0,37\t\t\tMercúrio");
            Console.WriteLine("2\t\t\t0,88\t\t\tVênus");
            Console.WriteLine("3\t\t\t0,38\t\t\tMarte");
            Console.WriteLine("4\t\t\t2,64\t\t\tJúpiter");
            Console.WriteLine("5\t\t\t1,15\t\t\tSaturno");
            Console.WriteLine("6\t\t\t1,17\t\t\tUrano");

            try {
                Console.Write("Opcao: ");
                opcao = char.Parse(Console.ReadLine());
            } catch(FormatException erro) {
                Console.WriteLine($"Error: {erro.Message}");
                System.Environment.Exit(0);
            }
            

            double result = 0.0;
            string result2 = "";

            switch(opcao)
            {
                case '1': result = (pesoTerra /10) * 0.37; break; 
                case '2': result = (pesoTerra /10) * 0.88; break; 
                case '3': result = (pesoTerra /10) * 0.38; break; 
                case '4': result = (pesoTerra /10) * 2.64; break; 
                case '5': result = (pesoTerra /10) * 1.15; break; 
                case '6': result = (pesoTerra /10) * 1.17; break;
                default : result2 = "Opcao inválida"; break; 
            }

            if(!string.IsNullOrEmpty(result2))
            {
                Console.WriteLine("\n" + result2);
            }
            else 
            {
                Console.WriteLine($"Seu peso no planeta terra é {result.ToString("F2")}");
            }
        }
    }
}