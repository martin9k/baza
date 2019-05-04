using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
   public class Kredencijal
    {
      public  string korisnickoIme { set; get; }
      public  string lozinka { set; get; }
      public  bool aktiven { set; get; }
    }
}
