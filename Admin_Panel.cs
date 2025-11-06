// Gerekli kütüphaneler
using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using FontAwesome.Sharp;
using System.Drawing;
using MetroFramework.Controls;
using System.Drawing.Text;

namespace Teknik_Servis_Otomasyonu
{
    public partial class Admin_Panel : MetroForm
    {
        // Global Kontroller
        private MetroPanel solMenuPanel; //Butonların yer alacağı panelin tanımlanması 
        private IconButton btnPersonel, btnMusteri, btnAriza, btnStok, btnRapor, btnHakkımızda, btnOturumKapat, btnCikis; // 8 ADET İKONLU BUTON TANIMLANMASI 
        //İkonlu Button özelliğini sağlayan kütüphane FontAwesome.Sharp.Material kütüphanesidir 

        // Takvim/Saat Kontrolleri
        private Timer timerSaat; 
        private MetroLabel lblSaatTarih;

        public Admin_Panel()
        {
            // HATA ÇÖZÜMÜ: MDI Container ayarı, InitializeComponent'tan ÖNCE yapılır.//
            this.IsMdiContainer = true;
            InitializeComponent();

            this.Text = "ADMİN KONTROL PANELİ";
            this.Size = new Size(1200, 720);
            this.WindowState = FormWindowState.Maximized;

            this.Load += new System.EventHandler(this.Admin_Panel_Load);
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            MenuyuOlustur(); // Sol menüyü oluştur
            SaatiVeTarihiAyarla(); // Saat ve Tarihi ekle
        }

        // --- Butonları ve Menüyü oluşturan metot ---
        private void MenuyuOlustur()
        {
            //Sol Menü Tasarımı (Siyah Şerit)
            solMenuPanel = new MetroPanel();
            solMenuPanel.Dock = DockStyle.Left;
            solMenuPanel.Width = 230;
            solMenuPanel.BackColor = Color.FromArgb(30, 30, 30); // Koyu renk
            this.Controls.Add(solMenuPanel);

            // FlowLayoutPanel (Butonları taşır ve o boşluğu engeller)
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = false;
            flowPanel.Padding = new Padding(0, 10, 0, 0);
            flowPanel.BackColor = Color.FromArgb(30, 30, 30);
            solMenuPanel.Controls.Add(flowPanel);

            //Personel Yönetim Buton Eklenmesi
            btnPersonel = new IconButton();
            btnPersonel.Text = " PERSONEL YÖNETİMİ";
            btnPersonel.IconChar = IconChar.UserGear;
            btnPersonel.Click += BtnPersonel_Click;
            flowPanel.Controls.Add(btnPersonel);
            AyarlaButon(btnPersonel);

            //Müşteri Yönetimi Butonu 
            btnMusteri = new IconButton();
            btnMusteri.Text = " MÜŞTERİ YÖNETİMİ";
            btnMusteri.IconChar = IconChar.Users;
            btnMusteri.Click += BtnMusteri_Click;
            flowPanel.Controls.Add(btnMusteri);
            AyarlaButon(btnMusteri);

            //Arıza Kayıt Butonu
            btnAriza = new IconButton();
            btnAriza.Text = " ARIZA KAYITLARI";
            btnAriza.IconChar = IconChar.Wrench;
            btnAriza.Click += BtnAriza_Click;
            flowPanel.Controls.Add(btnAriza);
            AyarlaButon(btnAriza);

            //Stok Yönetim Butonu Eklenmesi
            btnStok = new IconButton();
            btnStok.Text = " STOK YÖNETİMİ";
            btnStok.IconChar = IconChar.Boxes;
            btnStok.Click += BtnStok_Click;
            flowPanel.Controls.Add(btnStok);
            AyarlaButon(btnStok);

            //Raporlama Butonu Eklenmesi
            btnRapor = new IconButton();
            btnRapor.Text = " RAPORLAMA";
            btnRapor.IconChar = IconChar.ChartBar;
            btnRapor.Click += BtnRapor_Click;
            flowPanel.Controls.Add(btnRapor);
            AyarlaButon(btnRapor);

            // Hakkımızda Oturumu Kapat ve Sistemden Çıkış Butonlarının Görünümü
            MetroFramework.Controls.MetroPanel cikisPanel = new MetroFramework.Controls.MetroPanel();
            cikisPanel.Dock = DockStyle.Bottom;
            cikisPanel.Height = 175;
            cikisPanel.BackColor = Color.FromArgb(30, 30, 30);
            solMenuPanel.Controls.Add(cikisPanel);

            //Hakkımızda Butonu 
            btnHakkımızda = new IconButton();
            btnHakkımızda.Text = "Hakkımızda";
            btnHakkımızda.IconChar = IconChar.InfoCircle; //Bilgi İkonunun Eklenmesi
            btnHakkımızda.Click += btnHakkımızda_Click;
            btnHakkımızda.Dock = DockStyle.Bottom; //Bir alttaki butonun hemen üstüne eklendi
            cikisPanel.Controls.Add(btnHakkımızda);
            AyarlaButon(btnHakkımızda, false); 


            //Oturumu Kapat Butonu
            btnOturumKapat = new IconButton();
            btnOturumKapat.BackColor = Color.Red;
            btnOturumKapat.Text = "Oturumu Kapat";
            btnOturumKapat.IconChar = IconChar.UserClock;
            btnOturumKapat.Click += BtnOturumKapat_Click;
            btnOturumKapat.Dock = DockStyle.Bottom;
            cikisPanel.Controls.Add(btnOturumKapat);
            AyarlaButon(btnOturumKapat, false);

            //Sistemden Çıkış Butonu
            btnCikis = new IconButton();
            btnCikis.Text = " Sistemden Çıkış";
            btnCikis.IconChar = IconChar.SignOutAlt;
            btnCikis.Click += BtnCikis_Click;
            btnCikis.Dock = DockStyle.Bottom;
            btnCikis.BackColor = Color.Red;
            cikisPanel.Controls.Add(btnCikis);
            AyarlaButon(btnCikis, true);
        }

