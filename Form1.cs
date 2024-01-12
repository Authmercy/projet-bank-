using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Projet_Gestion_de_Banque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Database=reg;Data Source=localhost;User Id='root'; Password=''");
            con.Open();
            string str = "SELECT username FROM user WHERE password = @pwd";
            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.Parameters.AddWithValue("@pwd", textBox2.Text);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                this.Hide();
                Form9 obj2 = new Form9();
                obj2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur invalide");
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
