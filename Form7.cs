using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace Projet_Gestion_de_Banque
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Database=reg;Data Source=localhost;User Id='root';Password=''");
            con.Open();
            try
            {
                string id = textBox6.Text;
                string nom = textBox5.Text;
                string prenom = textBox3.Text;
                string dn = textBox2.Text;
                string Ln = textBox1.Text;

                string str2 = "UPDATE etudiant SET nom = @nom, prenom = @prenom, date_naissance = @dn, Lieu_naissance = @Ln WHERE Matricule = @id";

                MySqlCommand cmd2 = new MySqlCommand(str2, con);
                cmd2.Parameters.AddWithValue("@nom", nom);
                cmd2.Parameters.AddWithValue("@prenom", prenom);
                cmd2.Parameters.AddWithValue("@dn", dn);
                cmd2.Parameters.AddWithValue("@Ln", Ln);
                cmd2.Parameters.AddWithValue("@id", id);

                int dr1 = cmd2.ExecuteNonQuery();

                if (dr1 != 0)
                {
                    MessageBox.Show("Etudiant a été modifié");
                    this.Hide();
                }
                this.Close();
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
