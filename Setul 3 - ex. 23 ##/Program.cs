namespace Setul_3___ex._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.

            int n, m;

            Console.Write("Numarul de elemente din primul vector: ");
            n = int.Parse(Console.ReadLine());

            int[] v1 = new int[n];

            Console.Write("Numarul de elemente din al doilea vector: ");
            m = int.Parse(Console.ReadLine());

            int[] v2 = new int[m];

            Console.Write("***Elementele primului vector***");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                v1[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(v1);
            Console.WriteLine();

            Console.Write("Elementele vectorului 'v1' sunt: ");
            for (int i = 0; i < n; i++)
                Console.Write(v1[i] + " ");

            Console.WriteLine();

            Console.Write("***Elementele celui de-al doilea vector***");
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                v2[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(v2);
            Console.WriteLine();

            Console.Write("Elementele vectorului 'v2' sunt: ");
            for (int i = 0; i < m; i++)
                Console.Write(v2[i] + " ");
            Console.WriteLine();

            Console.WriteLine("***Intersectia vectorilor 'v1' si 'v2'***");
            Intersectie(v1, v2);
            Console.WriteLine();

            Console.WriteLine("***Reuniunea vectorilor 'v1' si 'v2'***");
            Reuniune(v1, v2);
            Console.WriteLine();

            Console.WriteLine("***Diferenta vectorilor 'v1' si 'v2'***");
            Diferenta(v1, v2);
            Console.WriteLine();

            Console.WriteLine("***Diferenta vectorilor 'v2' si 'v1'***");
            Diferenta(v2, v1);
        }

        private static void Diferenta(int[] v1, int[] v2)
        {
            var diferenta = v1.Except(v2);

            //Console.Write($"Elementele dupa diferenta sunt: ");
            foreach (var element in diferenta)
                Console.Write(element + " ");
        }

        private static void Reuniune(int[] v1, int[] v2)
        {
            var reuniune = v1.Union(v2);
            var sortat = reuniune.OrderBy(x => x);

            //Console.Write($"Cei doi vectori reuniti alcatuiesc multimea formata din numerele: ");
            foreach (var element in sortat)
                Console.Write(element + " ");
        }

        private static void Intersectie(int[] v1, int[] v2)
        {
            var intersectie = v1.Intersect(v2);

            //Console.Write("Elementele comune ale vectorilor sunt: ");
            foreach (var element in intersectie)
                Console.Write(element + " ");
        }
    }
}

