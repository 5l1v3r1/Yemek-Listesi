namespace Yemek_Listesi
{
    partial class form_YemekEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_YemekEkle));
            this.listBox_Yemekler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_YemekEkle = new System.Windows.Forms.Button();
            this.textBox_YemekAdi = new System.Windows.Forms.TextBox();
            this.button_SeciliYemekCikart = new System.Windows.Forms.Button();
            this.label_CopyRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Yemekler
            // 
            this.listBox_Yemekler.FormattingEnabled = true;
            this.listBox_Yemekler.ItemHeight = 16;
            this.listBox_Yemekler.Location = new System.Drawing.Point(14, 35);
            this.listBox_Yemekler.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBox_Yemekler.Name = "listBox_Yemekler";
            this.listBox_Yemekler.Size = new System.Drawing.Size(327, 532);
            this.listBox_Yemekler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yemek Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(403, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yemek Adı";
            // 
            // button_YemekEkle
            // 
            this.button_YemekEkle.Location = new System.Drawing.Point(363, 142);
            this.button_YemekEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_YemekEkle.Name = "button_YemekEkle";
            this.button_YemekEkle.Size = new System.Drawing.Size(152, 45);
            this.button_YemekEkle.TabIndex = 1;
            this.button_YemekEkle.Text = "Yemek Ekle";
            this.button_YemekEkle.UseVisualStyleBackColor = true;
            this.button_YemekEkle.Click += new System.EventHandler(this.Button_YemekEkle_Click);
            // 
            // textBox_YemekAdi
            // 
            this.textBox_YemekAdi.Location = new System.Drawing.Point(363, 111);
            this.textBox_YemekAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_YemekAdi.Name = "textBox_YemekAdi";
            this.textBox_YemekAdi.Size = new System.Drawing.Size(152, 23);
            this.textBox_YemekAdi.TabIndex = 0;
            this.textBox_YemekAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SeciliYemekCikart
            // 
            this.button_SeciliYemekCikart.Location = new System.Drawing.Point(363, 222);
            this.button_SeciliYemekCikart.Name = "button_SeciliYemekCikart";
            this.button_SeciliYemekCikart.Size = new System.Drawing.Size(152, 45);
            this.button_SeciliYemekCikart.TabIndex = 2;
            this.button_SeciliYemekCikart.Text = "Seçili Yemeği Çıkart";
            this.button_SeciliYemekCikart.UseVisualStyleBackColor = true;
            this.button_SeciliYemekCikart.Click += new System.EventHandler(this.Button_SeciliYemekCikart_Click);
            // 
            // label_CopyRight
            // 
            this.label_CopyRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_CopyRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_CopyRight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_CopyRight.Location = new System.Drawing.Point(0, 581);
            this.label_CopyRight.Name = "label_CopyRight";
            this.label_CopyRight.Size = new System.Drawing.Size(532, 27);
            this.label_CopyRight.TabIndex = 15;
            this.label_CopyRight.Text = "Yemek Listesi Hazırlama © - 2019 (Powered by AdamlarYazilim.com)";
            this.label_CopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_YemekEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(532, 608);
            this.Controls.Add(this.label_CopyRight);
            this.Controls.Add(this.button_SeciliYemekCikart);
            this.Controls.Add(this.textBox_YemekAdi);
            this.Controls.Add(this.button_YemekEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Yemekler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "form_YemekEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Ekle - adamlaryazilim.com";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_YemekEkle_FormClosed);
            this.Load += new System.EventHandler(this.form_YemekEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Yemekler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_YemekEkle;
        private System.Windows.Forms.TextBox textBox_YemekAdi;
        private System.Windows.Forms.Button button_SeciliYemekCikart;
        private System.Windows.Forms.Label label_CopyRight;
    }
}