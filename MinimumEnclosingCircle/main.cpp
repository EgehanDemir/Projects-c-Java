/*Projeyi Calistirabilmek icin ve Calistirmadan once yapilmasi gerekenler:
1-koordinatal() fonksiyonundaki "dosyalar.txt" dosyasinin sizde acik oldugundan ve ayni isimde baska bir dosyanin olmadigindan emin olunuz.
2-Eger "dosyalar.txt" dosyasi bilgisayarinizda yoksa koordinatal() fonksiyonundaki FILE *filep=fopen("dosyalar.txt","w") yaparak yani
write modunda acabilirsiniz.
3-"w" modunda actiginiz "dosyalar.txt" isimli dosyan�n modunu "r" yani "read" moduna cevirmeniz gerekmektedir.
4-Bunlar� yaptiktan sonra yapmaniz gerekebilecek en onemli sey kod parcasindaki ilk 3 fonksiyonu (yani cemberciz() fonksiyonu haric hepsini)
cemberciz() FONKS�YONUNU DAHIL ETMEDEN ONCE SADECE 1 KEREL�G�NE CALISTIRMANIZ GEREKEBILIR.
5-Eger koordinatal() fonksiyonunu �LK ONCE mainde cagirip sirasiyla 1,2,3 adimli islemleri yapmazsaniz kodunuz calismayabilir.
6-Bu ad�mlar� sirasiyla dikkatli bir sekilde yaptiktan sonra kodunuzu rahat bir sekilde kullanabilirsiniz.*/

#include <graphics.h>
#include <stdlib.h>
#include <stdio.h>
#include <math.h>
#include <string.h>

struct cember//x ve y noktalar�n� bir koordinat dizisi icinde tutmay� saglar.(17-21)
{
    float x;
    float y;
} koordinatlar[50];
float uzaklik(float c, float d)//Alinan noktalarin uzaklik hesabini d�nd�r�r.(22-27)
{

    return (sqrt(abs(c*c)+abs(d*d)));

}

int koordinatsayisi()//Girilen koordinat sayisini d�nd�r�r.(29-44)
{
    FILE *fp = fopen("koordinatlar.txt","r");//Dosyadan girilen koordinatlarin sayimi yapilabilmesi icin "r" momdunda ayn� dosya acildi.

    char *buff= (char*)malloc(50*sizeof(char));
    int sayac=0;
    while(fgets(buff,50,fp)!=NULL)//fgets fonksiyonu girilen koordinatlarin dinamik bir dizi yapisi ile satir satir okunmasini saglar.
    {

        sayac++;
    }
    free(buff);
    fclose(fp);
    return sayac;

}


