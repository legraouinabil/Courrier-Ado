using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courrier_Ado
{
    public partial class SettingPage : Form
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            txt_servername.Text = Properties.Settings.Default.server;
            txt_dbname.Text = Properties.Settings.Default.database;
            string mode = Properties.Settings.Default.mode;
            if (mode == "Windows")
            {
                rdWA.Checked = true;

                txt_userid.Clear();
                txt_pwd.Clear();
                txt_userid.ReadOnly = true;
                txt_pwd.ReadOnly = true;
            }
            else
            {
                rdSA.Checked = true;
                txt_userid.Text = Properties.Settings.Default.userid;
                txt_pwd.Text = Properties.Settings.Default.password;
            }
        }

       

        private void rdSA_CheckedChanged(object sender, EventArgs e)
        {
            txt_userid.ReadOnly = false;
            txt_pwd.ReadOnly = false;
        }

        private void rdWA_CheckedChanged(object sender, EventArgs e)
        {
            txt_userid.Clear();
            txt_pwd.Clear();
            txt_userid.ReadOnly = true;
            txt_pwd.ReadOnly = true;
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            var server = txt_servername.Text;
            var dbname = txt_dbname.Text;

            var user = txt_userid.Text;
            var password = txt_pwd.Text;

            if (rdWA.Checked == true)
            {
                Properties.Settings.Default.mode = "Windows";
                Properties.Settings.Default.server = server;
                Properties.Settings.Default.database = dbname;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.mode = "Sql";
                Properties.Settings.Default.server = server;
                Properties.Settings.Default.database = dbname;
                Properties.Settings.Default.userid = user;
                Properties.Settings.Default.password = password;
                Properties.Settings.Default.Save();
            }
            Application.Restart();
        }
    }
}
