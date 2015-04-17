import java.util.Scanner;


public class _01VideoDurations {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine();
		int hours = 0;
		int minute = 0;
		int currentSum = 0;
		while (!input.equals("End")) {
			
			String[] currentRes = input.split(":");
			currentSum  += (Integer.parseInt(currentRes[0]) * 60);
			currentSum += Integer.parseInt(currentRes[1]);
			input = scan.nextLine();
			
		}
		hours = currentSum / 60;
		minute = currentSum % 60; 
		
		if (minute < 10) {
			System.out.printf("%d:0%d",hours,minute);
		}
		else {
			System.out.printf("%d:%d",hours,minute);
		}
		
	}

}
