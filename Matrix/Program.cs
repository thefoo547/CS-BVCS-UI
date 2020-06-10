using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de filas");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cantidad de columnas");
            int n = Convert.ToInt32(Console.ReadLine());

            // si el arreglo no tenía valores
            int[,] matriz = new int[m, n];
            //i para las filas
            for (int i = 0; i < m; i++)
            {
                //j para las columnas
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            imprimir_matriz(matriz);

            int[,] mt = { { 5, 6, 8 }, { 74, 99, 156 } };
            imprimir_matriz(mt);
        }

        static void imprimir_matriz(int[,] mtx)
        {
            Console.WriteLine("----------------");
            for (int i = 0; i < mtx.GetLength(1); i++)
            {
                for (int j = 0; j < mtx.GetLength(0); j++)
                {
                    Console.Write($"|{mtx[j, i]}| ");
                }
                Console.WriteLine();
            }
        }
    }
}
