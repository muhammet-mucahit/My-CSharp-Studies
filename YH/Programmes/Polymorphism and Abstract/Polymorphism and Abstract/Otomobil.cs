using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Abstract
{
    class Otomobil:Urun // kalitim aldiysan base sniftaki abstact elemanlarin burda tanimlanmasi zorunludur yoksa bu sinifta abstract olur.
    {                   // derleyici kabul etmiyor zaten sanirim
        public string Uretici { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }

        public override void Yazdir()
        {
            Console.WriteLine("{0} - {1} - {2}", Uretici, Model,Fiyat);
        }

        //public override void Yazdir()
        //{
        //    throw new NotImplementedException(); // bunu kendi yazdi urunun altinda kutucuk cikti ve kendi bunu olusturdu.
        //}
    }
}
