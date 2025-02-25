using System;
namespace PersonelProject
{
    abstract class Personel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int SatisSayisi { get; set; }

        public abstract double Maas { get; }
        public abstract void PersonelVerileri();

    }
}
