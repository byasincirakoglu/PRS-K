using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAESTRO_İK
{
    public partial class GirişPanel : Form
    {
        public GirişPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Personel_giriş_button_Click(object sender, EventArgs e)
        {
            PersonelGirişPanel form2 = new PersonelGirişPanel();
            this.Hide();
            form2.ShowDialog();
            

        }

        private void admin_giriş_button_Click(object sender, EventArgs e)
        {
            AdminGirişPanel form2 = new AdminGirişPanel();
            this.Hide();
            form2.ShowDialog();
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
