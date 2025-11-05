// Gerekli kütüphaneleri ekliyoruz
using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using FontAwesome.Sharp;
using System.Drawing;
using MetroFramework.Controls;

namespace Teknik_Servis_Otomasyonu
{
    public partial class Admin_Panel : MetroForm
    {
        /*
        nitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Text = "Admin Paneli";
        */
        // Global Kontroller
        private MetroPanel solMenuPanel;
        private IconButton btnPersonel, btnMusteri, btnAriza, btnStok, btnRapor, btnCikis;

        // Takvim/Saat Kontrolleri
        private Timer timerSaat;
        private MetroLabel lblSaatTarih;

        public Admin_Panel()
        {
            // HATA ÇÖZÜMÜ: MDI Container ayarı, InitializeComponent'tan ÖNCE yapılır.
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
            // Dashboard formu kaldırıldığı için burası boş kalacak.
        }

        // --- Butonları ve Menüyü oluşturan metot ---
        private void MenuyuOlustur()
        {
            solMenuPanel = new MetroPanel();
            solMenuPanel.Dock = DockStyle.Left;
            solMenuPanel.Width = 240;
            solMenuPanel.BackColor = Color.FromArgb(30, 30, 30); // Koyu renk
            this.Controls.Add(solMenuPanel);

            // FlowLayoutPanel (Menü butonlarını tutar) (Form da bulunan Dikey Sol Şerit)
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = false;
            flowPanel.Padding = new Padding(0, 10, 0, 0);
            flowPanel.BackColor = Color.Black;
            solMenuPanel.Controls.Add(flowPanel);

            /*
            //Label Oluşturma
            lblFormAd = new MetroLabel();
            lblFormAd.AutoSize = true;

            */
            // --- BUTON EKLEME SIRALAMASI ---

            //Personel Yönetim Butonu
            btnPersonel = new IconButton();
            btnPersonel.Text = " PERSONEL YÖNETİMİ";
            btnPersonel.IconChar = IconChar.UserGear;
            btnPersonel.Click += BtnPersonel_Click;
            flowPanel.Controls.Add(btnPersonel);
            AyarlaButon(btnPersonel);

            //Müşteri Yönetim Butonu
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

            //Stok Yönetim Butonu
            btnStok = new IconButton();
            btnStok.Text = " STOK YÖNETİMİ";
            btnStok.IconChar = IconChar.Boxes;
            btnStok.Click += BtnStok_Click;
            flowPanel.Controls.Add(btnStok);
            AyarlaButon(btnStok);

            //Raporlama Butonu
            btnRapor = new IconButton();
            btnRapor.Text = " RAPORLAMA";
            btnRapor.IconChar = IconChar.ChartBar;
            btnRapor.Click += BtnRapor_Click;
            flowPanel.Controls.Add(btnRapor);
            AyarlaButon(btnRapor);

            // Çıkış Butonunun yerleşimi
            MetroFramework.Controls.MetroPanel cikisPanel = new MetroFramework.Controls.MetroPanel();
            cikisPanel.Dock = DockStyle.Bottom;
            cikisPanel.Height = 60;
            cikisPanel.BackColor = Color.Red;
            solMenuPanel.Controls.Add(cikisPanel);

            btnCikis = new IconButton();
            btnCikis.Text = " Sistemden Çıkış";
            btnCikis.IconChar = IconChar.SignOutAlt;
            btnCikis.Click += BtnCikis_Click;
            btnCikis.Dock = DockStyle.Bottom;
            cikisPanel.Controls.Add(btnCikis);
            AyarlaButon(btnCikis, true);
        }

        // --- SAAT/TARİH PANELİNİ ÜST KISMA EKLEME METODU ---
        private void SaatiVeTarihiAyarla()
        {
            // Panel oluştur
            MetroPanel tarihPanel = new MetroPanel();
            tarihPanel.Dock = DockStyle.Top; // En üste yasla
            tarihPanel.Height = 35;
            tarihPanel.BackColor = Color.FromArgb(20, 20, 20); // Koyu arka plan
            this.Controls.Add(tarihPanel);

            // Label oluştur
            lblSaatTarih = new MetroLabel();
            lblSaatTarih.AutoSize = true;
            lblSaatTarih.Dock = DockStyle.Right; // Saati sağa yasla
            // Kullanım hatası veren UseCustomForeColor SİLİNDİ
            lblSaatTarih.ForeColor = Color.White;
            lblSaatTarih.Font = new Font("Segoe UI Semibold", 11F);
            tarihPanel.Controls.Add(lblSaatTarih);

            // Timer oluştur
            timerSaat = new Timer();
            timerSaat.Interval = 1000;
            timerSaat.Tick += timerSaat_Tick;
            timerSaat.Start();
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            lblSaatTarih.Text = $" {simdi.ToString("dd MMMM dddd")} | {simdi.ToString("HH:mm:ss")} ";
        }

        // --- Diğer metotlar (AyarlaButon, Mouse Eventleri, Click Olayları) aynı kalır ---

        private void AyarlaButon(IconButton buton, bool isCikisButonu = false)
        {
            // (Ortak ayarların kodu buraya gelir)
            buton.Width = 260;
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

            // Çıkış butonu kırmızı, diğerleri normal
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
            Application.Exit();
        }
    }
}