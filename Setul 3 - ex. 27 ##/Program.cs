namespace Setul_3___ex._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un vector si un index in vectorul respectiv.
            //Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 

            int n, index, i;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("index = ");
            index = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Vectorul initial este: ");
            for (i = 0; i < n; i++)
                Console.Write(vector[i] + " ");

            Console.WriteLine();

            int nr = vector[index];
            Console.WriteLine($"Numarul initial de pe valoarea {index} este {nr}");

            Array.Sort(vector);

            Console.Write("Vectorul sortat este: ");
            for (i = 0; i < n; i++)
                Console.Write(vector[i] + " ");

            nr = vector[index];
            Console.WriteLine();

            Console.WriteLine($"Noul numar de pe valoarea {index} dupa sortare este {nr}");
        }
    }
}
