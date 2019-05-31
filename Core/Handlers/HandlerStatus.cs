using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Handlers
{
 public   class HandlerStatus
    {
        TaskRepository repo;

        public HandlerStatus()
        {
            repo = new TaskRepository();
        }
        public Status HandlerGetstatus(int idStatus)
        {
            var stat = repo.GetStatus(idStatus);
            return stat;
        }
        public List<Status> HandlerGetstatusi()
        {
            var stat = repo.GetStatusi();
            return stat;
        }
        public Status HandlerDeletestatus(int idStatus)
        {
            var odd = repo.GetStatus(idStatus);
            if (odd == null) throw new ArgumentException();
            var oddel = repo.DeleteStatus(idStatus);
            return oddel;
        }
        public Status HandlerPoststatus(string opis)
        {
            var status = repo.PostStatus(opis);
            return status;
        }
        public Status HandlerPutstatus(int id, string Odel)
        {
            var odd = repo.GetStatus(id);
            if (odd == null) throw new ArgumentException();
            var oddel = repo.DeleteStatus(id);
            return oddel;
        }
    }
}
