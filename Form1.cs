using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adisyon_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtAdana.Text = "0";
            kkofte.Text = "0";
            corbam.Text = "0";
            kıymalı.Text = "0";
            kasarlisucugu.Text = "0";
            kiymalikasarlim.Text = "0";
            kusbası.Text = "0";
            karisiki.Text = "0";
            lahmacunu.Text = "0";
            kasarlim.Text = "0";
            sucuklum.Text = "0";
            TxtKola.Text = "0";
            TxtAyran.Text = "0";
            TxtSalgam.Text = "0";
            TxtSu.Text = "0";
        }

        int kasatutar = 0; //başlangıçta tanımlarız çünkü ilk açılışta kasa tutar 0 olur 
        private void button1_Click(object sender, EventArgs e)
        {
            int adana, kiremit, corba, kiymali, kasarlisucuk, kiymalikasarli, kusbasi,
                karisik, lahmacun, kasarli, sucuklu, toplam, cola, su, salgam, ayran;

            adana = Convert.ToInt16(TxtAdana.Text);
            kiremit = Convert.ToInt16(kkofte.Text);
            corba = Convert.ToInt16(corbam.Text);
            kiymali = Convert.ToInt16(kıymalı.Text);
            kasarlisucuk = Convert.ToInt16(kasarlisucugu.Text);
            kiymalikasarli = Convert.ToInt16(kiymalikasarlim.Text);
            kusbasi = Convert.ToInt16(kusbası.Text);
            karisik = Convert.ToInt16(karisiki.Text);
            lahmacun = Convert.ToInt16(lahmacunu.Text);
            kasarli = Convert.ToInt16(kasarlim.Text);
            sucuklu = Convert.ToInt16(sucuklum.Text);
            cola = Convert.ToInt16(TxtKola.Text);
            ayran = Convert.ToInt16(TxtAyran.Text);
            salgam = Convert.ToInt16(TxtSalgam.Text);
            su = Convert.ToInt16(TxtSu.Text);


            toplam = adana * 19 + kiremit * 22 + corba * 9 + kiymali * 16 +
                kasarlisucuk * 22 + kiymalikasarli * 19 + kusbasi * 22 +
                karisik * 22 + lahmacun * 9 + kasarli * 19 + sucuklu * 20
            + cola * 5 + ayran * 2 + salgam * 4 + su * 2;

            topla.Text = toplam.ToString() + " ₺";

            kasatutar = kasatutar + toplam;
            kasa.Text = kasatutar.ToString() + " ₺";
        }

        private void button2_Click(object sender, EventArgs e)
        { //temizleyelim textboxları
            TxtAdana.Text = "0";
            kkofte.Text = "0";
            corbam.Text = "0";
            kıymalı.Text = "0";
            kasarlisucugu.Text = "0";
            kiymalikasarlim.Text = "0";
            kusbası.Text = "0";
            karisiki.Text = "0";
            lahmacunu.Text = "0";
            kasarlim.Text = "0";
            sucuklum.Text = "0";
            TxtKola.Text = "0";
            TxtAyran.Text = "0";
            TxtSalgam.Text = "0";
            TxtSu.Text = "0";
            topla.Text = "0";
            TxtAdana.Focus(); //adanaya götürür imleci
        }
    }
}
