using Core.Contracts;
using Core.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Handlers
{
   public class HandlerReport
    {
        TaskRepository repo;

        public HandlerReport()
        {
            repo = new TaskRepository();
        }
        public List <Report> HandlerGetReport(int id_vraboten)
        {
            var report = repo.GetReport(id_vraboten);
            return report;
        }
    }
}