        // --- SAAT/TARİH PANELİNİ FORMUN ÜSTÜNE EKLENMESİ
        private void SaatiVeTarihiAyarla()
        {
            //Tarih Panel Tanımlanması ve TarihPanel Design Ayarlamasının Yapılması
            MetroPanel tarihPanel = new MetroPanel();
            tarihPanel.Dock = DockStyle.Top; // En üste yasla
            tarihPanel.Height = 35;
            tarihPanel.BackColor = Color.FromArgb(20, 20, 20); // Koyu arka plan
            this.Controls.Add(tarihPanel);

            //Tarih ve Saat Tanımlama ve Design
            lblSaatTarih = new MetroLabel();
            lblSaatTarih.AutoSize = true;
            lblSaatTarih.Dock = DockStyle.Right; // Saati sağa yasla
            // Hatalı UseCustomForeColor kaldırıldı
            lblSaatTarih.ForeColor = Color.White;
            lblSaatTarih.Font = new Font("Segoe UI Semibold", 11F);
            tarihPanel.Controls.Add(lblSaatTarih);

            Timer timerSaat = new Timer(); // Yerel Timer değişkeni kullanıldı
            timerSaat.Interval = 1000;
            timerSaat.Tick += timerSaat_Tick;
            timerSaat.Start();
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            // Takvim  Saat Dakika Girişi 
            lblSaatTarih.Text = $" {simdi.ToString("dd MMMM dddd")} | {simdi.ToString("HH:mm:ss")} ";
        }

        // Diğer Metotlar

        private void AyarlaButon(IconButton buton, bool isCikisButonu = false)
        {
            buton.Width = 230;
            buton.Height = 55;
            buton.FlatStyle = FlatStyle.Flat;
            buton.FlatAppearance.BorderSize = 0;
            buton.ForeColor = Color.White;
            buton.IconColor = Color.White;
            buton.IconSize = 32;
            buton.ImageAlign = ContentAlignment.MiddleLeft;
            buton.TextAlign = ContentAlignment.MiddleLeft;
            buton.TextImageRelation = TextImageRelation.ImageBeforeText;
            buton.Padding = new Padding(20, 0, 0, 0);

            buton.BackColor = isCikisButonu ? Color.FromArgb(192, 0, 0) : Color.FromArgb(30, 30, 30);

            buton.MouseEnter += MenuButton_MouseEnter;
            buton.MouseLeave += MenuButton_MouseLeave;
        }

        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            ((IconButton)sender).BackColor = Color.FromArgb(50, 50, 50);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            if (btn != btnCikis)
            {
                btn.BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personel Yönetimi Formu Açılacak");
        }

        private void BtnMusteri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri Yönetimi Formu Açılacak");
        }

        private void BtnAriza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arıza Kayıtları Formu Açılacak");
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stok Yönetimi Formu Açılacak");
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Raporlama Formu Açılacak");
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamadan Çıkış Yapılmaktadır.", "Uyarı");
            Application.Exit(); 
            
        }
        private void BtnOturumKapat_Click(object sender, EventArgs e)
        {
            // Gizlemiş olduğumuz Giriş Panelini arıyoruz
            Form girisFormu = Application.OpenForms["Giris_Panel"];

            if (girisFormu != null)
            {
                //MessageBox İle Bilgilendirme Yapılmaktadır
                MessageBox.Show("Giriş Ekranına Yönlendirileceksiniz", "Bilgi");
                // Bulduysak, onu göster
                girisFormu.Show();
                // Bu Admin Panelini kapat
                this.Close();
            }
            else
            {
                
                MessageBox.Show("Giriş ekranı bulunamadı!");
                Application.Exit();
            }
            
        }
        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje TÜ Bilgisayar Programcılığı BPR203 Sistem Analizi ve Tasarımı Dersi İçin Geliştirilen Bir Projedir \n" +
                "Proje Bir Teknik Servis Otomasyon Sistemidir \n" +
                "Teknik Servis Şirketlerinin Süreç Yönetimlerini Dijital bir Ortama Aktarmasını Amaçlamaktadır");
        }
    }
}