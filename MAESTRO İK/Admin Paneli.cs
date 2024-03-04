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
    public partial class Admin_Paneli : Form
    {
        public Admin_Paneli()
        {
            
            InitializeComponent();
            Personel_Adı.Text = "Kullanıcı Adı";
            // TextBox'a Enter olayını bağla
            Personel_Adı.Enter += Personel_Adı_Enter;
            // TextBox'tan Leave olayını bağla
            Personel_Adı.Leave += Personel_Adı_Leave;
            //yukarısı kullanıcı adı textboxu için 

            Personel_Soyadı.Text = "Şifre";
            // TextBox'a Enter olayını bağla
            Personel_Soyadı.Enter += Personel_Soyadı_Enter;
            // TextBox'tan Leave olayını bağla
            Personel_Soyadı.Leave += Personel_Soyadı_Leave;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Personel_Adı_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void Personel_Adı_Enter(object sender, EventArgs e)
        {
            // TextBox'a tıklandığında, metni temizle
            if (Personel_Adı.Text == "Kullanıcı Adı")
            {
                Personel_Adı.Text = "";
            }
        }
        private void Personel_Adı_Leave(object sender, EventArgs e)
        {
            // TextBox'tan odak çıkıldığında ve içerik boşsa, varsayılan metni geri yükle
            if (string.IsNullOrWhiteSpace(Personel_Adı.Text))
            {
                Personel_Adı.Text = "Kullanıcı Adı";
            }
        }


        private void Personel_Soyadı_Enter(object sender, EventArgs e)
        {
            // TextBox'a tıklandığında, metni temizle
            if (Personel_Soyadı.Text == "Şifre")
            {
                Personel_Soyadı.Text = "";
            }
        }
        private void Personel_Soyadı_Leave(object sender, EventArgs e)
        {
            // TextBox'tan odak çıkıldığında ve içerik boşsa, varsayılan metni geri yükle
            if (string.IsNullOrWhiteSpace(Personel_Soyadı.Text))
            {
                Personel_Soyadı.Text = "Şifre";
            }
        }

        private void Admin_Paneli_Load(object sender, EventArgs e)
        {

        }
    }
}
