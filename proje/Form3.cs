using System;
using System.Windows.Forms;

namespace proje
{

    public partial class Form3 : Form
    {



        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ad", 100);
            listView1.Columns.Add("Soyad", 100);
            listView1.Columns.Add("Telefon", 150);
            listView2.Columns.Add("Ürün", 100);
            listView2.Columns.Add("Seri No", 100);
            listView2.Columns.Add("Arıza Nedeni", 300);

            string[] teknoloji = { "Bilgisayar", "Telefon", "Tablet", "Televizyon" };
            comboBox1.Items.AddRange(teknoloji);
            kayitsayisiyaz();



        }
        private void kayitsayisiyaz()
        {
            int kayitsayisi = listView1.Items.Count;
            label7.Text = Convert.ToString(kayitsayisi);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(); // veri aktarımı için tanımlandı
            Musteri musteri = new Musteri();
            musteri.Ad = frm1.textBox1.Text;
            musteri.Soyad = frm1.textBox2.Text;
            musteri.Telefon = frm1.maskedTextBox1.Text;

            Form2 frm2 = new Form2(); // veri aktarımı için tanımlandı

            Urunler urun1 = new Urunler();
            urun1.Urun = frm2.comboBox1.Text;
            urun1.SeriNo = frm2.textBox1.Text;
            urun1.ArizaNedeni = frm2.richTextBox1.Text;
            

            string[] genel = { musteri.Ad, musteri.Soyad, musteri.Telefon, urun1.Urun, urun1.SeriNo, urun1.ArizaNedeni };
            ListViewItem ekle = new ListViewItem(genel);
        }
    }
}
