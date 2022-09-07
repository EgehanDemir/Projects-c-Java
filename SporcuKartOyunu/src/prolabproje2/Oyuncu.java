package prolabproje2;

import java.util.ArrayList;

public class Oyuncu {

    String oyuncuID;
    String oyuncuAdi;
    int skor;
    

    public Oyuncu(String oyuncuID, String oyuncuAdi, int skor) {
        this.oyuncuID = oyuncuID;
        this.oyuncuAdi = oyuncuAdi;
        this.skor = skor;

    }

    
    public Oyuncu() {
        this("Bilgi Yok", "Bilgi Yok", 0);
        
    }

    public String getOyuncuID() {
        return oyuncuID;
    }

    public void setOyuncuID(String oyuncuID) {
        this.oyuncuID = oyuncuID;
    }

    public String getOyuncuAdi() {
        return oyuncuAdi;
    }

    public void setOyuncuAdi(String oyuncuAdi) {
        this.oyuncuAdi = oyuncuAdi;
    }

    public int getSkor() {
        return skor;
    }

    public void setSkor(int skor) {
        this.skor = skor;
    }

    public void SkorGoster() {
        System.out.println();
    }

    public int kartSec() {
        return 0;
    }

}
