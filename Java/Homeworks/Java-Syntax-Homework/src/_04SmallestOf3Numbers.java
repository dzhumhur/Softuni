import java.util.Scanner;


public class _04SmallestOf3Numbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		double a = scan.nextDouble();
		double b = scan.nextDouble();
		double c = scan.nextDouble();
		
		double min = Double.MAX_VALUE;
		
		min = printSmallNumber(a, b, c, min);
			
		System.out.println(min);

	}

	private static double printSmallNumber(double a, double b, double c,
			double min) {
		if (a < min) {
			min = a;
		}
		
		if (b < min) {
			min = b;
		}
		
		if (c < min) {
			min = c;
		}
		return min;
	}

}
