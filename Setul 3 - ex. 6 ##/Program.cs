namespace Setul_3___ex._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.
            //Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.

            int n, k, i, x;

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

            Console.Write("Vectorul initial este: ");
            for (i = 0; i < n; i++)
                Console.Write($"{vector[i]} ");

            for (i = 0; i < n - 1; i++)
            {
                if (i >= k)
                    vector[i] = vector[i + 1];
            }

            Array.Resize(ref vector, n - 1);

            Console.WriteLine();
            Console.Write("Vectorul modificat este: ");
            for (i = 0; i < n - 1; i++)
                Console.Write($"{vector[i]} ");
        }
    }
}
