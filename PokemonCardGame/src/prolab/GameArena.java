package prolab;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.util.ArrayList;
import javax.swing.*;
import java.util.Random; 
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;
import java.util.logging.Logger;

public class GameArena extends JFrame{
    
    int ScreenWidth=500;
    int ScreenHeight=1050;
    String top = BorderLayout.PAGE_START;
    String center  = BorderLayout.CENTER;
    public static int COM_SCORE =0;
    public static int PLAYER_SCORE =0;
    private int secim;
    protected ArrayList<JButton> computer1_cards = new ArrayList<JButton>();
    protected ArrayList<JButton> computer2_cards = new ArrayList<JButton>();
    protected ArrayList<JButton> extra_cards = new ArrayList<JButton>();
    private int Hamle =0;

    
    public GameArena(int secim){
        this.secim =secim; 
        ImageIcon icon = new ImageIcon( System.getProperty("user.dir")+"\\src\\prolab\\documents\\button.png");
        JPanel panel = new JPanel();        
        panel.setBackground(Color.black);
        getContentPane().add(panel);
        
        LayoutManager layout = new BoxLayout(panel, BoxLayout.Y_AXIS);
        Box boxes[] = new Box[6];
        
        int[] size={50,150,540,150,50,30};
        ArrayList<JPanel> panels = new ArrayList<JPanel>();
        

        for(int i=0;i<6;i++){
            JPanel temp = new JPanel();
            temp.setPreferredSize(new Dimension(ScreenWidth, size[i] ));
            temp.setBackground(Color.black);
            panels.add(temp);
        }
        
        for(int i=0;i<6;i++){
            boxes[i] = Box.createHorizontalBox();
            boxes[i].createGlue();
            panel.add(boxes[i]);
            boxes[i].add(panels.get(i));
        }

        ArrayList<JPanel> center = CenterLayout(panels);
            
        anasayfa(panels,icon,center);
        setTitle("Pokemon Game");
        setSize(ScreenWidth,ScreenHeight);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setIconImage(icon.getImage());
        
    }
    
    public ArrayList<JPanel> CenterLayout(ArrayList<JPanel> panels){
           
        int[] center_size={25,140,25,140,140,25};
        LayoutManager center_layout = new BoxLayout(panels.get(2), BoxLayout.Y_AXIS);
        ArrayList<JPanel> center_elements = new ArrayList<JPanel>();
        Box center_boxes[] = new Box[center_size.length];
        
        
        for(int i=0;i<center_size.length;i++){
            JPanel temp = new JPanel();
            temp.setPreferredSize(new Dimension(ScreenWidth, center_size[i] ));
            temp.setBackground(Color.black);
            center_elements.add(temp);
        }
        
        for(int i=0;i<center_size.length;i++){
            center_boxes[i] = Box.createHorizontalBox();
            center_boxes[i].createGlue();
            panels.get(2).add(center_boxes[i]);
            center_boxes[i].add(center_elements.get(i));
        }

        return center_elements;
    }
    
