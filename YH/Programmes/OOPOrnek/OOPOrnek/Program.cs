using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // throw new exception("") = Uyari mesaji verir, programa cikti verdirmez run time error gibi uyari verir.
            // bir degiskeni eger ozellik kullaniyorsa onu sadece ozellik kullanmak zorundadir fonksiyonda falan da hep ozellikle o degiskene ulasilir.
            // classin icindeki fonksiyon private olsa bile class daki diger fonksiyonlar tarafindan kullanilabilir.
            // Bir class dosyasinin icinde birden fazla class tanimlanabilir ama goruntu ve okunabilirlik icin hos olmaz.
            // kompozisyon yaparsak eger baska bir sinifta mesela araba.motor = v6 araba da class motor da class ;) motorun degiskenlerine de erisebiliyon.
            // DateTime.Now == simdiki zamani verir
            // cw yazip iki defa taba bas console.writeline gelir. (kisa yollar var iste ogrenirsin ;) codesnippet ;) tabi kullan tabi :D ogren ! ! !
            // Immediate window -- debug yaparken baya ise yariyor bak
            // new kelimesiyle ayni isimli iki fonksiyon yazilabilir kalitim da iki farkli sinifta
            // base classtaki fonksiyon virtual turetilmis siniftaki override ;)
            // static bir fonksiyon, ozellik vb ... direkt class ismiyle ulasilabilir referansla cagrilamaz aksi halde sadece referansla erisilebilir ;)
            // static bir methotun, ozelligin vb... icinde static olmayan bisey olamaz.
            // static class tan referans olusturulamaz ;) direkt sinif ismiyle kullanilmalidir. static classin icinde de hersey static olmak zorunda ;)
            // Bir ozellik illa bir degiskene ihtiyac duymaz. sadece get; set; yazsak yeter ;) public string ozellik {get; set;} hepsi bu kadar
            // prop = ozelliklerin codesnippet i ;)
            // enumdan nesne gibi olusturabiliyon mesela BenimRenklerim renk; renk. vs... bunun gibi ;)



                    
        }
    }

    enum BenimRenklerim
    {
        Sari,
        Mavi,
        Yesil,
        Kirmizi
    }
}
