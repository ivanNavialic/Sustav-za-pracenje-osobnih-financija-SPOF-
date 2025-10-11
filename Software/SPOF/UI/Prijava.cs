using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOF.UI
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void PrijaviSeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PrijavaKorImeTxt.Text) || string.IsNullOrEmpty(PrijavaLozinkaTxt.Text))
            {
                MessageBox.Show("Unesi korisničko ime i lozinku");
                return;
            }

            UserDataAccess access = new UserDataAccess();
            int userId;
            bool ok = access.Login(PrijavaKorImeTxt.Text.Trim(), PrijavaLozinkaTxt.Text, out userId);

            if(!ok) { MessageBox.Show("Krivi podaci"); return; }

            GlavniMeni meni = new GlavniMeni(userId);
            meni.Show();

            this.Hide();
        }

        private void PrikaziLozinkuChB_CheckedChanged(object sender, EventArgs e)
        {
            if (PrikaziLozinkuChB.Checked)
            {
                PrijavaLozinkaTxt.UseSystemPasswordChar = false;
            }
            else {
                PrijavaLozinkaTxt.UseSystemPasswordChar = true;
            }
        }

        private void RegistrirajBtn_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();
            this.Hide();
        }

        private void ExitAppLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
