
package prolabproje2;

import java.util.Scanner;



public class Kullanıcı extends Oyuncu {

    public Kullanıcı(String oyuncuID, String oyuncuAdi, int skor) {
        super(oyuncuID, oyuncuAdi, skor);
        System.out.println(oyuncuID);
        System.out.println(oyuncuAdi);
    }

    public Kullanıcı() {
    super();
    Scanner scanner = new Scanner(System.in);
    this.oyuncuAdi ="Kullanıcı İsmi: ";
    oyuncuAdi = scanner.nextLine();
    this.oyuncuID ="1 = ";
    this.skor=0;
    
    }
    
    
    @Override
    public int kartSec() {
        return 0; //To change body of generated methods, choose Tools | Templates.
    }

    
    
 
}
