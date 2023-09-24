using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace esDnevnik
{
    public class Baza
    {
        public String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=esDnevnikDB.accdb;
                Persist Security Info=False;";
        public OleDbConnection konekcija;
        public OleDbCommand komanda;
        public OleDbDataReader reader;

        public void izvrsiUpit(String upit)
        {
            try
            {
                konekcija = new OleDbConnection(connectionString);
                konekcija.Open();
                komanda = new OleDbCommand();
                komanda.CommandText = upit;
                

                komanda.Connection = konekcija;
                reader = komanda.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upozorenje", "Konekcija nije ostvarena");
            }
        }

        public void zatvoriKonekciju()
        {
            if (reader != null && !reader.IsClosed)
            {
                reader.Close();
            }

            if (komanda != null)
            {
                komanda.Dispose();
            }

            if (konekcija != null && konekcija.State != ConnectionState.Closed)
            {
                konekcija.Close();
            }
        }
    }
}
