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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int startp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 1;
            progressBar1.Value = startp;
            if (progressBar1.Value == 50)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Form1 Obj = new Form1();
                Obj.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
