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
    public partial class form_YemekSec : Form
    {
        public form_YemekSec()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Değişkenler
        /// </summary>
        public ComboBox comboBox;


        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_YemekSec_Load(object sender, EventArgs e)
        {
            listBox_Yemekler.Items.Clear();
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


        /// <summary>
        /// Seçili İtem
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool SelectItem(ListBox listBox, string item)
        {
            bool contains = listBox.Items.Contains(item);
            if (!contains)
                return false;
            listBox.SelectedItem = item;
            return listBox.SelectedItems.Contains(item);
        }


        /// <summary>
        /// Yemek Arama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_YemekAra_TextChanged(object sender, EventArgs e)
        {
            string searchString = textBox_YemekAra.Text;
            if (!string.IsNullOrEmpty(searchString))
            {
                int index = listBox_Yemekler.FindString(searchString);
                if (index != -1)
                {
                    listBox_Yemekler.SetSelected(index, true);
                }
                else
                {
                    MessageBox.Show("Yemek Bulunamadı", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Seçilen Yemek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_Yemekler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            comboBox.SelectedItem = listBox_Yemekler.Text;
            this.Close();
        }




    }
}
