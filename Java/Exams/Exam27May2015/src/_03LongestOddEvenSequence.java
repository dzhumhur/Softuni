import java.util.ArrayList;
import java.util.Scanner;


public class _03LongestOddEvenSequence {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		
		String[] splittedInput = input.trim().split("[^0-9]+");
		ArrayList<Integer> numbers = new ArrayList<>();
		for (int i = 0; i < splittedInput.length; i++) {
			if (splittedInput[i].equals("")) {
				continue;
			}
			else {
				numbers.add(Integer.parseInt(splittedInput[i]));
			}
		}
		int counter = 1;
		int maxSeq = Integer.MIN_VALUE;
		boolean previousEven = numbers.get(0) % 2 == 0;
		
		for (int i = 1; i < numbers.size(); i++) {
			if (numbers.get(i) == 0) {
				counter++;
				previousEven = !previousEven;
			}
			else {
				boolean currentEven = numbers.get(i) % 2 == 0;
				if (currentEven != previousEven ) {
					counter++;
				}
				else {
					counter = 1;
				}
				previousEven = currentEven;
			}
			if (counter > maxSeq) {
				maxSeq = counter;
			}
		}
		System.out.println(maxSeq);
	}

}
