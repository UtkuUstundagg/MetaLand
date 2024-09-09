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

namespace MetaLand.Screens
{
    public partial class Emlak : Form
    {
        int kullaniciNo;
        int sahipNo;
        DateTime basTarih;
        public Emlak()
        {
            InitializeComponent();
        }

        public void teklifleriListele(int kullaniciNum,int sahipNum, DateTime tarih)
        {
            kullaniciNo = kullaniciNum;
            sahipNo = sahipNum;
            basTarih = tarih;
            Connection conn = new Connection();
            dataGridView1.DataSource = conn.gridEmlakDoldur().Tables[0];
        }

        private void btn_SatinAl_Click(object sender, EventArgs e)
        {
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int isletmeSahibi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            if (alanNo <= 3)
            {
                MessageBox.Show("Seçtiğiniz Alan Yöneticiye Ait Olduğu İçin Alınamıyor!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connection conn = new Connection();
                conn.connectionAc();
                if (conn.kullaniciArsaAlabilirMi(kullaniciNo))
                {
                    conn.arsaSatinAl(alanNo, kullaniciNo, sahipNo);
                    conn.emlakIslemler(1, kullaniciNo, sahipNo, isletmeSahibi, alanNo, basTarih);
                }
                else
                {
                    MessageBox.Show("En Fazla 2 Adet Boş Arsanız Olabilir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.connectionKapat();
                Close();
            }
        }

        private void btn_Market_Click(object sender, EventArgs e)
        {
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Connection conn = new Connection();
            conn.connectionAc();
            if (conn.kullaniciIsletmeKurabilirMi(kullaniciNo))
            {
                conn.isletmeAc(kullaniciNo, alanNo, "Market");
            }
            else
            {
                MessageBox.Show("Boş Arsanız Olmadığından İşletme Kuramazsınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connectionKapat();
            Close();
        }

        private void btn_Magaza_Click(object sender, EventArgs e)
        {
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Connection conn = new Connection();
            conn.connectionAc();
            if (conn.kullaniciIsletmeKurabilirMi(kullaniciNo))
            {
                conn.isletmeAc(kullaniciNo, alanNo, "Magaza");
            }
            else
            {
                MessageBox.Show("Boş Arsanız Olmadığından İşletme Kuramazsınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connectionKapat();
            Close();
        }

        private void btn_Emlak_Click(object sender, EventArgs e)
        {
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Connection conn = new Connection();
            conn.connectionAc();
            if (conn.kullaniciIsletmeKurabilirMi(kullaniciNo))
            {
                conn.isletmeAc(kullaniciNo, alanNo, "Emlak");
            }
            else
            {
                MessageBox.Show("Boş Arsanız Olmadığından İşletme Kuramazsınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connectionKapat();
            Close();
        }

        private void btn_Kirala_Click(object sender, EventArgs e)
        {
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int isletmeSahibi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            Connection conn = new Connection();
            conn.connectionAc();
            conn.emlakIslemler(2, kullaniciNo, sahipNo, isletmeSahibi, alanNo, basTarih);
            conn.connectionKapat();


        }
    }
}
