using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography; //SQL SORGULARI İÇİN GEREKLİ OLAN KÜTÜPHANENİN EKLENMESİ, Bu kütüphane olmaadan sql kısmını ekleyemeyiz



namespace Teknik_Servis_Otomasyonu
{
    public partial class Giris_Panel : MetroForm // YENİ HALİ (MetroForm'dan miras alıyoruz)
    {
        public Giris_Panel()
        {
            InitializeComponent();
        }
        private void Giris_Panel_Load(object sender, EventArgs e)
        {

        }
        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=ATA-MONSTER\\SQLEXPRESS01;Initial Catalog=Teknik_Servis_Otomasyon_Sistemi;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        private void metroButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Personel where Personel_ID=@p0 and Kullanici_Ad=@p1 and Sifre=@p2 and Rol=@p3",baglanti);
            komut.Parameters.AddWithValue("@p0", Txt_ID.Text);
            komut.Parameters.AddWithValue("@p1", TXT_Kullanıcı_Ad.Text);
            komut.Parameters.AddWithValue("@p2", TXT_Sifre.Text);
            komut.Parameters.AddWithValue("@p3", LBL_Kontrol.Text);
            SqlDataReader dr = komut.ExecuteReader(); //Database üzerin den "VERİ OKUMA" İşlemi yapıldığın dan ExecuteReader kullanılır.
            //dr.Read();
            if (dr.Read())
            {
              if(LBL_Kontrol.Text =="Admin")
                {
                    Admin_Panel frm_Admin = new Admin_Panel();
                    frm_Admin.Show();
                    this.Hide();
                }
              else if(LBL_Kontrol.Text =="Personel")
                {
                    Personel_Panel frm_Personel = new Personel_Panel();
                    frm_Personel.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Giriş bilgileri hatalı veya bu kullanıcı türü ile eşleşmiyor.", "Uyarı");

            }
            baglanti.Close();
        }


        private void BTN_Sifre_Sıfırlama_Click(object sender, EventArgs e)
        {

        }

        private void RDR_Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (RDR_Admin.Checked)
            {
                LBL_Kontrol.Text = "Admin";
            }
        }

        private void RDR_Personel_CheckedChanged(object sender, EventArgs e)
        {
            if (RDR_Personel.Checked)
            {
                LBL_Kontrol.Text = "Personel";
            }
        }

    }
}
