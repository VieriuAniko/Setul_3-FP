namespace Setul_3___ex._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            bool[] prim = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                prim[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prim[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                        prim[i] = false;
                }
            }

            Console.Write($"Numerele prime mai mici sau egale cu {n} sunt: ");
            for (int i = 2; i <= n; i++)
            {
                if (prim[i])
                    Console.Write(i + " ");
            }
        }
    }
}
