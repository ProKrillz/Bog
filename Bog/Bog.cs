﻿namespace Bog
{
    internal class Bogen
    {
        public int BogId { get; set; }
        public string Titel { get; set; }
        public string Forfatter { get; set; }
        public string IsbnNummer { get; set; }
        public DateTime Udgivelse { get; set; }
<<<<<<< HEAD

        int _bogId = default!;
        string _titel = default!;
        string _forfatter = default!;
        string _isbnNummer = default!;
        DateTime _udgivelse = default!;
=======
>>>>>>> Dev

        public Bogen() { }

        public Bogen(int bogId, string titel)
        {
<<<<<<< HEAD
            _bogId = bogId;
            _titel = titel;
            _forfatter = forfatter;
            _isbnNummer = isbnNummer;
            _udgivelse = udgivelse;
        }
        public Bogen(string titel, string forfatter, string isbnNummer, DateTime udgivelse)
        {
            Titel = titel;
            Forfatter = forfatter;
            IsbnNummer = isbnNummer;
            Udgivelse = udgivelse;
        }
        public string HentBog()
        {
            return $"Bog Id: {_bogId}\nTitel: {_titel}\nForfatter: {_forfatter}\nIsbn nummer: {_isbnNummer}\nUdgivelse: {_udgivelse.Year}";
        }
        public string HentBogTitel()
        {
            return $"Titel: {_titel}";
=======
            BogId = bogId;
            Titel = titel;
>>>>>>> Dev
        }
    }
}
