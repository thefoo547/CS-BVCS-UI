using System;
using System.Collections.Specialized;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos numeros va a ingresar?");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vct = { 45, 75, 223 };
            int[] arr = new int[3];


            leer_arreglo(arr);

            imprimir_arreglo(arr);
            
        }

        static void leer_arreglo(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Numero {i + 1}:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        static void imprimir_arreglo(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
