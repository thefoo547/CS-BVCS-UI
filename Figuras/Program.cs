using System;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fl;
            float area = 0;
            do
            {
                Console.WriteLine("Seleccione una figura geométrica");

                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Circulo");
                Console.WriteLine("3. Triángulo");

                int opt = Convert.ToInt32(Console.ReadLine());
                
                fl = false;
                switch (opt)
                {
                    case 1:
                        area = area_rectángulo(2, 5);
                        break;
                    case 2:
                        area = area_circulo(5);
                        break;
                    case 3:
                        triangulo();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        fl = true;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (fl);
        }
        static void triangulo()
        {
            float b, h;
            do
            { 
                Console.Write("Ingrese la base: ");
                b = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ingrese la altura: ");
                h = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
            } while (b < 0 || h < 0);

            Console.WriteLine($"El área del triángulo es {area_triangulo(b, h)}");
        }

        static float area_rectángulo(float b, float h)
        {
            return b * h;
        }
        static float area_circulo(float r)
        {
            return (float)((float)Math.PI * Math.Pow(r,2));
        }
        static float area_triangulo(float b, float h)
        {
            return (b * h) / 2;
        }
    }
}
