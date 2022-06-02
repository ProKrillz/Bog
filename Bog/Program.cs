using Bog;

class Program
{
    public static void Main()
    {      
        Bogen bogen = new Bogen 
        { 
            BogId = 1, 
            Titel = "Den gode bog", 
            Forfatter = "Thomas", 
            IsbnNummer = "123456", 
            Udgivelse = new DateTime(2020, 04, 22)
        };
        Bogen bogen2 = new Bogen(2, "Den onde bog") { Forfatter = "Satan", IsbnNummer = "666", Udgivelse = new DateTime(2006, 6, 6) };
        Blad blad = new Blad { BladId = 1, Titel = "Anders And", IsbnNummer = "354634", Udgivelse = new DateTime(2022, 5, 3) };
        Blad blad2 = new Blad(2, "Stålanden", "649374938", new DateTime(2013, 1, 1));
    }
}
