import java.util.Scanner;


public class _01SymmetricNumbersInRange {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int start = scan.nextInt();
		int end = scan.nextInt();
		
		for (int i = start; i <= end; i++) {
			String currentNum = "" + i;
			String reversedNum = "" + new StringBuilder(currentNum).reverse();
			if (currentNum.equals(reversedNum)) {
				System.out.print(currentNum + " ");
			}
		}
	}

}
