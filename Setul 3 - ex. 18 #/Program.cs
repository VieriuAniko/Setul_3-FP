namespace Setul_3___ex._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
            //Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.

            Console.Write("Gradul polinomului: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Punctul valorii polinomului: ");
            int x = int.Parse(Console.ReadLine());

            int[] vector = new int[n + 1];

            int produs = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Introduceti coeficientul lui x^{i}: ");
                vector[i] = int.Parse(Console.ReadLine());
                produs += vector[i] * (int)Math.Pow(x, i);
            }

            Console.WriteLine($"Valoarea polinomului in punctul {x} este: {produs}.");
        }
    }
}
