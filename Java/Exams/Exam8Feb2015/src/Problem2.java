import java.util.Scanner;


public class Problem2 {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		
		String[] inputAsArray = input.split("[\\s]+");
		
//		double fistSum = 0;
//		double secondSum = 0;
		double result = 0;
		double[] array = new double[inputAsArray.length];
		for (int i = 0; i < inputAsArray.length; i++) {
			String word = inputAsArray[i];
			char firstLetter = word.charAt(0);
			char secondLetter = word.charAt(word.length() - 1);
			word = word.substring(1, word.length() - 1);
			int number = Integer.parseInt(word);
			
			double currentSum = 0;
			double currentSumFirst = 0;
			double currentSumSecond = 0;
			if ((firstLetter >= 60 && firstLetter <= 90)) {
				currentSumFirst  = (char) (firstLetter - 64);
				currentSumFirst = number / currentSumFirst;
			}
			else if ((firstLetter >= 97 && firstLetter <= 122)) {
				currentSumFirst  = (char) (firstLetter - 96);
				currentSumFirst = number * currentSumFirst;
			}
			
			if (secondLetter >= 60 && secondLetter <= 90) {
				currentSumSecond = (char) (secondLetter - 64);
				currentSumSecond =  currentSumFirst - currentSumSecond;
			}
			else if (secondLetter >= 97 && secondLetter <= 122) {
				currentSumSecond = (char) (secondLetter - 96);
				currentSumSecond = currentSumFirst + currentSumSecond;
			}
			array[i] = currentSumSecond;
			
			
		}	
		for (int i = 0; i < array.length; i++) {
			result += array[i];
		}
		System.out.printf("%.2f", result);
		}
		
	}

