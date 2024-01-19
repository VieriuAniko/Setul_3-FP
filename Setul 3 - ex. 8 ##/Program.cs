namespace Setul_3___ex._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
            //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.

            int n, i, aux;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            aux = vector[0];

            for (i = 0; i < n; i++)
                if (i < n - 1)
                    vector[i] = vector[i + 1];
                else
                    vector[i] = aux;

            for (i = 0; i < n; i++)
                Console.Write(vector[i] + " ");
        }
    }
}
