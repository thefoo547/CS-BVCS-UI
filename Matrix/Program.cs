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
           

            //matriz normal
            int[,] mt = { { 5, 6, 8 }, { 74, 99, 156 } };

            //matriz truncada
            int[][] jmt = new int[3][];

            jmt[0] = new int[]{2, 3, 5};
            jmt[1] = new int[]{ 4, 7 };
            jmt[2] = new int[]{ 6, 11, 52, 100 };


            imprimir_matriz(mt);
            Console.WriteLine();
            imprimir_matrizt(jmt);
        }

        static void imprimir_matrizt(int[][] jmt)
        {
            for (int i = 0; i < jmt.Length; i++)
            {
                for (int j = 0; j < jmt[i].Length; j++)
                {
                    Console.Write($"|{jmt[i][j]}| ");
                }
                Console.WriteLine();
            }
        }

        static void imprimir_matriz(int[,] mtx)
        {
            Console.WriteLine("----------------");
            //filas, getlength(0)
            for (int i = 0; i < mtx.GetLength(0); i++)
            {
                //col, getlength(1)
                for (int j = 0; j < mtx.GetLength(1); j++)
                {
                    Console.Write($"|{mtx[i, j]}| ");
                }
                Console.WriteLine();
            }
        }
    }
}
