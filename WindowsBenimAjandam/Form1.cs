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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Tarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            lbl_Tarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            NotlarıGetir();
        }

        private void btn_NotEkle_Click(object sender, EventArgs e)
        {
            Not_Ekle not = new Not_Ekle();
            not.ShowDialog();
        }
        void NotlarıGetir()
        {
            NotlarımıGösterLayout.Controls.Clear();
            DataTable dt = Cls.SQLConnectionClass.Table("SELECT not_KayıtNo, not_Başlık ,not_İçerik FROM NOT" + 
                 " WHERE not_Tarih >= '" + Convert.ToDateTime(lbl_Tarih.Text).ToString("yyyyMMdd") + "' + ' 00:00:00'   " + 
                 " AND not_Tarih <= '" + Convert.ToDateTime(lbl_Tarih.Text).ToString("yyyyMMdd") + "' + ' 23:59:59' ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NotuGöster NotumuGöster = new NotuGöster();
                NotumuGöster.lbl_Başlık.Text = dt.Rows[i]["not_Başlık"].ToString();
                NotumuGöster.lbl_İçerik.Text = dt.Rows[i]["not_İçerik"].ToString();
                NotumuGöster.lbl_ID.Text = dt.Rows[i]["not_KayıtNo"].ToString();
                NotlarımıGösterLayout.Controls.Add(NotumuGöster);
            }
        }

        private void btn_Sonraki_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbl_Tarih.Text = Convert.ToDateTime(lbl_Tarih.Text).AddDays(+1).ToString("dd.MM.yyyy");
            NotlarıGetir();
        }

        private void btn_Önceki_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbl_Tarih.Text = Convert.ToDateTime(lbl_Tarih.Text).AddDays(-1).ToString("dd.MM.yyyy");
            NotlarıGetir();
        }
    }
}
