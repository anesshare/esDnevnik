using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esDnevnik
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registar reg = new Registar();
            PromeniUC.promeniUC(reg, Globalne.panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uname, pass;
            uname = textBox1.Text;
            pass = textBox2.Text;
            if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Popunite sva polja!");
            }
            else
            {
                String upit = "SELECT * from Profesor WHERE Username = '" + uname + "' AND Password = '" + pass + "';";
                Baza konekcija = new Baza();
                konekcija.izvrsiUpit(upit);
                if (konekcija.reader.Read())
                {
                    Globalne.profesor = new Profesor();
                    Globalne.profesor.lname = konekcija.reader["Last Name"].ToString();
                    Globalne.profesor.fname = konekcija.reader["First Name"].ToString();
                    Globalne.profesor.username = konekcija.reader["Username"].ToString();
                    Menu menu = new Menu();
                    PromeniUC.promeniUC(menu, Globalne.panel1);
                }
                else
                {
                    MessageBox.Show("Niste uneli ispravne podatke");
                }
                konekcija.zatvoriKonekciju();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
