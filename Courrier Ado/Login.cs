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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
        public bool isValidate()
        {
            if (txt_user.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("merci de saisie username et le mot de passe", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidate())
                {
                    User u = new User();
                    if(u.login(txt_user.Text, txt_pass.Text))
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            catch (Exception )
            {

                SettingPage s = new SettingPage();
                s.Show();
            }
        }
    }
}
