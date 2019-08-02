using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Program
    {
        static Random rnd = new Random();

        public static Sekil SekilOlustur()
        {
            Sekil retSekil = null;
            int secim = Program.rnd.Next(1, 4);

            switch (secim)
            {
                case 1:
                    int boyut = Program.rnd.Next(1, 20);
                    retSekil = new Kare(boyut);
                    break;
                case 2:
                    int taban = Program.rnd.Next(1, 20);
                    int yukseklik = Program.rnd.Next(1, 20);
                    retSekil = new Ucgen(taban, yukseklik);
                    break;
                case 3:
                    taban = Program.rnd.Next(1, 20);
                    int tavan = Program.rnd.Next(1, 20);
                    yukseklik = Program.rnd.Next(1, 20);
                    retSekil = new Yamuk(taban, tavan, yukseklik);
                    break;
            }

            return retSekil;
        }

        static void Main(string[] args)
        {

            int diziBoyut = 10;

            Sekil[] sekiller = new Sekil[diziBoyut];

            for(int i = 0; i < diziBoyut; i++)
            {
                sekiller[i] = SekilOlustur();
                sekiller[i].Yazdir();
            }

            //Ucgen uc1 = new Ucgen(20, 30);

            //uc1.Yazdir();

            //Kare k1 = new Kare(39);

            //k1.x = 10;
            //k1.y = 20;

            //k1.Yazdir();

            //Sekil s2 = k1;

            //s2.Yazdir();

            //Sekil sekil1 = uc1;

            //sekil1.Yazdir();

            //int diziBoyutu = 10;

            //Sekil[] sekiller = new Sekil[diziBoyutu];

            //sekiller[0] = new Ucgen(10, 20);

            //sekiller[0].x = 20;
            //sekiller[0].y = 40;


        }
    }
}
