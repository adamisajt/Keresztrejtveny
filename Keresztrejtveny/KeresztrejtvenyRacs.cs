using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keresztrejtveny
{
    internal class KeresztrejtvenyRacs
    {
        private List<string> Adatsorok;
        private char[,] Racs;
        private int[,] Sorszamok;

        public int SorokDb { get; }
        public int OszlopokDb { get; }

        public KeresztrejtvenyRacs(string forras)
        {
            BeolvasAdatsorok(forras);

            SorokDb = Adatsorok.Count;
            OszlopokDb = Adatsorok[0].Length;
            Racs = new char[SorokDb + 2, OszlopokDb + 2];
            Sorszamok = new int[SorokDb + 2, OszlopokDb + 2];

            FeltoltRacs();
        }

        public void BeolvasAdatsorok(string forras)
        {
            Adatsorok = new List<string>(File.ReadAllLines(forras));
        }

        public void FeltoltRacs()
        {
            for (int i = 0; i < SorokDb; i++)
                for (int j = 0; j < OszlopokDb; j++)
                Racs[i + 1, j + 1] = Adatsorok[i][j];
        }
        public void Megjelenit()
        {
            for (int i = 1; i <= SorokDb; i++)
            {
                for (int j = 1; j <= OszlopokDb; j++)
                {
                    if (Racs[i, j] == '-')
                        Console.Write("[]");
                    else
                        Console.Write("##");
                }
                Console.WriteLine();
            }
        }


        public int LeghosszabbFuggoleges()
        {
            int max = 0;
            for (int j = 1; j <= OszlopokDb; j++)
            {
                int hossz = 0;
                for (int i = 1; i <= SorokDb; i++)
                {
                    if (Racs[i, j] == '-')
                    {
                        hossz++;
                        if (hossz > max) max = hossz;
                    }
                    else
                        hossz = 0;
                }
            }
            return max;
        }
        public void VizszintesStatisztika()
        {
            Dictionary<int, int> stat = new Dictionary<int, int>();

            for (int i = 1; i <= SorokDb; i++)
            {
                int hossz = 0;

                for (int j = 1; j <= OszlopokDb; j++)
                {
                    if (Racs[i, j] == '-')
                        hossz++;
                    else
                    {
                        if (hossz >= 2)
                        {
                            if (!stat.ContainsKey(hossz))
                                stat[hossz] = 0;

                            stat[hossz]++;
                        }
                        hossz = 0;
                    }
                }

                if (hossz >= 2)
                {
                    if (!stat.ContainsKey(hossz))
                        stat[hossz] = 0;

                    stat[hossz]++;
                }
            }

            foreach (var k in stat.OrderBy(x => x.Key))
                Console.WriteLine($"{k.Key} betűs: {k.Value} darab");
        }
    }


}
