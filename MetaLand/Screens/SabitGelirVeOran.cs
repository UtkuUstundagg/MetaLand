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
    public partial class SabitGelirVeOran : Form
    {
        public SabitGelirVeOran()
        {
            InitializeComponent();
        }

        private void btn_Ayarla_Click(object sender, EventArgs e)
        {
            int miktar = Convert.ToInt32(tb_Miktar.Text);
            float oran = (float)Convert.ToDouble(tb_Oran.Text);

            Connection conn = new Connection();
            conn.connectionAc();
            conn.yoneticiSabitGelirAyarla(miktar, oran);
            conn.connectionKapat();

            Close();

        }
    }
}
