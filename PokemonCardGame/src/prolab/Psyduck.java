package prolab;
public class Psyduck extends Pokemon {
	int DamagePoint = 0;
	boolean CardControl = false;

	public int getDamagePoint() {
		return DamagePoint;
	}

	public void setDamagePoint(int damagePoint) {
		DamagePoint = damagePoint;
	}

	public Psyduck() {
		super();
		this.DamagePoint = 20;
		this.PkmnType = " Water ";
                this.FileName = "Psyduck.jpeg";
                this.PkmnName = "Psyduck";
	}

	public Psyduck(String pkmnType, String pkmnName,String fileName, int damagePoint) {
		super(pkmnType, pkmnName,fileName,damagePoint);
		DamagePoint = damagePoint;
	}

	public void HasarPuani_Goster() {
		// TODO Auto-generated method stub
		super.HasarPuani_Goster();
	}

	public void UsedThisCard() {
		if (CardControl == true) {
			System.out.println("This Card Used!");
		} else {
			System.out.println("This Card did not used!");
		}
	}
}
