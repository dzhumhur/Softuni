import java.util.Scanner;


public class _06FormattingNumbers {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		int firstNumber = scan.nextInt();
		float secondNumber = scan.nextFloat();
		float thirdNumber = scan.nextFloat();
		
		String hex = Integer.toHexString(firstNumber).toUpperCase();
		
		String convNumtoBin = Integer.toBinaryString(firstNumber);
		String bin = String.format("%10s", convNumtoBin).replace(' ', '0');
		System.out.printf("|%-10s|%s|%10.2f|%-10.3f|",
				hex,bin,secondNumber,thirdNumber);
		
		
	}

}
