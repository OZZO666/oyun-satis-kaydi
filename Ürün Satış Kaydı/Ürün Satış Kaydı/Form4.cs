using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ürün_Satış_Kaydı
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=urunler.mdb;Persist Security Info=True";
OleDbConnection baglanti = new OleDbConnection(vtyolu);
baglanti.Open();
string ekle = "insert into urunler(urun) values (@urun)";
OleDbCommand komut = new OleDbCommand(ekle, baglanti);
komut.Parameters.AddWithValue("@urun", textBox1.Text);
komut.ExecuteNonQuery();
}

        }
    }
