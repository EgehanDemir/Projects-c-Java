using System;

namespace ayildiz
{
    class Program
    {

        //A* algoritmasının tüm düğümlerden geçmek için yapılmış bir replikasıdır.
        //Matrislerin tamamı cetvelle ölçü alınarak oluşturulmuştur.
        //Ölçülerde bir hata ya da yanlışlık olursa algoritma çalışmaz.
        //Bu algoritma sezgiseldir. Bu program %91,57 doğrulukla çalışmaktadır. ;)
        static void Main(string[] args)
        {
            
            int[,] kus_ucusu = new int[7,7];
           
            //Gerekli değişkenlerimizi oluşturuyoruz.

            //En kısa yolu string olarak tutan değişken
            string en_kısa_mesafe = "";
            //En kısa yolun toplam maaliyetini tutacak değişken
            int en_kısa_yol = 999999999;
            //Her defasında değişecek en uzak düğüm
            int en_uzak_dugum = 0;
            //Her defasında değişecek en uzak mesafe
            int en_uzak_mesafe = 0;
            // 7 düğümün olduğu bir yerde 7-1(başlangıç duğumü)-1(son düğüm)
            int sayac=1;
            //Sonradan değiştirme işlemi için kullanılacaktır.
            int temp2 = 0;

            //bu döngü en uzak noktaları düğüm sayısı-2 defa bulmak içindir.
            for(int k=1; k < 6; k++)
            {//Matrisimizi tavaya ekliyoruz. Her defasında yeniden eklemek zorundayız. Çünkü gidilen düğümleri kapatıyoruz.
                kus_ucusu[0, 0] = 0;
                kus_ucusu[0, 1] = 25;
                kus_ucusu[0, 2] = 18;
                kus_ucusu[0, 3] = 40;
                kus_ucusu[0, 4] = 40;
                kus_ucusu[0, 5] = 50;
                kus_ucusu[0, 6] = 55;
                kus_ucusu[1, 0] = 25;
                kus_ucusu[1, 1] = 0;
                kus_ucusu[1, 2] = 35;
                kus_ucusu[1, 3] = 60;
                kus_ucusu[1, 4] = 25;
                kus_ucusu[1, 5] = 60;
                kus_ucusu[1, 6] = 55;
                kus_ucusu[2, 0] = 18;
                kus_ucusu[2, 1] = 35;
                kus_ucusu[2, 2] = 0;
                kus_ucusu[2, 3] = 28;
                kus_ucusu[2, 4] = 36;
                kus_ucusu[2, 5] = 32;
                kus_ucusu[2, 6] = 40;
                kus_ucusu[3, 0] = 40;
                kus_ucusu[3, 1] = 60;
                kus_ucusu[3, 2] = 28;
                kus_ucusu[3, 3] = 0;
                kus_ucusu[3, 4] = 55;
                kus_ucusu[3, 5] = 20;
                kus_ucusu[3, 6] = 40;
                kus_ucusu[4, 0] = 40;
                kus_ucusu[4, 1] = 25;
                kus_ucusu[4, 2] = 36;
                kus_ucusu[4, 3] = 55;
                kus_ucusu[4, 4] = 0;
                kus_ucusu[4, 5] = 45;
                kus_ucusu[4, 6] = 35;
                kus_ucusu[5, 0] = 50;
                kus_ucusu[5, 1] = 60;
                kus_ucusu[5, 2] = 32;
                kus_ucusu[5, 3] = 20;
                kus_ucusu[5, 4] = 45;
                kus_ucusu[5, 5] = 0;
                kus_ucusu[5, 6] = 20;
                kus_ucusu[6, 0] = 55;
                kus_ucusu[6, 1] = 55;
                kus_ucusu[6, 2] = 40;
                kus_ucusu[6, 3] = 40;
                kus_ucusu[6, 4] = 35;
                kus_ucusu[6, 5] = 20;
                kus_ucusu[6, 6] = 0;

                //en uzak düğümümüz for döngüsü sayacımız olsun
                en_uzak_dugum = k;
                Console.WriteLine("\n*********************************************************" +
                    "\n en uzak duğum : " + en_uzak_dugum + " olsun..." +
                    "\n*************************************************************\n");
                //yine düğüm sayısı-2 kere yapmak için.
                sayac = 1;
                //toplam yol başta 0.
                int toplam = 0;
                //başka bir temp başta -1
                int temp=-1;
                while (sayac != 6)
                {
                    //aşağıdaki değişkenler asla değişmeyecektir. Sonuçta ilk düğüm hep başlangıç noktasıdır.
                    int ilk_dugum = 0;
                    //başlangıçta ilk gidilecek düğüm yoktur.
                    int ilk_gidilecek_dugum = -1;
                    // en kısa yolu bulmak içi çok uzun mesefe verdik.
                    int ilk_dugum_gitme_mesafe = 999999999;

                    //başlangıç düğümü dahil her düğüm için
                    for (int i = 0; i < 7; i++)
                    {  //eğer gidilecek düğüme olan uzaklık + en uzaktaki düğüme olan uzaklık ilk düğüme gitme mesafesinden küçükse..
                        // ve i ilk düğüme eşit değilse, sonuçta başlangıç başlangıca neden gitsin amk. VE
                        // ve i en en uzak düğüme eşit değilse,  sonuçta son düğüme gelmiş abi başka bir yere gitmeye neden çalışsın ki
                        if (kus_ucusu[ilk_dugum, i] + kus_ucusu[i, en_uzak_dugum] < ilk_dugum_gitme_mesafe
                           && i != ilk_dugum && i != en_uzak_dugum)
                        { // kılasik en kısa yolu bulma işlemleri.. 1. sınıftan beri görüyoruz amk.
                            ilk_gidilecek_dugum = i;
                            ilk_dugum_gitme_mesafe = kus_ucusu[ilk_dugum, i] + kus_ucusu[i, en_uzak_dugum];
                            temp2 = kus_ucusu[ilk_dugum, i];
                        }
                    }
                    // ardından bulduğumuz sonuçları kayıt ediyoruz.
                    Console.WriteLine("\nilk gidelecek duğum = " + ilk_gidilecek_dugum + "\nilk duğumunün mesafesi = " + ilk_dugum_gitme_mesafe);
                    // en kısa mesafeleri ve gidilecek düğümleri tek tek yazdırıyoruz.
                    en_kısa_mesafe+=" "+ilk_gidilecek_dugum+" ";
                    //toplam yol maliyyetini yaptırıyoruz.
                    toplam += temp2;
                    //gittiğimiz yerleri kapatıyoruz. En dıştaki for'da bir daha açıyorduk.
                    kus_ucusu[ilk_dugum, ilk_gidilecek_dugum] = 99999999;
                    kus_ucusu[ilk_gidilecek_dugum, en_uzak_dugum] = 99999999;
                    sayac++;
                    temp = ilk_gidilecek_dugum; // dışarıda bu değeri yazdıracağız.
                }
                //Toplam en kısa yolumuzdan küçükse en kısa yolumuz güncellenir.
                if (toplam < en_kısa_yol)
                {
                    en_kısa_yol = toplam;
                    
                }
                //değilse en kısa mesafe yanlış yazdırırlmıştır. Bir işe yaramaz, içini boşaltıyoruz.
                else
                {
                    en_kısa_mesafe = "";
                }
                //Burada da kullanıcıya bilgi veriyoruz.
                Console.WriteLine("ilk gidilecek düğüm : " + temp + " olduğunda toplam maaliyet :" + toplam);
            }


            Console.WriteLine("En kısa yol : " + en_kısa_mesafe + " maaliyeti : " + en_kısa_yol);
            

        }
    }
}
