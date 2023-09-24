using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace esDnevnik
{
    public partial class Registar : UserControl
    {

        public Registar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login reg = new Login();
            PromeniUC.promeniUC(reg, Globalne.panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string frname, laname, user, ema, pass;
            frname = textBox1.Text;
            laname = textBox2.Text;
            user = textBox3.Text;
            ema = textBox4.Text;
            pass = textBox5.Text;
            if (string.IsNullOrEmpty(frname) || string.IsNullOrEmpty(laname) || string.IsNullOrEmpty(user) ||
                string.IsNullOrEmpty(ema) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Popunite sva polja!");
            }
            {
                String upit = "INSERT INTO Profesor ([First Name], [Last Name], Username, Email, [Password]) " +
                              $"VALUES ('{frname}', '{laname}', '{user}', '{ema}', '{pass}')";
                Baza konekcija = new Baza();
                konekcija.izvrsiUpit(upit);
                MessageBox.Show("Uspesno ste se registrovali!");
            }
        }
    }
}
