using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1(); // veri aktarımı için tanımlandı
        Form3 frm3 = new Form3(); // veri aktarımı için tanımlandı


        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Combobox1 e listedeki ögeler eklendi
            string[] teknoloji = { "Bilgisayar", "Telefon", "Tablet", "Televizyon" };
            comboBox1.Items.AddRange(teknoloji);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler urn = new Urunler();
            urn.Urun = comboBox1.Text;
            urn.SeriNo = textBox1.Text;
            urn.ArizaNedeni = richTextBox1.Text;
            string[] urunDizi = { urn.Urun, urn.SeriNo, urn.ArizaNedeni };
            ListViewItem urunEkle = new ListViewItem(urunDizi);
            frm3.listView2.Items.Add(urunEkle);
            
        }
    }
}
