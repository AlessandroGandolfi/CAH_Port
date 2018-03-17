using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOSQLServer2016_c
{
    class ADOSQLServer2016
    {
        private SqlConnection cn;
        private String _erroreSQL;
        public string erroreSQL
        { 
            get
            {
                return _erroreSQL;
            }
        }

        public ADOSQLServer2016(string dbName)
        {
            impostaConnessione(dbName);
        }
        private void impostaConnessione(string dbName)
        {
            string cnString;
            string errore = "";//"" OK altrimenti il msg di errore
            try
            {
                cnString = @"Server=(localdb)\MSSQLLocalDB;attachdbfilename= " + Application.StartupPath + "\\" + dbName + @";Integrated Security=True";
                cn = new SqlConnection();
                cn.ConnectionString = cnString;
                cn.Open();
            }
            catch(Exception ex)
            {
                errore = ex.Message;
            }
            this._erroreSQL = errore;
        }
        public DataTable EseguiQuery(SqlCommand cmd)
        {
            string errore = "";
            SqlDataAdapter adp;
            DataTable dt = new DataTable();
            cmd.Connection = cn;
            adp = new SqlDataAdapter(cmd);
            try
            {
                adp.Fill(dt);
            }   
            catch(Exception ex)
            {
                errore = ex.Message;
            }
            this._erroreSQL = errore;
            return dt;
        }
        public DataTable EseguiQueryDGV(DataGridView dgt, SqlCommand cmd)
        {
            string errore = "";
            SqlDataAdapter adp;
            DataTable dt = new DataTable();
            cmd.Connection = cn;
            adp = new SqlDataAdapter(cmd);
            try
            {
                adp.Fill(dt);
                dgt.DataSource = dt;
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            this._erroreSQL = errore;
            return dt;
        }
        public object eseguiScalar(SqlCommand cmd)
        {
            object ris = null;
            String errore = "";
            cmd.Connection = cn;
            try
            {
                ris = cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                errore = ex.Message;
            }
            this._erroreSQL = errore;
            return ris;
        }
        public int eseguiNonQuery(SqlCommand cmd)
        {
            int ris = -1;
            String errore = "";
            cmd.Connection = cn;
            try
            {
                ris = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            this._erroreSQL = errore;
            return ris;
        }

    }
}
