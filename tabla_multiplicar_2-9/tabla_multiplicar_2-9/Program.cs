using System;

namespace tabla_multiplicar_2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tablas del 2 al 9");

            for (int nTabla = 2; nTabla < 10; nTabla++)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine( nTabla + "X" + i + "=" + nTabla * i );
                }

                Console.WriteLine("");
            }
        }
    }
}
