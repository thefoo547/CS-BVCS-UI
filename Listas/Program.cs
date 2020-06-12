using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string> { "Pepito", "Ana", "Juan", "Mariela", "Pepito", "Pedro", "Pablo" };

            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine($"{i+1}. {nombres[i]}");
            }
            Console.WriteLine();

            nombres.Sort();

            //foreach como bucle
            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine();
            //foreach como funcion de orden superior
            nombres.ForEach(delegate(String name)
            {
                Console.WriteLine(name);
            });

            Console.WriteLine();

            //Linq query para buscar todos los nombres que empiezen con P
            var nombres_p = (from nombre in nombres where nombre.StartsWith("Pe") select nombre).Distinct();
           

            foreach (var n in nombres_p)
            {
                Console.WriteLine(n);
            }
        }
    }
}
