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
    public partial class AdminGirişPanel : Form
    {
        public AdminGirişPanel()
        {
            InitializeComponent();
            kullanıcı_adıTextbox.Text = "Kullanıcı Adı";
            // TextBox'a Enter olayını bağla
            kullanıcı_adıTextbox.Enter += kullanıcı_adıTextbox_Enter;
            // TextBox'tan Leave olayını bağla
            kullanıcı_adıTextbox.Leave += KullaniciAdiTextBox_Leave;
            //yukarısı kullanıcı adı textboxu için 

            Şifre_Textbox.Text = "Şifre";
            // TextBox'a Enter olayını bağla
            Şifre_Textbox.Enter += Şifre_Textbox_Enter;
            // TextBox'tan Leave olayını bağla
            Şifre_Textbox.Leave += Şifre_Textbox_Leave;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            Admin_Paneli form2 = new Admin_Paneli();
            this.Hide();
            form2.ShowDialog();
        }

        private void AdminGirişPanel_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            GirişPanel form2 = new GirişPanel();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void kullanıcı_adıTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void kullanıcı_adıTextbox_Enter(object sender, EventArgs e)
        {
            // TextBox'a tıklandığında, metni temizle
            if (kullanıcı_adıTextbox.Text == "Kullanıcı Adı")
            {
                kullanıcı_adıTextbox.Text = "";
            }
        }
        private void KullaniciAdiTextBox_Leave(object sender, EventArgs e)
        {
            // TextBox'tan odak çıkıldığında ve içerik boşsa, varsayılan metni geri yükle
            if (string.IsNullOrWhiteSpace(kullanıcı_adıTextbox.Text))
            {
                kullanıcı_adıTextbox.Text = "Kullanıcı Adı";
            }
        }

        private void Şifre_Textbox_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void Şifre_Textbox_Enter(object sender, EventArgs e)
        {
            // TextBox'a tıklandığında, metni temizle
            if (Şifre_Textbox.Text == "Şifre")
            {
                Şifre_Textbox.Text = "";
            }
        }
        private void Şifre_Textbox_Leave(object sender, EventArgs e)
        {
            // TextBox'tan odak çıkıldığında ve içerik boşsa, varsayılan metni geri yükle
            if (string.IsNullOrWhiteSpace(Şifre_Textbox.Text))
            {
                Şifre_Textbox.Text = "Şifre";
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
