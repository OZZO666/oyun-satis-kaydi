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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
		
		 OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=satislar.mdb;Persist Security Info=True");
         private void button1_Click(object sender, EventArgs e)
         {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From alicilar");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read()) {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["urun"].ToString());
				ekle.SubItems.Add(oku["eposta"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'satislarDataSet1.alicilar' table. You can move, or remove it, as needed.
            this.alicilarTableAdapter1.Fill(this.satislarDataSet1.alicilar);
            // TODO: This line of code loads data into the 'satislarDataSet.alicilar' table. You can move, or remove it, as needed.
            this.alicilarTableAdapter.Fill(this.satislarDataSet.alicilar);

        }


    }
}
