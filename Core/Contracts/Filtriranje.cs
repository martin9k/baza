using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
   public class Filtriranje
    {
        string ime { get; set; }
        string prezime { get; set; }
        string naslov { get; set; }
        int id_vraboten { get; set; }
        int id_status { get; set; }
        int id_proekt { get; set; }
    }
}
