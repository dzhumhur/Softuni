import java.util.Arrays;
import java.util.Scanner;


public class _01SortArrayOfNumbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int n = scan.nextInt();
		int[] numbers = new int[n];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = scan.nextInt();
		}
		Arrays.sort(numbers);
		
		for (int i : numbers) {
			System.out.printf("%d ", i);
		}
	}

}
