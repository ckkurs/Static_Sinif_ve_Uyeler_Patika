using System;

namespace Static_Sinif_ve_Üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Çalışan Sayısı: {0}",Calisan.Calisansayisi);

           Calisan calisan =new Calisan("Ayşe","Yılmaz","IK");
           Console.WriteLine("Çalışan Sayısı: {0}",Calisan.Calisansayisi);

           Calisan calisan1 =new Calisan("Deniz","Arda","IK");
           Calisan calisan2 =new Calisan("Zikriye","Ürkmez","IK");
           Console.WriteLine("Çalışan Sayısı: {0}",Calisan.Calisansayisi);

           //Static class olduğu için nesneyle erişemedim class adıyla eriştim.
           Console.WriteLine("Toplama işlemi sonucu: {0}",Islemler.Topla(100,200));
           Console.WriteLine("Çıkarma işlemi sonucu: {0}",Islemler.Cikar(400,50));


        }
    }

    class Calisan
    {
        //Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
        private static int calisansayisi;
        //Sadece calısan sınıfından değiştirmek istiyorum setini kaldırdım o yüzden
        public static int Calisansayisi { get => calisansayisi;  }

        private string isim;
        private string soyisim;

        private string departman;

        //static kurucuların erişim belirteci olmaz
        static Calisan()
        {
           calisansayisi=0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisansayisi++;
        }
    }

    static class Islemler
    {

        public static long Topla (int sayi1,int sayi2)
        {
           return sayi1 + sayi2;
        }

        public static long Cikar (int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }

    }
}
