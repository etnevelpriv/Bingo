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
                    if (nev != "nevek" || jatekosok.Count < 100)
                    {
                        string[] sorok = File.ReadAllLines(file);
                        List<string> szamok = new List<string>();
                        foreach (var sor in sorok)
                        {
                            string[] elemek = sor.Split(';');

                            foreach (var elem in elemek)
                            {
                                szamok.Add(elem);
                            }
                        }
                        jatekosok.Add(new BingoJatekos(nev, szamok, new List<string>()));
                    }
                }
            }
            Console.WriteLine($"4. Feladat: A játékosok száma: {jatekosok.Count()}");
        }
    }
}
