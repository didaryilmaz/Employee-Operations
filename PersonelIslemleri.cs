using System;
using System.Collections.Generic;

namespace PersonelProject
{
    public static class PersonelIslemleri
    {
        static List<Personel> personels = new List<Personel>();

        public static void PersonelEkle(Personel personel)
        {
            personels.Add(personel);
        }

        public static void PersonelListele()
        {
            foreach (var personel in personels)
            {
                Console.WriteLine(personel.FirstName + " " + personel.Surname);
            }
        }
    }
}
