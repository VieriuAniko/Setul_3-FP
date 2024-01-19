namespace Setul_3___ex._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: (Interclasare) Se dau doi vector sortati crescator v1 si v2.
            //Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 

            int n, m, i;

            Console.Write("Numarul de elemente din primul vector: ");
            n = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];

            Console.Write("Numarul de elemente din al doilea vector: ");
            m = int.Parse(Console.ReadLine());

            int[] v2 = new int[m];

            Console.Write("***Elementele primului vector***");
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Elementele vectorului 'v1' sunt: ");
            for (i = 0; i < n; i++)
                Console.Write(v1[i] + " ");

            Console.WriteLine();

            Console.Write("***Elementele celui de-al doilea vector***");
            Console.WriteLine();
            for (i = 0; i < m; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                v2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Elementele vectorului 'v2' sunt: ");
            for (i = 0; i < m; i++)
                Console.Write(v2[i] + " ");
            Console.WriteLine();

            int[] v3 = new int[v1.Length + v2.Length];

            i = 0;
            int j = 0, k = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    v3[k] = v1[i];
                    i++;
                }
                else
                {
                    v3[k] = v2[j];
                    j++;
                }
                k++;
            }

            while (i < v1.Length)
            {
                v3[k] = v1[i];
                i++;
                k++;
            }

            while (j < v2.Length)
            {
                v3[k] = v2[j];
                j++;
                k++;
            }

            Console.WriteLine("Elementele din vectorul interclasat sunt:");
            foreach (var element in v3)
            {
                Console.Write(element + " ");
            }
        }
    }
}
