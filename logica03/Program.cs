using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            bool maiorQ = a > b;
            bool menorQ = a < b;
           bool  igual = a == b;
            bool diferente = a != b;    
            bool maiorouigual = a >= b;
            bool menorouigual = a <= b;

            Console.WriteLine("operadores relacionais");
            Console.WriteLine($"{a} > {b}: {maiorQ}");
            Console.WriteLine($"{a} < {b}: {menorQ}");
            Console.WriteLine($"{a} = {b}: {igual}");
            Console.WriteLine($"{a} ! {b}: {diferente}");
            Console.WriteLine($"{a} >= {b}: {maiorouigual}");
            Console.WriteLine($"{a} <= {b}: {menorouigual}");

            // Operadores Lógicos
            bool x = true;
            bool y = false;
            bool and = x && y;  // E lógico
            bool or = x || y;   // Ou lógico
            bool not = !x;      // Não lógico

            // Exibindo resultados dos operadores lógicos
            Console.WriteLine("\nOperadores Lógicos:");
            Console.WriteLine($"x && y: {and}");   // E lógico
            Console.WriteLine($"x || y: {or}");    // Ou lógico
            Console.WriteLine($"!x: {not}");       // Não lógico
            

            Console.ReadLine();
        }
    }
}
