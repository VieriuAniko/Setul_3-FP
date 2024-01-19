namespace Setul_3___ex._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta).
            //Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.
            //(Problema este dificila doar daca o rezolvati cu un algoritm liniar).

            int nr1, nr2, nr = 0;

            Console.Write("Introduceti cate elemente are vectorul din care se cauta: ");
            nr1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti cate elemente are vectorul care se cauta: ");
            nr2 = int.Parse(Console.ReadLine());

            int[] vectorCautare = new int[nr1];
            int[] vectorCauta = new int[nr2];

            Console.WriteLine();
            Console.WriteLine("***Vectorul din care se cauta***");
            for (int i = 0; i < nr1; i++) 
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vectorCautare[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("vectorCautare are urmatorii termeni: ");
            for (int i = 0; i < nr1; i++)
                Console.Write(vectorCautare[i] + " ");
            Console.WriteLine();

            Console.WriteLine("***Vectorul care se cauta***");
            for (int i = 0; i < nr2; i++)
            {
                Console.Write($"Introduceti termenul de pe pozitia {i}: ");
                vectorCauta[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("vectorCauta are urmatorii termeni: ");
            for (int i = 0; i < nr2; i++)
                Console.Write(vectorCauta[i] + " ");
            Console.WriteLine();
            for (int i = 0; i <= nr1 - nr2; i++)
            {
                bool gasit = true;
                for (int j = 0; j < nr2; j++)
                {
                    if (vectorCautare[i + j] != vectorCauta[j])
                    {
                        gasit = false;
                        break;
                    }
                }

                if (gasit)
                    nr++;
            }

            Console.WriteLine($"Vectorul 'vectorCauta' apare de {nr} ori in vectorul 'vectorCautare'");
        }
    }
}
