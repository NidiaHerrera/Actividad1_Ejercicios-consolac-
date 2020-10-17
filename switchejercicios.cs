using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_con_menu
{
    class Program
    {
        static void Main(string[] args)
        {


            int Macaco;

            do
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Dependiendo del ejercicio que precise coloque:\n" +
                    "1. Define Si Es Par o Impar\n" +
                    "2. Genera los multiplos del 1 al 10 del numero que insertes\n" +
                    "3. Genera las tablas de multiplicar del 2 al 9 del con sus multiplos del 1 al 10\n" +
                    "4. Define si un numero es primo o no\n" +
                    "5. Ordena de forma ascendente el vector de edad\n" +
                    "6. Datos Del Vector\n" +
                    "7. Ordena el vector de menor a mayor con sus respectivos datos\n" +
                    "8. Difine si una palabra es un palindromo o no\n" +
                    "9. Salir");

                Macaco = Convert.ToInt32(Console.ReadLine());

                switch (Macaco)
                {


                    case 1:

                        int num;

                        Console.WriteLine("ingrese numero");
                        num = Convert.ToInt32(Console.ReadLine());

                        if (num % 2 == 0)
                        {
                            Console.WriteLine("es un numero par");
                        }
                        else
                        {
                            Console.WriteLine("es un numero impar");
                        }

                        Console.ReadKey();
                        break;

                    case 2:

                        Console.WriteLine("ingrese numero del cual quiere multiplicar");
                        //Pide al usuario que ingrese el numero de la tabla que desea multiplicar

                        int tabla = Convert.ToInt32(Console.ReadLine());
                        //crear una variable de tipó int le asigno el nombren de tabla

                        for (int u = 1; u < 11; u++)
                        //hacer un for que nos recorre las tablas de multiplicar del 1 al 11
                        {
                            Console.WriteLine(tabla + "X" + u + "=" + tabla * u);
                            //Modtrar en consola tabla X el contador = tabla * contador que es el resultado
                        }
                        Console.ReadKey();

                        break;

                    case 3:

                        Console.WriteLine("tablas del 2 al 9");

                        for (int nTabla = 2; nTabla < 10; nTabla++)
                        {
                            for (int o = 1; o < 11; o++)
                            {
                                Console.WriteLine(nTabla + "X" + o + "=" + nTabla * o);
                            }

                            Console.WriteLine("");
                        }

                        break;

                    case 4:

                        int numero;
                        bool validacion = false;
                        Console.WriteLine("ingrese el numero para evaluar si es primo o no");
                        numero = Int32.Parse(Console.ReadLine());


                        for (int x = 2; x < numero; x++)
                        {
                            if ((numero % x) == 0)
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

                        break;

                    case 5:

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

                        break;


                    case 6:

                        Console.WriteLine("Ingresa el nombre");
                        String nombre = (Console.ReadLine());
                        string[] nombres = { "Juan", "Maria", "Tereza", "Pedro", "Javier", "Ana", "Diana", "Jorge", "Dayana", "Leidy" };
                        int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };

                        Boolean siExisteNombre = false;

                        for (int f = 0; f < 10; f++)
                        {
                            if (nombre == nombres[f])
                            {
                                Console.WriteLine("si existe: " + nombre + " su edad es: " + edad[f]);
                                siExisteNombre = true;
                            }
                        }

                        if (siExisteNombre == false)
                        {
                            Console.WriteLine("No existe: " + nombre);
                        }

                        Console.ReadKey();

                        break;


                    case 7:

                        int[] age = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        string[] name = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                        int p = age.Length;
                        int tempo;
                        string tempo2;
                        Console.WriteLine("\n" +
                            "Arrelo Original\n");
                        foreach (int item in age)
                        {
                            Console.Write(item + " | ");
                        }

                        for (int x = 1; x < p - 1; x++)
                        {
                            for (int h = 0; h < p - x; h++)
                            {
                                if (age[h] > age[h + 1])
                                {
                                    tempo = age[h];
                                    age[h] = age[h + 1];
                                    age[h + 1] = tempo;

                                    tempo2 = name[h];
                                    name[h] = name[h + 1];
                                    name[h + 1] = tempo2;

                                }
                            }
                        }
                        Console.WriteLine("\n \n" +
                            "Arreglo ordenado\n");
                        foreach (int item in age)
                        {
                            Console.Write(item + " | ");
                        }

                        for (int h = 0; h < p; h++)
                        {
                            if (h == 0)
                            {
                                Console.WriteLine("\n \n \nEl menor es " +
                                    "\n");
                                Console.WriteLine(name[h] + " tiene " + age[h] + " años ");
                            }
                            if (h == (p - 1))
                            {
                                Console.WriteLine("\nEl mayor es " +
                                    "\n");
                                Console.WriteLine(name[h] + " tiene " + age[h] + " años ");
                            }
                        }

                        Console.ReadKey();

                        break;

                    case 8:

                        Console.WriteLine("ingresa la palabra");
                        String palabra = (Console.ReadLine());
                        char[] palabraArray = palabra.ToCharArray();
                        String palabraAlRevez = "";
                        for (int q = palabraArray.Length - 1; q >= 0; q--)
                        {
                            palabraAlRevez += palabraArray[q];
                        }
                        if (palabra == palabraAlRevez)
                        {
                            Console.WriteLine("la palabra es palindromo");
                        }
                        else
                        {
                            Console.WriteLine("la palabra NO es palindromo");
                        }

                        break;


                }

                

            } while (Macaco != 9);

        }
    }
}
