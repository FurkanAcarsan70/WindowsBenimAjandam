using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBenimAjandam
{
    public partial class NotuGöster : UserControl
    {
        public NotuGöster()
        {
            InitializeComponent();
        }

        private void btn_Düzenle_Click(object sender, EventArgs e)
        {
            Not_Ekle Not = new Not_Ekle();
            Not.txt_KayıtNumarası.Text = lbl_ID.Text;
            Not.ShowDialog();
        }
    }
}
