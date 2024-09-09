using MetaLand.Screens;
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
    public partial class Yonetici : Form
    {
        Connection conn = new Connection();
        public Yonetici()
        {
            InitializeComponent();
        }

        private void btn_AlanVeTarih_Click(object sender, EventArgs e)
        {
            OyunAlaniVeTarih ekran = new OyunAlaniVeTarih();
            ekran.Show();
            
        }

        private void btn_Envanter_Click(object sender, EventArgs e)
        {
            Envanter ekran = new Envanter();
            ekran.Show();
        }

        private void btn_Giderler_Click(object sender, EventArgs e)
        {
            Giderler ekran = new Giderler();
            ekran.Show();

        }

        private void btn_Isletme_Ucret_Click(object sender, EventArgs e)
        {
            Isletme_Ucretleri ekran = new Isletme_Ucretleri();
            ekran.Show();
        }

        private void btn_Sabit_Click(object sender, EventArgs e)
        {
            SabitGelirVeOran ekran = new SabitGelirVeOran();
            ekran.Show();
        }

        private void btn_ItemFiyat_Click(object sender, EventArgs e)
        {
            ItemFiyat ekran = new ItemFiyat();
            ekran.Show();
        }

        private void btn_EnvanterGor_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.envanterGoruntule().Tables[0];
            conn.connectionKapat();
        }

        private void btn_Gecmis_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.gecmisGoruntule().Tables[0];
            conn.connectionKapat();
        }

        private void btn_Alan_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.alanGoruntule().Tables[0];
            conn.connectionKapat();
        }

        private void btn_Ucret_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.isletmeUcretGoruntule().Tables[0];
            conn.connectionKapat();
        }

        private void btn_IsDurumu_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.isGoruntule().Tables[0];
            conn.connectionKapat();
        }

        private void btn_Kullanici_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.kullaniciGoruntule().Tables[0];
            conn.connectionKapat();
        }

        private void btn_Emlak_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.emlakGoruntule().Tables[0];
            conn.connectionKapat();
        }
    }
}
