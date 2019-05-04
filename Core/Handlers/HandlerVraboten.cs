using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Handlers
{
   public class HandlerVraboten
    {
        TaskRepository repo;

        public HandlerVraboten()
        {
            repo = new TaskRepository();
        }
        public List<Vraboten> HandlerGetvraboteni()
        {
            var stat = repo.GetVraboteni();
            return stat;
        }
        public Vraboten HandlerGetvraboten(int idVraboten)
        {
            var stat = repo.GetVraboten(idVraboten);
            return stat;
        }
        public Vraboten HandlerPostvraboten(int id_kredencijali, int id_pozicija,int id_oddel,string ime,string prezime,string grad,string adresa,string telefonski_broj)
        {
            var stat = repo.PostVraboten(id_kredencijali, id_pozicija,id_oddel,ime, prezime,grad,adresa, telefonski_broj);
            return stat;
        }
        public Vraboten HandlerPutvraboten(int id_vraboten,int id_kredencijali, int id_pozicija, int id_oddel, string ime, string prezime, string grad, string adresa, string telefonski_broj)
        {
            var stat = repo.PutVraboten(id_vraboten,id_kredencijali, id_pozicija, id_oddel, ime, prezime, grad, adresa, telefonski_broj);
            return stat;
        }
        public Vraboten HandlerDeletevraboten(int idVraboten)
        {
            var stat = repo.DeleteVraboten(idVraboten);
            return stat;
        }
    }
}
