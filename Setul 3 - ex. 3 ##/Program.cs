namespace Setul_3___ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 

            int n, nrMinim, nrMaxim, pozMinim = 0, pozMaxim = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            nrMinim = nrMaxim = vector[0];

            for (int i = 0; i < n; i++)
            {
                if (vector[i] < nrMinim)
                {
                    nrMinim = vector[i];
                    pozMinim = i;
                }

                if (vector[i] > nrMaxim)
                {
                    nrMaxim = vector[i];
                    pozMaxim = i;
                }
            }

            Console.WriteLine($"Pozitia numarului cel mai mic din vector este {pozMinim}, iar pozitia numarului cel mai mare din vector este {pozMaxim}");
        }
    }
}
