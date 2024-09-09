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
    public partial class Market : Form
    {
        int kullaniciNo;
        int sahipNo;
        public Market()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int miktar = Convert.ToInt32(tb_Miktar.Text);
            Connection conn = new Connection();
            conn.connectionAc();
            conn.yiyecekAl(kullaniciNo, miktar, sahipNo);
            conn.connectionKapat();

            Close();


        }
        
        public void labelAyarla(int kullaniciNum, int fiyat, int sahipNum)
        {
            kullaniciNo = kullaniciNum;
            sahipNo = sahipNum;
            label2.Text = label2.Text + fiyat.ToString();
        }

    }
}
