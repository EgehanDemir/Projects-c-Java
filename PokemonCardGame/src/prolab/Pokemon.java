package prolab;
public class Pokemon {

	String PkmnType;
	String PkmnID;
	String PkmnName;
        String FileName;
        int DamagePoint;

	public Pokemon(String pkmnType, String pkmnName,String fileName,int damagePoint) {
		PkmnType = pkmnType;
		PkmnName = pkmnName;
                FileName = fileName;
                DamagePoint = damagePoint;
	}

	public Pokemon() {
		this.PkmnName = "Bilinmeyen";
		this.PkmnType = "Bilinmeyen";
	}

	public String getPkmnType() {
		return PkmnType;
	}

	public void setPkmnType(String pkmnType) {
		PkmnType = pkmnType;
	}

	public String getPkmnID() {
		return PkmnID;
	}

	public void setPkmnID(String pkmnID) {
		PkmnID = pkmnID;
	}
        
        public void setFileName(String fileName) {
		FileName = fileName;
	}
        public String getFileName() {
		return FileName;
	}
        
        public void setDamagePoint(int damagePoint) {
		DamagePoint = damagePoint;
	}
        public int getDamagePoint() {
		return DamagePoint;
	}

	public String getPkmnName() {
		return PkmnName;
	}

	public void setPkmnName(String pkmnName) {
		PkmnName = pkmnName;
	}

	public void HasarPuani_Goster() {
		System.out.println();
	}

}
