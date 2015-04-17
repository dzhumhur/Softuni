import java.util.LinkedHashMap;
import java.util.Map.Entry;
import java.util.Scanner;
import java.util.TreeMap;


public class Problem1 {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String input = scan.nextLine().replace("=", " ").replace("'", "");
		TreeMap<String, LinkedHashMap<String, Integer>> orders = new TreeMap();
		while (!input.equals("end")) {
			
			String[] inputAsArray = input.split("[\\s]+");
			String userName;
			String iP;
			String message;
			if (inputAsArray.length == 5) {
				userName = inputAsArray[4];
				iP = inputAsArray[1];
				message = "a";
			}
			else{
				userName = inputAsArray[5];
				iP = inputAsArray[1];
				message = inputAsArray[3];
			}
			
			
			
			if (!orders.containsKey(userName)) {
				LinkedHashMap<String, Integer> currIPAndMsg = new LinkedHashMap();
				currIPAndMsg.put(iP, 1);
				orders.put(userName, currIPAndMsg);
			}else {
				LinkedHashMap<String, Integer> currentIP = 
						orders.get(userName);
				if (!currentIP.containsKey(iP)) {
					currentIP.put(iP, 1);
					orders.put(userName, currentIP);
				}else {
					int msg = currentIP.get(iP);
					currentIP.put(iP, msg+1);
					orders.put(userName, currentIP);
				}
			}
			input = scan.nextLine().replace("=", " ").replace("'", "");
		}
		
		for (String user : orders.keySet()) {
			String output = "";
			System.out.println(user + ":");
			LinkedHashMap<String, Integer> outputIP = orders.get(user);
			for (String ip : outputIP.keySet()) {
				String currentIp = ip;
				int counter = outputIP.get(ip);
//				for (Entry<String, String> string : outputIP.entrySet()) {
//					counter++;
//				}
				//int msgCounter = outputIP.get(ip);
				output += currentIp + " => "  + counter + ", ";
				
			//	int counter = 0;
//				for (Entry<String, String> msgCounts : outputIP.entrySet()) {
//					counter++;
//				}
				
				
				
			}
			output = output.substring(0, output.length() - 2);
			System.out.println(output + ".");
			
			
		}
		
	}

}
