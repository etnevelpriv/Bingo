namespace Bingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JatekosokBeolvasasa();
        }

        static void JatekosokBeolvasasa()
        {
            List<BingoJatekos> jatekosok = new List<BingoJatekos>();
            foreach (var file in Directory.GetFiles("../../../Jatekosok", "*.txt"))
            {
                {
                    string nev = Path.GetFileNameWithoutExtension(file);
                    if (nev != "nevek")
                    {
                        string[] sorok = File.ReadAllLines(file);
                        List<int> szamok = new List<int>();
                        foreach (var sor in sorok)
                        {
                            string[] elemek = sor.Split(';');

                            foreach (var elem in elemek)
                            {
                                if (int.TryParse(elem, out int szam))
                                {
                                    szamok.Add(szam);
                                }
                            }
                        }
                        jatekosok.Add(new BingoJatekos { Nev = nev, Szamok = szamok, Talalatok = new List<int>() });
                    }
                }
            }
            foreach (var jatekos in jatekosok)
            {
                Console.WriteLine(jatekos);
            }
        }
    }
}
