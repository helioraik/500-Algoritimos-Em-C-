using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class QuantosSalariosMinimosGanha
    {
        public static void Executar()
        {
            Console.Write("Salario minimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Seu salario: ");
            double seuSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salariosMinimos = seuSalario / salarioMinimo;

            Console.WriteLine($"\nVoçe ganha {salariosMinimos.ToString("F1")} salarios minimos.");

            // Ou

            int s1 = (int) (seuSalario / salarioMinimo);
            double s2 =  s1 - (seuSalario / salarioMinimo);
            string format = s2.ToString("#.##");
            char[] retira = new char[2];
            retira[0] = '-';
            retira[1] = ',';

            format = format.Trim(retira);
            Console.WriteLine($"Voçe ganha {s1} salarios mais {format}% de um salario minimo.");


        }
    }
}