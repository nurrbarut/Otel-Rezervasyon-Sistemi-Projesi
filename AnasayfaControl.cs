using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class AnasayfaControl : UserControl
    {
        public AnasayfaControl()
        {
            InitializeComponent();
        }

        private void AnasayfaControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Tarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Lbl_Saat.Text = DateTime.Now.ToString("HH:mm");
            Lbl_Tarih.Visible = true;
            Lbl_Saat.Visible = true;
            int saat = DateTime.Now.Hour;
            if ((saat >= 18 || saat < 6))
            {
                Lbl_Mesaj.Text = "İYİ AKŞAMLAR,";
            }
            else
            {
                Lbl_Mesaj.Text = "İYİ GÜNLER,";
            }
            Lbl_Mesaj.Visible = true;
        }
    }
}
