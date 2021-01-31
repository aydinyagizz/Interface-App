using System;

namespace InterfaceApp
{
    class Program
    {
        //interface'ler new'lenemezler.
        static void Main(string[] args)
        {
            //IPersonmanager musteriEkleme = new MusteriEkleme();

            //IPersonmanager personelEkleme = new PersonelEkleme();

            ProjeyiYonetmeYeri projeyiYonetmeYeri = new ProjeyiYonetmeYeri();
            projeyiYonetmeYeri.Ekleme(new StajyerYoneticisi());
            projeyiYonetmeYeri.Guncelleme(new MusteriYoneticisi());


            Console.ReadKey();

        }


        interface IPersonmanager
        {
            
            //unimplement operation

            void Add();

            void Update();
        }

        class MusteriYoneticisi : IPersonmanager
        {
            public void Add()
            {
                //Müşteri ekleme kodları.
                Console.WriteLine("Müşteri Eklendi.");
            }

            public void Update()
            {
                //Müşteri güncelleme kodları.
                Console.WriteLine("Müşteri Güncellendi.");
            }
        }

        class PersonelYonticisi : IPersonmanager
        {
            public void Add()
            {
                //Personel ekleme kodları.
                Console.WriteLine("Personel Eklendi.");
            }

            public void Update()
            {
                //Personel güncelleme kodları.
                Console.WriteLine("Personel Güncellendi.");
            }
        }

        class StajyerYoneticisi : IPersonmanager
        {
            public void Add()
            {
                //Stajyer ekleme kodları.
                Console.WriteLine("Stajyer Eklendi.");
            }

            public void Update()
            {
                //Stajyer güncelleme kodları.
                Console.WriteLine("Stajyer Güncellendi.");
            }
        }

        class ProjeyiYonetmeYeri 
        {
            public void Ekleme(IPersonmanager personManager )
            {
                personManager.Add();
            }

            public void Guncelleme(IPersonmanager personManager)
            {
                personManager.Update();
            }

        }


    }
}
