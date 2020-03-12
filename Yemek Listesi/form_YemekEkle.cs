using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemek_Listesi
{
    public partial class form_YemekEkle : Form
    {
        public form_YemekEkle()
        {
            InitializeComponent();
        }

        private void form_YemekEkle_Load(object sender, EventArgs e)
        {
            listBox_Yemekler.Items.Clear();
            textBox_YemekAdi.Clear();
            YemekListesiOku();
        }


        /// <summary>
        /// Yemek Listesi Okuma
        /// </summary>
        public void YemekListesiOku()
        {
            string dosya_yolu = Application.StartupPath + @"\Yemek Listesi.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs, Encoding.GetEncoding("iso-8859-9"), false);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                listBox_Yemekler.Items.Add(yazi);
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

        private void Button_YemekEkle_Click(object sender, EventArgs e)
        {
            if (listBox_Yemekler.Items.Contains(textBox_YemekAdi.Text) == false)
            {
                if(textBox_YemekAdi.Text == "")
                {
                    MessageBox.Show("Yemek adı girmelisiniz", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    listBox_Yemekler.Items.Add(textBox_YemekAdi.Text);
                }
            }
            else
            {
                MessageBox.Show("Bu yemek daha önce eklenmiş", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_SeciliYemekCikart_Click(object sender, EventArgs e)
        {
            try
            {
                listBox_Yemekler.Items.Remove(listBox_Yemekler.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Yemek listeden çıkartılamadı", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Kaydet()
        {

            //Yeni bir dosya oluştur
            try
            {
                string sPath = Application.StartupPath + @"\Yemek Listesi.txt";


                string[] sitesDizi = new String[listBox_Yemekler.Items.Count];
                listBox_Yemekler.Items.CopyTo(sitesDizi, 0);
                System.IO.File.WriteAllLines(sPath, sitesDizi, Encoding.GetEncoding("iso-8859-9"));


                /*FileStream fs = new FileStream(sPath, FileMode.Open, FileAccess.Write);
                StreamWriter dosyaAc = new StreamWriter(fs, Encoding.GetEncoding("iso-8859-9"));

                foreach (var item in listBox_Yemekler.Items)
                {
                    if(item.ToString() != "")
                    {
                        dosyaAc.WriteLine(item);
                    }
                }

                // Dosya yı kapattık.
                dosyaAc.Close();
                dosyaAc.Dispose();*/




            }
            catch
            {

                //bilgi mesajı
                MessageBox.Show("Hata liste kaydedilemedi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form_YemekEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kaydet();
        }



    }
}
