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
        public Zadaca HandlerDeletezadaca(int idTask)
        {
            var stat = repo.DeleteZadaca(idTask);
            return stat;
        }
        public Zadaca HandlerPostzadaca(int idproekt,int idvrab,int idstaus,string datumk,string datump,string naslov,string opis,int est,bool odob)
        {
            var stat = repo.PostZadaca(idproekt,idvrab,idstaus,datumk,datump,naslov,opis,est,odob);
            return stat;
        }
        public Zadaca HandlerPutzadaca(int idzad,int idproekt, int idvrab, int idstaus, string datumk, string datump, string naslov,string opis, int est, bool odob)
        {
            var stat = repo.PutZadaca(idzad,idproekt, idvrab, idstaus, datumk, datump, naslov,opis,est, odob);
            return stat;
        }
    }
}