    public ArrayList<JButton> atama(ArrayList<JButton> Buttons){
        Pokemon[] Cards = new Pokemon[10];
        Bulbasaur card1 = new  Bulbasaur();
        Cards[0] = card1;
        Butterfree card2 = new  Butterfree();
        Cards[1] = card2;
        Charmender card3 = new  Charmender();
        Cards[2] = card3;
        Jigglypuff card4 = new  Jigglypuff();
        Cards[3] = card4;
        Meowth card5 = new  Meowth();
        Cards[4] = card5;
        Pikachu card6 = new  Pikachu();
        Cards[5] = card6;
        Psyduck card7 = new  Psyduck();
        Cards[6] = card7;
        Snorlax card8 = new  Snorlax();
        Cards[7] = card8;
        Squirtle card9 = new  Squirtle();
        Cards[8] = card9;
        Zubat card10 = new  Zubat();
        Cards[9] = card10;
        
        
        
        for (int i = 0; i < 10; i++) {
            JButton temp = new JButton();
            temp.putClientProperty("Name", String.valueOf(Cards[i].getPkmnName()));
            temp.putClientProperty("DamagePoint", String.valueOf(Cards[i].getDamagePoint()));
            temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+Cards[i].getFileName());
            ImageIcon icon = new ImageIcon( System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+Cards[i].getFileName());
            Image image = icon.getImage();
            image = image.getScaledInstance(80, 160, Image.SCALE_SMOOTH);
            ImageIcon edited = new ImageIcon(image);
            temp.setIcon(edited);
            temp.setAlignmentX(JButton.CENTER_ALIGNMENT);
            temp.setPreferredSize( new Dimension(80,140));
            temp.setBackground(Color.white);
        
            Buttons.add(temp);
        }
         return Buttons;
    }
    
    
    public void player_vs_computer(JButton player_btn,ArrayList<JPanel> center,ArrayList<JButton> Buttons,ArrayList<JPanel> panels,JButton extra_btn1,JButton extra_btn2,JButton computer_btn){
         if(this.secim == 1 ||this.secim == 2){
                ImageIcon Closed_Card = new ImageIcon( System.getProperty("user.dir")+"\\src\\prolab\\documents\\button.png");
                String WarCard1_Name = player_btn.getClientProperty("Name").toString();
                int WarCard1_DamagePoint  = Integer.valueOf(player_btn.getClientProperty("DamagePoint").toString());
                ImageIcon  icon1 = new ImageIcon( player_btn.getClientProperty("CardImage").toString());
                Image image1 = icon1.getImage();
                image1 = image1.getScaledInstance(80, 160, Image.SCALE_SMOOTH);
                ImageIcon edited1 = new ImageIcon(image1);
                panels.get(3).remove(player_btn);
                panels.get(3).repaint();
                
                if(extra_btn1 != null){
                    String ExtraCard1_Name = extra_btn1.getClientProperty("Name").toString();
                    int ExtraCard1_DamagePoint  = Integer.valueOf(extra_btn1.getClientProperty("DamagePoint").toString());
                    ImageIcon  extra1_icon = new ImageIcon( extra_btn1.getClientProperty("CardImage").toString());
                    Image extra1_image1 = extra1_icon.getImage();
                    extra1_image1 = extra1_image1.getScaledInstance(80, 160, Image.SCALE_SMOOTH);
                    ImageIcon extra1_edited1 = new ImageIcon(extra1_image1);
                    extra_btn1.setIcon(extra1_edited1);
                    
                    
                    panels.get(3).add(extra_btn1);
                    center.get(4).remove(extra_btn1);
                    center.get(4).repaint();
                    center.get(1).repaint();
                    final JButton edit = extra_btn1;
                    final ArrayList<JButton> buttons = Buttons;
                    extra_btn1.addActionListener((ActionEvent e) ->{
                        center.get(3).removeAll();
                        savas(edit,center,buttons,panels);

                    });
                }
                
                JButton WarCard1 = new JButton();
                
                WarCard1.setAlignmentX(JButton.CENTER_ALIGNMENT);
                WarCard1.setPreferredSize( new Dimension(80,140));
                WarCard1.setBackground(Color.white);
                WarCard1.setIcon(Closed_Card);
                
                String WarCard2_Name = computer_btn.getClientProperty("Name").toString();
                int WarCard2_DamagePoint  = Integer.valueOf(computer_btn.getClientProperty("DamagePoint").toString());
                ImageIcon icon2 = new ImageIcon( computer_btn.getClientProperty("CardImage").toString());
                Image image2 = icon2.getImage();
                image2 = image2.getScaledInstance(80, 160, Image.SCALE_SMOOTH);
                ImageIcon edited2 = new ImageIcon(image2);
                panels.get(1).remove(computer_btn);
                panels.get(1).repaint();
                
                if(extra_btn2 != null){
                    if(secim == 1 || secim == 3){
                        extra_btn2.setIcon(Closed_Card);
                    }
                    
                    computer1_cards.add(extra_btn2);
                    
                    panels.get(1).add(extra_btn2);
                    center.get(1).remove(extra_btn2);
                    center.get(4).repaint();
                    center.get(1).repaint();
                }
                
                JButton WarCard2 = new JButton();
                WarCard2.setIcon(Closed_Card);
                WarCard2.setAlignmentX(JButton.CENTER_ALIGNMENT);
                WarCard2.setPreferredSize( new Dimension(80,140));
                WarCard2.setBackground(Color.white);
                
                center.get(3).add(WarCard2);
                center.get(3).add(WarCard1);
                
                WarCard1.setIcon(edited1);
                WarCard2.setIcon(edited2);
                
                if(WarCard1_DamagePoint > WarCard2_DamagePoint){
                    PLAYER_SCORE +=5;
                }else if(WarCard2_DamagePoint > WarCard1_DamagePoint){
                    COM_SCORE +=5;
                }
                center.get(3).invalidate();
           
               
                write_score(panels);
        }    
    }
    
    public void computer_vs_computer(JButton computer2_btn,ArrayList<JPanel> center,ArrayList<JButton> Buttons,ArrayList<JPanel> panels,JButton extra_btn1,JButton extra_btn2,JButton computer_btn){
         if(this.secim == 3 ||this.secim == 4){
                ImageIcon Closed_Card = new ImageIcon( System.getProperty("user.dir")+"\\src\\prolab\\documents\\button.png");
                String WarCard1_Name = computer2_btn.getClientProperty("Name").toString();
                int WarCard1_DamagePoint  = Integer.valueOf(computer2_btn.getClientProperty("DamagePoint").toString());
                ImageIcon  icon1 = new ImageIcon( computer2_btn.getClientProperty("CardImage").toString());
                Image image1 = icon1.getImage();
                image1 = image1.getScaledInstance(80, 160, Image.SCALE_SMOOTH);
                ImageIcon edited1 = new ImageIcon(image1);
                panels.get(3).remove(computer2_btn);
                panels.get(3).repaint();
                
                if(extra_btn1 != null){
                    String ExtraCard1_Name = extra_btn1.getClientProperty("Name").toString();
                    int ExtraCard1_DamagePoint  = Integer.valueOf(extra_btn1.getClientProperty("DamagePoint").toString());
                    ImageIcon  extra1_icon = new ImageIcon( extra_btn1.getClientProperty("CardImage").toString());
                    Image extra1_image1 = extra1_icon.getImage();
                    extra1_image1 = extra1_image1.getScaledInstance(80, 160, Image.SCALE_SMOOTH);
                    ImageIcon extra1_edited1 = new ImageIcon(extra1_image1);
                    extra_btn1.setIcon(extra1_edited1);
                    
                    panels.get(3).add(extra_btn1);
                    center.get(4).remove(extra_btn1);
                    center.get(4).repaint();
                    center.get(1).repaint();
                    final JButton edit = extra_btn1;
                    final ArrayList<JButton> buttons = Buttons;
                    computer2_cards.add(extra_btn1);
                }
                
                JButton WarCard1 = new JButton();
                
                WarCard1.setAlignmentX(JButton.CENTER_ALIGNMENT);
                WarCard1.setPreferredSize( new Dimension(80,140));
                WarCard1.setBackground(Color.white);
                WarCard1.setIcon(Closed_Card);
                
                String WarCard2_Name = computer_btn.getClientProperty("Name").toString();
                int WarCard2_DamagePoint  = Integer.valueOf(computer_btn.getClientProperty("DamagePoint").toString());
                ImageIcon icon2 = new ImageIcon( computer_btn.getClientProperty("CardImage").toString());
                Image image2 = icon2.getImage();
                image2 = image2.getScaledInstance(80, 160, Image.SCALE_SMOOTH);
                ImageIcon edited2 = new ImageIcon(image2);
                panels.get(1).remove(computer_btn);
                panels.get(1).repaint();
                
                if(extra_btn2 != null){
                    if(secim == 1 || secim == 3){
                        extra_btn2.setIcon(Closed_Card);
                    }
                    
                    computer1_cards.add(extra_btn2);
                    
                    panels.get(1).add(extra_btn2);
                    center.get(1).remove(extra_btn2);
                    center.get(4).repaint();
                    center.get(1).repaint();
                }
                
                JButton WarCard2 = new JButton();
                WarCard2.setIcon(Closed_Card);
                WarCard2.setAlignmentX(JButton.CENTER_ALIGNMENT);
                WarCard2.setPreferredSize( new Dimension(80,140));
                WarCard2.setBackground(Color.white);
                
                center.get(3).add(WarCard2);
                center.get(3).add(WarCard1);
                
                WarCard1.setIcon(edited1);
                WarCard2.setIcon(edited2);
                
                if(WarCard1_DamagePoint > WarCard2_DamagePoint){
                    PLAYER_SCORE +=5;
                }else if(WarCard2_DamagePoint > WarCard1_DamagePoint){
                    COM_SCORE +=5;
                }
                center.get(3).invalidate();
               
                write_score(panels);
                
                panels.get(4).repaint();
        }    
    }
    

    public void savas(JButton player_btn,ArrayList<JPanel> center,ArrayList<JButton> Buttons,ArrayList<JPanel> panels){
        /*Savaş sırasında yapılacak işlemlerin olduğu kısım.Computerdan kart çekme kodları olmadığı için o kısımları yapamadım.
        Amacım seçilen kartların ortaya alınması ve kartıların savaş güçlerine bakılması.Sonrasında saldırı gücü yüksek olan 5 puan alacak.
        Sonra ise rastgele yeni kart çekilmesi işlemleriyle devam edicek.*/
        
       
        Random rand = new Random();
        int computer_secim = (int)rand.nextInt(computer1_cards.size());
        
        JButton computer_btn = computer1_cards.get(computer_secim);
        computer1_cards.remove(computer_secim);
        JButton extra_btn1=null,extra_btn2=null;
        
       if(extra_cards.size() == 4){
            int extra_secim1 = (int)rand.nextInt(extra_cards.size());
            extra_btn1 = extra_cards.get(extra_secim1);
            extra_cards.remove(extra_secim1);
            int extra_secim2 = (int)rand.nextInt(extra_cards.size());
            extra_btn2 = extra_cards.get(extra_secim2);
            extra_cards.remove(extra_secim2);
        }else if(extra_cards.size() == 2){
            int extra_secim1 = (int)rand.nextInt(extra_cards.size());
            extra_btn1 = extra_cards.get(extra_secim1);
            extra_cards.remove(extra_secim1);
            
            extra_btn2 = extra_cards.get(0);
            extra_cards.remove(0);
        }
       
       if(this.secim == 1 ||this.secim == 2){
            player_vs_computer(player_btn,center,Buttons,panels,extra_btn1,extra_btn2,computer_btn);
       }else if(this.secim == 3 ||this.secim == 4){
            int computer2_secim = (int)rand.nextInt(computer2_cards.size());
            System.out.println(computer2_cards.size());
            JButton computer2_btn = computer2_cards.get(computer2_secim);
            computer2_cards.remove(computer2_secim);

            
            computer_vs_computer(computer2_btn,center,Buttons,panels,extra_btn1,extra_btn2,computer_btn);
       }
       
    }
    
    public void write_score(ArrayList<JPanel> panels){
        panels.get(0).removeAll();
        panels.get(4).removeAll();
        if(this.secim == 1 ||this.secim == 2){
            JLabel comLabel = new  JLabel("<html><font size='7' color='white'>"+COM_SCORE+"</font></html>");
            JLabel playerLabel = new  JLabel("<html><font size='7' color='white'>"+PLAYER_SCORE+"</font></html>");
            panels.get(0).add(new JLabel("<html><font size='7' color='white'/>-COMPUTER-PUAN:</font></html>"));
            panels.get(0).add(comLabel);
            panels.get(4).add(new JLabel("<html><font size='7' color='white'/>-PLAYER-PUAN:</font></html>"));
            panels.get(4).add(playerLabel);
        }if(this.secim == 3 ||this.secim == 4){
            JLabel comLabel = new  JLabel("<html><font size='7' color='white'>"+COM_SCORE+"</font></html>");
            JLabel playerLabel = new  JLabel("<html><font size='7' color='white'>"+PLAYER_SCORE+"</font></html>");
            panels.get(0).add(new JLabel("<html><font size='7' color='white'/>-COMPUTER-PUAN:</font></html>"));
            panels.get(0).add(comLabel);
            panels.get(4).add(new JLabel("<html><font size='7' color='white'/>-COMPUTER2-PUAN:</font></html>"));
            panels.get(4).add(playerLabel);
        }
    }
   
    
    public void  anasayfa(ArrayList<JPanel> panels,ImageIcon icon,ArrayList<JPanel> center){
        ArrayList<JButton> Buttons = new  ArrayList<JButton>();
        
        write_score(panels);
        
        center.get(0).add(new JLabel("<html><font size='5' color='white'/>-Ek Kartlar-</font></html>"));
        
        center.get(5).add(new JLabel("<html><font size='5' color='white'/>-Ek Kartlar-</font></html>"));
        
        center.get(2).add(new JLabel("<html><font size='5' color='white'/>-Savaş Alanı-</font></html>"));

        Buttons  = atama(Buttons);
      
        if(this.secim == 3 ||this.secim == 4){
            Buttons  = atama(Buttons);
            JButton basla = new JButton("Hamle Yap");
            basla.setBackground(Color.white);
            final ArrayList<JButton> buttons = Buttons;
            basla.addActionListener((ActionEvent e) ->{
              if(Hamle <5){
                center.get(3).removeAll();
                savas(null,center,buttons,panels);
                Hamle++;
                center.get(3).repaint();
              }else{
                  System.out.println("Oyun Bitti");
              }
            });
            panels.get(5).add(basla);
       }
        
        
        
        
        int[] sira = new int[10];

        Random rand = new Random(); 

        boolean check =true;
        for(int i=0;i<10;i++){
            while(true){
                int gen_kart = rand.nextInt(10); 
                check=true;
                for (int j = 0; j < i; j++) {
                    if(sira[j] == gen_kart){
                        check = false;
                    }
                }
                if(check){
                    sira[i] = gen_kart;
                    break;
                }
            }   
        }
       


        for(int i=0;i<10;i++){
            if(i<3){
                if(this.secim == 1 ||this.secim == 2){
                    JButton player_btn = Buttons.get(sira[i]);
                    final ArrayList<JButton> buttons = Buttons;
                    Buttons.get(sira[i]).addActionListener((ActionEvent e) ->{center.get(3).removeAll();
                        savas(player_btn,center,buttons,panels);
                    });
                }else if(this.secim == 3 ||this.secim == 4){
                    computer2_cards.add(Buttons.get(sira[i]));
                }
                panels.get(3).add(Buttons.get(sira[i]));
            }else if( i>=3 && i<6){
                computer1_cards.add(Buttons.get(sira[i]));
                String WarCard1_Name = Buttons.get(i).getClientProperty("Name").toString();
                System.out.println(WarCard1_Name+": "+i);
                if(secim == 1 || secim == 3){
                    Buttons.get(sira[i]).setIcon(icon);
                }
                panels.get(1).add(Buttons.get(sira[i]));
            }else if(i>=6 && i<8){
                extra_cards.add(Buttons.get(sira[i]));
                if(secim == 1 || secim == 3){
                    Buttons.get(sira[i]).setIcon(icon);
                }
                center.get(1).add(Buttons.get(sira[i]));
            }else if(i>=8 && i<10){
                extra_cards.add(Buttons.get(sira[i]));
                if(secim == 1 || secim == 3){
                    Buttons.get(sira[i]).setIcon(icon);
                }
                center.get(4).add(Buttons.get(sira[i]));
            }
        }
        
        /*
        Kartların saldırı gücüne ve ismine nasıl ulaşabileceğin konusunda bir örnek
        for(int i=0;i<10;i++){
            System.out.print(Buttons.get(sira[i]).getClientProperty("Name")+": ");
            System.out.println(Buttons.get(sira[i]).getClientProperty("DamagePoint"));
        }
         */
    }
   

}
