import java.util.ArrayList;
import java.util.Scanner;

public class Problem3 {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

		int count = Integer.parseInt(scan.nextLine());

		ArrayList<String> firstArray = new ArrayList();
		ArrayList<String> secondArray = new ArrayList();

		for (int i = 0; i < count; i++) {
			
			String[] next = scan.nextLine().trim().split("\\s+");
			String sdf = "";
			for (int j = 0; j < next.length; j++) {
				sdf += next[j] + " ";
			}
			firstArray.add(sdf);
			

		}

		for (int i = 0; i < count; i++) {

			String currentLine = scan.nextLine();
			String reverse = new StringBuffer(currentLine).reverse().toString();
			String[] next = reverse.trim().split("\\s+");
			String sdf = "";
			for (int j = 0; j < next.length; j++) {
				sdf += next[j] + " ";
			}
			secondArray.add(sdf);

		}
		ArrayList<String> result = new ArrayList();

		for (int i = 0; i < count; i++) {
			result.add(firstArray.get(i) + " " + secondArray.get(i));

		}
		String currentString = "";
		ArrayList<Integer> neznam = new ArrayList();
		for (int j = 0; j < result.size(); j++) {
			currentString = result.get(j);
			String[] stringAsArray = currentString.split(" ");
			int counter = 0;
			for (String string : stringAsArray) {
				counter++;
			}
			neznam.add(counter);
		}

		boolean isFindRazlika = false;
		int reallyCounter = 0;
		for (int i = 0; i < 1; i++) {
			for (int j = i; j < neznam.size(); j++) {
				reallyCounter += neznam.get(i) + neznam.get(j);
				if (neznam.get(i) != neznam.get(j)) {
					isFindRazlika = true;
					
				}
			}
		}
			if (isFindRazlika) {
				System.out.printf("The total number of cells is: %d",
						reallyCounter);
			} else {
				for (int i = 0; i < result.size(); i++) {

					String[] first = result.get(i).split(" ");

					System.out.print("[");
					String current = "";
					for (int j = 0; j < first.length; j++) {
						current += first[j] + ", ";
					}
					current = current.substring(0, current.length() - 2);
					System.out.println(current + "]");
					current = "";
				}
			}
		}
	}

