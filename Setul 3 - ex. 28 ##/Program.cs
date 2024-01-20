


namespace Setul_3___ex._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Quicksort. Sortati un vector folosind metoda QuickSort.

            int n;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Vectorul initial este: ");
            for (int i = 0; i < n; i++)
                Console.Write(vector[i] + " ");

            QuickSort(vector, 0, n - 1);
            Console.WriteLine();

            Console.Write("Vectorul dupa sortare este: ");
            for (int i = 0; i < n; i++)
                Console.Write(vector[i] + " ");
        }

        private static void QuickSort(int[] vector, int st, int dr)
        {
            if (st < dr)
            {
                int pi = Partition(vector, st, dr);
                QuickSort(vector, st, pi - 1);
                QuickSort(vector, pi + 1, dr);
            }
        }

        private static int Partition(int[] vector, int st, int dr)
        {
            int pivot = vector[dr];
            int i = (st - 1);
            for (int j = st; j < dr; j++)
            {
                if (vector[j] <= pivot)
                {
                    i++;
                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                }
            }
            int temp1 = vector[i + 1];
            vector[i + 1] = vector[dr];
            vector[dr] = temp1;
            return i + 1;
        }
    }
}
