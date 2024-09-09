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
    public partial class ItemFiyat : Form
    {
        public ItemFiyat()
        {
            InitializeComponent();
        }

        private void btn_Ayarla_Click(object sender, EventArgs e)
        {
            int yiyecek = Convert.ToInt32(tb_Yiyecek.Text);
            int esya = Convert.ToInt32(tb_Esya.Text);
            int emlak = Convert.ToInt32(tb_Emlak.Text);

            Connection conn = new Connection();
            conn.connectionAc();
            conn.yoneticiMarketFiyatlariAyarla(yiyecek, esya, emlak);
            conn.connectionKapat();

            Close();

        }
    }
}
