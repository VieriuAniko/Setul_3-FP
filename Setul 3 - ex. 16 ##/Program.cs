

namespace Setul_3___ex._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.

            int n;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(FindGCD(vector, n));
        }

        private static int FindGCD(int[] vector, int n)
        {
            int result = vector[0];
            for (int i = 1; i < n; i++)
            {
                result = GCD(vector[i], result);

                if (result == 1)
                    return 1;
            }
            return result;
        }

        private static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
    }
}
