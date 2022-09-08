package prolab;
import java.awt.*;
import java.awt.event.ActionEvent;
import javax.swing.*;

public class MainPage extends JFrame{
    
    int ScreenWidth=500;
    int ScreenHeight=700;

    public MainPage(){
        ImageIcon icon = new ImageIcon( System.getProperty("user.dir")+"\\src\\prolab\\documents\\pokeball.png");
        JPanel panel = new JPanel();
        panel.setBackground(Color.black);
        getContentPane().add(panel);
        panel.setLayout(new GridBagLayout());
        
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.gridwidth = GridBagConstraints.REMAINDER;
        gbc.anchor = GridBagConstraints.NORTH;
        
        gbc.anchor = GridBagConstraints.CENTER;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        

        anasayfa(panel,gbc);
        setBackground(Color.black);
        setTitle("Pokemon Game");
        setSize(ScreenWidth,ScreenHeight);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setIconImage(icon.getImage());
        
    }
    
    public void  anasayfa(JPanel panel,GridBagConstraints gbc){
        JButton btn1 = new JButton("Oyuncu vs Bilgisayar");
        JButton btn2 = new JButton("Oyuncu vs Bilgisayar Sunum");
        JButton btn3 = new JButton("Bilgisayar vs Bilgisayar ");
        JButton btn4 = new JButton("Bilgisayar vs Bilgisayar Sunum");
        JButton btn5 = new JButton("Exit");
        
        btn1.setBackground(Color.white);
        btn2.setBackground(Color.white);
        btn3.setBackground(Color.white);
        btn4.setBackground(Color.white);
        btn5.setBackground(Color.white);
        btn1.addActionListener((ActionEvent e) -> {
            setVisible(false);
            GameArena game = new  GameArena(1);
            game.setVisible(true);
            System.out.println("Selected: PC vs Person");
        });
        btn2.addActionListener((ActionEvent e) ->{
            setVisible(false);
            GameArena game = new  GameArena(2);
            game.setVisible(true);
            System.out.println("Selected: PC vs Person Presentetion");
        });
           btn3.addActionListener((ActionEvent e) ->{
            setVisible(false);
            GameArena game = new  GameArena(3);
            game.setVisible(true);
            System.out.println("Selected: Computer vs Computer");
        });
              btn4.addActionListener((ActionEvent e) ->{
            setVisible(false);
            GameArena game = new  GameArena(4);
            game.setVisible(true);
            System.out.println("Selected: Computer vs Computer Presentetion");
        });
        btn5.addActionListener((ActionEvent e) ->{
            System.exit(1);
        });
        
        panel.add(new JLabel("<html><font size='6' color='red'>Pokemon</font><font size='6' color='white'> Game</font><br/><br/></html>"),gbc);
        panel.add(btn1,gbc);
        panel.add(new JLabel("<html><br/></html>"),gbc);
        panel.add(btn2,gbc);
        panel.add(new JLabel("<html><br/></html>"),gbc);
        panel.add(btn3,gbc);
        panel.add(new JLabel("<html><br/></html>"),gbc);
        panel.add(btn4,gbc);
        panel.add(new JLabel("<html><br/><br/><font size='3' color='gray'>Yapanlar:<br/>Yağızhan Şimşek<br/>Emre Nihat Durgun</html>"),gbc);
        panel.add(btn5,gbc);


    }
   
    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {

            @Override
            public void run() {
               MainPage gui = new MainPage();
               gui.setVisible(true);
        }
        });
    }
}
