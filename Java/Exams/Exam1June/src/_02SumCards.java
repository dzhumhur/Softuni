import java.util.Scanner;

public class _02SumCards {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

		String input = scan.nextLine();
		String[] inputAsArray = input.split("[S HDC]+");
		int[] numbers = new int[inputAsArray.length];

		for (int i = 0; i < inputAsArray.length; i++) {
			numbers[i] = getValue(inputAsArray[i]);
		}
		
		int sum = 0;
		boolean isEqual = false;
		for (int i = 0; i < numbers.length - 1; i++) {
			
			if (numbers[i] == numbers[i + 1]){
				isEqual = true;
				sum += numbers[i] * 2;
			}
			else if (isEqual) {
				sum += numbers[i] * 2;
				isEqual = false;
			}
			else {
				isEqual = false;
				sum += numbers[i];
			}
		}
		if (isEqual) {
			sum += numbers[numbers.length - 1]  * 2;
		}
		else {
			sum += numbers[numbers.length - 1];
		}
		System.out.println(sum);

	}

	private static int getValue(String card) {
		if (card.startsWith("2"))
			return 2;
		if (card.startsWith("3"))
			return 3;
		if (card.startsWith("4"))
			return 4;
		if (card.startsWith("5"))
			return 5;
		if (card.startsWith("6"))
			return 6;
		if (card.startsWith("7"))
			return 7;
		if (card.startsWith("8"))
			return 8;
		if (card.startsWith("9"))
			return 9;
		if (card.startsWith("10"))
			return 10;
		if (card.startsWith("J"))
			return 12;
		if (card.startsWith("Q"))
			return 13;
		if (card.startsWith("K"))
			return 14;
		if (card.startsWith("A"))
			return 15;
		return 0;

	}

}
