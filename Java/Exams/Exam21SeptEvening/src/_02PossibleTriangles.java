
import java.util.Arrays;

import java.util.Scanner;


public class _02PossibleTriangles {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine(); 
		boolean isFind = false;
		while (!input.equals("End")) {
			
			String[] inputAsArray = input.split(" ");
			
			double[] array = new double[3];
			for (int i = 0; i < 3; i++) {
				array[i]= Double.parseDouble(inputAsArray[i]);
			}
			
			Arrays.sort(array);
			
			if (array[2] < array[0] + array[1]){
				
				System.out.printf("%.2f+%.2f>%.2f%n", 
						array[0], array[1], array[2]);
				isFind = true;
			}
			input = scan.nextLine();
			
			}
			
		if (!isFind) {
			System.out.println("No");
		}
		}
		
	}


