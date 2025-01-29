using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
               
                //for (; ;  Console.WriteLine("esse é um loop infinito");

                //while
                int contador = 1;
            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++; //incrementa o contador 
            }
            // faça enquanto

            int contador2 = 2;
            do
            {
                Console.WriteLine(contador2);
                contador2++;
            }
            while (contador2 <= 5);

            //laço foreach
            //uma lista de strings
            List<string> nomes = new List<string> {"Ana", "Carlos", "João" , "Maria"};
            //usando foreach para exibir a lista 
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome); //imprime cada nome 
            }
            // vetor de numeros inteiros
            int[] numeros = { 1, 2, 3, 4, 5 };
            //usando oforeach para percorrer o vetor 
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero); //IMPRIME CADA NUMERO
            }



                Console.ReadLine();
            }
        }
    }

