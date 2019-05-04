using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Handlers
{
   public class HandlerKredencijal
    {
        TaskRepository repo;

        public HandlerKredencijal()
        {
            repo = new TaskRepository();
        }
        public Kredencijal HandlerGetkredencijal(int id)
        {
            var oddel = repo.GetKredencijal(id);
            return oddel;
        }
        public List<Kredencijal> HandlerGetkredencijali()
        {
            var oddel = repo.GetKredencijali();
            return oddel;
        }
        public Kredencijal HandlerDeletekredencija(int idOdel)
        {
            var oddel = repo.DeleteKredencijal(idOdel);
            return oddel;
        }
        public Kredencijal HandlerPostkredencijal(string korisnik,string lozinka,bool aktiven)
        {
            var oddel = repo.PostKredencijal(korisnik,lozinka,aktiven);
            return oddel;
        }
        public Kredencijal HandlerPutkredencijal(int id, string Odel,string n,bool aktiven)
        {
            var oddel = repo.PutKredencijal(id, Odel,n,aktiven);
            return oddel;
        }
    }
}
