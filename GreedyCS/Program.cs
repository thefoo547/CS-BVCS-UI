using System;

namespace GreedyCS
{
    class Program
    {
        static void Main(string[] args)
        {
            float dinero;
            do
            {
                Console.Write("Ingrese la cantidad de dinero: ");
                dinero = Convert.ToSingle(Console.ReadLine());
            } while (dinero < 0);
            int centavos = (int)Math.Round(dinero * 100);

            int mon_25 = centavos / 25;
            centavos %= 25;
            int mon_10 = centavos / 10;
            centavos %= 10;
            int mon_5 = centavos / 5;
            centavos %= 5;
            int mon_1 = centavos / 1;

            Console.WriteLine($"Se extraen {mon_25} monedas de 25, {mon_10} monedas de 10, {mon_5} monedas de 5 y {mon_1} monedas de 1 de {dinero:F2}$");
        }
    }
}
