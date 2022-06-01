namespace Bog
{
    internal class Bogen
    {
        int _bogId = default!;
        string _titel = default!;
        string _forfatter = default!;
        string _isbnNummer = default!;
        DateTime _udgivelse = default!;

        public Bogen(int bogId, string titel, string forfatter, string isbnNummer, DateTime udgivelse)
        {
            _bogId = bogId;
            _titel = titel;
            _forfatter = forfatter;
            _isbnNummer = isbnNummer;
            _udgivelse = udgivelse;
        }
        public string HentBog()
        {
            return $"Bog Id: {_bogId}\nTitel: {_titel}\nForfatter: {_forfatter}\nIsbn nummer: {_isbnNummer}\nUdgivelse: {_udgivelse.Year}";
        }
        public string HentBogTitel()
        {
            return $"Titel: {_titel}";
        }
    }
   

}
