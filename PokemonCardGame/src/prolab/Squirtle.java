package prolab;
public class Squirtle extends Pokemon {
	int DamagePoint = 0;
	boolean CardControl = false;

	public int getDamagePoint() {
		return DamagePoint;
	}

	public void setDamagePoint(int damagePoint) {
		DamagePoint = damagePoint;
	}

	public Squirtle() {
		super();
		this.DamagePoint = 30;
		this.PkmnType = " Water ";
                this.FileName = "Squirtle.jpeg";
                this.PkmnName = "Squirtle";
	}

	public Squirtle(String pkmnType, String pkmnName,String fileName, int damagePoint) {
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
