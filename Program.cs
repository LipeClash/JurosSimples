using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Juros Simples ----");

            double C = 1500;
            double I = 0.04;
            double T = 15;
            double Juros = C * I;
            double resultado = Juros;
            double multiplicarjuros = resultado * T; 

            double Montante = C + Juros;
            double resultado2 = resultado * T;
            double Montante2 = resultado2 + C;
            double resultado3 = Montante2;

            Console.WriteLine($"{C:C} * {I} = {resultado} * {T} = {resultado2:C} = Juros ");
            Console.WriteLine("\n");
            Console.WriteLine($"Juros = {resultado2:C} + {C:C} = {resultado3:C} = Montante");
            Console.WriteLine("\n");

            Console.WriteLine("Capital [c] (R$).......: 1,500,00");
            Console.WriteLine("Taxa de juros [i] (%)..: 4");
            Console.WriteLine("Tempo [t] (meses)......: 15");
            Console.WriteLine("\n");
            Console.WriteLine("Juros (R$).....: 900,00");
            Console.WriteLine("Montante (R$)..: 2,400,00");
        }
    }
}
