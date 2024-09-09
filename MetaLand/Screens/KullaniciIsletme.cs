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
    public partial class KullaniciIsletme : Form
    {
        int kullaniciNo;
        public KullaniciIsletme()
        {
            InitializeComponent();
        }

        private void btn_Ayarla_Click(object sender, EventArgs e)
        {
            int marketFiyat = Convert.ToInt32(tb_Market.Text);
            int magazaFiyat = Convert.ToInt32(tb_Magaza.Text);
            int emlakKomisyon = Convert.ToInt32(tb_Emlak.Text);

            Connection conn = new Connection();
            conn.connectionAc();
            conn.kullaniciIsletmeUcretiAyarla(kullaniciNo, marketFiyat, magazaFiyat, emlakKomisyon);
            conn.connectionKapat();

            Close();
        }

        public void noGetir(int kullaniciNum)
        {
            kullaniciNo = kullaniciNum;
        }
    }
}
