using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWind_ORM.Entity;
using NorthWind_ORM.Facade;
namespace NorthWindUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori ktg = new Kategori();
            ktg.KategoriAdi = txtAdi.Text;
            ktg.Tanimi = txtTanimi.Text;
            bool sonuc = Kategoriler.Insert(ktg);
            if (sonuc)
            {
                MessageBox.Show("Islem basarili dostum");
                KategoriListele();
            } 

            else
            {
                MessageBox.Show("Islem basarisiz");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriListele();

        }

        private void KategoriListele()
        {
            dataGridView1.DataSource = Kategoriler.Select();
            dataGridView1.Columns["KategoriID"].Visible = false;
        }
    }
}
