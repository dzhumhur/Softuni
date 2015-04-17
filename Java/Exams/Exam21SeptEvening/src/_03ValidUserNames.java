import java.util.ArrayList;
import java.util.Scanner;


public class _03ValidUserNames {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		String[] inputAsArray = input.split("[^A-Za-z0-9_]+");
		ArrayList<String> list = new ArrayList<String>();
		int maxLength = Integer.MIN_VALUE;
		for (int i = 0; i < inputAsArray.length; i++) {
			String curentName = inputAsArray[i];
			if ((curentName.startsWith("0") || curentName.startsWith("1")||
					curentName.startsWith("2") || curentName.startsWith("3") ||
					curentName.startsWith("4") || curentName.startsWith("5")||
					curentName.startsWith("6") || curentName.startsWith("7")||
					curentName.startsWith("8") || curentName.startsWith("9")) || 
					(curentName.length() < 3 || curentName.length() > 25)
					) {
				continue;
			}
			else {
					list.add(curentName);
				}
			}
		
		String first = "";
		String second = "";
		for (int i = 0; i < list.size() - 1; i++) {
				if ((list.get(i).length() < 25) && 
					(list.get(i + 1).length() < 25)){
					
					if (list.get(i).length() + list.get(i + 1).length() > maxLength) {
						maxLength = list.get(i).length() + list.get(i + 1).length();
						first = list.get(i);
						second = list.get(i + 1);
					}
				}
		}
		System.out.println(first + "\n" + second);
	}
}
