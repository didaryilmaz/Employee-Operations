using System;
using System.Collections.Generic;
using System.Text;
using PersonelProject;


namespace PersonelProject
{
    class Program
    {
        public static void Main()
        {
            TamZamanliPersonel personel1 = new TamZamanliPersonel { FirstName="didar", Surname = "yilmaz", SatisSayisi = 100, TabanUcret=1000};
            TamZamanliPersonel personel2 = new TamZamanliPersonel { FirstName = "melike", Surname = "yilmaz", SatisSayisi = 200, TabanUcret = 1000 };
            TamZamanliPersonel personel3 = new TamZamanliPersonel { FirstName = "sevda", Surname = "yilmaz", SatisSayisi = 300, TabanUcret = 1000 };


            YariZamanliPersonel personel4 = new YariZamanliPersonel { FirstName = "ahmet", Surname = "yilmaz", SatisSayisi = 400, calistigiSaat = 8, saatUcreti = 200 };
            YariZamanliPersonel personel5 = new YariZamanliPersonel { FirstName = "mehmet", Surname = "yilmaz", SatisSayisi = 500, calistigiSaat = 8, saatUcreti = 200 };
            YariZamanliPersonel personel6 = new YariZamanliPersonel { FirstName = "ali", Surname = "yilmaz", SatisSayisi = 600, calistigiSaat = 8, saatUcreti = 200 };


            PersonelIslemleri.PersonelEkle(personel1);
            PersonelIslemleri.PersonelEkle(personel2);
            PersonelIslemleri.PersonelEkle(personel3);
            PersonelIslemleri.PersonelEkle(personel4);

            PersonelIslemleri.PersonelListele();


        }
    }

}
