Projeyi Calistirabilmek icin ve Calistirmadan once yapilmasi gerekenler:
1-koordinatal() fonksiyonundaki "dosyalar.txt" dosyasinin sizde acik oldugundan ve ayni isimde baska bir dosyanin olmadigindan emin olunuz.
2-Eger "dosyalar.txt" dosyasi bilgisayarinizda yoksa koordinatal() fonksiyonundaki FILE *filep=fopen("dosyalar.txt","w") yaparak yani
write modunda acabilirsiniz.
3-"w" modunda actiginiz "dosyalar.txt" isimli dosyanın modunu "r" yani "read" moduna cevirmeniz gerekmektedir.
4-Bunları yaptiktan sonra yapmaniz gerekebilecek en onemli sey kod parcasindaki ilk 3 fonksiyonu (yani cemberciz() fonksiyonu haric hepsini)
cemberciz() FONKSİYONUNU DAHIL ETMEDEN ONCE SADECE 1 KERELİĞİNE CALISTIRMANIZ GEREKEBILIR.
5-Eger koordinatal() fonksiyonunu ilk mainde cagirip sirasiyla 1,2,3 adimli islemleri yapmazsaniz kodunuz calismayabilir.
6-Bu adımları sirasiyla dikkatli bir sekilde yaptiktan sonra kodunuzu rahat bir sekilde kullanabilirsiniz.