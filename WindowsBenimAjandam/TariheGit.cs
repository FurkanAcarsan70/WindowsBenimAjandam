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
    public partial class TariheGit : Form
    {
        public TariheGit()
        {
            InitializeComponent();
        }

        public DateTime Tarih = DateTime.Now;
        public int Devam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Devam = 1;
            Tarih = Convert.ToDateTime(dateTarihBulucu.Value);
            Close();
        }

        private void btnÇık_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
