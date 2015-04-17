import java.util.Scanner;


public class _01MirrorNumbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		scan.nextLine();
		
		String input = scan.nextLine();
		String[] inputAsArray = input.split("\\s+");
		String currentString = "";
		boolean isFind = false;
		
		for (int i = 0; i < inputAsArray.length; i++) {
			for (int j = i + 1; j < inputAsArray.length; j++) {
//				if (inputAsArray[i].equals(inputAsArray[j])) {
//					continue;
//				}
				currentString = new StringBuilder
								(inputAsArray[j]).reverse().toString();
				
				if (inputAsArray[i].equals(currentString)) {
					System.out.println(inputAsArray[i] + "<!>" + inputAsArray[j]);
					isFind = true;
				}
			}
		}
		if (!isFind) {
			System.out.println("No");
		}
	}

}
