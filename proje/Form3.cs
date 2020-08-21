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
            //listview a sütün eklendi
            listView1.Columns.Add("Ad", 100);
            listView1.Columns.Add("Soyad", 100);
            listView1.Columns.Add("Telefon", 120);
            listView1.Columns.Add("Ürün", 100);
            listView1.Columns.Add("Seri No", 100);
            listView1.Columns.Add("Arıza Nedeni", 160);
            listView1.Columns.Add("Giriş Tarihi", 160);
            listView1.Columns.Add("Çıkış Tarihi", 160);
            //combobox a item eklendi
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

            //Tarih Kontrolü

            if (dtPickerCikisT.Value >= dtPickerGirisT.Value)
            {
                //Bütün bilgiler eksiksiz girilmelidir kontrolü
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
                MessageBox.Show("Tarih bilgileri hatalıdır.");
            }




        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listView1.CheckedItems.Count;//listviewde ki seçili kayıt sayısı

            foreach (ListViewItem secilikayitbilgisi in listView1.CheckedItems)
            {
                secilikayitbilgisi.Remove();//seçilen kayıtlar silinmiştir.
            }
            MessageBox.Show(secilenSayisi.ToString() + " Adet Kayıt Silinmiştir.");
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Close();//formdan çıkılsın...
        }
        string ad;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Bu kod sayesinde eklediğimiz kayıtları geri çağırarak değişiklik varsa değişikliği yapıp tekrar kayıt yapıcaz ve eski kayıdı silicez 
            //listview deki ad a çigt tıklandığında
            ad = listView1.SelectedItems[0].SubItems[0].Text;
            //listview deki değerleri al ilgili textbox ve date time pickerlara ekle
            txtAD.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            mtxtTelefon.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbUrun.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtSeriNo.Text = listView1.SelectedItems[0].SubItems[4].Text;
            rtxtArizaNedeni.Text = listView1.SelectedItems[0].SubItems[5].Text;
            dtPickerGirisT.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dtPickerCikisT.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }
    }
}
