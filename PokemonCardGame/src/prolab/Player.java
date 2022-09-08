
public abstract class Player {
        String PlayerName;
        String PlayerID;
        int score=0;
		public String getPlayerName() {
			return PlayerName;
		}
		public void setPlayerName(String playerName) {
			PlayerName = playerName;
		}
		public String getPlayerID() {
			return PlayerID;
		}
		public void setPlayerID(String playerID) {
			PlayerID = playerID;
		}
		public int getScore() {
			return score;
		}
		public void setScore(int score) {
			this.score = score;
		}
        
		public Player(){
			
		}
        
}
