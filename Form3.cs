using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet_Gestion_de_Banque
{
    public partial class Form3 : Form
    {
 
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
          
                MySqlConnection con = new MySqlConnection("Database=banque;Data Source=localhost;User Id='root'; Password=''");

                con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into client(nom,email,dateNaissance,telephone,adresse,solde) VALUES (@nom, @pnom, @date, @tel, @add, @solde)", con);

                cmd.Parameters.AddWithValue("@nom", textBox1.Text);
                cmd.Parameters.AddWithValue("@pnom", textBox2.Text);
                cmd.Parameters.AddWithValue("@date", textBox3.Text);
                cmd.Parameters.AddWithValue("@solde", textBox7.Text);

                cmd.Parameters.AddWithValue("@tel", textBox4.Text);
                cmd.Parameters.AddWithValue("@add", textBox5.Text);
                ;
                cmd.Parameters.AddWithValue("@id", textBox6.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Compte Crée avec success.. ");
                        this.Hide();

                    
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
