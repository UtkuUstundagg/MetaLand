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
    public partial class SatveyaKirala : Form
    {
        int kullaniciNo;
        public SatveyaKirala()
        {
            InitializeComponent();
        }

        public void noGetir(int kullaniciNum)
        {
            kullaniciNo = kullaniciNum;
            Connection conn = new Connection();
            dataGridView1.DataSource = conn.satilikKiralikDoldur(kullaniciNo).Tables[0];
            
        }

        private void btn_Sat_Click(object sender, EventArgs e)
        {
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Connection conn = new Connection();
            conn.connectionAc();
            conn.alanSatilikYap(alanNo);
            conn.connectionKapat();
            
            
        }

        private void btn_Kirala_Click(object sender, EventArgs e)
        {
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Connection conn = new Connection();
            conn.connectionAc();
            conn.alanKiralikYap(alanNo);
            conn.connectionKapat();

            
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Connection conn = new Connection();
            conn.connectionAc();
            conn.alanIptalEt(alanNo);
            conn.connectionKapat();

            
        }

        private void btn_Belirle_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(tb_Fiyat.Text);
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Connection conn = new Connection();

            conn.connectionAc();
            conn.alanFiyatBelirle(alanNo, fiyat);
            conn.connectionKapat();
        }
    }
}
