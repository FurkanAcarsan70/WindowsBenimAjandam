
namespace WindowsBenimAjandam
{
    partial class TariheGit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariheGit));
            this.dateTarihBulucu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTariheGit = new System.Windows.Forms.Button();
            this.btnÇık = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTarihBulucu
            // 
            this.dateTarihBulucu.Location = new System.Drawing.Point(59, 12);
            this.dateTarihBulucu.Name = "dateTarihBulucu";
            this.dateTarihBulucu.Size = new System.Drawing.Size(200, 23);
            this.dateTarihBulucu.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tarih:";
            // 
            // btnTariheGit
            // 
            this.btnTariheGit.Location = new System.Drawing.Point(184, 41);
            this.btnTariheGit.Name = "btnTariheGit";
            this.btnTariheGit.Size = new System.Drawing.Size(75, 23);
            this.btnTariheGit.TabIndex = 14;
            this.btnTariheGit.Text = "Git";
            this.btnTariheGit.UseVisualStyleBackColor = true;
            this.btnTariheGit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnÇık
            // 
            this.btnÇık.Location = new System.Drawing.Point(103, 41);
            this.btnÇık.Name = "btnÇık";
            this.btnÇık.Size = new System.Drawing.Size(75, 23);
            this.btnÇık.TabIndex = 15;
            this.btnÇık.Text = "Çıkış";
            this.btnÇık.UseVisualStyleBackColor = true;
            this.btnÇık.Click += new System.EventHandler(this.btnÇık_Click);
            // 
            // TariheGit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnÇık;
            this.ClientSize = new System.Drawing.Size(270, 69);
            this.Controls.Add(this.btnÇık);
            this.Controls.Add(this.btnTariheGit);
            this.Controls.Add(this.dateTarihBulucu);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TariheGit";
            this.Text = "Tarihe Git";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTarihBulucu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTariheGit;
        private System.Windows.Forms.Button btnÇık;
    }
}