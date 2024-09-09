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
    public partial class Detaylar : Form
    {
        int kullaniciNo;
        Connection conn = new Connection();
        public Detaylar()
        {
            InitializeComponent();
        }

        public void noGetir(int kullaniciNum)
        {
            kullaniciNo = kullaniciNum;
        }

        private void btn_Giderler_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.giderDoldur(kullaniciNo).Tables[0];
            conn.connectionKapat();
            
        }

        private void btn_SatinAlma_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.satinAlmaDoldur(kullaniciNo).Tables[0];
            conn.connectionKapat();
        }

        private void btn_Varlik_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            dataGridView1.DataSource = conn.varlikDoldur(kullaniciNo).Tables[0];
            conn.connectionKapat();
        }
    }
}
