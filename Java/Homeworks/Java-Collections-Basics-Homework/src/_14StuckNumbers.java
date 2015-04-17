import java.util.Scanner;

public class _14StuckNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		int n = input.nextInt();
		int[] array = new int[n];
		boolean find = false;

		for (int i = 0; i < n; i++) {
			array[i] = input.nextInt();
		}

		for (int i1 = 0; i1 < array.length; i1++) {

			for (int i2 = 0; i2 < array.length; i2++) {

				for (int i3 = 0; i3 < array.length; i3++) {

					for (int i4 = 0; i4 < array.length; i4++) {
						int a = array[i1];
						int b = array[i2];
						int c = array[i3];
						int d = array[i4];
						boolean notEqual = (a != b) && (a != c) && (a != d)
								&& (c != b) && (b != d) && (c != d);

						if (notEqual) {
							String leftPart = "" + a + b;
							String rightPart = "" + c + d;
							if (leftPart.equals(rightPart)) {
								find = true;
								System.out.println(a + "|" + b + "==" + c + "|"
										+ d);
							}

						}
					}

				}
			}
		}
		if (!find) {
			System.out.println("No");
		}
	}
}
