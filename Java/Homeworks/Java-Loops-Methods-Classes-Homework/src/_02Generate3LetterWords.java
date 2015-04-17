import java.util.Scanner;


public class _02Generate3LetterWords {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		String[] inputAsArray = input.split("");
		int counter = 0;
		
		for (int i = 0; i < inputAsArray.length; i++) {
			for (int j = 0; j < inputAsArray.length; j++) {
				for (int j2 = 0; j2 < inputAsArray.length; j2++) {
					
					System.out.print("" + inputAsArray[i] + inputAsArray[j] +
										inputAsArray[j2] + " ");
					counter++;
					if (counter % 3 == 0) {
						System.out.println();
					}
				}
			}
		}
		
	}

}
