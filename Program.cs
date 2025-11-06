using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teknik_Servis_Otomasyonu; // Bu, Giriş Panelini bulmasını sağlar

namespace Teknik_Servis_Otomasyonu
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris_Panel()); // Yeni sınıf adınız bu olmalı
        }
    }
}
