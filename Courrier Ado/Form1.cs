using Courrier_Ado.Layout;
using Courrier_Ado.Models;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void addToPannel(Control c)
        {

            mainPanel.Controls.Clear();
            c.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(c);

        }
        Connexion cn = new Connexion();
        private void Form1_Load(object sender, EventArgs e)
        {

            Home uc = new Home();
            addToPannel(uc);
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home uc = new Home();
            addToPannel(uc);
        }

        private void btn_dashbord_Click(object sender, EventArgs e)
        {
            ListCourrierArriver uc = new ListCourrierArriver();
            addToPannel(uc);
        }

        private void btn_depart_Click(object sender, EventArgs e)
        {
            ListCourrierDepart uc = new ListCourrierDepart();
            addToPannel(uc);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_swivi_Click(object sender, EventArgs e)
        {
            Swivi uc = new Swivi();
            addToPannel(uc);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            ListUsers uc = new ListUsers();
            addToPannel(uc);
        }

        private void btn_conf_Click(object sender, EventArgs e)
        {
            Setting uc = new Setting();
            addToPannel(uc);
        }
    }
}
