using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Ordenar_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 25, 63, 8, 12, 11, 5 };
            int i, j;
            int temp;
            int t = n.Length;

            Console.WriteLine("Orden Original");



            foreach (int elemento in n)
            {
                Console.WriteLine(elemento + " | ");

            }

            for (j = 0; j < t; j++)
            {



                for (i = 0; i < t - 1; i++)
                {

                    if (n[i] > n[i + 1])
                    {
                        temp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = temp;

                    }

                }
            }

            Console.WriteLine("Orden Menor a Mayor");



            foreach (int elemento in n)
            {
                Console.WriteLine(elemento + " | ");

            }

            Console.ReadKey();
        }
    }
}
