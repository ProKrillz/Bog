namespace Bog
{
    internal class Bogen
    {
        public int BogId { get; set; }
        public string Titel { get; set; }
        public string Forfatter { get; set; }
        public string IsbnNummer { get; set; }
        public DateTime Udgivelse { get; set; }

        public Bogen() { }

        public Bogen(int bogId, string titel)
        {
            BogId = bogId;
            Titel = titel;
        }
    }
}
