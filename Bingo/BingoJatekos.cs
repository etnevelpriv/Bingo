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
        public List<int> Szamok { get; set; }
        public List<int> Talalatok { get; set; }

        public override string ToString()
        {
            return $"{Nev} - Számok: {string.Join(", ", Szamok)} - Találatok: {string.Join(", ", Talalatok)}";
        }
    }
}
