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
    public partial class Envanter : Form
    {
        public Envanter()
        {
            InitializeComponent();
        }

        private void btn_Ayarla_Click(object sender, EventArgs e)
        {
            int yemek = Convert.ToInt32(tb_Yemek.Text);
            int para = Convert.ToInt32(tb_Para.Text);
            int esya = Convert.ToInt32(tb_Esya.Text);

            Connection conn = new Connection();
            conn.connectionAc();
            conn.baslangicEnvanterAyarla(yemek, para, esya);
            conn.connectionKapat();
            Visible = false;
        }
    }
}
