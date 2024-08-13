using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courrier_Ado
{
    class Connexion
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        public void Connecter()
        {
            if(con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                string mode = Properties.Settings.Default.mode;
                if (mode == "Sql")
                {
                    con.ConnectionString = @"Data Source=" + Properties.Settings.Default.server + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=false ;User Id=" + Properties.Settings.Default.userid + ";Password=" + Properties.Settings.Default.password + "";

                }
                else
                {
                    con.ConnectionString = @"Data Source=" + Properties.Settings.Default.server + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=true";

                }
                    con.Open();
            }
        }

        public void Deconnecter()
        {
            if (con.State == ConnectionState.Open )
            {
              
                con.Close();
            }
        }
    }
}
