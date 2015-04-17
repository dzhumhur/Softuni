import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map.Entry;
import java.util.Scanner;


public class _05AngleUnitConverter {

	public static double convertToRad(double number){
		double rad = Math.toRadians(number);
		return rad;
	}
	
	public static double convertToDegree(double number){
		double degree = Math.toDegrees(number);
		return degree;
	}
	
	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		
		int count = scan.nextInt();
		scan.nextLine();
		
		ArrayList<Double> number = new ArrayList<Double>();
		ArrayList<String> measure= new ArrayList<String>();
		
		for (int i = 0; i < count; i++) {
			
			String input = scan.nextLine();
			String[] inputAsArray = input.split(" ");
			
			double currentNumber = Double.parseDouble(inputAsArray[0]);
			
			String degreeOrRad = inputAsArray[1];
			
			if (degreeOrRad.equals("rad")) {
				
				number.add(convertToDegree(currentNumber));
				measure.add("deg");
			}
			else {
				
				number.add(convertToRad(currentNumber));
				measure.add("rad");
			}
		}
		
		for (int i = 0; i < number.size(); i++) {
			System.out.printf("%.6f %s",number.get(i), measure.get(i) + "\n");
		}
		
	}

}
