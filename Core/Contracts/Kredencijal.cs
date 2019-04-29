using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
   public class Kredencijal
    {
        string korisnicko_ime { set; get; }
        string lozinka { set; get; }
        bool aktiven { set; get; }
    }
}
