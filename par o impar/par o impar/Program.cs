using System;

namespace par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
           
            Console.WriteLine("ingrese numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("es un numero par");
            }
            else
            {
                Console.WriteLine("es un numero impar");
            }

        }
    }
}
