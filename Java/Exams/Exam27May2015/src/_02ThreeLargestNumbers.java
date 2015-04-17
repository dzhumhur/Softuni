import java.math.BigDecimal;
import java.util.Arrays;
import java.util.Scanner;

public class _02ThreeLargestNumbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

		int n = Integer.parseInt(scan.nextLine());
		BigDecimal[] array = new BigDecimal[n];

		for (int i = 0; i < array.length; i++) {
			array[i] = new BigDecimal(scan.nextLine());
		}
		
		Arrays.sort(array);
		
		if (n == 1) {
			System.out.println(array[0]);
		} else if (n < 3) {
			System.out.println(array[1].toPlainString());
			System.out.println(array[0].toPlainString());
		} else {
			for (int i = array.length - 1; i > array.length - 4; i--) {
				System.out.println(array[i].toPlainString());
			}
		}

	}

}
