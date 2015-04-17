package Substring;

import java.util.Scanner;

public class _04Substring {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String text = input.nextLine();
        int jump = Integer.parseInt(input.nextLine());

       // char search = 'р';
        boolean hasMatch = false;

        for (int i = 0; i < text.length(); i++) {
        	char currentChar = text.charAt(i);
            if (currentChar == 'p') {
                hasMatch = true;

                //int endIndex = jump;
                
                int endIndex = i + jump + 1;

                if (endIndex >= text.length()) {
                    endIndex = text.length();
                }
//                String matchedString = "";
//                for (int j = i; j <= i + endIndex; j++) {
//                	if (j  <= text.length() - 1) {
//                		matchedString += text.charAt(j);
//					}
//					
//				}
                String matchedString = text.substring(i, endIndex);
               	System.out.println(matchedString);
                
                i += jump;
            }
        }

        if (!hasMatch) {
            System.out.println("no");
        }
    }
}
