using System;
namespace PersonelProject
{
    class TamZamanliPersonel : Personel
    {
        public int TabanUcret { get; set; }

        public override double Maas
        {
            get
            {
                double prim = 0;

                if (SatisSayisi < 100000)
                {
                    prim = SatisSayisi * 0.01;
                }
                else if (SatisSayisi < 200000 && SatisSayisi > 100000)
                {
                    prim = SatisSayisi * 0.03;
                }
                else
                {
                    prim = SatisSayisi * 0.05;
                }
                return TabanUcret + prim;
            }
        }


        public override void PersonelVerileri()
        {
            Console.WriteLine(FirstName + " " + Surname + " " + Maas);
        }
    }
}
