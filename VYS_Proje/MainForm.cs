using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Npgsql;

namespace VYS_Proje
{
    public partial class MainForm : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=VYS_Database; user ID=postgres; password=3648");
        string query;
        public MainForm()
        {
            InitializeComponent();
        }
        private void IlDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Il\" order by \"ilNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "ilAdi";
            comboBox.ValueMember = "ilNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void FiloDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Filo\" order by \"filoNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "adi";
            comboBox.ValueMember = "filoNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void MusteriDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Musteri\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"Musteri\".\"kisiNo\" order by \"Kisi\".\"kisiNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "adi";
            comboBox.ValueMember = "kisiNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void MusteriNoDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Musteri\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"Musteri\".\"kisiNo\" order by \"Kisi\".\"kisiNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "kisiNo";
            comboBox.ValueMember = "kisiNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void ServisDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"TeknikServis\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"TeknikServis\".\"kisiNo\" order by \"Kisi\".\"kisiNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "adi";
            comboBox.ValueMember = "kisiNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void ServisNoDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"TeknikServis\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"TeknikServis\".\"kisiNo\" order by \"Kisi\".\"kisiNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "kisiNo";
            comboBox.ValueMember = "kisiNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void TemsilciDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"SatisTemsilcisi\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"SatisTemsilcisi\".\"kisiNo\" order by \"Kisi\".\"kisiNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "adi";
            comboBox.ValueMember = "kisiNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void TemsilciNoDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"SatisTemsilcisi\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"SatisTemsilcisi\".\"kisiNo\" order by \"Kisi\".\"kisiNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "kisiNo";
            comboBox.ValueMember = "kisiNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void KategoriDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Kategori\" order by \"kategoriNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "ad";
            comboBox.ValueMember = "kategoriNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void BakimNoDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"UrunBakim\" order by \"bakimNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "bakimNo";
            comboBox.ValueMember = "bakimNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void AracDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Arac\" order by \"aracNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "aracPlaka";
            comboBox.ValueMember = "aracNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void AracNoDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Arac\" order by \"aracNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "aracNo";
            comboBox.ValueMember = "aracNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void UrunDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Urun\" order by \"urunKodu\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "adi";
            comboBox.ValueMember = "urunKodu";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void UrunNoDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Urun\" order by \"urunKodu\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "urunKodu";
            comboBox.ValueMember = "urunKodu";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void MusteriUrunNoDoldur(ComboBox comboBox)
        {
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"MusteriUrun\" order by \"musteriUrunNo\" asc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DisplayMember = "musteriUrunNo";
            comboBox.ValueMember = "musteriUrunNo";
            comboBox.DataSource = dt;
            connection.Close();
        }
        private void MusteriListele()
        {
            query = "select \"Kisi\".\"kisiNo\" as \"No\", \"Kisi\".\"adi\" as \"Adı\",\"Kisi\".\"soyadi\" as \"Soyadı\",\"Musteri\".\"kimlikNo\" as \"Kimlik Numarası\", \"IletisimBilgileri\".\"telefon\" as \"Telefon Numarası\", \"IletisimBilgileri\".\"adres\" as \"Adres\", \"Il\".\"ilAdi\" as \"İl \" from \"Kisi\" inner join \"Musteri\" on \"Kisi\".\"kisiNo\"=\"Musteri\".\"kisiNo\" inner join \"IletisimBilgileri\" on \"IletisimBilgileri\".\"kisiNo\"=\"Kisi\".\"kisiNo\" inner join \"Il\" on \"Il\".\"ilNo\"=\"IletisimBilgileri\".\"ilNo\" order by \"Kisi\".\"kisiNo\" asc;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Musteri.DataSource = ds.Tables[0];
        }
        private void TemsilciListele()
        {
            query = "select \"Kisi\".\"kisiNo\" as \"No\",\"Kisi\".\"adi\" as \"Adı\",\"Kisi\".\"soyadi\" as \"Soyadı\",\"SatisTemsilcisi\".\"kidem\" as \"Kıdem\", \"IletisimBilgileri\".\"telefon\" as \"Telefon Numarası\", \"IletisimBilgileri\".\"adres\" as \"Adres\", \"Il\".\"ilAdi\" as \"İl \" from \"Kisi\" inner join \"SatisTemsilcisi\" on \"Kisi\".\"kisiNo\"=\"SatisTemsilcisi\".\"kisiNo\" inner join \"IletisimBilgileri\" on \"IletisimBilgileri\".\"kisiNo\"=\"Kisi\".\"kisiNo\" inner join \"Il\" on \"Il\".\"ilNo\"=\"IletisimBilgileri\".\"ilNo\" order by \"Kisi\".\"kisiNo\" asc;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Temsilci.DataSource = ds.Tables[0];
        }
        private void ServisListele()
        {
            query = "select \"Kisi\".\"kisiNo\" as \"No\",\"Kisi\".\"adi\" as \"Adı\",\"Kisi\".\"soyadi\" as \"Soyadı\",\"Arac\".\"aracPlaka\" as \"Araç Plakası\", \"Arac\".\"aracTipi\" as \"Araç Tipi\", \"IletisimBilgileri\".\"telefon\" as \"Telefon Numarası\", \"IletisimBilgileri\".\"adres\" as \"Adres\", \"Il\".\"ilAdi\" as \"İl \" from \"Kisi\" inner join \"TeknikServis\" on \"Kisi\".\"kisiNo\"=\"TeknikServis\".\"kisiNo\" inner join \"IletisimBilgileri\" on \"IletisimBilgileri\".\"kisiNo\"=\"Kisi\".\"kisiNo\" inner join \"Il\" on \"Il\".\"ilNo\"=\"IletisimBilgileri\".\"ilNo\" inner join \"Arac\" on \"TeknikServis\".\"aracNo\"=\"Arac\".\"aracNo\" order by \"Kisi\".\"kisiNo\" asc;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Servis.DataSource = ds.Tables[0];
        }
        private void AracListele()
        {
            query = "select \"Arac\".\"aracNo\" as \"No\",\"Arac\".\"aracPlaka\" as \"Araç Plakası\",\"Arac\".\"aracTipi\" as \"Araç Tipi\",\"Filo\".\"adi\" as \"Filo Adı\", \"Filo\".\"telefon\" as \"Filo Telefon\", \"Filo\".\"adres\" as \"Filo Adres\" from \"Arac\" inner join \"Filo\" on \"Arac\".\"filoNo\"=\"Filo\".\"filoNo\"  order by \"Arac\".\"aracNo\" asc;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Arac.DataSource = ds.Tables[0];
        }
        private void UrunListele()
        {
            query = "select \"Urun\".\"urunKodu\" as \"No\",\"Urun\".\"adi\" as \"Ürün Adı\",\"Urun\".\"referansFiyati\" as \"Referans Fiyatı\",\"Kategori\".\"ad\" as \"Kategori\" from \"Urun\" inner join \"Kategori\" on \"Urun\".\"kategoriNo\"=\"Kategori\".\"kategoriNo\"  order by \"Urun\".\"urunKodu\" asc;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Urun.DataSource = ds.Tables[0];
        }
        private void MusteriUrunListele()
        {
            query = "select \"MusteriUrun\".\"musteriUrunNo\" as \"No\",\"Urun\".\"adi\" as \"Ürün Adı\", \"Urun\".\"urunKodu\" as \"Ürün Kodu\",\"Kisi\".\"adi\" as \"Adı\",\"Kisi\".\"soyadi\" as \"Soyadı\" from \"MusteriUrun\" inner join \"Urun\" on \"Urun\".\"urunKodu\"=\"MusteriUrun\".\"urunKodu\" inner join \"Kisi\" on \"MusteriUrun\".\"musteriNo\"=\"Kisi\".\"kisiNo\" order by \"MusteriUrun\".\"musteriUrunNo\" asc;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_MusteriUrun.DataSource = ds.Tables[0];
        }
        private void SiparisListele()
        {
            query = "select \"Siparis\".\"siparisNo\" as \"No\", \"Kisi\".\"adi\" as \"Müşteri Adı\", \"Kisi\".\"soyadi\" as \"Müşteri Soyadı\", \"Urun\".\"adi\" as \"Ürün Adı\", \"Siparis\".\"siparisTarihi\" as \"Sipariş Tarihi\", \"Odeme\".\"toplamTutar\" as \"Tutar\", \"Odeme\".\"odemeTuru\" as \"Ödeme Türü\" ,\"Siparis\".\"servisNo\" as \"Servis No\", \"Siparis\".\"temsilciNo\" as \"Temsilci No\" from \"Siparis\" inner join \"SiparisUrun\" on \"SiparisUrun\".\"siparisNo\"=\"Siparis\".\"siparisNo\" inner join \"Urun\" on \"SiparisUrun\".\"urunKodu\"=\"Urun\".\"urunKodu\" inner join \"Odeme\" on \"Siparis\".\"odemeNo\"=\"Odeme\".\"odemeNo\" inner join \"Musteri\" on \"Musteri\".\"kisiNo\"=\"Siparis\".\"musteriNo\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"Musteri\".\"kisiNo\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Siparis.DataSource = ds.Tables[0];
        }
        private void UrunBakimListele()
        {
            query = "select \"UrunBakim\".\"bakimNo\" as \"No\", \"Kisi\".\"adi\" as \"Müşteri Adı\", \"Kisi\".\"soyadi\" as \"Müşteri Soyadı\", \"Urun\".\"adi\" as \"Ürün Adı\", \"MusteriUrun\".\"urunKodu\" as \"Ürün Kodu\", \"UrunBakim\".\"servisTarihi\" as \"Servis Tarihi\", \"UrunBakim\".\"servisNo\" as \"Servis No\", \"Odeme\".\"toplamTutar\" as \"Toplam Tutar\", \"Odeme\".\"odemeTuru\" as \"Ödeme Türü\" from  \"UrunBakim\" inner join \"MusteriUrun\" on \"UrunBakim\".\"musteriUrunNo\"=\"MusteriUrun\".\"musteriUrunNo\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"MusteriUrun\".\"musteriNo\" inner join \"Urun\" on \"MusteriUrun\".\"urunKodu\"=\"Urun\".\"urunKodu\" inner join \"Odeme\" on \"Odeme\".\"odemeNo\"=\"UrunBakim\".\"odemeNo\";";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_UrunBakim.DataSource = ds.Tables[0];
        }
        private void KayitSayisiListele()
        {
            query = "select * from \"MusteriKayitTakip\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lbl_EklenenKayit.Text = ds.Tables[0].Rows[0]["eklenenkayit"].ToString();
            lbl_SilinenKayit.Text = ds.Tables[0].Rows[0]["silinenkayit"].ToString();
        }
        private void UrunSayisiListele()
        {
            query = "select * from \"UrunSayilari\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lbl_AritmaSayisi.Text = ds.Tables[0].Rows[0]["aritma"].ToString();
            lbl_SupurgeSayisi.Text = ds.Tables[0].Rows[0]["supurge"].ToString();
            lbl_KombiSayisi.Text = ds.Tables[0].Rows[0]["kombi"].ToString();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MusteriListele();
            TemsilciListele();
            ServisListele();
            AracListele();
            UrunListele();
            SiparisListele();
            UrunBakimListele();
            IlDoldur(cmb_MusteriIl);
            MusteriNoDoldur(cmb_MusteriNo);
            IlDoldur(cmb_TemsilciIl);
            TemsilciNoDoldur(cmb_TemsilciNo);
            IlDoldur(cmb_ServisIl);
            ServisNoDoldur(cmb_ServisNo);
            AracDoldur(cmb_ServisArac);
            AracNoDoldur(cmb_AracNo);
            FiloDoldur(cmb_AracFilo);
            KategoriDoldur(cmb_UrunKategori);
            UrunNoDoldur(cmb_UrunNo);
            MusteriDoldur(cmb_SiparisMusteri);
            TemsilciDoldur(cmb_SiparisTemsilci);
            ServisDoldur(cmb_SiparisServis);
            UrunDoldur(cmb_SiparisUrun);
            ServisNoDoldur(cmb_BakimServis);
            MusteriUrunNoDoldur(cmb_MusteriUrunNo);
            BakimNoDoldur(cmb_BakimNo);
            MusteriUrunListele();
            KayitSayisiListele();
            UrunSayisiListele();
        }

        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select musteriEkle(@p1, @p2, @p3, @p4, @p5, @p6);", connection);
            command.Parameters.AddWithValue("@p1", txt_MusteriAd.Text);
            command.Parameters.AddWithValue("@p2", txt_MusteriSoyad.Text);
            command.Parameters.AddWithValue("@p3", txt_MusteriKimlik.Text);
            command.Parameters.AddWithValue("@p4", txt_MusteriTelefon.Text);
            command.Parameters.AddWithValue("@p5", rtb_MusteriAdres.Text);
            command.Parameters.AddWithValue("@p6", cmb_MusteriIl.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarıyla eklendi.");
            MusteriListele();
            connection.Close();
            MusteriNoDoldur(cmb_MusteriNo);
            MusteriDoldur(cmb_SiparisMusteri);
            KayitSayisiListele();
        }

