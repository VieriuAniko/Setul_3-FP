namespace Setul_3___ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 

            int n, i, nrMinim = 0, nrMaxim = 0, aparitiiMin = 0, aparitiiMax = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    nrMinim = nrMaxim = vector[i];
                    aparitiiMax++;
                    aparitiiMin++;
                }
                else
                {
                    if (vector[i] < nrMinim)
                    {
                        nrMinim = vector[i];
                        aparitiiMin = 1;
                    }
                    else if (vector[i] == nrMinim)
                        aparitiiMin++;

                    if (vector[i] > nrMaxim)
                    {
                        nrMaxim = vector[i];
                        aparitiiMax = 1;
                    }
                    else if (vector[i] == nrMaxim)
                        aparitiiMax++;
                }

            }

            Console.WriteLine($"Cea mai mica valoare a vectorului este {nrMinim} (cu {aparitiiMin} aparitii), iar cea mai mare valoare a vectorului este {nrMaxim} (cu {aparitiiMax} aparitii)");
        }
    }
}
