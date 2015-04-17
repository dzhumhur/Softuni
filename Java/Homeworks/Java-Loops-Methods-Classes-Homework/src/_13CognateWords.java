
import java.util.HashSet;
import java.util.Scanner;


public class _13CognateWords {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		String[] inputAsArray = input.trim().split("[\\d\\W]+");
		HashSet<String> result = new HashSet<String>();
		boolean isFind = false;
		
		for (int i = 0; i < inputAsArray.length; i++) {
			for (int j = 0; j < inputAsArray.length; j++) {
				for (int j2 = 0; j2 < inputAsArray.length; j2++) {
					if (i != j) {
						
						if ((inputAsArray[i] + inputAsArray[j]).equals(inputAsArray[j2])) {
							String currentResult = inputAsArray[i] + "|" + inputAsArray[j] +
													"=" + inputAsArray[j2]; 
							isFind = true;
							result.add(currentResult);
						}
					}
				}
			}
		}
		if (!isFind) {
			System.out.println("No");
		}else{
			for (String string : result) {
				System.out.println(string);
			}
		}
	}

}
