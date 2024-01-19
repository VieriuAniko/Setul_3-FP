namespace Setul_3___ex._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.

            int n, k, i;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            int[] vectorRotit = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
                vectorRotit[i] = vector[(i + k) % n];

            Console.Write("Vectorul rotit este: ");
            for (i = 0; i < n; i++)
                Console.Write(vectorRotit[i] + " ");
        }
    }
}
