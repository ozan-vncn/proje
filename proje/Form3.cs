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
            listView1.Columns.Add("Telefon", 120);
            listView1.Columns.Add("Ürün", 100);
            listView1.Columns.Add("Seri No", 100);
            listView1.Columns.Add("Arıza Nedeni", 160);
            listView1.Columns.Add("Giriş Tarihi", 160);
            listView1.Columns.Add("Çıkış Tarihi", 160);

            string[] teknoloji = { "Bilgisayar", "Telefon", "Tablet", "Televizyon" };
            cmbUrun.Items.AddRange(teknoloji);
            kayitsayisiyaz();



        }
        private void kayitsayisiyaz()
        {
            int kayitsayisi = listView1.Items.Count;
            lblkayitSayisi.Text = Convert.ToString(kayitsayisi);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Musteri mustri = new Musteri();
            Urunler urn = new Urunler();
            mustri.Ad = txtAD.Text;
            mustri.Soyad = txtSoyad.Text;
            mustri.Telefon = mtxtTelefon.Text;

            urn.Urun = cmbUrun.Text;
            urn.SeriNo = txtSeriNo.Text;
            urn.ArizaNedeni = rtxtArizaNedeni.Text;
            urn.girisTarihi = dtPickerGirisT.Value;
            urn.cikisTarihi = dtPickerCikisT.Value;
            string[] bilgiler = { mustri.Ad, mustri.Soyad, mustri.Telefon, urn.Urun, urn.SeriNo, urn.ArizaNedeni, urn.girisTarihi.ToString(), urn.cikisTarihi.ToString() };

            //Tarih KONTROLÜ

            if (dtPickerGirisT.Value >= DateTime.Now && dtPickerCikisT.Value >= dtPickerGirisT.Value)
            {
              ListViewItem lstItem = new ListViewItem(bilgiler);//listview de ni nesne oluşturuldu ve bilgiler dizisi aktarıldı.
                if (txtAD.Text != "" && txtSoyad.Text != "" && txtSeriNo.Text != "" && cmbUrun.Text != "" && mtxtTelefon.Text != "" && rtxtArizaNedeni.Text != "")//bütün değerlerin girilmesi şart kontrolü
                {
                    listView1.Items.Add(lstItem);
                }
                else
                    MessageBox.Show("Bütün değerler girilmelidir...");


                kayitsayisiyaz(); 
            }
            else
            {

                MessageBox.Show("Tarih bilgileri Hatalıdır");
                
            }

        }
    }
}
