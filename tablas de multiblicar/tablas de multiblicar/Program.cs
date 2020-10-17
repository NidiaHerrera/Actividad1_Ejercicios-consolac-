using System;

namespace tablas_de_multiblicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero del cual quiere multiplicar");
           int tabla = Convert.ToInt32(Console.ReadLine());

           for (int i = 1; i < 11; i++)
            {
                Console.WriteLine ( tabla + "X" + i + "=" + tabla * i);
            }



          


        }
    }
}
