using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast___Polimorphism
{
    class Program
    {
        static public Kare SolaKareYerlestir(Sekil s1)
        {
            Kare ret = new Kare();

            int x = s1.x - 20;
            int y = s1.y;

            ret.x = x;
            ret.y = y;

            return ret;
        }
        static void Main(string[] args)
        {

            // UPCAST

            //Kare kare = new Kare();

            //kare.x = 15;
            //kare.y = 20;

            //Sekil sekil1 = kare;

            //sekil1.yazdir();

            //sekil1.x = 45;
            //sekil1.y = 50;

            //sekil1.yazdir();
            //kare.yazdir();

            //int diziBoyutu = 10;
            //Sekil[] sekiller = new Sekil[diziBoyutu];

            //sekiller[0] = new Ucgen();

            //sekiller[0].x = 20;
            //sekiller[0].y = 40;
            //sekiller[0].yazdir();

            //sekiller[1] = SolaKareYerlestir(sekiller[0]);
            //sekiller[1].yazdir();

            //sekiller[2] = SolaKareYerlestir(sekiller[1]);
            //sekiller[2].yazdir();

            //sekiller[3] = SolaKareYerlestir(sekiller[2]);
            //sekiller[3].yazdir();

            //for (int i = 0; i < sekiller.Length; i++)
            //{
            //    if (sekiller[i] != null)
            //        sekiller[i].yazdir();
            //}

            //DOWNCAST // O sekille ilgili ozel bilgilere yani sekillere ait bilgilere erismek istedigimizde kullaniriz

            int diziBoyutu = 10;
            Sekil[] sekiller = new Sekil[diziBoyutu];

            sekiller[0] = new Ucgen();

            sekiller[0].x = 20;
            sekiller[0].y = 40;

            Ucgen uc1 = (Ucgen)sekiller[0];

            uc1.taban = 15;
            uc1.yukseklik = 20;

            sekiller[2] = null; // silmek icin bunu kullaniriz

            for (int i = 0; i < sekiller.Length; i++)
            {
                if (sekiller[i] != null)
                {
                    if (sekiller[i] is Ucgen) // eleman bir ucgen ise if in icine girecek bu sekilde turunu anlayabiliriz.
                    {
                        sekiller[i].yazdir();
                    }
                }    
            }
        }
    }
}
