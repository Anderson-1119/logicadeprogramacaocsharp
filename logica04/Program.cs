using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Ana";
            if (nome == "Ana")
            {
                Console.WriteLine("ola Ana");
            }
            string texto = "";
            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("a string esta vazia");
            }
            int idade = 16;
            if (idade >= 18)
            {
                Console.WriteLine("voce é maior de idade");
            }
            else
            {
                Console.WriteLine("voce é menor de idade");
            }

            //else if
            double nota = 6.5;

            if (nota >= 9.0)
            {
                Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Você está aprovado.");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Você está em recuperação.");
            }
            else if (nota >= 3.0)
            {
                Console.WriteLine("Você está com risco de reprovação.");
            }
            else
            {
                Console.WriteLine("Você foi reprovado.");
            }

            //switch
            double pontuaçao = 8.6;
            // arredondar para o numero inteiro mais proximo
            int faixanota = (int)Math.Round(pontuaçao);
            Console.WriteLine(faixanota);

            switch (faixanota)
            {
                case 10: Console.WriteLine("voce obteve uma excelente nota!");
                    break;
                case 8:
                    case 9: Console.WriteLine("voce foi aprovado");
                    break;

                case 7:
                    case 6: Console.WriteLine("voce esta em recuperaçao");
                    break;
                case 4:
                case 3:
                    case 5: Console.WriteLine("voce esta em risco");
                         break;

                    default: Console.WriteLine("voce foi reprovado");
                    break;
            }


            Console.ReadLine();
        }
    }
}
