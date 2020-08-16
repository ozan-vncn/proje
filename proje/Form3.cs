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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Ad",);
            listView1.Columns.Add("Soyad");
            listView1.Columns.Add("Mail");
            listView1.Columns.Add("Ürün");
            listView1.Columns.Add("Seri No");
            listView1.Columns.Add("Arıza Nedeni");
        }
    }
}
