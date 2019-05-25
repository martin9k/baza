using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public class Zadaca
    {
        public int id_zadaca { get; set; }
        public string naslov { get; set; }
        public string opis { get; set; }
        public bool odobrena { get; set; }
        public int estimacija { get; set; }
        public string datum_kreiranje { get; set; }
       public string datum_posledna_promena{ get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string proekt_ime { get; set; }
    }
}
