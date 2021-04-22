
namespace WindowsBenimAjandam
{
    partial class NotuGöster
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Başlık = new System.Windows.Forms.Label();
            this.lbl_İçerik = new System.Windows.Forms.Label();
            this.btn_Düzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(0, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(38, 15);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "label1";
            // 
            // lbl_Başlık
            // 
            this.lbl_Başlık.AutoSize = true;
            this.lbl_Başlık.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Başlık.Location = new System.Drawing.Point(0, 33);
            this.lbl_Başlık.Name = "lbl_Başlık";
            this.lbl_Başlık.Size = new System.Drawing.Size(96, 33);
            this.lbl_Başlık.TabIndex = 1;
            this.lbl_Başlık.Text = "Başlık";
            // 
            // lbl_İçerik
            // 
            this.lbl_İçerik.AutoSize = true;
            this.lbl_İçerik.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_İçerik.Location = new System.Drawing.Point(0, 66);
            this.lbl_İçerik.Name = "lbl_İçerik";
            this.lbl_İçerik.Size = new System.Drawing.Size(48, 19);
            this.lbl_İçerik.TabIndex = 2;
            this.lbl_İçerik.Text = "İçerik";
            // 
            // btn_Düzenle
            // 
            this.btn_Düzenle.Location = new System.Drawing.Point(624, 228);
            this.btn_Düzenle.Name = "btn_Düzenle";
            this.btn_Düzenle.Size = new System.Drawing.Size(95, 36);
            this.btn_Düzenle.TabIndex = 3;
            this.btn_Düzenle.Text = "Düzenle";
            this.btn_Düzenle.UseVisualStyleBackColor = true;
            this.btn_Düzenle.Click += new System.EventHandler(this.btn_Düzenle_Click);
            // 
            // NotuGöster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Düzenle);
            this.Controls.Add(this.lbl_İçerik);
            this.Controls.Add(this.lbl_Başlık);
            this.Controls.Add(this.lbl_ID);
            this.Name = "NotuGöster";
            this.Size = new System.Drawing.Size(719, 264);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.Label lbl_Başlık;
        public System.Windows.Forms.Label lbl_İçerik;
        private System.Windows.Forms.Button btn_Düzenle;
    }
}
