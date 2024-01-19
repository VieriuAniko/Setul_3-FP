
namespace Setul_3___ex._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()), i;

            int[] vector = new int[n];

            for (i = 0; i < n; i++) 
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Vectorul initial este: ");
            for (i = 0; i < n; i++)
                Console.Write(vector[i] + " ");

            SelectionSort(vector);

            Console.WriteLine("Vectorul sortat este: ");
            for (i = 0; i < n; i++) 
                Console.Write(vector[i] + " ");
        }

        private static void SelectionSort(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < vector.Length; j++)
                    if (vector[j] < vector[k])
                        k = j;
                int aux;
                aux = vector[i];
                vector[i] = vector[k]; ;
                vector[k] = aux;
            }
        }
    }
}
