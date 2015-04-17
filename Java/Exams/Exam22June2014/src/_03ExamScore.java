
import java.util.Scanner;
import java.util.TreeMap;

public class _03ExamScore {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

		scan.nextLine();
		scan.nextLine();
		scan.nextLine();
		String input = scan.nextLine();
		TreeMap<Integer, TreeMap<String, Double>> result = new TreeMap();

		while (!input.startsWith("-")) {

			String[] splittedInput = input.trim().split("[| ]+");

			String name = splittedInput[1] + " " + splittedInput[2];
			int examScore = Integer.parseInt(splittedInput[3]);
			double grade = Double.parseDouble(splittedInput[4]);

			if (!result.containsKey(examScore)) {
				result.put(examScore, new TreeMap<String, Double>());
			}
			if (!result.get(examScore).containsKey(name)) {
				result.get(examScore).put(name, grade);
			}
			input = scan.nextLine();
		}
		
		
		String currentName = " -> [";
		for (Integer score : result.keySet()) {
			TreeMap<String, Double> currentData = result.get(score);
			int gradesCounter = 0;
			double grades = 0;
			for (String name : currentData.keySet()) {
				currentName += "" + name + ", ";
				gradesCounter++;
				grades += currentData.get(name);
			}
			currentName = currentName.substring(0, currentName.length() - 2);
			grades /= gradesCounter;
			System.out.printf("%d%s]; avg=%.2f%n",score,currentName,grades);
			currentName = " -> [";
		}


	}
}
