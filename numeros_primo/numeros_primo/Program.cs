using System;

namespace numeros_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool validacion = false;
            Console.WriteLine("ingrese el numero para evaluar si es primo o no");
            numero =Int32.Parse( Console.ReadLine());


            for (int i = 2; i < numero; i++)
            {
               if  ((numero % i)==0)
                {
                    validacion = true;
                }
            }

            if (validacion == false)
            {
                Console.WriteLine("si es primo");
            }
            else
            {
                Console.WriteLine("no es primo");
            }

        }
    }
}
