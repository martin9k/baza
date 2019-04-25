using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using Core.DbAccess;
using Core.Contracts;

namespace Core.DataRepository
{
    public class TaskRepository
    {
        private readonly DbConnection _dbAccess;

        public TaskRepository()
        {
            _dbAccess = new DbConnection();
        }
        public Zadaca DeleteZadaca(int id_zadaca)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_zadaca", id_zadaca);
                Zadaca result =
                    conn.Query<Zadaca>("spDeleteTask", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Zadaca GetZadaca(int id_zadaca)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_zadaca", id_zadaca);
                Zadaca result =
                    conn.Query<Zadaca>("spGetTask", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
               public Zadaca PutZadaca(int id_zadaca, int id_proekt, int id_vraboten, int id_status, string datum_kreiranje, string datum_posledna_promena, string naslov,string opis,int estimacija, bool odobrena)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_vraboten", id_vraboten);
                param.Add("@id_zadaca", id_zadaca);
                param.Add("@id_proekt", id_proekt);
                param.Add("@id_status", id_status);
                param.Add("@datum_kreiranje", datum_kreiranje);
                param.Add("@datum_posledna_promena", datum_posledna_promena);
                param.Add("@naslov", naslov);
                param.Add("@opis", opis);
                param.Add("@estimacija", estimacija);
                param.Add("@odobrena", odobrena);
                Zadaca result =
                    conn.Query<Zadaca>("spUpdateTask", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Zadaca PostZadaca(int id_proekt, int id_vraboten, int id_status, string datum_kreiranje, string datum_posledna_promena, string naslov,string opis, int estimacija, bool odobrena)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_vraboten", id_vraboten);
                param.Add("@id_proekt", id_proekt);
                param.Add("@id_status", id_status);
                param.Add("@datum_kreiranje", datum_kreiranje);
                param.Add("@datum_posledna_promena", datum_posledna_promena);
                param.Add("@naslov", naslov);
                param.Add("@opis", opis);
                param.Add("@estimacija", estimacija);
                param.Add("@odobrena", odobrena);
                Zadaca result =
                    conn.Query<Zadaca>("spAddTask", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Pozicija GetPozicija(int id_pozicija)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_pozicija", id_pozicija);
                Pozicija result =
                    conn.Query<Pozicija>("spGetPozicija", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }

        public Pozicija DeletePozicija(int id_pozicija)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_pozicija", id_pozicija);
                Pozicija result =
                    conn.Query<Pozicija>("spDeletePozicija", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Pozicija PostPozicija(string pozicija)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@pozicija", pozicija);
                Pozicija result =
                    conn.Query<Pozicija>("spAddPozicija", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Pozicija PutPozicija(int id_pozicija, string pozicija)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_pozicija", id_pozicija);
                param.Add("@pozicija", pozicija);
                Pozicija result =
                    conn.Query<Pozicija>("spUpdatePozicija", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Oddel GetOddel(int id_oddel)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_oddel", id_oddel);
                Oddel result =
                    conn.Query<Oddel>("spGetOddel", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Oddel DeleteOddel(int id_oddel)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_oddel", id_oddel);
                Oddel result =
                    conn.Query<Oddel>("spDeleteOddel", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Oddel PostOddel(string oddel)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@oddel", oddel);
                Oddel result =
                    conn.Query<Oddel>("spAddOddel", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Oddel PutOddel(int id_oddel, string oddel)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_oddel", id_oddel);
                param.Add("@oddel", oddel);
                Oddel result =
                    conn.Query<Oddel>("spUpdateOddel", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Status GetStatus(int id_status)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_status", id_status);
                Status result =
                    conn.Query<Status>("spGetStatus", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Status DeleteStatus(int id_status)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_status", id_status);
                Status result =
                    conn.Query<Status>("spDeleteStatus", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Status PutStatus(int id_status, string opis)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_status", id_status);
                param.Add("@opis", opis);
                Status result =
                    conn.Query<Status>("spUpdateStatus", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Status PostStatus(string opis)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@opis", opis);
                Status result =
                    conn.Query<Status>("spAddStatus", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Proekt GetProekt(int id_proekt)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_proekt", id_proekt);
                Proekt result =
                    conn.Query<Proekt>("spGetProekt", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Proekt DeleteProekt(int id_proekt)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_proekt", id_proekt);
                Proekt result =
                    conn.Query<Proekt>("spDeleteProekt", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Proekt PutProekt(int id_proekt, string proekt_ime)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_proekt", id_proekt);
                param.Add("@proekt_ime", proekt_ime);
                Proekt result =
                    conn.Query<Proekt>("spUpdateProekt", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Proekt PostProekt(string proekt_ime)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@proekt_ime", proekt_ime);
                Proekt result =
                    conn.Query<Proekt>("spAddProekt", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Vraboten GetVraboten(int id_vraboten)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_vraboten", id_vraboten);
                Vraboten result =
                    conn.Query<Vraboten>("spGetAllVraboteni", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Vraboten DeleteVraboten(int id_vraboten)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_vraboten", id_vraboten);
                Vraboten result =
                    conn.Query<Vraboten>("spDeleteVraboteni", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Vraboten PostVraboten(int id_kredencijali, int id_oddel, int id_pozicija, string ime, string prezime, string grad, string adresa, string telefonski_br)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_kredencijali", id_kredencijali);
                param.Add("@id_pozicija", id_pozicija);
                param.Add("@id_oddel", id_oddel);
                param.Add("@ime", ime);
                param.Add("@prezime", prezime);
                param.Add("@grad", grad);
                param.Add("@adresa", adresa);
                param.Add("@telefonski_br", telefonski_br);
                Vraboten result =
                    conn.Query<Vraboten>("spAddVraboteni", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Vraboten PutVraboten(int id_vraboten, int id_kredencijali, int id_oddel, int id_pozicija, string ime, string prezime, string grad, string adresa, string telefonski_br)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_vraboten", id_vraboten);
                param.Add("@id_kredencijali", id_kredencijali);
                param.Add("@id_pozicija", id_pozicija);
                param.Add("@id_oddel", id_oddel);
                param.Add("@ime", ime);
                param.Add("@prezime", prezime);
                param.Add("@grad", grad);
                param.Add("@adresa", adresa);
                param.Add("@telefonski_br", telefonski_br);
                Vraboten result =
                    conn.Query<Vraboten>("spUpdateVraboteni", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }

            /*
                    public List<Vraboten> Read
                    {
                        get
                        {
                            using (var conn = OpenConnectionTaskManagerdb())
                            {
                                string readSp = "spGetAllVraboteni";
                                return db.Query<Vraboten>(readSp, commandType: CommandType.StoredProcedure).ToList();
                            }
                        }

                    }
                    public List<Vraboten> Add
                    {
                        get
                        {
                            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Vraboteni"].ConnectionString))
                            {
                                string addSp = "spAddVraboteni";
                                return db.Query<Vraboten>(addSp, commandType: CommandType.StoredProcedure).ToList();
                            }
                        }
                    }
                    public List<Vraboten> Update
                    {
                        get
                        {
                            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Vraboteni"].ConnectionString))
                            {
                                string updateSp = "spUpdateVraboteni";
                                return db.Query<Vraboten>(updateSp, commandType: CommandType.StoredProcedure).ToList();
                            }
                        }
                    }
                    public List<Vraboten> Delete
                    {
                        get
                        {
                            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Vraboteni"].ConnectionString))
                            {
                                string deleteSp = "spDeleteVraboteni";
                                return db.Query<Vraboten>(deleteSp, commandType: CommandType.StoredProcedure).ToList();
                            }
                        }
                    }
                    */
        }
    }
}
