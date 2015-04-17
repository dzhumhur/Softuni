import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class _12CardsFrequencies {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String[] input = scan.nextLine().split("[^A-Z0-9]+");
		ArrayList<String> pairs = new ArrayList<>();
		LinkedHashMap<String,Integer> hash = new LinkedHashMap<>();
		
		for (int i = 0; i < input.length; i++) {
				pairs.add(input[i]);
		}
		
		for (int i = 0; i < pairs.size(); i++) {
			String currentCouple = pairs.get(i);
			if (!hash.containsKey(currentCouple)) {
				hash.put(pairs.get(i), 1);
			}
			else {
				int currentkeyValue = hash.get(currentCouple);
				hash.put(currentCouple, currentkeyValue + 1);
			}
		}
		double totalPairs = pairs.size();
		
		
		for (Map.Entry<String, Integer> entry : hash.entrySet()) {
            String key = entry.getKey().toString();;
            Integer value = entry.getValue();
            double percentage = (value*100) / totalPairs;
            
            System.out.printf("%s -> %.2f%%%n", key, percentage);
          }
		
	}

}
