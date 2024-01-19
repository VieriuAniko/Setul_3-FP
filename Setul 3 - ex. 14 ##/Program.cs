
namespace Setul_3___ex._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.
            //(nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            int count = 0;  // numără toate elementele non-zero

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vector[i] = int.Parse(Console.ReadLine());

                if (vector[i] != 0)
                    vector[count++] = vector[i];
            }
            while (count < n)
                vector[count++] = 0;

            for (int i = 0; i < n; i++)
                Console.Write(vector[i] + " ");
        }
    }
}
