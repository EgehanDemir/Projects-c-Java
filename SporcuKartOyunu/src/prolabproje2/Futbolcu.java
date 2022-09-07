package prolabproje2;

import java.util.Scanner;

public class Futbolcu extends Sporcu {

    
    private String FutbolcuTakim;
    private String FutbolcuAdi;

    public Futbolcu(String FutbolcuAdi, String FutbolcuTakim, String sporcuisim, String sporcutakim) {
        super(sporcuisim, sporcutakim);
        this.FutbolcuTakim = FutbolcuTakim;
        this.FutbolcuAdi = FutbolcuAdi;
        
    }
    public Futbolcu(){
        super();
    }

    public Futbolcu(String FutbolcuAdi,String FutbolcuTakim,  String sporcuisim) {
        super(sporcuisim);
        this.FutbolcuTakim = FutbolcuTakim;
        this.FutbolcuAdi = FutbolcuAdi;
    }

    public Futbolcu(String sporcuisim, String sporcutakim) {
        super(sporcuisim, sporcutakim);
    }

    public Futbolcu(String sporcuisim) {
        super(sporcuisim);
    }

    public String getFutbolcuAdi() {
        return FutbolcuAdi;
    }

    public String getFutbolcuTakim() {
        return FutbolcuTakim;
    }

    public void setFutbolcuAdi(String FutbolcuAdi) {
        this.FutbolcuAdi = FutbolcuAdi;
    }

    public void setFutbolcuTakim(String FutbolcuTakim) {
        this.FutbolcuTakim = FutbolcuTakim;
    }

    @Override
    public int sporcuPuaniGoster(int pen, int serbestatis, int kkk) {
        int hareketsayisi;
        Scanner scanner = new Scanner(System.in);
        System.out.println("---------------------------------------");
        String hareketler = "1. Hareket(penaltı)\n"
                           + "2. Hareket(serbestAtis)\n"
                           + "3. Hareket(kaleciKarsiKarsiya";
        System.out.println("---------------------------------------");
        System.out.println("Lutfen secmek istediğiniz harekete basınız: " + hareketler);

        hareketsayisi = scanner.nextInt();
        if (hareketsayisi == 1) {
          System.out.println(getSporcuisim() + " isimli futbolcunun penalti puanı: " + pen);
            return pen;
        } else if (hareketsayisi == 2) {
         System.out.println(getSporcuisim() + " isimli futbolcunun Serbest Atış puanı: " + serbestatis);
            return serbestatis;
        } else if (hareketsayisi == 3) {
         System.out.println(getSporcuisim() + " isimli futbolcunun kaleci ile Karşı karşıya puanı: " + kkk);
            return kkk;
        } else {
            System.out.println("Yanlış tuşlama yaptınız...");
         
        }
      return 0;
    }

    @Override
    public int sporcu_hareketleri3(int kkk) {
        return kkk; //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int sporcu_hareketleri2(int serbestatis) {
        return serbestatis; //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int sporcu_hareketleri1(int pen) {
        return pen; //To change body of generated methods, choose Tools | Templates.
    }
    

}
