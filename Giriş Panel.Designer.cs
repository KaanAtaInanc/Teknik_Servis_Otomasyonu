namespace Teknik_Servis_Otomasyonu

{
    partial class Giris_Panel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_Panel));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Txt_ID = new MetroFramework.Controls.MetroTextBox();
            this.TXT_Kullanıcı_Ad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TXT_Sifre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.RDR_Admin = new MetroFramework.Controls.MetroRadioButton();
            this.RDR_Personel = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BTN_Sifre_Sıfırlama = new MetroFramework.Controls.MetroButton();
            this.LBL_Kontrol = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(1584, 341);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(1686, 245);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Teknik Servis Otomasyon Sistemi ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseMnemonic = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(196, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(210, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Teknik Servis Otomasyon";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.UseWaitCursor = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(242, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Sistemi Girişi";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.UseWaitCursor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(146, 192);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Personel ID:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            this.metroLabel4.UseWaitCursor = true;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(271, 192);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(142, 23);
            this.Txt_ID.TabIndex = 4;
            // 
            // TXT_Kullanıcı_Ad
            // 
            this.TXT_Kullanıcı_Ad.Location = new System.Drawing.Point(271, 256);
            this.TXT_Kullanıcı_Ad.Name = "TXT_Kullanıcı_Ad";
            this.TXT_Kullanıcı_Ad.Size = new System.Drawing.Size(142, 23);
            this.TXT_Kullanıcı_Ad.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(146, 254);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(111, 25);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Kullanıcı Adı:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.UseWaitCursor = true;
            // 
            // TXT_Sifre
            // 
            this.TXT_Sifre.Location = new System.Drawing.Point(271, 324);
            this.TXT_Sifre.Name = "TXT_Sifre";
            this.TXT_Sifre.PasswordChar = '●';
            this.TXT_Sifre.Size = new System.Drawing.Size(142, 23);
            this.TXT_Sifre.TabIndex = 7;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(146, 324);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(119, 25);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Kullanıcı Şifre:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = true;
            this.metroLabel6.UseWaitCursor = true;
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.Black;
            this.metroLabel7.Location = new System.Drawing.Point(146, 394);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(109, 25);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Kullanıcı Rol:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseStyleColors = true;
            this.metroLabel7.UseWaitCursor = true;
            // 
            // RDR_Admin
            // 
            this.RDR_Admin.AutoSize = true;
            this.RDR_Admin.Location = new System.Drawing.Point(271, 402);
            this.RDR_Admin.Name = "RDR_Admin";
            this.RDR_Admin.Size = new System.Drawing.Size(61, 17);
            this.RDR_Admin.TabIndex = 13;
            this.RDR_Admin.TabStop = true;
            this.RDR_Admin.Text = "Admin";
            this.RDR_Admin.UseVisualStyleBackColor = true;
            this.RDR_Admin.CheckedChanged += new System.EventHandler(this.RDR_Admin_CheckedChanged);
            // 
            // RDR_Personel
            // 
            this.RDR_Personel.AutoSize = true;
            this.RDR_Personel.Location = new System.Drawing.Point(339, 402);
            this.RDR_Personel.Name = "RDR_Personel";
            this.RDR_Personel.Size = new System.Drawing.Size(74, 17);
            this.RDR_Personel.TabIndex = 14;
            this.RDR_Personel.TabStop = true;
            this.RDR_Personel.Text = "Personel";
            this.RDR_Personel.UseVisualStyleBackColor = true;
            this.RDR_Personel.CheckedChanged += new System.EventHandler(this.RDR_Personel_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(275, 436);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(138, 79);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Giriş Yap";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BTN_Sifre_Sıfırlama
            // 
            this.BTN_Sifre_Sıfırlama.Location = new System.Drawing.Point(146, 436);
            this.BTN_Sifre_Sıfırlama.Name = "BTN_Sifre_Sıfırlama";
            this.BTN_Sifre_Sıfırlama.Size = new System.Drawing.Size(105, 79);
            this.BTN_Sifre_Sıfırlama.TabIndex = 17;
            this.BTN_Sifre_Sıfırlama.Text = "Şifremi Unuttum";
            this.BTN_Sifre_Sıfırlama.Click += new System.EventHandler(this.BTN_Sifre_Sıfırlama_Click);
            // 
            // LBL_Kontrol
            // 
            this.LBL_Kontrol.AutoSize = true;
            this.LBL_Kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Kontrol.Location = new System.Drawing.Point(8, 576);
            this.LBL_Kontrol.Name = "LBL_Kontrol";
            this.LBL_Kontrol.Size = new System.Drawing.Size(304, 16);
            this.LBL_Kontrol.TabIndex = 18;
            this.LBL_Kontrol.Text = "Rol Kontrolü İçin Eklenmiştir Label Adı LBL_Kontrol";
            this.LBL_Kontrol.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(78, 374);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(78, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Giris_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(48F, 91F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 605);
            this.Controls.Add(this.LBL_Kontrol);
            this.Controls.Add(this.BTN_Sifre_Sıfırlama);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.RDR_Personel);
            this.Controls.Add(this.RDR_Admin);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.TXT_Sifre);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.TXT_Kullanıcı_Ad);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.Name = "Giris_Panel";
            this.Padding = new System.Windows.Forms.Padding(120, 341, 120, 114);
            this.Text = "Giriş Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Giris_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TXT_Sifre;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TXT_Kullanıcı_Ad;
        private MetroFramework.Controls.MetroTextBox Txt_ID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroRadioButton RDR_Personel;
        private MetroFramework.Controls.MetroRadioButton RDR_Admin;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label LBL_Kontrol;
        private MetroFramework.Controls.MetroButton BTN_Sifre_Sıfırlama;
    }
}

