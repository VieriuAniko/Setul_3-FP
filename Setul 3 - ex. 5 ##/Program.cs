using System.Numerics;
using System.Runtime.InteropServices;

namespace Setul_3___ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k.
            //Primul element al vectorului se considera pe pozitia zero.

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()); //elemente

            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine()); //valoare

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine()); //pozitie

            int[] vector = new int[n];

            Console.WriteLine("Vectorul initial este: ");
            for (int i = 0; i < n; i++) 
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());

                if (i == k)
                    vector[i] = e;
            }

            Console.WriteLine();
            Console.Write("Vectorul modificat este: ");
            for (int i = 0; i < n; i++) 
            {
                Console.Write(vector[i] + " ");
            }
        }
    }
}
