package prolabproje2;

import java.util.Scanner;


public class Basketbolcu extends Sporcu{
    private String Basketbolcuadi;
    private String Basketbolcutakim;

    public Basketbolcu(String sporcuisim, String sporcutakim) {
        super(sporcuisim, sporcutakim);
        
    }
    
     public String getBasketbolcuadi() {
        return Basketbolcuadi;
    }

    public void setBasketbolcuadi(String Basketbolcuadi) {
        this.Basketbolcuadi = Basketbolcuadi;
    }

    public String getBasketbolcutakim() {
        return Basketbolcutakim;
    }

    public void setBasketbolcutakim(String Basketbolcutakim) {
        this.Basketbolcutakim = Basketbolcutakim;
    }

    @Override
    public int sporcuPuaniGoster(int ikilik, int ucluk, int serbestAtis) {
        int hareketsayisi;
        Scanner scanner = new Scanner(System.in);
        System.out.println("---------------------------------------");
        String hareketler = "1. Hareket(ikilik)\n"
                           + "2. Hareket(Üçlük)\n"
                           + "3. Hareket(Serbest Atış)";
        System.out.println("---------------------------------------");
        System.out.println("Lutfen secmek istediğiniz harekete basınız: " + hareketler);

        hareketsayisi = scanner.nextInt();
        if (hareketsayisi == 1) {

            System.out.println(getBasketbolcuadi() + " isimli basketbolcunun ikilik puanı: " + ikilik);
            return ikilik;
        } else if (hareketsayisi == 2) {
        System.out.println(getBasketbolcuadi() + " isimli basketbolcunun üçlük puanı: " + ucluk);
        return ucluk;
        } else if (hareketsayisi == 3) {
         System.out.println(getBasketbolcuadi() + " isimli basketbolcunun Serbest Atış puanı: " + serbestAtis);
            return serbestAtis;
        } else {
            System.out.println("Yanlış tuşlama yaptınız...");
        }
       return 0;
    }

    
    
}
