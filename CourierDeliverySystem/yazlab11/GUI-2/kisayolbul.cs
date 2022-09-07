using GeoCoordinatePortable;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using yazlab11.GUI_2;

namespace yazlab11
{
    class kisayolbul
    {

        public string Find(List<Pozisyonlar> teslimNoktaları)
        {
            int[,] kus_ucusu = new int[teslimNoktaları.Count, teslimNoktaları.Count];
            int[,] temp_kusucusu = new int[teslimNoktaları.Count, teslimNoktaları.Count];
            for (int x = 0; x < teslimNoktaları.Count; x++)
            {
                for (int y = 0; y < teslimNoktaları.Count ; y++)
                {
                    if(x == y)
                    {
                        kus_ucusu[x,y] = 0;
                    }
                    else
                    {

                        PointLatLng first = new PointLatLng(teslimNoktaları[x].KargoEnlem, teslimNoktaları[x].KargoBoylam);
                        PointLatLng second = new PointLatLng(teslimNoktaları[y].KargoEnlem, teslimNoktaları[y].KargoBoylam);
                        kus_ucusu[x, y] = getBirdDistance(first, second);                        
                    }
                }
            }

            temp_kusucusu = kus_ucusu;

            string en_kısa_mesafe = "";
            int en_kısa_yol = 999999999;
            int en_uzak_dugum = 0;
            int en_uzak_mesafe = 0;
            int sayac=1;
            int temp2 = 0;

            for(int temp_en_uzak_dugum = 1; temp_en_uzak_dugum < teslimNoktaları.Count-1; temp_en_uzak_dugum++)
            {
                kus_ucusu = temp_kusucusu;
                sayac = 1;
                int toplam = 0;
                int temp=-1;

                string temp_en_kısa_mesafe = "";

                while (sayac != teslimNoktaları.Count)
                {
                    int ilk_dugum = 0;
                    int ilk_gidilecek_dugum = -1;
                    int ilk_dugum_gitme_mesafe = 999999999;

                    for (int i = 0; i < teslimNoktaları.Count; i++)
                    {  
                        if (kus_ucusu[ilk_dugum, i] + kus_ucusu[i, temp_en_uzak_dugum] < ilk_dugum_gitme_mesafe
                           && i != ilk_dugum && i != temp_en_uzak_dugum)
                        { 
                            ilk_gidilecek_dugum = i;
                            ilk_dugum_gitme_mesafe = kus_ucusu[ilk_dugum, i] + kus_ucusu[i, temp_en_uzak_dugum];
                            temp2 = kus_ucusu[ilk_dugum, i];
                        }
                    }
                    temp_en_kısa_mesafe+=" "+ilk_gidilecek_dugum;
                    toplam += temp2;
                    kus_ucusu[ilk_dugum, ilk_gidilecek_dugum] = 99999999;
                    kus_ucusu[ilk_gidilecek_dugum, temp_en_uzak_dugum] = 99999999;
                    sayac++;
                    temp = ilk_gidilecek_dugum;
                    if(sayac == teslimNoktaları.Count - 1)
                    {
                        if (toplam < en_kısa_yol)
                        {
                            en_kısa_yol = toplam;
                            en_kısa_mesafe = temp_en_kısa_mesafe;
                            en_uzak_dugum = temp_en_uzak_dugum;
                        }
                    }
                }

            }

            return "0" + en_kısa_mesafe +" " +en_uzak_dugum.ToString();
        }

        private int getBirdDistance(PointLatLng first, PointLatLng second)
        {
            GeoCoordinate baslangicNoktasi = new GeoCoordinate(first.Lat, first.Lng);

            GeoCoordinate teslimatNoktası = new GeoCoordinate(second.Lat, second.Lng);

            return (int)(baslangicNoktasi.GetDistanceTo(teslimatNoktası));
        }
    }
}
