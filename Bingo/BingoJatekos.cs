using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    internal class BingoJatekos
    {
        private string Nev { get; set; }
        private List<string> Szamok { get; set; }
        private List<string> Talalatok { get; set; }

        public BingoJatekos(string nev, List<string> szamok, List<string> talalatok)
        {
            Nev = nev;
            Szamok = szamok;
            Talalatok = talalatok;
        }

        public override string ToString()
        {
            return $"{Nev} - Számok: {string.Join(", ", Szamok)} - Találatok: {string.Join(", ", Talalatok)}";
        }

        public void SorsoltSzamotJelol(string szam)
        {
            if (Szamok.Contains(szam) && !Talalatok.Contains(szam))
            {
                Talalatok.Add(szam);
            }
        }
    }
}
