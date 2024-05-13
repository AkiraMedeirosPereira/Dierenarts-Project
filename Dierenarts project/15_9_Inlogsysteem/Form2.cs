using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _15_9_Inlogsysteem
{
    public partial class mainSysteem : Form
    {
        public mainSysteem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LeesGegevens();
            Behandeling();
        }
        public void WijzigKlantgegevens(int klantid)
        {
            string voorletters = txtVoorletters.Text;
            string achternaam = txtAchternaam.Text;
            string adres = txtAdres.Text;
            string woonplaats = txtWoonplaats.Text;

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\Dierenartsonline.accdb ";
            con.Open();

            string sql = "UPDATE klanten SET Voorletters = @Voorletters, " +
                "Achternaam = @Achternaam, Adres = @Adres, Woonplaats = @Woonplaats " +
                "WHERE Klantid = @Klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, con);
            dbcom.Parameters.AddWithValue("@Voorletters", voorletters);
            dbcom.Parameters.AddWithValue("@Achternaam", achternaam);
            dbcom.Parameters.AddWithValue("@Adres", adres);
            dbcom.Parameters.AddWithValue("@Woonplaats", woonplaats);   
            dbcom.Parameters.AddWithValue("@Klantid", klantid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            con.Close();
            MessageBox.Show("Gewijzigd");
        }
        private void LadenKlantDetails(int klantid)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\Dierenartsonline.accdb ";
            con.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT * FROM klanten WHERE klantid = @klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, con);
            OleDbParameter param1 = new OleDbParameter();
            param1.ParameterName = "@klantid";
            param1.Value = klantid;
            dbcom.Parameters.Add(param1);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                txtVoorletters.Text = dbread.GetValue(1).ToString();
                txtAchternaam.Text = dbread.GetValue(2).ToString();
                txtAdres.Text = dbread.GetValue(3).ToString();
                txtWoonplaats.Text = dbread.GetValue(4).ToString();
            }
            dbread.Close();
            dbcom.Dispose();
            con.Close();
        }
        public void Behandeling()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\Dierenartsonline.accdb ";
            con.Open();
            string sql = "SELECT SUM(aantal) FROM behandelregel";
            OleDbCommand dbcom = new OleDbCommand(sql, con);
            txtBehandeling.Text = dbcom.ExecuteScalar().ToString();
            dbcom.Dispose();
            con.Close();
        }
        public void LeesGegevens()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbDataReader dbread = null;
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\Dierenartsonline.accdb ";
            con.Open();
            string sql = "SELECT * FROM klanten";
            OleDbCommand dbcom = new OleDbCommand(sql, con);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                lbxOverzicht.Items.Add(dbread.GetValue(0).ToString() + " "
                    + dbread.GetValue(1).ToString() + " " +
                    dbread.GetValue(2).ToString() + " " +
                    dbread.GetValue(3).ToString());
            }
            dbread.Close();
            dbcom.Dispose();
            con.Close();
        }

        private void btnwijzig_Click(object sender, EventArgs e)
        {
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int klantid = int.Parse(woordenArray[0]);
            WijzigKlantgegevens(klantid);
        }

        private void btnNieuweKlant_Click(object sender, EventArgs e)
        {
            string voorletters = txtVoorletters.Text;
            string achternaam = txtAchternaam.Text + ",";
            string adres = txtAdres.Text;
            string woonplaats = txtWoonplaats.Text;

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\Dierenartsonline.accdb ";
            con.Open();
            string sql = "INSERT INTO klanten (Voorletters, Achternaam, Adres, Woonplaats) VALUES (@Voorletters, @Achternaam, @Adres, @Woonplaats)";
            OleDbCommand dbcom = new OleDbCommand(sql, con);
            dbcom.Parameters.AddWithValue("@Voorletters", voorletters);
            dbcom.Parameters.AddWithValue("@Achternaam", achternaam);
            dbcom.Parameters.AddWithValue("@Adres", adres);
            dbcom.Parameters.AddWithValue("@Woonplaats", woonplaats);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            con.Close();
            MessageBox.Show("toegevoegd");
        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int klantid = int.Parse(woordenArray[0]);
            LadenKlantDetails(klantid);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int klantenid = int.Parse(woordenArray[0]);
            Verwijderklant(klantenid);
        }

        private void Verwijderklant(int klantenid)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\Dierenartsonline.accdb ";
            con.Open();
            string sql = "DELETE FROM klanten WHERE [Klantid] = @Klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, con);
            dbcom.Parameters.AddWithValue("@Klantid", klantenid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            con.Close();
            MessageBox.Show("Verwijderd");
        }
    }
}
