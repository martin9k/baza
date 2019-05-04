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
        public Filtriranje HandlerGetFiltriranje(int id_proekt, int id_vraboten, int id_status, string ime, string prezime, string naslov)
        {
            var filtriranje = repo.GetFiltriranje(id_proekt,id_status,id_vraboten,ime,prezime,naslov);
            return filtriranje;
        }
    }
}
