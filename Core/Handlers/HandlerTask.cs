using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Handlers
{
  public  class HandlerTask
    {
        TaskRepository repo;

        public HandlerTask()
        {
            repo = new TaskRepository();
        }
        public Zadaca HandlerGetzadaca(int idTask)
        {
            var stat = repo.GetZadaca(idTask);
            return stat;
        }
        public List<Zadaca> HandlerGetzadaci()
        {
            var stat = repo.GetZadaci();
            return stat;
        }
        public Zadaca HandlerDeletezadaca(int idTask)
        {
            var stat = repo.DeleteZadaca(idTask);
            return stat;
        }
        public Zadaca HandlerPostzadaca(int idproekt, int idvrab, string naslov, string opis, int est, bool odo = false, int idstatus = 1)
        {
            var stat = repo.PostZadaca(idproekt,idvrab,naslov,opis,est,odo,idstatus);
            return stat;
        }
        public Zadaca HandlerPutzadaca(int idzad,int idproekt, int idvrab, int idstaus,string naslov,string opis, int est, bool odob)
        {
            var stat = repo.PutZadaca(idzad,idproekt, idvrab, idstaus,naslov,opis,est, odob);
            return stat;
        }
       public Zadaca OdobriZadaca (int idvrab,int idzad)
        {
            var stat = repo.OdobriZadaca(idvrab, idzad);
            if (stat !=null)
            {
                return stat;
            }
        }

        public Zadaca HandlerUpdateStatus(int idzad, int idstaus)
        {
            var stat = repo.UpdateStatus(idzad,idstaus);
            return stat;
        }
    }
}
