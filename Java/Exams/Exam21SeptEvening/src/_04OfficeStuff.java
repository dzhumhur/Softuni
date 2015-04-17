import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;
/*
7
|SoftUni - 600 - paper|
|Vivacom - 600 - pen|
|XS - 20 - chair|
|Vivacom - 200 - chair|
|SoftUni - 40 - chair|
|XS - 40 - chair|
|SoftUni - 1 - printer|
*/
public class _04OfficeStuff {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int count = Integer.parseInt(scan.nextLine());
		TreeMap<String, LinkedHashMap<String, Integer>> orders = new TreeMap<>();
		for (int i = 0; i < count; i++) {
			String input = scan.nextLine();
			
			String[] inputAsArray = input.split("[^\\w0-9]+");
			String companyName = inputAsArray[1];
			int amount = Integer.parseInt(inputAsArray[2]);
			String product = inputAsArray[3];
			
			if (!orders.containsKey(companyName)) {
				LinkedHashMap<String, Integer> newPurchases = new LinkedHashMap<>();
				newPurchases.put(product, amount);
				orders.put(companyName, newPurchases);
			}else {
				LinkedHashMap<String, Integer> currentProduct = orders.get(companyName);
				if (!currentProduct.containsKey(product)) {
					currentProduct.put(product, amount);
					orders.put(companyName, currentProduct);
				}
				else {
					int newAmount = currentProduct.get(product) + amount;
					currentProduct.put(product, newAmount);
					orders.put(companyName, currentProduct);
				}
			}
		}
		
		for (String company : orders.keySet()) {
			String output = company + ": ";
			LinkedHashMap<String, Integer> outputProductAmount = orders.get(company);
			for (String products : outputProductAmount.keySet()) {
				int amount = outputProductAmount.get(products);
				output += products + "-" + amount + ", ";
			}
			output = output.substring(0, output.length() - 2);
			System.out.println(output);
		}
	}

}
