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
    }


}
