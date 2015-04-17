import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;


public class _08SumNumbersFromTextFile {

	public static void main(String[] args) throws FileNotFoundException {
		
		String fileName = "Input.txt";
		Scanner fileReader = null;
		int sum = 0;
		
		try {
			fileReader = new Scanner(new File(fileName));
			while (fileReader.hasNextLine()) {
				int currentNumber = Integer.parseInt(fileReader.nextLine());
				sum += currentNumber; 
			}
			System.out.println(sum);
		} catch (FileNotFoundException fnf) {
			System.out.println("Error");
		}
		
		
	}

}
