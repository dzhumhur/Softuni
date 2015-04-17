import java.util.Scanner;


public class _14Durts {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		int cX = scan.nextInt();
		int cY = scan.nextInt();
		int r = scan.nextInt();
		int count = scan.nextInt();
		scan.nextLine();
		
		String input = scan.nextLine();
		String[] numbersAsString = input.split("[\\s]+");

		int[] numbers = new int[count*2];
		
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(numbersAsString[i]);
		}
		 
		printResults(cX, cY, r, numbers);
		
	}

	private static void printResults(int cX, int cY, int r, int[] numbers) {
		for (int i = 0; i < numbers.length - 1; i+= 2) {
			int x = numbers[i];
			int y = numbers[i+1];
			boolean horizontalRectangle = ((x >= cX - r) && (x <= cX + r) &&
										  (y >= cY - r/2) && (y <= cY + r/2)); 
			
			boolean verticalRectangle = (((x >= cX - r/2) && (x <= cX + r/2)) &&
										((y >= cY - r) && (y <= cY + r)));
			
			if ( verticalRectangle || horizontalRectangle) {
				System.out.println("yes");
			}
			else {
				System.out.println("no");
			}
		}
	}

}
