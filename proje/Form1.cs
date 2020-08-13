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
    public partial class Form1 : Form
    {
        Form3 frm3 = new Form3(); // admin formuna geçiş için değişken tanımladım..
        Form2 frm2 = new Form2(); // müşteri formuna geçiş için değişken tanımladım..
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length==0 || textBox2.Text.Length==0)
            {
                MessageBox.Show("Lütfen ilgili yerleri doldurunuz...");
            }
            else
            {
                frm2.Show();//eğer  kullanıcı doğru giriş yaptıysa form2 ye geçsin dedim..
                this.Hide();//form1 i gizle
                Musteri musteri = new Musteri();
                musteri.Ad = textBox1.Text;
                musteri.Soyad = textBox2.Text;
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text=="ozanvncn"&&textBox4.Text=="1234")
            {
                frm3.Show();//eğer  kullanıcı doğru giriş yaptıysa form2 ye geçsin dedim..
                this.Hide();//form1 i gizle
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız...");
            }
        }
    }
}
