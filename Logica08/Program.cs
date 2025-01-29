using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaraçao de uma matriz 3x3
            int[,] matriz2D = new int[3, 3]

            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            foreach (var valor in matriz2D) 
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
            
            //matriz 1D
            int[] matriz1d = new int[5] { 10, 20, 30, 40, 50 };

            //exibindo valores da matriz 1D
            for (int i = 0; i < matriz1d.Length; i++)
            {
                Console.WriteLine(matriz1d[i]);
            }

            Console.ReadLine();
        }
    }
}
