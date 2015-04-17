import java.util.Scanner;


public class Problem4 {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
	
		int currentMod = Integer.parseInt(scan.nextLine());
		String input = scan.nextLine().toLowerCase();
		String[] inputAsArray = input.split("[^A-Za-z]+");
		
		for (String string : inputAsArray) {
			//System.out.println(string);
			switch (string) {
			case "cram": currentMod += 2; break;
			case "lembas": currentMod += 3; break;
			case "apple": currentMod += 1; break;
			case "melon": currentMod += 1; break;
			case "honeycake": currentMod += 5; break;
			case "mushrooms": currentMod += -10; break;
			
			default: currentMod += -1; break;
			}
		}
//		switch (currentMod) {
//		case :
//			
//			break;
//
//		default:
//			break;
//		}
		if (currentMod < -5) {
			System.out.println(currentMod);
			System.out.println("Angry");
		}
		else if (currentMod >= -5 && currentMod < 0) {
			System.out.println(currentMod);
			System.out.println("Sad");
		}
		else if (currentMod >= 0 && currentMod < 15) {
			System.out.println(currentMod);
			System.out.println("Happy");
		}
		else {
			System.out.println(currentMod);
			System.out.println("Special JavaScript mood");
		}
	}

}
