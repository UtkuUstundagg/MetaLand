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
    public partial class Teklifler : Form
    {
        public int kullaniciNo;
        public DateTime tarih;
        public Teklifler()
        {
            InitializeComponent();
        }

        public void teklifGetir(int kullaniciNum, DateTime value)
        {
            kullaniciNo = kullaniciNum;
            tarih = value;
            Connection conn = new Connection();
            dataGridView1.DataSource = conn.gridDoldur().Tables[0];
        }

        private void brn_Sec_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            int teklifNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int alanNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            int teklifSahibi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            conn.connectionAc();
            conn.kullaniciIsGuncelle(kullaniciNo, teklifNo, teklifSahibi, alanNo, tarih);
            conn.connectionKapat();



            Close();


        }
    }
}
