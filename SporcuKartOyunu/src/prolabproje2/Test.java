package prolabproje2;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;


public class Test {
    public int rastgele_hareket_sec(int hareket){ //Bilgisayarın rastgele kart seçmesi için gerekli method
        Sporcu sporcu = new Futbolcu();
        int k,m,s;
        Random rand = new Random();
        
        for(m=0; m<4 ; m++){
            k =  rand.nextInt(3);
            if(k==0){
                s = rand.nextInt((10)+90)+10;
                hareket = sporcu.sporcu_hareketleri1(s);
            }
            if(k==1){
                s = rand.nextInt((10)+90)+10;
                hareket = sporcu.sporcu_hareketleri2(s);
            }
            if(k==2){
                s = rand.nextInt((10)+90)+10;
                hareket = sporcu.sporcu_hareketleri3(s);
            }
        }
        return hareket;
    }
    public void rastgele_oynat(Oyuncu Bilgisayar){ // Zamanım Yetseydi Bilgisayara oynatmak için bu methodu kullanacaktım.
        
    }
    

    public static void main(String[] args) {

        Sporcu Messi = new Futbolcu("Messi","Barcelona"); //Oyuncu kartlarının ilk oluşumu(39-54)
        Sporcu Ronaldo = new Futbolcu("Ronaldo","Juventus");
        Sporcu Alex = new Futbolcu("Alex De Souza","Fenerbahçe");
        Sporcu Ronaldinho = new Futbolcu("Ronaldinho","Barcelona");
        Sporcu Zidane = new Futbolcu("Zinedine Zidane","Real Madrid");
        Sporcu Maradona = new Futbolcu("Diego Maradona","Napoli");
        Sporcu Ibrahimovic = new Futbolcu("Ibrahimovic","Paris Saint-Germain");
        Sporcu Maldini = new Futbolcu("Paolo Maldini","Milan");
        Sporcu Kobe = new Basketbolcu("Kobe Bryant","Los Angeles Lakers");
        Sporcu Oneal = new Basketbolcu("Shaquille O'Neal","Los Angeles Lakers");
        Sporcu Lebron = new Basketbolcu("Lebron James","Lakers");
        Sporcu Kyrie = new Basketbolcu("Kyrie Irving","Cleveland Cavaliers");
        Sporcu Jordan = new Basketbolcu("Michael Jordan","Chicago Bulls");
        Sporcu Wilt = new Basketbolcu("Wilt Chamberlain","Los Angeles Lakers");
        Sporcu Kareem = new Basketbolcu("Kareem Abdul-Jabbar","Los Angeles Lakers");
        Sporcu Tim = new Basketbolcu("Tim Duncan","Los Angeles Lakers");
        List<Sporcu> a = new ArrayList<Sporcu>(); //Oyuncuların rastgele seçilebilmesi için listeye eklendi(55-72)
        List<Sporcu> b = new ArrayList<Sporcu>();
        a.add(Messi);
        a.add(Ronaldo);
        a.add(Alex);
        a.add(Ronaldinho);
        a.add(Zidane);
        a.add(Maradona);
        a.add(Ibrahimovic);
        a.add(Maldini);
        b.add(Kobe);
        b.add(Oneal);
        b.add(Lebron);
        b.add(Kyrie);
        b.add(Jordan);
        b.add(Wilt);
        b.add(Kareem);
        b.add(Tim);
        Oyuncu oyuncu = new Kullanıcı();
        Scanner scanner = new Scanner(System.in);
        System.out.println("Oyun Arayüzüne Geçiliyor...");
        System.out.println("Tüm kartlar listeleniyor...");
        String arayuz = "Devam etmek için p'ye basınız...\n"
                       +"Çıkış için q'ya basınız...";
        System.out.println(arayuz);
        arayuz = scanner.nextLine();
        if(arayuz.equals("p")){
            System.out.println("Oyun başlatılıyor...");
         }
        if(arayuz.equals("q")){
            System.out.println("Çıkış yapılıyor...");
            return;
        }
        else{
            System.out.println("Yanlış tuşlama yaptınız...");
        }
        
        for(int i=0 ; i<a.size() ; i++){
            System.out.println("Futbolcuların ismi/takımı: "+ a.get(i).getSporcuisim() + " / " + a.get(i).getSporcutakim());
        }
        for(int i=0 ; i<b.size() ; i++){
            System.out.println("Basketbolcuların ismi/takımı: "+ b.get(i).getSporcuisim() + " / " + b.get(i).getSporcutakim());
        }
        System.out.println(arayuz);
        arayuz = scanner.nextLine();
        int k,m;
        if((arayuz.equals("p"))){
            for(m=0 ; m<4 ; m++){
            Random rand = new Random();
            k = rand.nextInt(8);
        
        if(k ==0){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + a.get(0).getSporcuisim() + " / " + a.get(0).getSporcutakim());
            Messi.sporcuPuaniGoster(90, 85, 95);
            System.out.println("****************************************");
            
            }
        if(k==1){
            
        
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + a.get(1).getSporcuisim() + " / " + a.get(1).getSporcutakim());
            Ronaldo.sporcuPuaniGoster(90, 90, 95);
            System.out.println("****************************************");
        }
        if(k==2){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + a.get(2).getSporcuisim() + " / " + a.get(2).getSporcutakim());
            Alex.sporcuPuaniGoster(95, 95, 100);
            System.out.println("****************************************");
        }
        if(k==3){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + a.get(3).getSporcuisim() + " / " + a.get(3).getSporcutakim());
            Ronaldinho.sporcuPuaniGoster(90, 80, 95);
            System.out.println("****************************************");
        }
        if(k==4){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + a.get(4).getSporcuisim() + " / " + a.get(4).getSporcutakim());
            Zidane.sporcuPuaniGoster(85, 80, 100);
            System.out.println("****************************************");
        }
        if(k==5){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + a.get(5).getSporcuisim() + " / " + a.get(5).getSporcutakim());
            Maradona.sporcuPuaniGoster(100, 90, 100);
            System.out.println("****************************************");
        }
        if(k==6){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + a.get(6).getSporcuisim() + " / " + a.get(6).getSporcutakim());
            Ibrahimovic.sporcuPuaniGoster(94, 88, 97);
            System.out.println("****************************************");
        }
        if(k==7){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + a.get(7).getSporcuisim() + " / " + a.get(7).getSporcutakim());
            Maldini.sporcuPuaniGoster(90, 98, 93);
        }
            }
        }
            else if(arayuz.equals("q")){
              return;
        }
        else{
            System.out.println("Yanlış tuşlama yaptınız...");
        }
        
        
        System.out.println(arayuz);
        scanner.nextLine();
        if((arayuz.equals("p"))){
            for(m=0 ; m<4 ; m++){
            Random rand = new Random();
            k = rand.nextInt(8);
        
        if(k ==0){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + b.get(0).getSporcuisim() + " / " + b.get(0).getSporcutakim());
            Kobe.sporcuPuaniGoster(90, 85, 95);
            System.out.println("****************************************");
            
            }
        if(k==1){
            
        
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + b.get(1).getSporcuisim() + " / " + b.get(1).getSporcutakim());
            Oneal.sporcuPuaniGoster(90, 90, 95);
            System.out.println("****************************************");
        }
        if(k==2){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + b.get(2).getSporcuisim() + " / " + b.get(2).getSporcutakim());
            Lebron.sporcuPuaniGoster(95, 95, 100);
            System.out.println("****************************************");
        }
        if(k==3){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + b.get(3).getSporcuisim() + " / " + b.get(3).getSporcutakim());
            Kyrie.sporcuPuaniGoster(95, 95, 100);
            System.out.println("****************************************");
        }
        if(k==4){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + b.get(4).getSporcuisim() + " / " + b.get(4).getSporcutakim());
            Jordan.sporcuPuaniGoster(95, 95, 100);
            System.out.println("****************************************");
        }
        if(k==5){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + b.get(5).getSporcuisim() + " / " + b.get(5).getSporcutakim());
            Wilt.sporcuPuaniGoster(95, 95, 100);
            System.out.println("****************************************");
        }
        if(k==6){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + b.get(6).getSporcuisim() + " / " + b.get(6).getSporcutakim());
            Kareem.sporcuPuaniGoster(95, 95, 100);
            System.out.println("****************************************");
        }
        if(k==7){
            oyuncu.skor = 0;
            System.out.println("Şuan ki skorun: " + oyuncu.skor);
            System.out.println("Seçilen Kartın: " + b.get(7).getSporcuisim() + " / " + b.get(7).getSporcutakim());
            Tim.sporcuPuaniGoster(95, 95, 100);
        }
            }
        }
            else if(arayuz.equals("q")){
              return;
        }
        else{
            System.out.println("Yanlış tuşlama yaptınız...");
            
        }
    
        
        
        
    
}
}
