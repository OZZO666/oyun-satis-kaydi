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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'urunlerDataSet.urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.urunlerDataSet.urunler);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string vtyolu2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=satislar.mdb;Persist Security Info=True";
            OleDbConnection baglanti2 = new OleDbConnection(vtyolu2);
            baglanti2.Open();
            string ekle2 = "insert into alicilar(ad,soyad,urun,eposta) values (@ad,@soyad,@urun,@eposta)";
            OleDbCommand komut2 = new OleDbCommand(ekle2, baglanti2);
            komut2.Parameters.AddWithValue("@ad", textBox1.Text);
            komut2.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut2.Parameters.AddWithValue("@urun", comboBox1.Text);
            komut2.Parameters.AddWithValue("@eposta", textBox3.Text);
            komut2.ExecuteNonQuery();
        }


    }
}
