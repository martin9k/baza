using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
  public  class Korisnik
    {
     public string korisnickoIme { get; set; }
     public int id_vraboten { get; set; }
     public string ime { get; set; }
     public string prezime { get; set; }
     public string pozicija { get; set; }
    }
}
