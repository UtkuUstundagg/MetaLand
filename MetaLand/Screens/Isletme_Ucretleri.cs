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
    public partial class Isletme_Ucretleri : Form
    {
        public Isletme_Ucretleri()
        {
            InitializeComponent();
        }

        private void btn_Ayarla_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            int emlakUcreti = Convert.ToInt32(tb_Emlak.Text);
            int magazaUcreti = Convert.ToInt32(tb_Magaza.Text);
            int marketUcreti = Convert.ToInt32(tb_Market.Text);

            int kurmaUcreti = Convert.ToInt32(tb_Kur.Text);
            int kiralamaUcreti = Convert.ToInt32(tb_Kiralama.Text);

            conn.connectionAc();
            conn.yoneticiUcretiAyarla(marketUcreti, magazaUcreti, emlakUcreti);
            conn.yoneticiIsletmeFiyatAyarla(kurmaUcreti, kiralamaUcreti);
            conn.connectionKapat();

            Close();
        }
    }
}
