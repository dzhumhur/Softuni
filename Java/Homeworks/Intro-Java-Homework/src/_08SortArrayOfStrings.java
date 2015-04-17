import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;


public class _08SortArrayOfStrings {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		
		int number = input.nextInt();
		input.nextLine();
		String[] strings = new String[number];
		
		for (int i = 0; i < number; i++) {
			strings[i] = input.nextLine();
		}
		
		for (int i = 0; i < strings.length - 1; i++) {
			for (int j = i + 1; j < strings.length; j++) {
				String firstString = strings[i];
				String secondString = strings[j];
				if (firstString.compareTo(secondString) > 0) {
					strings[j] = firstString;
					strings[i] = secondString;
				}
			}
		}
		
		for (String string : strings) {
			System.out.println(string);
		}
	}
}
