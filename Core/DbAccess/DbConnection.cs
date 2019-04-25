using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Core.DbAccess
{
   public class DbConnection:IDbConnection
    {
        public SqlConnection GetDbConection(string connectionName)
        {
            string connString = GetDbConnectionString(connectionName);
            var connection = new SqlConnection(connString);
            connection.Open();
            return connection;
        }

        private string GetDbConnectionString(string cs)
        {
            var dbConnection = ConfigurationManager.ConnectionStrings[cs].ConnectionString;
            return dbConnection;
        }

        SqlConnection con;
        string _con;
        SqlCommand _cmd;
        SqlDataAdapter _dta;
        DataTable _dt;

        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ConnectionTimeout => throw new NotImplementedException();

        public string Database => throw new NotImplementedException();

        public ConnectionState State => throw new NotImplementedException();

        public DbConnection()
        {
            _con = ConfigurationManager.ConnectionStrings["TaskManagerDB"].ConnectionString; //new SqlConnection(@"Data Source=DESKTOP-HFHC3UI\SQLEXPRESS01;Initial Catalog=task_manager;Integrated Security=True");
            //_con.Open();
        }

        public void OpenConnectionTaskManagerdb()
        {
            con = new SqlConnection(_con);
            con.Open();
            
        }
        public void SqlQuery(string queryText)
        {
            _cmd = new SqlCommand(queryText, con);
        }
        public DataTable QueryEx()
        {
            _dta = new SqlDataAdapter(_cmd);
            _dt = new DataTable();
            _dta.Fill(_dt);
            return _dt;
        }
        public void NonQuery()
        {
            _cmd.ExecuteNonQuery();
        }

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public IDbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
