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
        public Status HandlerDeletestatus(int idStatus)
        {
            var stat = repo.DeleteStatus(idStatus);
            return stat;
        }
        public Status HandlerPoststatus(string opis)
        {
            var status = repo.PostStatus(opis);
            return status;
        }
        public Status HandlerPutstatus(int id, string Odel)
        {
            var status = repo.PutStatus(id, Odel);
            return status;
        }
    }
}
