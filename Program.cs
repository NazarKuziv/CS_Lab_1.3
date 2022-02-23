using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, N;
            double S = 1;

            Console.Write("N = ");
            N = Convert.ToInt32(Console.ReadLine());
            k = N;

            while (k <= 19)
            {
                S *= (1.0 * k - N) / (1.0 * k + N) + 1;
                k++;
            }
            Console.WriteLine($"S1 = {Math.Round(S, 2)}");

            S = 1;
            k = N;
            do
            {
                S *= (1.0 * k - N) / (1.0 * k + N) + 1;
                k++;
            } while (k <= 19);
            Console.WriteLine($"S2 = {Math.Round(S, 2)}");

            S = 1;
            for (k = N; k <= 19; k++)
            {
                S *= (1.0 * k - N) / (1.0 * k + N) + 1;
            }
            Console.WriteLine($"S3 = {Math.Round(S, 2)}");
           
            S = 1;
            for (k = 19; k >= N; k--)
            {
                S *= (1.0 * k - N) / (1.0 * k + N) + 1;
            }
            Console.WriteLine($"S3 = {Math.Round(S, 2)}");

            Console.ReadKey();


        }
    }
}
