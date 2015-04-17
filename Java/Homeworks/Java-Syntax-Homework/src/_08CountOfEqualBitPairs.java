import java.util.Scanner;


public class _08CountOfEqualBitPairs {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		int number = scan.nextInt();
		int countOfPairs = 0;
		while(number > 0) {
			if ((number & 3) == 3 || (number & 3) == 0) {
				countOfPairs++;
			}
			number >>= 1;
		}
		System.out.println(countOfPairs);
	}

}
