using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Gestion_de_Banque
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj1 = new Form3();
            obj1.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 obj1 = new Form8();
            obj1.ShowDialog();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 obj2 = new Form6();
            obj2.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form9 obj2 = new Form9();
            obj2.ShowDialog();
            this.Hide();
        }
    }
}
