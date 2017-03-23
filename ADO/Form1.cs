using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//braucht mann

namespace ADO
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;

        public Form1()
        {

            InitializeComponent();
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            OleDbConnectionStringBuilder bldr = new OleDbConnectionStringBuilder();
            bldr.Provider = "Microsoft.ACE.OLEDB.12.0";
            bldr.DataSource = "Bestellung.accdb";
            con = new OleDbConnection(bldr.ConnectionString);
            try
            {
                buttonCommand.Visible = true;
                con.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tArtikel";
            cmd.CommandType = CommandType.Text;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            while (reader.Read())//true
            {
                String zeile = reader["ArtikelOID"].ToString() + ": " + reader["Bezeichnung"];
                listBoxAusgabe.Items.Add(zeile)
            }
        }
    }
}
