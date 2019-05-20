using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Handlers
{
  public  class HandlerFiltriranje
    {
        TaskRepository repo;

        public HandlerFiltriranje()
        {
            repo = new TaskRepository();
        }
        public List<Filtriranje> HandlerGetFiltriranje(string id_proekt, string id_vraboten, string id_status, string ime, string prezime, string naslov)
        {
            var filtriranje = repo.GetFiltriranje(id_proekt,id_vraboten, id_status,ime, prezime,naslov);
            return filtriranje;
        }
    }
}
