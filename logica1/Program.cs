using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //variaveis
                char letra = 'a';
                string nome = "joão";
                float temperatura = 1.0f;
                double salario = 1234.56;
                bool chuva = true;

                //constantes
                const char simbolo = '$';
                const string saudacao = "bem vindo ao c#";
                const float pi = 3.14159f;
                const double altura = 1.75;
                const bool verdade = false;

                Console.WriteLine("valores originais");
                Console.WriteLine($"letra {letra}");
                Console.WriteLine($"nome {nome}");
                Console.WriteLine($"temperatura {temperatura}");
                Console.WriteLine($"salario {salario}");
                Console.WriteLine($"chuva {chuva}");
                Console.WriteLine($"simbolo {simbolo}");
                Console.WriteLine($"altura {altura}");
                Console.WriteLine($"verdade{verdade}");



                Console.ReadLine();

            }
        }
    }
}
