import java.util.ArrayList;
import java.util.Scanner;


public class _02SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		String[] inputAsArray = input.split("\\s+");
		ArrayList<String> list = new ArrayList<>();
		
		for (int i = 0; i < inputAsArray.length; i++) {
			if (list.contains(inputAsArray[i])) {
				continue;
			}
			else {
				list.add(inputAsArray[i]);
			}
		}
		
		for (String string : list) {
			for (int i = 0; i < inputAsArray.length; i++) {
				if (string.equals(inputAsArray[i])) {
					System.out.printf("%s ", string);
				}
			}
			System.out.println();
		}
	}
}
