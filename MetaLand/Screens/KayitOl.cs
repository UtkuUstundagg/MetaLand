using MetaLand.Classes;
using MetaLand.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaLand
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            kayitYap();
        }

        public void kayitYap()
        {
            Kullanici kullanici = new Kullanici();

            kullanici.Kullanici_Adi = tb_KulAdi.Text;

            kullanici.Kullanici_Soyadi = tb_Soyadi.Text;

            kullanici.Kullanici_Sifre = tb_Sifre.Text;

            kullanici.Kullanici_Is_Durumu = "Issiz";

            Connection conn = new Connection();
            conn.connectionAc();
            conn.kayitEkle(kullanici);
            conn.kullaniciEnvanterSetle();
            conn.connectionKapat();
            Visible = false;

        }
       
        
    }
}
