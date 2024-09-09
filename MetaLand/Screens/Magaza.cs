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
    public partial class Magaza : Form
    {
        int kullaniciNo;
        int sahipNo;
        public Magaza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int miktar = Convert.ToInt32(tb_Miktar.Text);
            Connection conn = new Connection();
            conn.connectionAc();
            conn.esyaAl(kullaniciNo, miktar, sahipNo);
            conn.connectionKapat();

            Close();
        }

        public void labelAyarla(int kullaniciNum, int fiyat, int sahipNum)
        {
            kullaniciNo = kullaniciNum;
            sahipNo = sahipNum;
            label1.Text = label1.Text + fiyat.ToString();
        }
    }
}
