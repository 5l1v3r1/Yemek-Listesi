using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Yemek_Listesi
{
    public partial class form_YemekListesi : Form
    {
        public form_YemekListesi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Değişkenler
        /// </summary>
        form_YemekSec frm_YemekSec = new form_YemekSec();
        form_YemekEkle frm_YemekEkle = new form_YemekEkle();


        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_YemekListesi_Load(object sender, EventArgs e)
        {

            YemekListesiOku();
        }


        /// <summary>
        /// Yemek Listesi Okuma Fonksiyonu
        /// </summary>
        public void YemekListesiOku()
        {
            try
            {
                ComboTemizle();

                string dosya_yolu = System.Windows.Forms.Application.StartupPath + @"\Yemek Listesi.txt";
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                StreamReader sw = new StreamReader(fs, Encoding.GetEncoding("iso-8859-9"), false);

                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    combo_1_1.Items.Add(yazi);
                    combo_1_2.Items.Add(yazi);
                    combo_1_3.Items.Add(yazi);
                    combo_1_4.Items.Add(yazi);
                    combo_1_5.Items.Add(yazi);
                    combo_1_6.Items.Add(yazi);
                    combo_1_7.Items.Add(yazi);
                    combo_2_1.Items.Add(yazi);
                    combo_2_2.Items.Add(yazi);
                    combo_2_3.Items.Add(yazi);
                    combo_2_4.Items.Add(yazi);
                    combo_2_5.Items.Add(yazi);
                    combo_2_6.Items.Add(yazi);
                    combo_2_7.Items.Add(yazi);
                    combo_3_1.Items.Add(yazi);
                    combo_3_2.Items.Add(yazi);
                    combo_3_3.Items.Add(yazi);
                    combo_3_4.Items.Add(yazi);
                    combo_3_5.Items.Add(yazi);
                    combo_3_6.Items.Add(yazi);
                    combo_3_7.Items.Add(yazi);
                    combo_4_1.Items.Add(yazi);
                    combo_4_2.Items.Add(yazi);
                    combo_4_3.Items.Add(yazi);
                    combo_4_4.Items.Add(yazi);
                    combo_4_5.Items.Add(yazi);
                    combo_4_6.Items.Add(yazi);
                    combo_4_7.Items.Add(yazi);
                    combo_5_1.Items.Add(yazi);
                    combo_5_2.Items.Add(yazi);
                    combo_5_3.Items.Add(yazi);
                    combo_5_4.Items.Add(yazi);
                    combo_5_5.Items.Add(yazi);
                    combo_5_6.Items.Add(yazi);
                    combo_5_7.Items.Add(yazi);
                    combo_6_1.Items.Add(yazi);
                    combo_6_2.Items.Add(yazi);
                    combo_6_3.Items.Add(yazi);
                    combo_6_4.Items.Add(yazi);
                    combo_6_5.Items.Add(yazi);
                    combo_6_6.Items.Add(yazi);
                    combo_6_7.Items.Add(yazi);

                    yazi = sw.ReadLine();
                }

                sw.Close();
                fs.Close();
            }
            catch { }
        }


        #region Yemek Seçme
        private void button_1_1_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_1_1;
            frm_YemekSec.ShowDialog();
        }

        private void Button_1_2_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_1_2;
            frm_YemekSec.ShowDialog();
        }

        private void button_1_3_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_1_3;
            frm_YemekSec.ShowDialog();
        }

        private void button_1_4_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_1_4;
            frm_YemekSec.ShowDialog();
        }

        private void button_1_5_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_1_5;
            frm_YemekSec.ShowDialog();
        }

        private void button_1_6_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_1_6;
            frm_YemekSec.ShowDialog();
        }

        private void button_1_7_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_1_7;
            frm_YemekSec.ShowDialog();
        }

        private void button_2_1_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_2_1;
            frm_YemekSec.ShowDialog();
        }

        private void button_2_2_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_2_2;
            frm_YemekSec.ShowDialog();
        }

        private void button_2_3_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_2_3;
            frm_YemekSec.ShowDialog();
        }

        private void button_2_4_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_2_4;
            frm_YemekSec.ShowDialog();
        }

        private void button_2_5_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_2_5;
            frm_YemekSec.ShowDialog();
        }

        private void button_2_6_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_2_6;
            frm_YemekSec.ShowDialog();
        }

        private void button_2_7_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_2_7;
            frm_YemekSec.ShowDialog();
        }

        private void button_3_1_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_3_1;
            frm_YemekSec.ShowDialog();
        }

        private void button_3_2_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_3_2;
            frm_YemekSec.ShowDialog();
        }

        private void button_3_3_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_3_3;
            frm_YemekSec.ShowDialog();
        }

        private void button_3_4_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_3_4;
            frm_YemekSec.ShowDialog();
        }

        private void button_3_5_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_3_5;
            frm_YemekSec.ShowDialog();
        }

        private void button_3_6_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_3_6;
            frm_YemekSec.ShowDialog();
        }

        private void button_3_7_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_3_7;
            frm_YemekSec.ShowDialog();
        }

        private void button_4_1_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_4_1;
            frm_YemekSec.ShowDialog();
        }

        private void button_4_2_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_4_2;
            frm_YemekSec.ShowDialog();
        }

        private void button_4_3_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_4_3;
            frm_YemekSec.ShowDialog();
        }

        private void button_4_4_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_4_4;
            frm_YemekSec.ShowDialog();
        }

        private void button_4_5_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_4_5;
            frm_YemekSec.ShowDialog();
        }

        private void button_4_6_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_4_6;
            frm_YemekSec.ShowDialog();
        }

        private void button_4_7_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_4_7;
            frm_YemekSec.ShowDialog();
        }

        private void button_5_1_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_5_1;
            frm_YemekSec.ShowDialog();
        }

        private void button_5_2_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_5_2;
            frm_YemekSec.ShowDialog();
        }

        private void button_5_3_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_5_3;
            frm_YemekSec.ShowDialog();
        }

        private void button_5_4_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_5_4;
            frm_YemekSec.ShowDialog();
        }

        private void button_5_5_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_5_5;
            frm_YemekSec.ShowDialog();
        }

        private void button_5_6_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_5_6;
            frm_YemekSec.ShowDialog();
        }

        private void button_5_7_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_5_7;
            frm_YemekSec.ShowDialog();
        }

        private void button_6_1_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_6_1;
            frm_YemekSec.ShowDialog();
        }

        private void button_6_2_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_6_2;
            frm_YemekSec.ShowDialog();
        }

        private void button_6_3_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_6_3;
            frm_YemekSec.ShowDialog();
        }

        private void button_6_4_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_6_4;
            frm_YemekSec.ShowDialog();
        }

        private void button_6_5_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_6_5;
            frm_YemekSec.ShowDialog();
        }

        private void button_6_6_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_6_6;
            frm_YemekSec.ShowDialog();
        }

        private void button_6_7_Click(object sender, EventArgs e)
        {
            frm_YemekSec.comboBox = combo_6_7;
            frm_YemekSec.ShowDialog();
        }
        #endregion


        private void button3_Click(object sender, EventArgs e)
        {
            frm_YemekEkle.ShowDialog();
        }

        void ComboTemizle()
        {
            combo_1_1.Items.Clear();
            combo_1_2.Items.Clear();
            combo_1_3.Items.Clear();
            combo_1_4.Items.Clear();
            combo_1_5.Items.Clear();
            combo_1_6.Items.Clear();
            combo_1_7.Items.Clear();
            combo_2_1.Items.Clear();
            combo_2_2.Items.Clear();
            combo_2_3.Items.Clear();
            combo_2_4.Items.Clear();
            combo_2_5.Items.Clear();
            combo_2_6.Items.Clear();
            combo_2_7.Items.Clear();
            combo_3_1.Items.Clear();
            combo_3_2.Items.Clear();
            combo_3_3.Items.Clear();
            combo_3_4.Items.Clear();
            combo_3_5.Items.Clear();
            combo_3_6.Items.Clear();
            combo_3_7.Items.Clear();
            combo_4_1.Items.Clear();
            combo_4_2.Items.Clear();
            combo_4_3.Items.Clear();
            combo_4_4.Items.Clear();
            combo_4_5.Items.Clear();
            combo_4_6.Items.Clear();
            combo_4_7.Items.Clear();
            combo_5_1.Items.Clear();
            combo_5_2.Items.Clear();
            combo_5_3.Items.Clear();
            combo_5_4.Items.Clear();
            combo_5_5.Items.Clear();
            combo_5_6.Items.Clear();
            combo_5_7.Items.Clear();
            combo_6_1.Items.Clear();
            combo_6_2.Items.Clear();
            combo_6_3.Items.Clear();
            combo_6_4.Items.Clear();
            combo_6_5.Items.Clear();
            combo_6_6.Items.Clear();
            combo_6_7.Items.Clear();
        }

        private void Button_YemekListesiGuncelle_Click(object sender, EventArgs e)
        {
            YemekListesiOku();

        }






        private void Button_ExcelAktar_Click(object sender, EventArgs e)
        {
            if(number_BaskiSayisi.Value > 0)
            {
                printDocument1.PrinterSettings.Copies = short.Parse(number_BaskiSayisi.Value.ToString());
                printDocument1.DefaultPageSettings.Landscape = true;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Baskı sayısı girmelisiniz", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font YaziTipi = new Font("Calibri", 28);
            SolidBrush YaziCizimi = new SolidBrush(Color.Black);
            Pen Cizgi = new Pen(Color.Black);

            // Firma Adı
            e.Graphics.DrawString("KOÇGÜRBÜZLER KEYFİ LEZZET", YaziTipi, YaziCizimi, 0, 0);

            // Tarih
            YaziTipi = new Font("Calibri", 12, FontStyle.Bold);
           // DateTime BirHaftaSonrasi = DateTime.Now.AddDays(+7);
            e.Graphics.DrawString(date_TarihSec.Value.ToLongDateString() + " - " + date_TarihSec.Value.AddDays(+5).ToLongDateString(), YaziTipi, YaziCizimi, 5, 60);


            // Tablo
            int BaslangicGenislik = 10;
            int SabitGenislik = BaslangicGenislik + 190;

            YaziTipi = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Pazartesi", YaziTipi, YaziCizimi, BaslangicGenislik, 100);
            e.Graphics.DrawString("Salı", YaziTipi, YaziCizimi, SabitGenislik * 1, 100);
            e.Graphics.DrawString("Çarşamba", YaziTipi, YaziCizimi, SabitGenislik * 2, 100);
            e.Graphics.DrawString("Perşembe", YaziTipi, YaziCizimi, SabitGenislik * 3, 100);
            e.Graphics.DrawString("Cuma", YaziTipi, YaziCizimi, SabitGenislik * 4, 100);
            e.Graphics.DrawString("Cumartesi", YaziTipi, YaziCizimi, SabitGenislik * 5, 100);

            // çizgi
            e.Graphics.DrawLine(Cizgi, 0, 125, SabitGenislik * 6, 125);



            // Yazı Tipi
            YaziTipi = new Font("Calibri", 12, FontStyle.Regular);

            // pazartesi
            e.Graphics.DrawString(combo_1_1.Text, YaziTipi, YaziCizimi, BaslangicGenislik, 130);
            e.Graphics.DrawString(combo_1_2.Text, YaziTipi, YaziCizimi, BaslangicGenislik, 150);
            e.Graphics.DrawString(combo_1_3.Text, YaziTipi, YaziCizimi, BaslangicGenislik, 170);
            e.Graphics.DrawString(combo_1_4.Text, YaziTipi, YaziCizimi, BaslangicGenislik, 190);
            e.Graphics.DrawString(combo_1_5.Text, YaziTipi, YaziCizimi, BaslangicGenislik, 210);
            e.Graphics.DrawString(combo_1_6.Text, YaziTipi, YaziCizimi, BaslangicGenislik, 230);
            e.Graphics.DrawString(combo_1_7.Text, YaziTipi, YaziCizimi, BaslangicGenislik, 250);

            // salı
            e.Graphics.DrawString(combo_2_1.Text, YaziTipi, YaziCizimi, SabitGenislik * 1, 130);
            e.Graphics.DrawString(combo_2_2.Text, YaziTipi, YaziCizimi, SabitGenislik * 1, 150);
            e.Graphics.DrawString(combo_2_3.Text, YaziTipi, YaziCizimi, SabitGenislik * 1, 170);
            e.Graphics.DrawString(combo_2_4.Text, YaziTipi, YaziCizimi, SabitGenislik * 1, 190);
            e.Graphics.DrawString(combo_2_5.Text, YaziTipi, YaziCizimi, SabitGenislik * 1, 210);
            e.Graphics.DrawString(combo_2_6.Text, YaziTipi, YaziCizimi, SabitGenislik * 1, 230);
            e.Graphics.DrawString(combo_2_7.Text, YaziTipi, YaziCizimi, SabitGenislik * 1, 250);

            // çarşamba
            e.Graphics.DrawString(combo_3_1.Text, YaziTipi, YaziCizimi, SabitGenislik * 2, 130);
            e.Graphics.DrawString(combo_3_2.Text, YaziTipi, YaziCizimi, SabitGenislik * 2, 150);
            e.Graphics.DrawString(combo_3_3.Text, YaziTipi, YaziCizimi, SabitGenislik * 2, 170);
            e.Graphics.DrawString(combo_3_4.Text, YaziTipi, YaziCizimi, SabitGenislik * 2, 190);
            e.Graphics.DrawString(combo_3_5.Text, YaziTipi, YaziCizimi, SabitGenislik * 2, 210);
            e.Graphics.DrawString(combo_3_6.Text, YaziTipi, YaziCizimi, SabitGenislik * 2, 230);
            e.Graphics.DrawString(combo_3_7.Text, YaziTipi, YaziCizimi, SabitGenislik * 2, 250);


            // Perşembe
            e.Graphics.DrawString(combo_4_1.Text, YaziTipi, YaziCizimi, SabitGenislik * 3, 130);
            e.Graphics.DrawString(combo_4_2.Text, YaziTipi, YaziCizimi, SabitGenislik * 3, 150);
            e.Graphics.DrawString(combo_4_3.Text, YaziTipi, YaziCizimi, SabitGenislik * 3, 170);
            e.Graphics.DrawString(combo_4_4.Text, YaziTipi, YaziCizimi, SabitGenislik * 3, 190);
            e.Graphics.DrawString(combo_4_5.Text, YaziTipi, YaziCizimi, SabitGenislik * 3, 210);
            e.Graphics.DrawString(combo_4_6.Text, YaziTipi, YaziCizimi, SabitGenislik * 3, 230);
            e.Graphics.DrawString(combo_4_7.Text, YaziTipi, YaziCizimi, SabitGenislik * 3, 250);

            // Cuma
            e.Graphics.DrawString(combo_5_1.Text, YaziTipi, YaziCizimi, SabitGenislik * 4, 130);
            e.Graphics.DrawString(combo_5_2.Text, YaziTipi, YaziCizimi, SabitGenislik * 4, 150);
            e.Graphics.DrawString(combo_5_3.Text, YaziTipi, YaziCizimi, SabitGenislik * 4, 170);
            e.Graphics.DrawString(combo_5_4.Text, YaziTipi, YaziCizimi, SabitGenislik * 4, 190);
            e.Graphics.DrawString(combo_5_5.Text, YaziTipi, YaziCizimi, SabitGenislik * 4, 210);
            e.Graphics.DrawString(combo_5_6.Text, YaziTipi, YaziCizimi, SabitGenislik * 4, 230);
            e.Graphics.DrawString(combo_5_7.Text, YaziTipi, YaziCizimi, SabitGenislik * 4, 250);


            // Cumartesi
            e.Graphics.DrawString(combo_6_1.Text, YaziTipi, YaziCizimi, SabitGenislik * 5, 130);
            e.Graphics.DrawString(combo_6_2.Text, YaziTipi, YaziCizimi, SabitGenislik * 5, 150);
            e.Graphics.DrawString(combo_6_3.Text, YaziTipi, YaziCizimi, SabitGenislik * 5, 170);
            e.Graphics.DrawString(combo_6_4.Text, YaziTipi, YaziCizimi, SabitGenislik * 5, 190);
            e.Graphics.DrawString(combo_6_5.Text, YaziTipi, YaziCizimi, SabitGenislik * 5, 210);
            e.Graphics.DrawString(combo_6_6.Text, YaziTipi, YaziCizimi, SabitGenislik * 5, 230);
            e.Graphics.DrawString(combo_6_7.Text, YaziTipi, YaziCizimi, SabitGenislik * 5, 250);



            // çizgi
            e.Graphics.DrawLine(Cizgi, 0, 280, SabitGenislik * 6, 280);


            //
            YaziTipi = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Yemek Adı", YaziTipi, YaziCizimi, 10, 290);
            e.Graphics.DrawString("Ücret (₺)", YaziTipi, YaziCizimi, SabitGenislik * 1, 290);

            int YemekAdi_SabitYukseklik = 310;

            YaziTipi = new Font("Calibri", 12, FontStyle.Regular);
            for (int i = 0; i < listView_UcretliYemekler.Items.Count; i++)
            {
                e.Graphics.DrawString(
                    listView_UcretliYemekler.Items[i].SubItems[0].Text, 
                    YaziTipi, YaziCizimi, 
                    new Point(10, YemekAdi_SabitYukseklik)
                );


                e.Graphics.DrawString(
                    listView_UcretliYemekler.Items[i].SubItems[1].Text + "₺", 
                    YaziTipi, YaziCizimi, 
                    new Point(SabitGenislik * 1, YemekAdi_SabitYukseklik)
                );

                YemekAdi_SabitYukseklik += 20;
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }



        /// <summary>
        /// Ücretli yemek ekleme butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_UcretliYemekEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Eğer item 0 sa yeniden ekle
                if(listView_UcretliYemekler.Items.Count == 0)
                {
                    string[] satir = { textBox_YemekAdi.Text, textBox_Fiyat.Text };
                    var ekle = new ListViewItem(satir);
                    listView_UcretliYemekler.Items.Add(ekle);
                    textBox_YemekAdi.Clear();
                    textBox_Fiyat.Clear();
                }
                else
                {
                    // İtem arama daha önce eklediyse ekleme
                    ListViewItem foundItem = listView_UcretliYemekler.FindItemWithText(textBox_YemekAdi.Text, false, 0, true);
                    if (foundItem != null)
                    {
                        MessageBox.Show("Daha bu yemek eklenmiş.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Daha önce eklenmediyse ekle
                        string[] satir = { textBox_YemekAdi.Text, textBox_Fiyat.Text };
                        var ekle = new ListViewItem(satir);
                        listView_UcretliYemekler.Items.Add(ekle);
                        textBox_YemekAdi.Clear();
                        textBox_Fiyat.Clear();
                    }
                }
            }
            catch { }
        }


        /// <summary>
        /// Ücretli seçili yemek sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_UcretliSeciliSil_Click(object sender, EventArgs e)
        {
            try
            {
                listView_UcretliYemekler.Items.Remove(listView_UcretliYemekler.SelectedItems[0]);
            }
            catch
            {
                MessageBox.Show("Yemek seçmelisiniz", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




    }
}
