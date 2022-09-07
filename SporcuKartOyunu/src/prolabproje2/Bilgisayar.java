/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package prolabproje2;

/**
 *
 * @author egeha
 */
public class Bilgisayar extends Oyuncu {

    public Bilgisayar(String oyuncuID, String oyuncuAdi, int skor) {
        super(oyuncuID, oyuncuAdi, skor);
    }

    public Bilgisayar() {
    super();
            
            this.oyuncuID = "1 ";
            this.oyuncuAdi = "Bilgisayar: ";
            this.skor = 0;
    }
    
}
