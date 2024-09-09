using MetaLand.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MetaLand
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {   
            var girilenAd = tb_KullaniciAdi.Text;
            var girilenSifre = tb_Sifre.Text;

            Connection conn = new Connection();
            conn.connectionAc();
            if(conn.kayitKontrol(girilenAd, girilenSifre))
            {
                if (conn.yoneticiKontrol(girilenAd, girilenSifre))
                {
                    conn.connectionKapat();
                    Yonetici yoneticiEkran = new Yonetici();
                    yoneticiEkran.Show();
                    Visible = false;
                }
                else
                {
                    Oyun oyunEkran = new Oyun();

                    int kullanici_no = conn.kullaniciNoBul(girilenAd,girilenSifre);
                    conn.yoneticiTeklifOlustur();

                    oyunEkran.date = conn.suankiTarihiBul();
                    conn.connectionKapat();


                    oyunEkran.kullaniciNoAl(kullanici_no);

                    conn.connectionAc();
                    
                    if (conn.alanTabloSatirSayisi() == (conn.oyunAlaniBul() * conn.oyunAlaniBul()))
                    {
                        conn.connectionKapat();
                        oyunEkran.haritaEkranaBas();
                    }
                    else
                    {
                        conn.alanTablosunuTemizle();
                        conn.pbSil();
                        conn.connectionKapat();
                        oyunEkran.haritaOlustur();
                    }

                    conn.connectionAc();
                    if (!conn.devamKontrol(kullanici_no))
                    {
                        conn.oyuncuSil(kullanici_no);
                        conn.connectionKapat();
                        MessageBox.Show("Yiyecek Veya Eşyanız Bitti Oyunu Kaybettiniz", "Oyun Bitti!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }

                    conn.connectionKapat();
                    oyunEkran.Show();

                    Visible = false;
                }
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayitEkran = new KayitOl();
            kayitEkran.Show();
        }
    }
}
