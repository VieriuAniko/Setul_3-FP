namespace Setul_3___ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 

            int n, k, i, gasit = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n && gasit == 0; i++)
                if (vector[i] == k)
                {
                    gasit = 1;
                    Console.WriteLine($"Prima pozitie din vector pe care apare numarul {k} este pozitia {i}");
                }

            if (gasit == 0)
                Console.WriteLine(-1);
        }
    }
}
