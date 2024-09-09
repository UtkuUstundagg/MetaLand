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
    public partial class OyunAlaniVeTarih : Form
    {
        public OyunAlaniVeTarih()
        {
            InitializeComponent();
        }

        private void btn_OyunAlaniVeTarihAyarla_Click(object sender, EventArgs e)
        {
            int oyunAlani = Convert.ToInt32(tb_OyunAlani.Text);
            DateTime date = new DateTime();
            date = dateTimePicker1.Value;

            Connection conn = new Connection();
            conn.connectionAc();
            conn.alanVeDateTimeAyarla(oyunAlani,date);
            conn.connectionKapat();

            Visible = false;
        }
    }
}
