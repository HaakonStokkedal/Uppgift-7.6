using System.Collections.Generic;
namespace Uppgift_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namn på matvaror");
            string matvarorInput = Console.ReadLine();
            string[] matvaror = matvarorInput.Split(' ');

            Console.WriteLine("Skriv in matvarornas priser");
            string priserInput = Console.ReadLine();
            string[] priserString = priserInput.Split(' ');
            double[] priser = new double[priserString.Length];

            for (int i = 0; i < priserString.Length; i++)
            {
                priser[i] = double.Parse(priserString[i]);
            }

            Console.WriteLine("Skriv in din handlingslista");
            string listaInput = Console.ReadLine();
            string[] lista = listaInput.Split(' ');

            int[] antal = new int[matvaror.Length];
            for (int j = 0; j < matvaror.Length; j++)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i] == matvaror[j])
                    {
                        antal[j]++;
                    }
                }

            }

            Console.WriteLine($"Totalsumman är {Pris(priser, antal)} kr.");
            Console.ReadKey();
        }

        static double Pris(double[] priser, int[] antal)
        {
            double summa = 0;

            for (int i = 0; i < antal.Length; i++)
            {
                summa += priser[i] * antal[i];
            }

            return summa;
        }
    }
}