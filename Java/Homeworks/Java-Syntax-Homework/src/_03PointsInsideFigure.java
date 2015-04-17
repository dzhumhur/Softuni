import java.util.Scanner;



public class _03PointsInsideFigure {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		double x = scan.nextDouble();
		double y = scan.nextDouble();
		
		boolean firstFigure = ((x >= 12.5) && (x <= 17.5)) && ((y <= 13.5) && (y >= 8.5));
		boolean secondFigure = ((x >= 12.5) && (x <= 22.5)) && ((y >= 6) && (y <= 8.5));
		boolean thirdFigure  = ((x >= 20) && (x <= 22.5)) && ((y >= 8.5) && (y <= 13.5));
		
		if (firstFigure || secondFigure || thirdFigure) {
			 System.out.println("Inside");
		}else {
			System.out.println("Outside");
		}
	}

}
