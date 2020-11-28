using System;
using System.Globalization;

namespace Algoritimos_Origin
{
    public class SalarioLiquidoProfessor
    {
        public static void Executar()
        {
            Console.Write("Valor da hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Numero de aulas dadas: ");
            int numeroAulas = int.Parse(Console.ReadLine());

            Console.Write("Percentual INSS: ");
            double percentualINSS = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioBruto = valorHora * numeroAulas;
            double descontoINSS = (salarioBruto  * (percentualINSS/ 100));
            double salarioLiquido = salarioBruto - descontoINSS;

            Console.WriteLine($"\nSalario Bruto: R$ {salarioBruto.ToString("F2")}");
            Console.WriteLine($"Desconto INSS: R$ {descontoINSS.ToString("F2")}");
            Console.WriteLine($"Salario Liquido: R$ {salarioLiquido.ToString("F2")}");
            
        }
    }
}