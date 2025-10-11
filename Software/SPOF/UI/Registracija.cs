using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;
using DataAccessLayer;
using System.Diagnostics.Eventing.Reader;


namespace SPOF.UI
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }
                        

        private void RegistrirajSeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegKorisnickoImeTxt.Text) || string.IsNullOrWhiteSpace(RegLozinkaTxt.Text) || string.IsNullOrWhiteSpace(RegPonoviLozinkuTxt.Text))
            {
                MessageBox.Show("Unesite sva polja");
                return;
            }

            if (RegLozinkaTxt.Text != RegPonoviLozinkuTxt.Text)
            {
                MessageBox.Show("Lozinke se ne podudaraju");
                return;
            }

            User user = new User
            {
                Username = RegKorisnickoImeTxt.Text.Trim(),
                Password = RegLozinkaTxt.Text
            };

            UserDataAccess dataAccess = new UserDataAccess();
            bool success = dataAccess.AddUser(user);

            if (success)
                MessageBox.Show("Registracija uspješna.");

            else
                MessageBox.Show("Korisničko ime već postoji ili su podaci neispravni.");

        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void PrikaziLozinkuChB_CheckedChanged(object sender, EventArgs e)
        {
            if (PrikaziLozinkuChB.Checked) {
                RegLozinkaTxt.UseSystemPasswordChar = false;
                RegPonoviLozinkuTxt.UseSystemPasswordChar = false;
            }
            else
            {
                RegLozinkaTxt.UseSystemPasswordChar = true;
                RegPonoviLozinkuTxt.UseSystemPasswordChar = true;
            }
        }

        private void PrijaviSeBtn_Click(object sender, EventArgs e)
        {
            Prijava prijava = new Prijava();
            prijava.Show();

            this.Hide();
        }

        private void ExitAppLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

