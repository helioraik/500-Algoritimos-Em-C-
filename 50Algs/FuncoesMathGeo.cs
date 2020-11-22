using System;

namespace Algoritimos_Origin
{
    public class FuncoesMathGeo
    {
        public static void Executar()
        {
            Console.Write("Entre com um angulo: ");
            double angulo = double.Parse(Console.ReadLine());

            double rang = angulo * Math.PI / 180;

            Console.WriteLine("\nSeno: " + Math.Sin(rang));
            Console.WriteLine("Cosseno: " + Math.Cos(rang));
            Console.WriteLine("Tangente: " + Math.Tan(rang));
            Console.WriteLine("Cosecante: " + 1/Math.Sin(rang));
            Console.WriteLine("Secante: " + 1/Math.Cos(rang));
            Console.WriteLine("Cotangente: " + 1/Math.Tan(rang));
        }
    }
}