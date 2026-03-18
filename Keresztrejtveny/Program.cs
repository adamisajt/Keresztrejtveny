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

        }
    }
}

