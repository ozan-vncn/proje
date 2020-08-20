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
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "ozanvncn" && textBox4.Text == "1234")
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
