namespace Setul_3___ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

            int n, suma = 0;

            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
                suma += vector[i];

            Console.WriteLine($"Suma numerelor din vector este {suma}");
        }
    }
}
