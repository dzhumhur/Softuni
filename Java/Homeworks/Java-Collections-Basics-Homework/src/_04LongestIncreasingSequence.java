import java.util.ArrayList;
import java.util.Scanner;


public class _04LongestIncreasingSequence {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner (System.in);
		
		String input = scan.nextLine();
		String[] inputAsArray = input.split("\\s+");
		int[] numbers = new int[inputAsArray.length];
		int longest = Integer.MIN_VALUE;
		for (int i = 0; i < inputAsArray.length; i++) {
			numbers[i] = Integer.parseInt(inputAsArray[i]);
		}
		int firstNumber = numbers[0];
		
		String currentLine = "" + firstNumber + " ";
		
		ArrayList<String> newArray = new ArrayList<>();
		for (int i = 1; i < numbers.length; i++) {
			if (numbers[i] > numbers[i - 1]) {
				currentLine += "" + numbers[i] + " ";
				continue;
			}
			else {
				newArray.add(currentLine);
				
				currentLine = "" + numbers[i] + " ";
			}
			
		}
		newArray.add(currentLine);
		int index = 0;
		for (int i = 0; i < newArray.size(); i++) {
			String currentSet = newArray.get(i);
			if (currentSet.length() > longest) {
				longest = currentSet.length();
				index = i;
			}
			System.out.println(newArray.get(i));
			
		}
		System.out.printf("Longest: %s", newArray.get(index));
		// The second example not working correctly would you help me?
	}
}
