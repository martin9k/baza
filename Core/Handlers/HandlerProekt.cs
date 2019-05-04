using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Handlers
{
 public class HandlerProekt
    {
        TaskRepository repo;

        public HandlerProekt()
        {
            repo = new TaskRepository();
        }
        public Proekt HandlerGetproekt(int id_proekt)
            {
            var proekt = repo.GetProekt(id_proekt);
            return proekt;
            }
        public List<Proekt> HandlerGetproekti()
        {
            var stat = repo.GetProekti();
            return stat;
        }
        public Proekt HandlerDeleteproekt(int idStatus)
        {
            var stat = repo.DeleteProekt(idStatus);
            return stat;
        }
        public Proekt HandlerPostproekt(string proekt_ime)
        {
            var status = repo.PostProekt(proekt_ime);
            return status;
        }
        public Proekt HandlerPutproekt(int id, string proekt_ime)
        {
            var status = repo.PutProekt(id, proekt_ime);
            return status;
        }
    }
}
