namespace Yemek_Listesi
{
    partial class form_YemekSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_YemekSec));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Yemekler = new System.Windows.Forms.ListBox();
            this.textBox_YemekAra = new System.Windows.Forms.TextBox();
            this.label_CopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yemek Ara";
            // 
            // listBox_Yemekler
            // 
            this.listBox_Yemekler.FormattingEnabled = true;
            this.listBox_Yemekler.ItemHeight = 16;
            this.listBox_Yemekler.Location = new System.Drawing.Point(16, 44);
            this.listBox_Yemekler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_Yemekler.Name = "listBox_Yemekler";
            this.listBox_Yemekler.Size = new System.Drawing.Size(402, 436);
            this.listBox_Yemekler.TabIndex = 1;
            this.listBox_Yemekler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_Yemekler_MouseDoubleClick);
            // 
            // textBox_YemekAra
            // 
            this.textBox_YemekAra.Location = new System.Drawing.Point(98, 13);
            this.textBox_YemekAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_YemekAra.Name = "textBox_YemekAra";
            this.textBox_YemekAra.Size = new System.Drawing.Size(320, 23);
            this.textBox_YemekAra.TabIndex = 0;
            this.textBox_YemekAra.TextChanged += new System.EventHandler(this.textBox_YemekAra_TextChanged);
            // 
            // label_CopyRight
            // 
            this.label_CopyRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_CopyRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_CopyRight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_CopyRight.Location = new System.Drawing.Point(0, 493);
            this.label_CopyRight.Name = "label_CopyRight";
            this.label_CopyRight.Size = new System.Drawing.Size(433, 27);
            this.label_CopyRight.TabIndex = 15;
            this.label_CopyRight.Text = "Yemek Listesi Hazırlama © - 2019 (Powered by AdamlarYazilim.com)";
            this.label_CopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_YemekSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(433, 520);
            this.Controls.Add(this.label_CopyRight);
            this.Controls.Add(this.textBox_YemekAra);
            this.Controls.Add(this.listBox_Yemekler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "form_YemekSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Seç - adamlaryazilim.com";
            this.Load += new System.EventHandler(this.form_YemekSec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Yemekler;
        private System.Windows.Forms.TextBox textBox_YemekAra;
        private System.Windows.Forms.Label label_CopyRight;
    }
}