        private void btn_MusteriSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select kisisil(@p1);", connection);
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(cmb_MusteriNo.SelectedValue));
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla silindi.");
                MusteriListele();
                KayitSayisiListele();
            }
            catch
            {
                MessageBox.Show("Bu müşteri bir sipariş veya ürün ile bağlı.");
            }
            connection.Close();
            MusteriNoDoldur(cmb_MusteriNo);
            MusteriDoldur(cmb_SiparisMusteri);
        }

        private void btn_MusteriGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select musteriguncelle(@p1, @p2, @p3, @p4, @p5, @p6, @p7);", connection);
            command.Parameters.AddWithValue("@p1", cmb_MusteriNo.SelectedValue);
            command.Parameters.AddWithValue("@p2", txt_MusteriAd.Text);
            command.Parameters.AddWithValue("@p3", txt_MusteriSoyad.Text);
            command.Parameters.AddWithValue("@p4", txt_MusteriKimlik.Text);
            command.Parameters.AddWithValue("@p5", txt_MusteriTelefon.Text);
            command.Parameters.AddWithValue("@p6", rtb_MusteriAdres.Text);
            command.Parameters.AddWithValue("@p7", cmb_MusteriIl.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarıyla güncellendi.");
            MusteriListele();
            SiparisListele();
            MusteriUrunListele();
            connection.Close();
            MusteriNoDoldur(cmb_MusteriNo);
            MusteriDoldur(cmb_SiparisMusteri);
        }

        private void btn_MusteriAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = $"select \"Kisi\".\"kisiNo\" as \"No\", \"Kisi\".\"adi\" as \"Adı\",\"Kisi\".\"soyadi\" as \"Soyadı\",\"Musteri\".\"kimlikNo\" as \"Kimlik Numarası\", \"IletisimBilgileri\".\"telefon\" as \"Telefon Numarası\", \"IletisimBilgileri\".\"adres\" as \"Adres\", \"Il\".\"ilAdi\" as \"İl\" from \"Kisi\",\"Musteri\",\"IletisimBilgileri\",\"Il\" where \"Kisi\".\"kisiNo\"=\"Musteri\".\"kisiNo\" and \"IletisimBilgileri\".\"kisiNo\"=\"Musteri\".\"kisiNo\" and \"Il\".\"ilNo\"=\"IletisimBilgileri\".\"ilNo\" and \"Kisi\".\"adi\" LIKE '{txt_MusteriAd.Text}%' AND \"Kisi\".\"soyadi\" LIKE '{txt_MusteriSoyad.Text}%' AND \"Musteri\".\"kimlikNo\" LIKE '{txt_MusteriKimlik.Text}%' AND \"IletisimBilgileri\".\"telefon\" LIKE '{txt_MusteriTelefon.Text}%' AND \"IletisimBilgileri\".\"ilNo\"={cmb_MusteriIl.SelectedValue} AND \"IletisimBilgileri\".\"adres\" LIKE '{rtb_MusteriAdres.Text}%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Musteri.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btn_TemsilciEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select temsilciekle(@p1, @p2, @p3, @p4, @p5, @p6);", connection);
            command.Parameters.AddWithValue("@p1", txt_TemsilciAd.Text);
            command.Parameters.AddWithValue("@p2", txt_TemsilciSoyad.Text);
            command.Parameters.AddWithValue("@p3", txt_TemsilciKidem.Text);
            command.Parameters.AddWithValue("@p4", txt_TemsilciTelefon.Text);
            command.Parameters.AddWithValue("@p5", rtb_TemsilciAdres.Text);
            command.Parameters.AddWithValue("@p6", cmb_TemsilciIl.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Temsilci başarıyla eklendi.");
            TemsilciListele();
            connection.Close();
            TemsilciNoDoldur(cmb_TemsilciNo);
            TemsilciDoldur(cmb_SiparisTemsilci);
        }

        private void btn_TemsilciSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select kisisil(@p1);", connection);
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(cmb_TemsilciNo.SelectedValue));

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Temsilci başarıyla silindi.");
                TemsilciListele();
            }
            catch
            {
                MessageBox.Show("Bu temsilci bir satış ile bağlı.");
            }

            connection.Close();
            TemsilciNoDoldur(cmb_TemsilciNo);
            TemsilciDoldur(cmb_SiparisTemsilci);

        }

        private void btn_TemsilciGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select temsilciguncelle(@p1, @p2, @p3, @p4, @p5, @p6, @p7);", connection);
            command.Parameters.AddWithValue("@p1", cmb_TemsilciNo.SelectedValue);
            command.Parameters.AddWithValue("@p2", txt_TemsilciAd.Text);
            command.Parameters.AddWithValue("@p3", txt_TemsilciSoyad.Text);
            command.Parameters.AddWithValue("@p4", txt_TemsilciKidem.Text);
            command.Parameters.AddWithValue("@p5", txt_TemsilciTelefon.Text);
            command.Parameters.AddWithValue("@p6", rtb_TemsilciAdres.Text);
            command.Parameters.AddWithValue("@p7", cmb_TemsilciIl.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Temsilci başarıyla güncellendi.");
            TemsilciListele();
            connection.Close();
            TemsilciNoDoldur(cmb_TemsilciNo);
            TemsilciDoldur(cmb_SiparisTemsilci);
        }

        private void btn_TemsilciAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = $"select \"Kisi\".\"kisiNo\" as \"No\",\"Kisi\".\"adi\" as \"Adı\",\"Kisi\".\"soyadi\" as \"Soyadı\",\"SatisTemsilcisi\".\"kidem\" as \"Kıdem\", \"IletisimBilgileri\".\"telefon\" as \"Telefon Numarası\", \"IletisimBilgileri\".\"adres\" as \"Adres\", \"Il\".\"ilAdi\" as \"İl \" from \"Kisi\" inner join \"SatisTemsilcisi\" on \"Kisi\".\"kisiNo\"=\"SatisTemsilcisi\".\"kisiNo\" inner join \"IletisimBilgileri\" on \"IletisimBilgileri\".\"kisiNo\"=\"Kisi\".\"kisiNo\" inner join \"Il\" on \"Il\".\"ilNo\"=\"IletisimBilgileri\".\"ilNo\" where \"Kisi\".\"adi\" LIKE '{txt_TemsilciAd.Text}%' AND \"Kisi\".\"soyadi\" LIKE '{txt_TemsilciSoyad.Text}%' AND \"SatisTemsilcisi\".\"kidem\" LIKE '{txt_TemsilciKidem.Text}%' AND \"IletisimBilgileri\".\"telefon\" LIKE '{txt_TemsilciTelefon.Text}%' AND \"IletisimBilgileri\".\"ilNo\"={cmb_TemsilciIl.SelectedValue} AND \"IletisimBilgileri\".\"adres\" LIKE '{rtb_TemsilciAdres.Text}%' ;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Temsilci.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btn_ServisEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select servisekle(@p1, @p2, @p3, @p4, @p5, @p6);", connection);
            command.Parameters.AddWithValue("@p1", txt_ServisAd.Text);
            command.Parameters.AddWithValue("@p2", txt_ServisSoyad.Text);
            command.Parameters.AddWithValue("@p3", cmb_ServisArac.SelectedValue);
            command.Parameters.AddWithValue("@p4", txt_ServisTelefon.Text);
            command.Parameters.AddWithValue("@p5", rtb_ServisAdres.Text);
            command.Parameters.AddWithValue("@p6", cmb_ServisIl.SelectedValue);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Servis başarıyla eklendi.");
            ServisListele();
            connection.Close();
            ServisNoDoldur(cmb_ServisNo);
            ServisDoldur(cmb_SiparisServis);
            ServisNoDoldur(cmb_BakimServis);
        }

        private void btn_ServisSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select kisisil(@p1);", connection);
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(cmb_ServisNo.SelectedValue));
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Servis başarıyla silindi.");
                ServisListele();
            }
            catch
            {
                MessageBox.Show("Bu servis bir satış veya bakım ile bağlı.");
            }
            connection.Close();
            ServisNoDoldur(cmb_ServisNo);
            ServisDoldur(cmb_SiparisServis);
            ServisNoDoldur(cmb_BakimServis);
        }

        private void btn_ServisGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select servisguncelle(@p1, @p2, @p3, @p4, @p5, @p6, @p7);", connection);
            command.Parameters.AddWithValue("@p1", cmb_ServisNo.SelectedValue);
            command.Parameters.AddWithValue("@p2", txt_ServisAd.Text);
            command.Parameters.AddWithValue("@p3", txt_ServisSoyad.Text);
            command.Parameters.AddWithValue("@p4", cmb_ServisArac.SelectedValue);
            command.Parameters.AddWithValue("@p5", txt_ServisTelefon.Text);
            command.Parameters.AddWithValue("@p6", rtb_ServisAdres.Text);
            command.Parameters.AddWithValue("@p7", cmb_ServisIl.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Servis başarıyla güncellendi.");
            ServisListele();
            UrunBakimListele();
            connection.Close();
            ServisNoDoldur(cmb_ServisNo);
            ServisDoldur(cmb_SiparisServis);
            ServisNoDoldur(cmb_BakimServis);
        }

        private void btn_ServisAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = $"select \"Kisi\".\"kisiNo\" as \"No\",\"Kisi\".\"adi\" as \"Adı\",\"Kisi\".\"soyadi\" as \"Soyadı\",\"Arac\".\"aracPlaka\" as \"Araç Plakası\", \"Arac\".\"aracTipi\" as \"Araç Tipi\", \"IletisimBilgileri\".\"telefon\" as \"Telefon Numarası\", \"IletisimBilgileri\".\"adres\" as \"Adres\", \"Il\".\"ilAdi\" as \"İl \" from \"Kisi\" inner join \"TeknikServis\" on \"Kisi\".\"kisiNo\"=\"TeknikServis\".\"kisiNo\" inner join \"IletisimBilgileri\" on \"IletisimBilgileri\".\"kisiNo\"=\"Kisi\".\"kisiNo\" inner join \"Il\" on \"Il\".\"ilNo\"=\"IletisimBilgileri\".\"ilNo\" inner join \"Arac\" on \"TeknikServis\".\"aracNo\"=\"Arac\".\"aracNo\" where \"Kisi\".\"adi\" LIKE '{txt_ServisAd.Text}%' AND \"Kisi\".\"soyadi\" LIKE '{txt_ServisSoyad.Text}%' AND \"TeknikServis\".\"aracNo\"={cmb_ServisArac.SelectedValue} AND \"IletisimBilgileri\".\"telefon\" LIKE '{txt_ServisTelefon.Text}%' AND \"IletisimBilgileri\".\"ilNo\"={cmb_ServisIl.SelectedValue} AND \"IletisimBilgileri\".\"adres\" LIKE '{rtb_ServisAdres.Text}%' ;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Servis.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btn_AracEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into \"Arac\"(\"aracPlaka\",\"aracTipi\",\"filoNo\") values (@p1, @p2, @p3);", connection);
            command.Parameters.AddWithValue("@p1", txt_AracPlaka.Text);
            command.Parameters.AddWithValue("@p2", txt_AracTipi.Text);
            command.Parameters.AddWithValue("@p3", cmb_AracFilo.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Araç başarıyla eklendi.");
            AracListele();
            connection.Close();
            AracNoDoldur(cmb_AracNo);
            AracDoldur(cmb_ServisArac);
        }

        private void btn_AracSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("delete from \"Arac\" where \"aracNo\"=@p1;", connection);
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(cmb_AracNo.SelectedValue));

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Araç başarıyla silindi.");
                AracListele();
            }
            catch
            {
                MessageBox.Show("Bu araç bir servis ile bağlı.");
            }

            connection.Close();
            AracNoDoldur(cmb_AracNo);
            AracNoDoldur(cmb_ServisArac);
        }

        private void btn_AracGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand($"update \"Arac\" set \"aracPlaka\"='{txt_AracPlaka.Text}',\"aracTipi\"='{txt_AracTipi.Text}',\"filoNo\"={cmb_AracFilo.SelectedValue} where \"aracNo\"={cmb_AracNo.SelectedValue};", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Araç başarıyla güncellendi.");
            AracListele();
            connection.Close();
            AracNoDoldur(cmb_AracNo);
            AracDoldur(cmb_ServisArac);
        }

        private void btn_AracAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            query = $"select \"Arac\".\"aracNo\" as \"No\",\"Arac\".\"aracPlaka\" as \"Araç Plakası\",\"Arac\".\"aracTipi\" as \"Araç Tipi\",\"Filo\".\"adi\" as \"Filo Adı\", \"Filo\".\"telefon\" as \"Filo Telefon\", \"Filo\".\"adres\" as \"Filo Adres\" from \"Arac\" inner join \"Filo\" on \"Arac\".\"filoNo\"=\"Filo\".\"filoNo\" where \"Arac\".\"aracPlaka\" LIKE '{txt_AracPlaka.Text}%' AND \"Arac\".\"aracTipi\" LIKE '{txt_AracTipi.Text}%' AND \"Arac\".\"filoNo\"={cmb_AracFilo.SelectedValue} ;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_Arac.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("insert into \"Urun\"(\"adi\",\"referansFiyati\",\"kategoriNo\") values (@p1, @p2, @p3);", connection);
                command.Parameters.AddWithValue("@p1", txt_UrunAd.Text);
                command.Parameters.AddWithValue("@p2", Convert.ToInt64(txt_UrunReferansFiyat.Text));
                command.Parameters.AddWithValue("@p3", cmb_UrunKategori.SelectedValue);
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Referans fiyat boş bırakılamaz.");
            }
            UrunListele();
            UrunSayisiListele();
            connection.Close();
            UrunNoDoldur(cmb_UrunNo);
        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand("delete from \"Urun\" where \"urunKodu\"=@p1;", connection);
                command.Parameters.AddWithValue("@p1", Convert.ToInt32(cmb_UrunNo.SelectedValue));
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla silindi.");
                UrunListele();
            }
            catch
            {
                MessageBox.Show("Bu ürün bir sipariş ile bağlı.");
            }

            connection.Close();
            UrunSayisiListele();
            UrunDoldur(cmb_SiparisUrun);
            UrunNoDoldur(cmb_UrunNo);
        }

        private void btn_UrunGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
            NpgsqlCommand command = new NpgsqlCommand($"update \"Urun\" set \"adi\"='{txt_UrunAd.Text}',\"referansFiyati\"={Convert.ToInt64(txt_UrunReferansFiyat.Text)},\"kategoriNo\"={cmb_UrunKategori.SelectedValue} where \"urunKodu\"={cmb_UrunNo.SelectedValue};", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün başarıyla güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Referans fiyat boş bırakılamaz.");
            }
            UrunListele();
            UrunSayisiListele();
            SiparisListele();
            MusteriUrunListele();
            UrunBakimListele();
            connection.Close();
            UrunNoDoldur(cmb_UrunNo);
            UrunDoldur(cmb_SiparisUrun);
        }

        private void btn_UrunAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                query = $"select \"Urun\".\"urunKodu\" as \"No\",\"Urun\".\"adi\" as \"Ürün Adı\",\"Urun\".\"referansFiyati\" as \"Referans Fiyatı\",\"Kategori\".\"ad\" as \"Kategori\" from \"Urun\" inner join \"Kategori\" on \"Urun\".\"kategoriNo\"=\"Kategori\".\"kategoriNo\" where \"Urun\".\"adi\" LIKE '{txt_UrunAd.Text}%' AND \"Urun\".\"referansFiyati\"={Convert.ToInt64(txt_UrunReferansFiyat.Text)} AND \"Kategori\".\"kategoriNo\"={cmb_UrunKategori.SelectedValue} ;";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_Urun.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Referans fiyatı boş bırakılamaz.");
            }
            connection.Close();
        }

        private void btn_SiparisEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("select siparisekle(@p1, @p2, @p3, @p4, @p5, @p6, @p7);", connection);
                command.Parameters.AddWithValue("@p1", (DateTime.Now).Date);
                command.Parameters.AddWithValue("@p2", cmb_SiparisServis.SelectedValue);
                command.Parameters.AddWithValue("@p3", cmb_SiparisTemsilci.SelectedValue);
                command.Parameters.AddWithValue("@p4", cmb_SiparisMusteri.SelectedValue);
                command.Parameters.AddWithValue("@p5", cmb_SiparisUrun.SelectedValue);
                command.Parameters.AddWithValue("@p6", Convert.ToInt64(txt_SiparisTutar.Text));
                command.Parameters.AddWithValue("@p7", txt_SiparisOdeme.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sipariş başarıyla eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Bu ürün daha önce satılmış.");
            }
            connection.Close();
            SiparisListele();
            MusteriUrunListele();
            connection.Close();
            MusteriUrunNoDoldur(cmb_MusteriUrunNo);
        }

        private void btn_SiparisAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                query = $"select \"Siparis\".\"siparisNo\" as \"No\", \"Kisi\".\"adi\" as \"Müşteri Adı\", \"Kisi\".\"soyadi\" as \"Müşteri Soyadı\", \"Urun\".\"adi\" as \"Ürün Adı\", \"Siparis\".\"siparisTarihi\" as \"Sipariş Tarihi\", \"Odeme\".\"toplamTutar\" as \"Tutar\", \"Odeme\".\"odemeTuru\" as \"Ödeme Türü\" ,\"Siparis\".\"servisNo\" as \"Servis No\", \"Siparis\".\"temsilciNo\" as \"Temsilci No\" from \"Siparis\" inner join \"SiparisUrun\" on \"SiparisUrun\".\"siparisNo\"=\"Siparis\".\"siparisNo\" inner join \"Urun\" on \"SiparisUrun\".\"urunKodu\"=\"Urun\".\"urunKodu\" inner join \"Odeme\" on \"Siparis\".\"odemeNo\"=\"Odeme\".\"odemeNo\" inner join \"Musteri\" on \"Musteri\".\"kisiNo\"=\"Siparis\".\"musteriNo\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"Musteri\".\"kisiNo\" where \"Siparis\".\"musteriNo\"={cmb_SiparisMusteri.SelectedValue} AND \"Siparis\".\"temsilciNo\"={cmb_SiparisTemsilci.SelectedValue} AND \"Siparis\".\"servisNo\"={cmb_SiparisServis.SelectedValue} AND \"Urun\".\"urunKodu\"={cmb_SiparisUrun.SelectedValue} AND \"Odeme\".\"toplamTutar\"={Convert.ToInt64(txt_SiparisTutar.Text)} AND \"Odeme\".\"odemeTuru\" LIKE '{txt_SiparisOdeme.Text}%' ;";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_Siparis.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Tutar boş bırakılamaz.");
            }
            connection.Close();
        }

        private void btn_BakimEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
            NpgsqlCommand command = new NpgsqlCommand("select bakimekle(@p1, @p2, @p3, @p4, @p5);", connection);
            command.Parameters.AddWithValue("@p1", dtp_BakimTarih.Value);
            command.Parameters.AddWithValue("@p2", cmb_BakimServis.SelectedValue);
            command.Parameters.AddWithValue("@p3", cmb_MusteriUrunNo.SelectedValue);
            command.Parameters.AddWithValue("@p4", Convert.ToInt64(txt_BakimTutar.Text));
            command.Parameters.AddWithValue("@p5", txt_BakimOdeme.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Bakım başarıyla eklendi.");

            }
            catch (Exception)
            {
                MessageBox.Show("Tutar boş bırakılamaz.");
            }
            UrunBakimListele();
            connection.Close();
            BakimNoDoldur(cmb_BakimNo);
        }

        private void btn_BakimSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("delete from \"UrunBakim\" where \"bakimNo\"=@p1;", connection);
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(cmb_BakimNo.SelectedValue));

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Bakım başarıyla silindi.");
                UrunListele();
            }
            catch
            {
                MessageBox.Show("Hata");
            }
            UrunBakimListele();
            connection.Close();
            BakimNoDoldur(cmb_BakimNo);
        }

        private void btn_BakimGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
            NpgsqlCommand command = new NpgsqlCommand("select bakimguncelle(@p1, @p2, @p3, @p4, @p5, @p6);", connection);
            command.Parameters.AddWithValue("@p1", dtp_BakimTarih.Value);
            command.Parameters.AddWithValue("@p2", cmb_BakimServis.SelectedValue);
            command.Parameters.AddWithValue("@p3", cmb_MusteriUrunNo.SelectedValue);
            command.Parameters.AddWithValue("@p4", Convert.ToInt64(txt_BakimTutar.Text));
            command.Parameters.AddWithValue("@p5", txt_BakimOdeme.Text);
            command.Parameters.AddWithValue("@p6", cmb_BakimNo.SelectedValue);
            command.ExecuteNonQuery();
            MessageBox.Show("Bakım başarıyla güncellendi.");

            }
            catch (Exception)
            {
                MessageBox.Show("Tutar boş bırakılamaz.");
            }
            UrunBakimListele();
            connection.Close();
        }

        private void btn_BakimAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                query = $"select \"UrunBakim\".\"bakimNo\" as \"No\", \"Kisi\".\"adi\" as \"Müşteri Adı\", \"Kisi\".\"soyadi\" as \"Müşteri Soyadı\", \"Urun\".\"adi\" as \"Ürün Adı\", \"MusteriUrun\".\"urunKodu\" as \"Ürün Kodu\", \"UrunBakim\".\"servisTarihi\" as \"Servis Tarihi\", \"UrunBakim\".\"servisNo\" as \"Servis No\", \"Odeme\".\"toplamTutar\" as \"Toplam Tutar\", \"Odeme\".\"odemeTuru\" as \"Ödeme Türü\" from  \"UrunBakim\" inner join \"MusteriUrun\" on \"UrunBakim\".\"musteriUrunNo\"=\"MusteriUrun\".\"musteriUrunNo\" inner join \"Kisi\" on \"Kisi\".\"kisiNo\"=\"MusteriUrun\".\"musteriNo\" inner join \"Urun\" on \"MusteriUrun\".\"urunKodu\"=\"Urun\".\"urunKodu\" inner join \"Odeme\" on \"Odeme\".\"odemeNo\"=\"UrunBakim\".\"odemeNo\" where \"UrunBakim\".\"musteriUrunNo\"={cmb_MusteriUrunNo.SelectedValue} and \"UrunBakim\".\"servisNo\"={cmb_BakimServis.SelectedValue} and \"Odeme\".\"odemeTuru\" LIKE '{txt_BakimOdeme.Text}%' and \"Odeme\".\"toplamTutar\"={Convert.ToInt64(txt_BakimTutar.Text)};";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_UrunBakim.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Tutar boş bırakılamaz.");
            }
            connection.Close();
        }

        private void btn_MusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void btn_TemsilciListele_Click(object sender, EventArgs e)
        {
            TemsilciListele();
        }

        private void btn_ServisListele_Click(object sender, EventArgs e)
        {
            ServisListele();
        }

        private void btn_AracListele_Click(object sender, EventArgs e)
        {
            AracListele();
        }

        private void btn_UrunListele_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void btn_SiparisListele_Click(object sender, EventArgs e)
        {
            SiparisListele();
        }

        private void btn_BakimListele_Click(object sender, EventArgs e)
        {
            UrunBakimListele();
        }
    }
}
