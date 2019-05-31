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
            var stat = repo.GetZadaca(idTask);
            if(stat==null)throw new ArgumentException();
            var statu = repo.DeleteZadaca(idTask);
            return statu;
        }
        public Zadaca HandlerPostzadaca(int idproekt, int idvrab, string naslov, string opis, int est, bool odo = false, int idstatus = 1)
        {
            var statu = repo.PostZadaca(idproekt,idvrab,naslov,opis,est,odo,idstatus);
            return statu;
        }
        public Zadaca HandlerPutzadaca(int idzad,int idproekt, int idvrab, int idstaus,string naslov,string opis, int est, bool odob)
        {
            var stat = repo.GetZadaca(idzad);
            if (stat == null) throw new ArgumentException();
            var statu = repo.PutZadaca(idzad,idproekt, idvrab, idstaus,naslov,opis,est, odob);
            return statu;
        }
       public Zadaca OdobriZadaca (int idzad,int idvrab)
        {
            var stat = repo.GetZadaca(idzad);
            if (stat == null) throw new ArgumentException();
            var statu = repo.OdobriZadaca(idzad, idvrab);
            return statu;
        }

        public Zadaca HandlerUpdateStatus(int idzad, int idstaus)
        {
            var stat = repo.GetZadaca(idzad);
            if (stat == null) throw new ArgumentException();
            var statu = repo.UpdateStatus(idzad,idstaus);
            return statu;
        }
    }
}
