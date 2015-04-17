import java.util.Scanner;


public class _01CountBeers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		int stacksCounter = 0;
		int beersCounter = 0;
		while (!input.equals("End")) {
			
			String[] inputAsArray = input.split(" ");
			if (inputAsArray[1].equals("stacks")) {
				stacksCounter += Integer.parseInt(inputAsArray[0]);
			}
			else {
				beersCounter += Integer.parseInt(inputAsArray[0]);
			}
			input = scan.nextLine();
		}
		
		stacksCounter += beersCounter / 20;
		beersCounter %= 20;
		
		System.out.printf("%d stacks + %d beers",stacksCounter,beersCounter);
	}

}
