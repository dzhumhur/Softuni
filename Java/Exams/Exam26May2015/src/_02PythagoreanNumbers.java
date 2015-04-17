import java.util.Scanner;


public class _02PythagoreanNumbers {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		int count = Integer.parseInt(scan.nextLine());
		int[] numbers = new int[count];
		boolean isFind = false;
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(scan.nextLine());
		}
		
		for (int i = 0; i < numbers.length; i++) {
			for (int j = 0; j < numbers.length; j++) {
				for (int j2 = 0; j2 < numbers.length; j2++) {
					if (numbers[i] <= numbers[j]) {
						if (numbers[i] * numbers[i] + numbers[j] * numbers[j] == 
								numbers[j2] * numbers[j2]) {
							
							System.out.println(numbers[i] +"*"+numbers[i] + " + " +
								numbers[j] + "*" + numbers[j] + " = " +
									numbers[j2] +"*"+ numbers[j2]);
							isFind = true;
						}
					}
					
				}
			}
		}
		if (!isFind) {
			System.out.println("No");
		}
		
	}

}
