using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int valor1 = 10;
            const int valor2 = 5;

            int soma = valor1 + valor2;
            Console.WriteLine($"soma: {valor1} + {valor2} = {soma}" );

            int subtracao = valor1 - valor2;
            Console.WriteLine($"subtraçao: {valor1} - {valor2} = {subtracao}");

            int multiplicacao = valor1 * valor2;
            Console.WriteLine($"multipliçao: {valor1} * {valor2} = {multiplicacao}");

            int divisao = valor1 / valor2;
            Console.WriteLine($"divisao: {valor1} / {valor2} = {divisao}");

            int resto = valor1 % valor2;
            Console.WriteLine($"resto da divisao: {valor1} % {valor2} = {resto}");

            double potencia = Math.Pow(valor1, valor2);
            Console.WriteLine($"potenciaçao: {valor1} elevado a {valor2} = {potencia}");

            int a1 = 3 + 5 * 2; //sem parenteses
            Console.WriteLine($"resultado1 3+5*2= {a1}");

            int a2 = (3 + 5) * 2; //com parenteses
            Console.WriteLine($"resultado2 (3+5)*2= {a2}");

            int a3 = 8/4+3; //sem parenteses, divisao e multiplicacao tem prioridade
            Console.WriteLine($"resultado3 8/4+3= {a3}");

            double a4 = 8.0/ (4+3); //com parenteses
            Console.WriteLine($"resultado4 8/(4+3)= {a4}");



            Console.ReadLine();

        }
    }
}
