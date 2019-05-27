using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Handlers
{
   public class HandlerPozicija
    {
        TaskRepository repo;

        public HandlerPozicija()
        {
            repo = new TaskRepository();
        }
        public Pozicija HandlerGetpozicija(int idPozicija)
        {
            var pozicija = repo.GetPozicija(idPozicija);
            return pozicija;
        }
        public List<Pozicija> HandlerGetpozicii ()
        {
            var pozicija = repo.GetPozicii();
            return pozicija;
        }
        public Pozicija HandlerDeletepozicija(int idPozicija)
        {
            var poz = repo.GetPozicija(idPozicija);
            if (poz == null) throw new ArgumentException();
            var pozicija = repo.DeletePozicija(idPozicija);
            return pozicija;
        }
        public Pozicija HandlerPostpozicija(string pozicija)
        {
            var pozicii = repo.PostPozicija(pozicija);
            return pozicii;
        }
        public Pozicija HandlerPutpozicija(int id, string pozicija)
        {
            var poz = repo.GetPozicija(id);
            if (poz == null) throw new ArgumentException();
            var pozicii = repo.PutPozicija(id, pozicija);
            return pozicii;
        }
    }
}
