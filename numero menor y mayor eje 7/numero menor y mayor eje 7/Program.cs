using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_menor_y_mayor_eje_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
            string[] name = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            int t = age.Length;
            int tempo;
            string tempo2;
            Console.WriteLine("\n" +
                "Arrelo Original\n");
            foreach (int item in age)
            {
                Console.Write(item + " | ");
            }

            for (int x = 1; x < t - 1; x++)
            {
                for (int i = 0; i < t - x; i++)
                {
                    if (age[i] > age[i + 1])
                    {
                        tempo = age[i];
                        age[i] = age[i + 1];
                        age[i + 1] = tempo;

                        tempo2 = name[i];
                        name[i] = name[i + 1];
                        name[i + 1] = tempo2;

                    }
                }
            }
            Console.WriteLine("\n \n" +
                "Arreglo ordenado\n");
            foreach (int item in age)
            {
                Console.Write(item + " | ");
            }

            for (int i = 0; i < t; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\n \n \nEl menor es " +
                        "\n");
                    Console.WriteLine(name[i] + " tiene " + age[i] + " años ");
                }
                if (i == (t - 1))
                {
                    Console.WriteLine("\nEl mayor es " +
                        "\n");
                    Console.WriteLine(name[i] + " tiene " + age[i] + " años ");
                }
            }

        }
    }
}
