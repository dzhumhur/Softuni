import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;


public class _06RandomHandsOf5Cards {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int count = scan.nextInt();
		
		String[] faces = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
		String[] suits = {"♣", "♦", "♥", "♠"};
		
		ArrayList<String> cardDeck = new ArrayList<String>();
		ArrayList<String> result = new ArrayList<String>();
		
		for (int i = 0; i < faces.length; i++) {
			for (int j = 0; j < suits.length; j++) {
				String currCard = "" + faces[i] + suits[j];
				cardDeck.add(currCard);
			}
		}
		
		String currentRes = "";
		
		for (int i = 0; i < count; i++) {
			for (int j = 0; j < 5; j++) {
				
				Random rnd = new Random();
				
				int sequence = rnd.nextInt(cardDeck.size());
				currentRes += "" + cardDeck.get(sequence) + " ";
			}
			result.add(currentRes);
			currentRes = ""; 	 
		}
		
		for (String string : result) {
			System.out.println(string);
		}
	}
}
