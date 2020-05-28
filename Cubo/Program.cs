using System;

/*  Crear un programa que imprima un cubo de n * n
 * con la condicion que n no puede ser menor que 0
 * y mayor que 23
 * 
 * 
 */


namespace Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            // Do while para validar
            do {
                Console.Write("Ingrese n: ");
                n = Convert.ToInt32(Console.ReadLine());
                // que n no sea mayor que 25 y menor que 0
            } while (n < 0 || n > 25);
            // for i imprime las columnas
            for (int i = 0; i < n; i++)
            {
                // for j imprime las filas
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                // salto de linea despues de cada fila
                Console.WriteLine();
            }
            /*
             * ###
             * ###
             * ###
             */
            Console.WriteLine();
        }
    }
}
