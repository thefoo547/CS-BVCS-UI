using System;
using System.Linq;

namespace UnidadI
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tu nota es de: "+ nota);
            /*
            if (nota>=90)
            {
                Console.WriteLine("Excelente");
            }

            else if (nota >= 80)
            {
                Console.WriteLine("Muy bien");
            }

            else if(nota >= 70)
            {
                Console.WriteLine("Bien");
            }

            else if(nota>=60)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
            */

            char grado = (nota >= 90) ? 'A' : (nota>=80)? 'B' : (nota>=70)? 'C' : (nota>=60)? 'D' : 'F';

            switch (grado)
            {
                case 'A':
                    {
                        Console.WriteLine("Excelente");
                        break;
                    }
                case 'B':
                    {
                        Console.WriteLine("Muy Bien");
                        break;
                    }
                case 'C':
                    {
                        Console.WriteLine("Bien");
                        break;
                    }
                case 'D':
                    {
                        Console.WriteLine("Regular");
                        break;
                    }
                case 'F':
                    {
                        Console.WriteLine("Reprobado");
                        break;
                    }
            }


            Console.WriteLine(grado);

        }
    }
}
