
namespace WindowsBenimAjandam
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.panel = new System.Windows.Forms.Panel();
            this.btn_NotEkle = new System.Windows.Forms.Button();
            this.btn_Sonraki = new System.Windows.Forms.Button();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.btn_TariheGit = new System.Windows.Forms.Button();
            this.btn_Önceki = new System.Windows.Forms.Button();
            this.NotlarımıGösterLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btn_NotEkle);
            this.panel.Controls.Add(this.btn_Sonraki);
            this.panel.Controls.Add(this.lbl_Tarih);
            this.panel.Controls.Add(this.btn_TariheGit);
            this.panel.Controls.Add(this.btn_Önceki);
            this.panel.Controls.Add(this.NotlarımıGösterLayout);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(292, 450);
            this.panel.TabIndex = 0;
            // 
            // btn_NotEkle
            // 
            this.btn_NotEkle.Location = new System.Drawing.Point(13, 370);
            this.btn_NotEkle.Name = "btn_NotEkle";
            this.btn_NotEkle.Size = new System.Drawing.Size(271, 35);
            this.btn_NotEkle.TabIndex = 4;
            this.btn_NotEkle.Text = "Not Ekle";
            this.btn_NotEkle.UseVisualStyleBackColor = true;
            this.btn_NotEkle.Click += new System.EventHandler(this.btn_NotEkle_Click);
            // 
            // btn_Sonraki
            // 
            this.btn_Sonraki.Location = new System.Drawing.Point(198, 412);
            this.btn_Sonraki.Name = "btn_Sonraki";
            this.btn_Sonraki.Size = new System.Drawing.Size(86, 33);
            this.btn_Sonraki.TabIndex = 3;
            this.btn_Sonraki.Text = "Sonraki";
            this.btn_Sonraki.UseVisualStyleBackColor = true;
            this.btn_Sonraki.Click += new System.EventHandler(this.btn_Sonraki_Click);
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Tarih.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tarih.Location = new System.Drawing.Point(13, 13);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(271, 33);
            this.lbl_Tarih.TabIndex = 0;
            this.lbl_Tarih.Text = "---";
            // 
            // btn_TariheGit
            // 
            this.btn_TariheGit.Location = new System.Drawing.Point(110, 411);
            this.btn_TariheGit.Name = "btn_TariheGit";
            this.btn_TariheGit.Size = new System.Drawing.Size(82, 34);
            this.btn_TariheGit.TabIndex = 2;
            this.btn_TariheGit.Text = "Tarihe Git";
            this.btn_TariheGit.UseVisualStyleBackColor = true;
            // 
            // btn_Önceki
            // 
            this.btn_Önceki.Location = new System.Drawing.Point(13, 411);
            this.btn_Önceki.Name = "btn_Önceki";
            this.btn_Önceki.Size = new System.Drawing.Size(91, 35);
            this.btn_Önceki.TabIndex = 1;
            this.btn_Önceki.Text = "Önceki";
            this.btn_Önceki.UseVisualStyleBackColor = true;
            this.btn_Önceki.Click += new System.EventHandler(this.btn_Önceki_Click);
            // 
            // NotlarımıGösterLayout
            // 
            this.NotlarımıGösterLayout.Location = new System.Drawing.Point(0, 0);
            this.NotlarımıGösterLayout.Name = "NotlarımıGösterLayout";
            this.NotlarımıGösterLayout.Size = new System.Drawing.Size(292, 450);
            this.NotlarımıGösterLayout.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Text = "Notlarım";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_NotEkle;
        private System.Windows.Forms.Button btn_Sonraki;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Button btn_TariheGit;
        private System.Windows.Forms.Button btn_Önceki;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel NotlarımıGösterLayout;
    }
}

