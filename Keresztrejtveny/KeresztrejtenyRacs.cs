using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keresztrejtveny
{
    internal class KeresztrejtenyRacs
    {
        public List<string> Adatsorok { get; private set; } = new List<string>();
        public char[,] Racs { get; private set; }
        public int SorokDb { get; private set; }
        public int OszlopokDb { get; private set; }

    }
    public KeresztrejtenyRacs(string forras)
    {
        BeolvasAdatsorok(forras);
        MeghatarozMeret();
        FeltoltRacs();
    }
    private void BeolvasAdatsorok(string forras)
    {
        using (var sr = new StreamReader(forras))
        {
            string sor;
            while ((sor = sr.ReadLine()) != null)
            {
                if (sor.Trim().Length > 0)
                    Adatsorok.Add(sor.Trim());
            }
        }
    }
    private void MeghatarozMeret()
    {
        SorokDb = Adatsorok.Count;
        OszlopokDb = Adatsorok[0].Length;
        Racs = new char[SorokDb, OszlopokDb];
    }
    private void FeltoltRacs()
    {
        for (int i = 0; i < SorokDb; i++)
        {
            for (int j = 0; j < OszlopokDb; j++)
            {
                Racs[i, j] = Adatsorok[i][j];
            }
        }
    }
}
