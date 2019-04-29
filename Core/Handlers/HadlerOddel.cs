using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Handlers
{
    public class HadlerOddel
    {
        TaskRepository repo;

        public HadlerOddel()
        {
            repo = new TaskRepository();     
        }
        public Oddel HandlerGetoddel(int id)
        {
            var oddel = repo.GetOddel(id);
            return oddel;
        }
        public Oddel HandlerDeleteoddel(int idOdel)
        {
            var oddel = repo.DeleteOddel(idOdel);
            return oddel;
        }
        public Oddel HandlerPostoddel(string Odel)
        {
            var oddel = repo.PostOddel(Odel);
            return oddel;
        }
        public Oddel HandlerPutoddel(int id,string Odel)
        {
            var oddel = repo.PutOddel(id,Odel);
            return oddel;
        }
    }
}
