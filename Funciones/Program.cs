using System;

namespace Funciones
{
    class Program
    {
        static int a;
        static void Main(string[] args)
        {
            Console.Write("Contar los numeros del: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Al: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("De: ");
            int z = Convert.ToInt32(Console.ReadLine());

            contar(x, y, z);
            Console.WriteLine();
            
            contar(55, 105, 2);

            a = 70;

            funcion(a);
        }

        static void contar(int inicio, int fin, int step)
        {
            if (fin < inicio)
            {
                for (int i = inicio; i >= fin; i -= step)
                {
                    Console.Write($"{i}, ");
                }
            }
            else
            {
                for (int i = inicio; i <= fin; i += step)
                {
                    Console.Write($"{i}, ");
                }
            }
            
            Console.WriteLine();
        }

        static void funcion(int x)
        {
            x = 50;
            Console.WriteLine(a);
        }
    }
}
