import java.util.ArrayList;
import java.util.Scanner;


public class _03Largest3Rectangles {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		ArrayList<Integer> array = new ArrayList<>();
		ArrayList<Integer> result = new ArrayList<>();
		String[] inputAsArray = scan.nextLine().trim().split("[^0-9]+");
		
		long maxSUm = Long.MIN_VALUE;

		for (int i = 0; i < inputAsArray.length; i++) {
			if (inputAsArray[i].equals("")) {
				continue;
			}
			array.add(Integer.parseInt(inputAsArray[i]));
		}
		
		for (int i = 0; i < array.size() - 1; i += 2) {
			result.add(array.get(i) * array.get(i + 1));
		}

		for (int i = 0; i < result.size() - 2; i++) {

			long first = result.get(i);
			long second = result.get(i + 1);
			long third = result.get(i + 2);
			long currentSum = first + second + third;
			if (currentSum > maxSUm) {
				maxSUm = currentSum;
			}
		}
		System.out.println(maxSUm);
	}
}