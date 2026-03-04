using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    internal class BingoJatekos
    {
        public string Nev { get; set; }
        public List<string> Szamok { get; set; }
        public List<string> Talalatok { get; set; }

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
