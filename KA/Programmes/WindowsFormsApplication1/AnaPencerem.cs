using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class AnaPencerem:Form
    {

        private Button m_BtnTikla;
        private Button m_BtnTiklama;
        private RadioButton m_Rdb1;
        private RadioButton m_Rdb2;
        private RadioButton m_Rdb3;
        private RadioButton m_Rdb4;
        private GroupBox m_Grp1;
        private GroupBox m_Grp2;
        public int sayi;
        public int x = 100;
        public int y = 100;
        public int width = 0;
        public int height = 0;
        Kare karem = new Kare();
        bool cizimAktifmi = false;
        public int maxKareSayisi = 100;
        Sekil[] sekiller;
        //Kare[] kareler;  
        int sekilSayisi = 0;
        //int kareSayisi = 0;

        Sekil aktifSekil = null;

        public AnaPencerem(int height, int width)
        {
            sekiller = new Sekil[maxKareSayisi];
            //kareler = new Kare[maxKareSayisi];
            //kareler = new Sekil[maxKareSayisi];

            //for (int i = 0; i < 10; i++)
            //{
            //    kareler[i] = new Kare();
            //    kareler[i].x = 50 * i;
            //    kareler[i].y = 30 * i;
            //    kareler[i].width = 50;
            //    kareler[i].height = 50;
            //}
                

            DoubleBuffered = true; // daha iyi cizim icin ise yariyor.

            Height = height;
            Width = width;
            Text = "Mucahit Aktepe";

            FormElemanlariOlustur();

            Paint += AnaPencerem_Paint;

            MouseDown += AnaPencerem_MouseDown;
            MouseMove += AnaPencerem_MouseMove;
            MouseUp += AnaPencerem_MouseUp;

            karem.width = 100;
            //karem.height = 100;
        }

        void AnaPencerem_MouseUp(object sender, MouseEventArgs e)
        {
            cizimAktifmi = false;

            if (sekilSayisi != maxKareSayisi - 1)
                sekiller[sekilSayisi] = aktifSekil;
                //kareler[kareSayisi] = karem;

            sekilSayisi++;
            //kareSayisi++;
            Invalidate();

            //karem = new Kare();
        }

        void AnaPencerem_MouseMove(object sender, MouseEventArgs e)
        {
            if (cizimAktifmi)
            {
                aktifSekil.bitisAta(e.X, e.Y); 
                //karem.width = e.X - karem.X;
                //karem.height = e.Y - karem.y;
            }
            
            //width = e.X - x;
            //height = e.Y - y;

            Invalidate();

            //x = e.X;
            //y = e.Y;

            //Invalidate();
        }

        void AnaPencerem_MouseDown(object sender, MouseEventArgs e)
        {
            if (sayi % 3 == 0)
                aktifSekil = new Kare();
            else if (sayi % 2 == 0)
                aktifSekil = new Daire();
            else
                aktifSekil = new Dikdortgen();

            //karem = new Kare();
            cizimAktifmi = true;
            aktifSekil.X = e.X;
            aktifSekil.Y = e.Y;
            //karem.X = e.X;
            //karem.Y = e.Y;
            //x = e.X;
            //y = e.Y;

            Invalidate();
        }

        void AnaPencerem_Paint(object sender, PaintEventArgs e)
        {
            Graphics cizimAraci = e.Graphics;

            for (int i = 0; i < sekilSayisi; i++)
            {
                sekiller[i].Ciz(cizimAraci);
                //kareler[i].Ciz(cizimAraci);
            }

            if(aktifSekil != null)
                aktifSekil.Ciz(cizimAraci);

            //karem.Ciz(cizimAraci);
            //cizimAraci.DrawRectangle(Pens.Blue, x, y, width, height);

            sayi++;

            Text = sayi.ToString();
        }

        private void FormElemanlariOlustur()
        {
            m_BtnTikla = new Button();
            m_BtnTikla.Text = "TIKLA";
            m_BtnTikla.SetBounds(100, 100, 200, 50);
            m_BtnTikla.Click += m_BtnTikla_Click;
            
            m_BtnTiklama = new Button();
            m_BtnTiklama.Text = "TIKLAMA";
            m_BtnTiklama.Click += m_BtnTikla_Click;

            m_Rdb1 = new RadioButton();
            m_Rdb2 = new RadioButton();
            m_Rdb3 = new RadioButton();
            m_Rdb4 = new RadioButton();

            m_Rdb1.Text = "m_Rdb1";
            m_Rdb2.Text = "m_Rdb2";
            m_Rdb3.Text = "m_Rdb3";
            m_Rdb4.Text = "m_Rdb4";

            m_Rdb1.SetBounds(10, 30, 100, 20);
            m_Rdb2.SetBounds(10, 50, 100, 20);
            m_Rdb3.SetBounds(10, 30, 100, 20);
            m_Rdb4.SetBounds(10, 50, 100, 20);

            m_Grp1 = new GroupBox();
            m_Grp2 = new GroupBox();

            m_Grp1.SetBounds(200, 200, 200, 200);
            m_Grp1.Text = "Grup 1";

            m_Grp2.SetBounds(400, 200, 200, 200);
            m_Grp2.Text = "Grup 1";

            m_Rdb1.CheckedChanged += m_Rdb1_CheckedChanged;

            //m_Grp1.Controls.Add(m_Rdb1);
            //m_Grp1.Controls.Add(m_Rdb2);
            //m_Grp2.Controls.Add(m_Rdb3);
            //m_Grp2.Controls.Add(m_Rdb4);

            //Controls.Add(m_BtnTikla);
            //Controls.Add(m_BtnTiklama);
            //Controls.Add(m_Grp1);
            //Controls.Add(m_Grp2);
        }

        void m_Rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if(m_Rdb1.Checked == true)
                MessageBox.Show("Merhaba");
        }

        void m_BtnTikla_Click(object sender, EventArgs e)
        {
            if (m_BtnTiklama == sender)
            {
                MessageBox.Show("Merhaba tiklama butonuna tikladiniz");
            }
            else
            {
                if (m_Rdb1.Checked == true)
                    MessageBox.Show("Rdb1 Secildi");
                if (m_Rdb2.Checked == true)
                    MessageBox.Show("Rdb2 Secildi");
                if (m_Rdb3.Checked == true)
                    MessageBox.Show("Rdb3 Secildi");
                if (m_Rdb4.Checked == true)
                    MessageBox.Show("Rdb4 Secildi");
                
                //MessageBox.Show("Merhaba butona tikladiniz");
            }
        }


        //public AnaPencerem(int height, int width)
        //{
        //    Height = height;
        //    Width = width;

        //    Text = "Mucahit Aktepe";

        //    MouseClick += AnaPencerem_MouseClick;
        //    MouseMove += AnaPencerem_MouseMove;
        //    MouseDown += AnaPencerem_MouseDown;
        //    MouseUp += AnaPencerem_MouseUp;
        //}

        //void AnaPencerem_MouseUp(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show("Fare Birakildi");
            
        //}

        //void AnaPencerem_MouseDown(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show("Fare Basili");
            
        //}

        //void AnaPencerem_MouseMove(object sender, MouseEventArgs e)
        //{
        //    Text = e.X + ", " + e.Y;
            
        //}

        //private void AnaPencerem_MouseClick(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show(e.X + ", " + e.Y);
            
        //}
    }
}
