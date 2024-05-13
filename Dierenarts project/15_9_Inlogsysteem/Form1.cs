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
    public partial class inlogSysteem : Form
    {
        public inlogSysteem()
        {
            InitializeComponent();
        }

        private void btnInlog_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;data source = ..\\..\\..\\Dierenartsonline.accdb ";
            con.Open();
            OleDbDataReader dbread = null;

            string sql = "SELECT * FROM medewerker WHERE gebruikerid = " +
                "@gebruikerid AND wachtwoord = @wachtwoord";
            OleDbCommand dbcom = new OleDbCommand(sql, con);

            OleDbParameter param1 = new OleDbParameter();
            param1.ParameterName = "@gebruikerid";
            param1.Value = txtGebruikersnaam.Text;

            OleDbParameter param2 = new OleDbParameter();
            param2.ParameterName = "@wachtwoord";
            param2.Value = txtWachtwoord.Text;

            dbcom.Parameters.Add(param1);
            dbcom.Parameters.Add(param2);

            dbread = dbcom.ExecuteReader();
            
            if (dbread.HasRows)
            {
                MessageBox.Show("ingelogd");
                mainSysteem frm = new mainSysteem();
                frm.Show();
            }
            else
            {
                MessageBox.Show("niet ingelogd");
            }
         
        }

        private void txtGebruikersnaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void inloggen_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void txtWachtwoord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
