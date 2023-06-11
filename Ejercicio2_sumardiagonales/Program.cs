using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_sumardiagonales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma_diagonal_primera = 0;
            int suma_diagonal_segunda = 0;
            int[,] diagonal = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    diagonal[i, k] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write(diagonal[i, k] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                suma_diagonal_primera += diagonal[i, i];
                suma_diagonal_segunda += diagonal[i, 4 - i];
            }
            Console.WriteLine("La suma de la primera diagonal es de: " + suma_diagonal_primera);
            Console.WriteLine("La suma de la segunda diagonal es de: " + suma_diagonal_segunda);

            Console.ReadLine();
        }
    }
}
