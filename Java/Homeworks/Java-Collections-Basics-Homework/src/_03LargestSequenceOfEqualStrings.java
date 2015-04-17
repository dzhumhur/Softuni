//import java.util.Scanner;
//
//
//public class _03LargestSequenceOfEqualStrings {
//
//	public static void main(String[] args) {
//	
//		Scanner scan = new Scanner(System.in);
//		
//		String input = scan.nextLine();
//		String[] inputAsArray = input.split("\\s+");
//		
//		
//	}
//}

import java.util.Scanner;
 
public class _03LargestSequenceOfEqualStrings {
 
        public static void main(String[] args) {
                Scanner sc = new Scanner(System.in);
               
                int count = 1;
                int max = 1;
       
                String input = sc.nextLine();
                String[] strArr = input.split(" ");
                String largest = strArr[0];
               
 
                for (int i = 1; i < strArr.length; i++) {
                    if (strArr[i].equals(strArr[i - 1])) {
                        count++;
                        if (count > max) {
                            max = count;
                            largest = strArr[i];
                        }
                    } else {
                        count = 1;  
                    }
                }
 
                for (int i = 0; i < max; i++) {
                        System.out.print(largest + " ");
                }
        }
 
}