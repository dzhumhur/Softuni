//package problems;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04Orders {
	
	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		Integer rows = Integer.parseInt(scanner.nextLine());
		
		LinkedHashMap<String, TreeMap<String, Integer>> orders = new LinkedHashMap();
		
		for (int i = 0; i < rows; i++) {
			String[] currentInputData = scanner.nextLine().split(" ");
			
			String currentCustomer = currentInputData[0];
			Integer currentQuantity = Integer.parseInt(currentInputData[1]);
			String currentProduct = currentInputData[2];
			
			if (!orders.containsKey(currentProduct)) {
				
				TreeMap<String, Integer> newPurchase = new TreeMap<>();
				newPurchase.put(currentCustomer, currentQuantity);
				orders.put(currentProduct, newPurchase);
				
			} else {
				
				TreeMap<String, Integer> currentPurchases = orders.get(currentProduct);
				
				if (!currentPurchases.containsKey(currentCustomer)) {
					
					currentPurchases.put(currentCustomer, currentQuantity);	
					orders.put(currentProduct, currentPurchases);
					
				} else {
					
					Integer quantityInMap = currentPurchases.get(currentCustomer);
					Integer newQuantity = quantityInMap + currentQuantity;
					currentPurchases.put(currentCustomer, newQuantity);
					
				}
				
				
			}
		}

		for (String product : orders.keySet()) {
			
			String output = product + ": ";
			
			TreeMap<String, Integer> purchases = orders.get(product);
			for (String customer : purchases.keySet()) {
				
				Integer quantity = purchases.get(customer);
				output += customer + " " + quantity + ", ";
				
			}
			output = output.substring(0, output.length() - 2);
			
			System.out.println(output);
			
		}
	}
}