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
    public partial class Not_Ekle : Form
    {
        public Not_Ekle()
        {
            InitializeComponent();
        }

        private void Not_Ekle_Load(object sender, EventArgs e)
        {
            txt_KayıtNumarası.Text = "0";
            NotOku();
        }
        void NotOku()
        {
            if (Convert.ToInt32(txt_KayıtNumarası.Text) > 0)
            {
                DataTable dt = Cls.SQLConnectionClass.Table("SELECT not_KayıtNo, not_Başlık ,not_İçerik FROM NOT  WHERE not_KayıtNo = " + Convert.ToInt32(txt_KayıtNumarası.Text) + " ");
                txt_Başlık.Text = dt.Rows[0]["not_Başlık"].ToString();
                txt_İçerik.Text = dt.Rows[0]["not_İçerik"].ToString();
            }
            else
            {
                
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txt_KayıtNumarası.Text) == 0)
            {
                Cls.SQLConnectionClass.Command(""
                    + "          INSERT INTO [dbo].[NOT] "
                    + "                 ([not_KayıtTarihi] "
                    + "                 ,[not_Başlık] "
                    + "                 ,[not_Tarih] "
                    + "                 ,[not_İçerik]) "
                    + "          VALUES "
                    + "                 ( getdate() "
                    + "                 ,'" + txt_Başlık.Text + "' "
                    + "                 ,'" + Convert.ToDateTime(dateTarihBulucu.Value).ToString("yyyyMMdd HH:mm") + "' "
                    + "                 ,'" + txt_İçerik.Text + "') ");
                if(Cls.SQLConnectionClass.SQLexception == null)
                {
                    MessageBox.Show("Kayıt Başarılı.");
                    Close();
                }
            }
            else
            {
                Cls.SQLConnectionClass.Command(""
                    + "          UPDATE [dbo].[NOT] SET "
                    + "                  ,not_DeğiştirmeTarihi = getdate() "
                    + "                  ,[not_Başlık] = " + txt_Başlık.Text + "' "
                    + "                  ,[not_İçerik] = " + txt_İçerik.Text + "' "
                    + "                  ,[not_Tarih] = " + Convert.ToDateTime(dateTarihBulucu.Value).ToString("yyyyMMdd HH:mm") + "' "
                    + "          WHERE not_KayıtNo = " + Convert.ToInt32(txt_KayıtNumarası.Text) + "' ");
                if (Cls.SQLConnectionClass.SQLexception == null)
                {
                    MessageBox.Show("Güncelleme Başarılı.");
                    Close();
                }
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Cls.SQLConnectionClass.Command("DELETE FROM [dbo].[Not]   WHERE not_KayıtNo = " + Convert.ToInt32(txt_KayıtNumarası.Text) + " ");
            if (Cls.SQLConnectionClass.SQLexception == null)
            {
                MessageBox.Show("Silme Başarılı.");
                Close();
            }
        }

        private void btn_Çıkış_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
