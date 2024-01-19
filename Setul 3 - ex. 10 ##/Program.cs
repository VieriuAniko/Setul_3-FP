namespace Setul_3___ex._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k.
            //Daca elementul nu se gaseste in vector rezultatul va fi -1. 

            int n, k, i, ok = 0, pozitie = -1;

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

            for (i = 0; i < n; i++)
                if (vector[i] == k && ok == 0)
                {
                    pozitie = i;
                    ok = 1;
                }

            Console.WriteLine(pozitie);
        }
    }
}
