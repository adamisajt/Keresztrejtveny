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
}
