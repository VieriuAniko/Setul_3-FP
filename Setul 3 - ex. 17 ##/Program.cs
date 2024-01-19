namespace Setul_3___ex._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.

            Console.Write("Introduceti numarul n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti baza b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b < 2 || b > 16)
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine($"Numarul {n} in baza {b} este: {ConvertToBase(n, b)}");
        }

        static string ConvertToBase(int n, int b)
        {
            const string chars = "0123456789ABCDEF";
            string result = "";

            while (n > 0)
            {
                result = chars[n % b] + result;
                n /= b;
            }

            return result;   
        }
    }
}
