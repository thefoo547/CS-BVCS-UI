using System;

namespace AdiosMundo
{
    class Program
    {
        static int a = 21;
        static void Main(string[] args)
        {
            imprimir_num(a);
        }

        public static void imprimir_num(int x)
        {
            x = 12;
            Console.WriteLine(a);
        }
    }
}
