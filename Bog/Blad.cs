using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog
{
    public class Blad
    {
        public int BladId { get; set; }
        public string Titel { get; set; }
        public string IsbnNummer { get; set; }
        public DateTime Udgivelse { get; set; }
        public Blad() { }
        public Blad(int bladId, string titel, string isbnNummer, DateTime udgivelse)
        {
            BladId = bladId;
            Titel = titel;
            IsbnNummer = isbnNummer;
            Udgivelse = udgivelse;
        }
    }
}
