using System;
using System.Collections.Generic;

namespace OgrenciYonetimUygulamasi_G022
{
    class Program
    {

        static List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        static void Main(string[] args)
        {
            SahteVeriGir();
            Uygulama();
        }

        static void Uygulama()
        {
            Menu();
            while (true)
            {
                string secim = SecimAl();
                switch (secim)
                {
                    case "1":
                    case "E":
                        OgrenciEkle();
                        break;
                    case "2":
                    case "L":
                        OgrenciListele();
                        break;
                    case "3":
                    case "S":
                        OgrenciSil();
                        break;
                    case "4":
                    case "X":
                        //
                        break;
                }
                Console.WriteLine();
            }
        }

        static string SecimAl()
        {
            Console.Write("Seçiminiz: ");
            string giris = Console.ReadLine().ToUpper();
            return giris;
        }









        static void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması");
            Console.WriteLine("1 - Öğrenci Ekle(E)       ");
            Console.WriteLine("2 - Öğrenci Listele(L)    ");
            Console.WriteLine("3 - Öğrenci Sil(S)        ");
            Console.WriteLine("4 - Çıkış(X)              ");
            Console.WriteLine();
        }







        static void OgrenciEkle()
        {
            //buraya yeni bir öğrenci nesnesi açın
            Ogrenci o = new Ogrenci();
            Console.WriteLine("1- Öğrenci Ekle--------");
            Console.WriteLine("Öğrencinin");
            Console.Write("No: ");
            o.No = int.Parse(Console.ReadLine());
            Console.Write("Adı: ");
            o.Ad = Console.ReadLine();
            Console.Write("Soyadı: ");
            o.Soyad = Console.ReadLine();
            Console.Write("Şube: ");
            o.Sube = Console.ReadLine();

            Console.WriteLine("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H)");
            string secim = Console.ReadLine();
            if (secim.ToUpper() == "E")
            {
                Ogrenciler.Add(o);
                Console.WriteLine("Öğrenci eklendi.");
            }
            else
            {
                Console.WriteLine("Öğrenci eklenmedi.");
            }
        }
        static void OgrenciListele()
        {
            Console.WriteLine("2- Öğrenci Listele");
            Console.WriteLine();
            Console.WriteLine("Şube     No       Ad Soyad");
            Console.WriteLine("-----------------------------");
            foreach (Ogrenci item in Ogrenciler)
            {
                Console.WriteLine(item.Sube + "        " + item.No + "       " + item.Ad + " " + item.Soyad);
            }

        }

        static void OgrenciSil()
        {
            Console.WriteLine("3- Öğrenci Sil ---------");
            Console.WriteLine("Silmek istediğiniz öğrencinin");
            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());
            Ogrenci ogr = null;
            foreach (Ogrenci item in Ogrenciler) //öğrenciyi bulmak için döngü var
            {
                if (item.No == no)
                {
                    ogr = item;
                    break;
                }
            }
            if (ogr != null)
            {
                Console.WriteLine("Adı: " + ogr.Ad);
                Console.WriteLine("Soyadı: " + ogr.Soyad);
                Console.WriteLine("Şubesi: " + ogr.Sube);
                Console.WriteLine("Öğrenciyi silmek istediğinize emin misiniz? (E/H)");
                string secim = Console.ReadLine();
                if (secim.ToUpper() == "E")
                {
                    Ogrenciler.Remove(ogr);
                    Console.WriteLine("Öğrenci silindi.");
                }
                else
                {
                    Console.WriteLine("Öğrenci silinmedi.");
                }
            }
            else
            {
                Console.WriteLine("Listede böyle bir öğrenci yok.");
            }
        }

        static void SahteVeriGir()
        {
            Ogrenci o1 = new Ogrenci();
            o1.No = 12;
            o1.Ad = "Ayla";
            o1.Soyad = "Akın";
            o1.Sube = "A";
            Ogrenciler.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Burak";
            o2.Soyad = "Beyaz";
            o2.No = 45;
            o2.Sube = "B";
            Ogrenciler.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Neşe";
            o3.Soyad = "Can";
            o3.No = 23;
            o3.Sube = "B";
            Ogrenciler.Add(o3);

        }
    }
}
