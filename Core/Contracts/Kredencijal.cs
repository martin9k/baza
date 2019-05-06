using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
   public class Kredencijal
    {
      public int id_korisnik { set; get; }
      public  string korisnickoIme { set; get; }
      public  string lozinka { set; get; }
      public  bool aktiven { set; get; }
    }
}
