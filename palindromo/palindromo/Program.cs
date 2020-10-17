using System;

namespace palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el palabra");
            String palabra = (Console.ReadLine());
            char[] palabraArray = palabra.ToCharArray();
            String palabraAlRevez = "";
            for(int i= palabraArray.Length-1 ; i>=0; i--)
            {
                palabraAlRevez += palabraArray[i];
            }
            if (palabra== palabraAlRevez)
            {
                Console.WriteLine("la palabra es palindromo");
            }
            else
            {
                Console.WriteLine("la palabra NO es palindromo");
            }
        }
    }
}
