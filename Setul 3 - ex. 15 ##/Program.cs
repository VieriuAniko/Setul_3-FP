namespace Setul_3___ex._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int j = 0;
            for (int i = 0; i < n - 1; i++)
                if (arr[i] != arr[i + 1])
                    arr[j++] = arr[i];

            arr[j++] = arr[n - 1];

            Array.Resize(ref arr, j);

            for (int i = 0; i < j; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
