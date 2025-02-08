using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;

namespace OtelRezervasyonSistemi
{
    public partial class Login : Form
    {
        public static string kullaniciadi;

        public Login()
        {
            InitializeComponent();
        }


        public void Btn_GirisYap_Click(object sender, EventArgs e)
        {
            try
            {
 
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=25_132330042;User=25_132330042;Password=!nif.ogr42BA;");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT yonetici_adi, yonetici_soyadi, yonetici_cinsiyet FROM tbl_yonetici WHERE kullaniciadi= @kullaniciadi AND sifre= @sifre",baglanti);
                {
                    komut.Parameters.AddWithValue("@kullaniciadi", TxtKullaniciadi.Text);
                    komut.Parameters.AddWithValue("@sifre", MskdtxtSifre.Text);
                }

                MySqlDataReader okunanlar = komut.ExecuteReader();
                if (okunanlar.Read())
                {
                    string yoneticiAdi = okunanlar["yonetici_adi"].ToString();
                    string yoneticiSoyadi = okunanlar["yonetici_soyadi"].ToString();
                    string cinsiyet = okunanlar["yonetici_cinsiyet"].ToString();
                    YoneticiAnaSayfa yoneticiGiris = new YoneticiAnaSayfa(cinsiyet, yoneticiAdi, yoneticiSoyadi);
                    yoneticiGiris.Show();

                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre yanlýþ, lütfen tekrar giriþ yapýnýz!");
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Baðlantý kurulamadý!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MskdtxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                MskdtxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void Lbl_SifremiUnuttum_Click(object sender, EventArgs e)
        {
            string gKullaniciAdi = TxtKullaniciadi.Text;
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum(gKullaniciAdi);
            sifremiUnuttum.Show();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
