import java.util.Scanner;


public class _07CountOfBitsOne {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		int number = scan.nextInt();
		int mask = 1;
		int counter = 0;
		for (int i = 0; i < 16; i++) {
			if ((number & mask) == 1) {
				counter++;
			}
			number >>= 1;
		}
		System.out.println(counter);
	}

}
