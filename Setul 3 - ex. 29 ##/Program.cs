

namespace Setul_3___ex._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: MergeSort. Sortati un vector folosind metoda MergeSort.

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

            MergeSort(vector, 0, n - 1);
            Console.WriteLine();

            Console.Write("Vectorul sortat este: ");
            for (int i = 0; i < n; i++)
                Console.Write(vector[i] + " ");
        }

        private static void MergeSort(int[] vector, int st, int dr)
        {
            if (st < dr)
            {
                int m = st + (dr - st) / 2;

                MergeSort(vector, st, m);
                MergeSort(vector, m + 1, dr);

                Merge(vector, st, m, dr);
            }
        }

        private static void Merge(int[] vector, int st, int m, int dr)
        {
            int n1 = m - st + 1;
            int n2 = dr - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int x = 0; x < n1; x++)
                L[x] = vector[st + x];
            for (int y = 0; y < n2; y++)
                R[y] = vector[m + 1 + y];

            int i = 0, j = 0;

            int k = st;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    vector[k] = L[i];
                    i++;
                }
                else
                {
                    vector[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                vector[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                vector[k] = R[j];
                j++;
                k++;
            }

        }
    }
}