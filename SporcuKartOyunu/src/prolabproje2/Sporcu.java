package prolabproje2;


import java.util.Scanner;


public class Sporcu {
    private String sporcuisim;
    private String sporcutakim;

    public Sporcu(String sporcuisim, String sporcutakim) {
        this.sporcuisim = sporcuisim;
        this.sporcutakim = sporcutakim;
    }
    public Sporcu(String sporcuisim){
        this(sporcuisim,"Bilgi Yok");
        System.out.println(this.sporcuisim + " isimli futbolcunun takımı : " + this.sporcutakim);
    }
    public Sporcu(){
    this("Bilgi yok","Bilgi Yok");    
    }
    public String getSporcuisim() {
        return sporcuisim;
    }

    public String getSporcutakim() {
        return sporcutakim;
    }

    public void setSporcuisim(String sporcuisim) {
        this.sporcuisim = sporcuisim;
        
       }

    public void setSporcutakim(String Sporcutakim) {
        this.sporcutakim = sporcutakim;
    }

    
    
    public int sporcuPuaniGoster(int a, int b, int c){
        
        return a+b+c;
    }
    
    public int sporcu_hareketleri1(int a ){
        return a;
    }
     public int sporcu_hareketleri2(int a ){
        return a;
    }
      public int sporcu_hareketleri3(int a ){
        return a;
    }
    
        
}
