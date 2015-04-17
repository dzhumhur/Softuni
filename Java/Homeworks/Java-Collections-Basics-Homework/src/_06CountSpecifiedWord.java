import java.util.Scanner;


public class _06CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		String lookingWord = input.nextLine();
		
		String[] arrStr = str.split("\\W+");
		
		int count = 0;
		for (int i = 0; i < arrStr.length; i++) {
			if (arrStr[i].toLowerCase().equals(lookingWord)) {
				count++;
			}
		}
		System.out.println(count);

	}

}