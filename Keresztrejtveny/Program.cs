namespace Keresztrejtveny
{
    internal class Program
    {

        static void Main(string[] args)
        {
            KeresztrejtenyRacs racs = new KeresztrejtenyRacs("kr1.txt");
            Console.WriteLine("5. feladat");
            Console.WriteLine($"a keresztrejtveny merete: {racs.MeretSzoveg()}");

            Console.WriteLine("6. feladat");
            racs.SzavakStatisztika(out int szavakSzama, out int maxHossz);
            Console.WriteLine($"a keresztrejtvenyben {szavakSzama} darab szo van.");
            Console.WriteLine($"a leghosszabb szo hossza: {maxHossz}");


            Console.ReadKey();
        }
    }
}

