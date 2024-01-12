using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Gestion_de_Banque
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Database=banque;Data Source=localhost;User Id='root';Password=''");
            con.Open();
            dataGridView1.Rows.Clear();
            MySqlCommand cmd = new MySqlCommand("select * from versement", con);
            MySqlDataReader aff = cmd.ExecuteReader();
            while (aff.Read())
            {
                dataGridView1.Rows.Add(
                    aff.GetValue(0),aff.GetValue(2), aff.GetValue(5)
                );
            }
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consulter_Click(object sender, EventArgs e)
        {
            
                MySqlConnection con = new MySqlConnection("Database=banque;Data Source=localhost;User Id='root';Password=''");
                con.Open();
                dataGridView2.Rows.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from retrait", con);
                MySqlDataReader aff = cmd.ExecuteReader();
                while (aff.Read())
                {
                    dataGridView2.Rows.Add(
                        aff.GetValue(0), aff.GetValue(1), aff.GetValue(4)
                    );
                }
                con.Close();
            
        }

        private void Historiquedesretraits_Click(object sender, EventArgs e)
        {

        }
    }
}
