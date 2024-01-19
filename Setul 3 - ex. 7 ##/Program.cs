namespace Setul_3___ex._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Reverse. Se da un vector cu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
            //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

            int n, i;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            int[] reverseVector = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Vectorul initial este: ");
            for (i = 0; i < n; i++)
                Console.Write(vector[i] + " ");
            Console.WriteLine();

            for (i = 0; i < n; i++)
                reverseVector[i] = vector[n - i - 1];

            Console.Write("Vectorul inversat este: ");
            for (i = 0; i < n; i++)
                Console.Write(reverseVector[i] + " ");
                
        }
    }
}
