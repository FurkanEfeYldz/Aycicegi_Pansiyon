﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon_Uygulaması
{
    public partial class FrmSifreGuncelleme : Form
    {
        public FrmSifreGuncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2FGBHR3\\SQLEXPRESS;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "' ,Sifre='" + TxtSifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void FrmSifreGuncelleme_Load(object sender, EventArgs e)
        {

        }
    }
}
