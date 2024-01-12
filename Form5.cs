using MySql.Data.MySqlClient;
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

namespace Projet_Gestion_de_Banque
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";


            MySqlConnection con = new MySqlConnection("Database=banque;Data Source=localhost;User Id='root';Password=''");
            con.Open();
            try
            {
               string str = "INSERT INTO versement( nom,date, montant, motif, idCompte) VALUES('" + textBox5.Text + "','" + time.ToString(format) + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox6.Text + "');";


                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string a = textBox6.Text;
                string str1 = "select nom from versement ;";
                string solde2 = "SELECT solde from compte WHERE (idCompte=$a)";
                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Versement effectué avec success..");
                    this.Hide();

                }


                
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
    
}