float koordinatal(float m,float t)
{

    FILE *filep = fopen("koordinatlar.txt","r");//"koordinatlar.txt" dosyas� acildi ve "r","read" moduna getirildi.
    int n=koordinatsayisi();
    printf("Koordinat sayisi: %d\n",n);

    for(int i=0; i<n+3; i++)     //Dosyadan istenecek struct dizisine atama yap�labilmesi i�in atanacak 2 nokta tan�mland�.(56-58)
    {
        m=koordinatlar[i].x;
        t=koordinatlar[i].y;
    }


    if(filep == NULL)
    {
        printf("Dosya Acilamadi.");
    }
    if(filep!=NULL)
    {
        int j;
        printf("Dosya acildi. \n");

        printf("Lutfen koordinatlari 2 nokta arasina virgul koyarak txt dosyasina giriniz ! \n.");
        for(j=0; j<=n; j++)
        {
            fscanf(filep,"%f,%f",&koordinatlar[j].x,&koordinatlar[j].y);//Dosyaya girilecek koordinatlari aralarina "," koyarak yaz.


        }
        printf("...........Girilen Koordinatlar...........\n");
        for(j=0; j<n; j++)
        {

            printf("{%.2f,%.2f} \n",koordinatlar[j].x,koordinatlar[j].y);//Dosyaya girilen koordinatlar ayni sekilde "," ile basilir.
        }
        printf("\n");
        for(j=0; j<n; j++)
        {
            return koordinatlar[j].x;//koordinatlar[].x ve koordinatlar[].y dizilerini sirasiyla dondur.
            return koordinatlar[j].y;
        }

        fclose(filep);
    }
}
void cembercizdir()
{
    float noktalar_x[999],noktalar_y[999],e,f;
    float X=0;
    float Y=0;
    int i,noktasayisi;
    noktasayisi=koordinatsayisi();
    koordinatlar[0].x=koordinatal(*noktalar_x,*noktalar_y);
    for(i=0; i<noktasayisi; i++)
    {
        noktalar_x[i]=koordinatlar[i].x;
        noktalar_y[i]=koordinatlar[i].y;
    }


// Kullan�c�dan al�nan x ve y d�zlemindeki noktalar�n ayr� ayr� toplam� al�nd�,X ve Y'ye atand�.(100-115)
    for(i=0; i<noktasayisi; i++)
    {
        X+=noktalar_x[i];
        Y+=noktalar_y[i];

    }
//  x ve y koordinatlar�n�n toplam�(X,Y) nokta say�s�na b�l�nerek a��rl�k merkezi bulundu.(117-118)
    X/=noktasayisi;
    Y/=noktasayisi;

    float p=0.01;
    for(i=0; i<9999; i++)
    {
        int u=0;
        e=uzaklik(X-noktalar_x[0],Y-noktalar_y[0]);//A��rl�k merkezine en uzak nokta uzaklik fonksiyonu ile girilen ilk nokta kabul ediliyor.
        for(int j=1; j<noktasayisi; j++)// d�ng�ye 1.indisten ba�lanarak a��rl�k merkezine ger�ekten en uzak noktan�n indisi belirleniyor.(125-134)
        {
            f=uzaklik(X-noktalar_x[j],Y-noktalar_y[j]);
            if(e<f)
            {
                e=f;
                u=j;

            }
        }
        X+=(noktalar_x[u]-X)*p;
        Y+=(noktalar_y[u]-Y)*p;
        p=p*0.999;
        u++;
    }
    printf("Cemberin merkez koordinatlari: {%.3f,%.3f}\n",X,Y);
    printf("Cemberin yaricapi: %.3f\n",e);

    initwindow(850,650,"Minimum Enclosing Circle",0,0);
    char sayi1[100];
    char sayi2[100];
    int a=-14;



    for(i=15; i<=830;)
    {

        if(a!=0)
        {
            sprintf(sayi1,"%d",a);
            outtextxy(i,247,sayi1);

        }

        a++;
        i+=20;

    }
    int b=11;
    for(i=15; i<630;)
    {

        if(b!=0)
        {
            sprintf(sayi2,"%d",b);
            outtextxy(307,i,sayi2);

        }

        b--;
        i+=20;

    }

    //Koordinat cizimindeki her detay(181-190)
    line(5,240,840,240);
    line(300,5,300,640);
    line(295,10,300,5);
    line(300,5,305,10);
    line(295,635,300,640);
    line(300,640,305,635);
    line(5,240,10,245);
    line(10,235,5,240);
    line(840,235,845,240);
    line(845,240,840,245);
    for(i=20; i<830;)//Noktalar�n gosterilmesi icin koordinat uzerine cizilen kucuk cizgiler.(191-200)
    {
        line(i,235,i,245);
        i+=20;
    }
    for(i=20; i<630;)
    {
        line(295,i,305,i);
        i+=20;
    }
    int j;
    for(j=20; j<=820; )//Koordinattaki her bir birim aralikta kac pixel oldugunu g�sterir(202-212)
    {
        putpixel(j,240,RED);
        j+=2;
    }
    for(j=20; j<=620; )
    {
        putpixel(300,j,RED);
        j+=2;

    }
    // Grafik penceresinde merkez i�aretlendi ve sol �st k��eye yar��ap ve merkez koordinatlar�n�n de�erleri yaz�ld�.
    outtextxy(X*20+300,240-Y*20,"M");
    char yrr[3];
    float no=e;
    sprintf(yrr,"%.2f",no);
    outtextxy(80,20,yrr);
    outtextxy(20,20,"Yaricap:");
    outtextxy(20,35,"Merkez:{");
    char m1[3];
    sprintf(m1,"%.2f",X);
    outtextxy(82,35,m1);
    outtextxy(120,35,",");
    char m2[3];
    sprintf(m2,"%.2f",Y);
    outtextxy(124,35,m2);
    outtextxy(160,35,"}");



    circle(X*20+300,240-Y*20,e*20);



    for(j=0; j<=noktasayisi; j++)//Girilen noktalar koordinat d�zleminde g�sterildi.(236-247)
    {
        putpixel(noktalar_x[j]*20+300,240-noktalar_y[j]*20,RED);
    }
    for (int i = 0; i < noktasayisi; i++)
    {
        setcolor(RED);

        fillellipse(noktalar_x[i]*20+300, 240-noktalar_y[i]*20,3,3);
    }
    setcolor(RED);
    fillellipse(X*20+300, 240-Y*20, 4, 4);


    getch();
    closegraph();



}


int main()
{
    cembercizdir();

    return 0;
}
