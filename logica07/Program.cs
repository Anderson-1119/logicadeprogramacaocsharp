using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            string[] mcarro = { "Volvo", "Ford", "BMW", "BYD" };

            foreach (string carro in mcarro)
            {
                Console.WriteLine(carro);
            }
           
            Console.WriteLine(string.Join(", ", mcarro));

            // mostrar apenas um indice
            Console.WriteLine(mcarro[2]);

            //usando for
            for (int i = 0; i < mcarro.Length; i++)
            {
                Console.WriteLine(mcarro[i]);
            }
            //exibindo o comprimento da array
            Console.WriteLine(mcarro.Length);

            //ordenaçao de string de forma crescrente A - Z
            Array.Sort(mcarro);
            foreach (string ordenado in mcarro)
            {  Console.WriteLine(ordenado); }

            //ordenacao de forma decrescente Z - A
            Array.Reverse(mcarro);
            foreach(string ordenado in mcarro)
            { Console.WriteLine(ordenado); }

            //analise de array
            int[] numeros = { 5, 1, 8, 9 };
            Console.WriteLine(numeros.Max()); //maior valor
            Console.WriteLine(numeros.Min()); //menor valor
            Console.WriteLine(numeros.Sum()); //soma dos numeros

            Console.ReadLine();
        }
    }
}
