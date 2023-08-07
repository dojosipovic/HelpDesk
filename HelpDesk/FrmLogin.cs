using HelpDesk.Models;
using HelpDesk.Repositores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk {
    /// <summary>
    /// Forma za prijavu u sustav
    /// </summary>
    public partial class FrmLogin : Form {
        public static Employee LoggedEmployee { get; set; }
        public static User LoggedUser { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda koja se pokreće klikom na gumb btnPrijava.
        /// Provjeravaju se unešeni podaci te se prilikom ispravno unešenih podataka
        /// otvara forma za korištenje aplikacije kao i poruke o greškama u sličaju
        /// pogrešno unesenih podataka za prijavu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "" && txtLozinka.Text == "") 
            {
                MessageBox.Show("Molimo ispunite polja", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije unešeno!", "Korisničko ime", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unešena!", "Lozinka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var enteredUsername = txtKorisnickoIme.Text;
                var enteredPassword = txtLozinka.Text;

                LoggedEmployee = EmployeeRepository.GetEmployee(enteredUsername);
                LoggedUser = UserRepository.GetUser(enteredUsername);

                if (LoggedEmployee != null && LoggedEmployee.CheckPassword(enteredPassword))
                {
                    FrmEmployee frmEmployee = new FrmEmployee();
                    frmEmployee.Text = LoggedEmployee.ToString();
                    Hide();
                    frmEmployee.ShowDialog();
                    Close();
                }
                else if (LoggedUser != null && LoggedUser.CheckPassword(enteredPassword))
                {
                    FrmUser frmUser = new FrmUser();
                    frmUser.Text = LoggedUser.ToString();
                    Hide();
                    frmUser.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Neispravno korisničko ime ili lozinka!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
