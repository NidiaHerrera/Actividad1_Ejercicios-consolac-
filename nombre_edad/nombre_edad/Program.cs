using System;

namespace nombre_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el nombre");
            String nombre = (Console.ReadLine());
            string [] nombres = { "juan", "maria", "tereza","pedro", "javier", "ana", "diana","jorge", "dayana", "lady" };
            int[] edad = { 12, 50, 23, 12, 18, 35, 41, 85, 16, 45};

            Boolean siExisteNombre = false;

            for(int i = 0; i < 10; i++)
            {
                if (nombre == nombres[i])
                {
                    Console.WriteLine("si exisite: "+ nombre+" su edad es: "+edad[i]);
                    siExisteNombre = true;
                }
            }

            if (siExisteNombre == false)
            {
                Console.WriteLine("No exisite: " + nombre );
            }


        }
    }
}
