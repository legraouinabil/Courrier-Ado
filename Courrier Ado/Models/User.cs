using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courrier_Ado.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string motpass { get; set; }
        public string name { get; set; }
        public string prenom { get; set; }
        public string typeuser { get; set; }
        public string phone { get; set; }

        Connexion cn = new Connexion();
        public bool login(string username , string password)
        {
            bool user = false;
            cn.Connecter();
            cn.cmd.CommandText = "select username , motpass from users ";
            cn.cmd.Connection = cn.con;
            cn.dr = cn.cmd.ExecuteReader();
            while (cn.dr.Read())
            {
                if(cn.dr[0].ToString()== username && cn.dr[1].ToString() == password)
                {
                    user = true;
                    break;
                }
                else
                {
                    user = false;
                }
            }
            if (user)
                return true;
            else
                return false;
        }
    }
}
