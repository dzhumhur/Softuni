import java.util.ArrayList;


public class _03FullHouse {

	public static void main(String[] args) {
		//Scanner scan = new Scanner(System.in);
		
		String[] faces = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
		String[] suits = {"♣", "♦", "♥", "♠"};
		int counter  = 0;
		ArrayList<String> cardDeck = new ArrayList<String>();
		for (int i = 0; i < faces.length; i++) {
			for (int j = 0; j < suits.length; j++) {
				String currCard = "" + faces[i] + suits[j];
				cardDeck.add(currCard);
			}
		}
		
		for (int i = 0; i < cardDeck.size(); i++) {
			String firstCard = "" + cardDeck.get(i).charAt(0);

			for (int j = i+1; j < cardDeck.size(); j++) {
				String secondCard = "" + cardDeck.get(j).charAt(0);

				for (int j2 = j+1; j2 < cardDeck.size(); j2++) {
					String thirdCard = "" + cardDeck.get(j2).charAt(0);
					
					
					if (firstCard.equals(secondCard) && firstCard.equals(thirdCard)) {
						
						for (int k = 0; k < cardDeck.size();k++) {
							
							String forthCard = "" + cardDeck.get(k).charAt(0);
							
							if (!thirdCard.equals(forthCard)) {
								
								for (int k2 = k+1; k2 < cardDeck.size(); k2++) {
									String fifthCard = "" + cardDeck.get(k2).charAt(0);
									
								
								if (forthCard.equals(fifthCard)) {
									System.out.println("" + cardDeck.get(i) + " " +
															cardDeck.get(j) + " " +
															cardDeck.get(j2) + " " + 
															cardDeck.get(k) + " " + 
															cardDeck.get(k2));
									counter++;
								}
								
								}
							}
						}
					}
				}
			}
		}
		System.out.println(counter);
	}

}
