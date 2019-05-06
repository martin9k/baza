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
                    conn.Query<Zadaca>(ConfigurationManager.AppSettings["spIzbrisiZadaca"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public List<Oddel> GetOddeli()
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();

                List<Oddel> result =
                     conn.Query<Oddel>(ConfigurationManager.AppSettings["spZemiOddeli"], param, commandType: CommandType.StoredProcedure).ToList();
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
                    conn.Query<Zadaca>(ConfigurationManager.AppSettings["spZemiZadaca"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Zadaca>(ConfigurationManager.AppSettings["spIzmeniZadaca"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Zadaca>(ConfigurationManager.AppSettings["spDodadiZadaca"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Report GetReport ( int id_vraboten)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@vraboten_id", id_vraboten);
                Report result =
                    conn.Query<Report>(ConfigurationManager.AppSettings["spIzvestaj"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Filtriranje GetFiltriranje(int id_proekt,int id_vraboten,int id_status,string ime,string prezime, string naslov)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@proekt_id", id_proekt);
                param.Add("@vraboten_id", id_vraboten);
                param.Add("@status_id", id_status);
                param.Add("@naslov", naslov);
                param.Add("@ime", ime);
                param.Add("@prezime", prezime);
                Filtriranje result =
                    conn.Query<Filtriranje>(ConfigurationManager.AppSettings["spFilter"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }

        public Pozicija GetPozicija(int id_pozicija)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_pozicija",id_pozicija);
                Pozicija result =
                    conn.Query<Pozicija>(ConfigurationManager.AppSettings["spZemiPozicija"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public List<Pozicija> GetPozicii()
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();

                List<Pozicija> result =
                     conn.Query<Pozicija>(ConfigurationManager.AppSettings["spZemiPozicii"], param, commandType: CommandType.StoredProcedure).ToList();
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
                    conn.Query<Pozicija>(ConfigurationManager.AppSettings["spIzbrisiPozicija"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Pozicija>(ConfigurationManager.AppSettings["spFilter"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Pozicija>(ConfigurationManager.AppSettings["spIzmeniPozicija"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Oddel>(ConfigurationManager.AppSettings["spZemiOddel"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Oddel>(ConfigurationManager.AppSettings["spIzbrisiOddel"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Oddel>(ConfigurationManager.AppSettings["spDodadiOddel"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Oddel>(ConfigurationManager.AppSettings["spIzmeniOddel"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public List<Vraboten> GetVraboteni()
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();

                List<Vraboten> result =
                     conn.Query<Vraboten>(ConfigurationManager.AppSettings["spZemiVraboteni"], param, commandType: CommandType.StoredProcedure).ToList();
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
                    conn.Query<Vraboten>(ConfigurationManager.AppSettings["spZemiVraboten"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Vraboten>(ConfigurationManager.AppSettings["spIzbrisiVraboten"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Vraboten>(ConfigurationManager.AppSettings["spDodadiVraboten"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Vraboten>(ConfigurationManager.AppSettings["spIzmeniVraboten"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public List<Status> GetStatusi()
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();

                List<Status> result =
                     conn.Query<Status>(ConfigurationManager.AppSettings["spZemiStatusi"], param, commandType: CommandType.StoredProcedure).ToList();
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
                    conn.Query<Status>(ConfigurationManager.AppSettings["spZemiStatus"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Status>(ConfigurationManager.AppSettings["spIzbrisiStatus"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Status>(ConfigurationManager.AppSettings["spIzmeniStatus"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Status>(ConfigurationManager.AppSettings["spDodadiStatus"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Proekt>(ConfigurationManager.AppSettings["spZemiProekt"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public List<Proekt> GetProekti()
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();

                List<Proekt> result =
                     conn.Query<Proekt>(ConfigurationManager.AppSettings["spZemiProekti"], param, commandType: CommandType.StoredProcedure).ToList();
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
                    conn.Query<Proekt>(ConfigurationManager.AppSettings["spIzbrisiProekt"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Proekt>(ConfigurationManager.AppSettings["spIzmeniProekt"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
                    conn.Query<Proekt>(ConfigurationManager.AppSettings["spDodadiProekt"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public List<Kredencijal> GetKredencijali()
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();

                List<Kredencijal> result =
                     conn.Query<Kredencijal>(ConfigurationManager.AppSettings["spZemiKorisnici"], param, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public Kredencijal GetKredencijal(int id_korisnik)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_korisnik", id_korisnik);
                Kredencijal result =
                    conn.Query<Kredencijal>(ConfigurationManager.AppSettings["spZemiKorisnik"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Kredencijal DeleteKredencijal(int id_korisnik)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_korisnik", id_korisnik);
                Kredencijal result =
                    conn.Query<Kredencijal>(ConfigurationManager.AppSettings["spIzbrisiKorisnik"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Kredencijal PutKredencijal(int id_korisnici,string korisnicko_ime,string lozinka,bool aktiven)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_korisnik", id_korisnici);
                param.Add("@korisnickoIme", korisnicko_ime);
                param.Add("@lozinka", lozinka);
                param.Add("@aktiven", aktiven);
                Kredencijal result =
                    conn.Query<Kredencijal>(ConfigurationManager.AppSettings["spIzmeniKorisnik"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }
        }
        public Kredencijal PostKredencijal(string korisnicko_ime, string lozinka,bool aktiven)
        {
            using (var conn = _dbAccess.GetDbConection("TaskManagerDB"))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@korisnickoIme", korisnicko_ime);
                param.Add("@lozinka", lozinka);
                param.Add("@aktiven", aktiven);
                Kredencijal result =
                    conn.Query<Kredencijal>(ConfigurationManager.AppSettings["spDodadiKorisnik"], param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
