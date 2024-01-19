
namespace Setul_3___ex._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.

            int n, i;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            
            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            insertionSort(vector);

            for (i = 0; i < n; i++)
                Console.Write(vector[i] + " ");
        }

        private static void insertionSort(int[] vector)
        {
            for (int i = 1; i < vector.Length; i++)
                for (int k = i; k > 0 && vector[k] < vector[k - 1]; k--)
                    (vector[k - 1], vector[k]) = (vector[k], vector[k - 1]);
        }
    }
}
