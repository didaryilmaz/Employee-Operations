using System;
namespace PersonelProject
{
    class YariZamanliPersonel : Personel
    {
        public int calistigiSaat { get; set; }
        public int saatUcreti { get; set; }
        double komisyon = 0.01;

        public override double Maas
        {
            get
            {
                return (calistigiSaat * saatUcreti) + SatisSayisi * komisyon; ;
            }

        }


        public override void PersonelVerileri()
        {
            Console.WriteLine(FirstName + " " + Surname + " " + Maas);
        }

    }
}
