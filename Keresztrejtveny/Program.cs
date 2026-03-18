namespace Keresztrejtveny
{
    internal class Program
    {

        static void Main(string[] args)
        {
            KeresztrejtvenyRacs racs = new KeresztrejtvenyRacs("kr1.txt");
            Console.WriteLine("5. feladat: A keresztrejtvény mérete");
            Console.WriteLine($"Sorok száma: {racs.SorokDb}");
            Console.WriteLine($"Oszlopok száma: {racs.OszlopokDb}");
            //6
            Console.WriteLine("\n6. a beolvasott keresztrejtveny");
            racs.Megjelenit();
            //7
            Console.WriteLine($"\n7. feladat: a leghosszabb függ.: {racs.LeghosszabbFuggoleges()} karakter");
            //8
            Console.WriteLine("\n8. feladat: vizszintes szavak stat");
            racs.VizszintesStatisztika();
        }
    }
}

