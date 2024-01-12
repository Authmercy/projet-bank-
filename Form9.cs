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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet_Gestion_de_Banque
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void consulter_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Database=reg;Data Source=localhost;User Id='root';Password=''");
            con.Open();
            string a = textBox1.Text;
            MySqlCommand cmd = new MySqlCommand(" DELETE FROM etudiant WHERE Matricule= @a", con);

            cmd.Parameters.AddWithValue("@a", a);

            int dr = cmd.ExecuteNonQuery();

            if (dr != 0)
            {
                MessageBox.Show("Supprimer avec succes");
                this.Hide();








                con.Close();
            }
        }
    }
}
