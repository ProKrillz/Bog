using Bog;

class Program
{
    public static void Main()
    {   
        Bogen DeBlå = new Bogen(1, "De blå bæster", "R.L Stine", "8721018707", new DateTime(2002, 01, 01));
        Bogen BogenOmC = new Bogen(2, "Bogen om C# 9.0", "Michell Cronberg", "9788799338238", new DateTime(2021, 01, 01));
        Console.WriteLine(DeBlå.HentBog());
        Console.WriteLine(DeBlå.HentBogTitel());
        Console.WriteLine(BogenOmC.HentBog());

        Bogen deBlå2 = new Bogen("test", "thomas", "111111", new DateTime(2020, 01, 01));       
    }
}
