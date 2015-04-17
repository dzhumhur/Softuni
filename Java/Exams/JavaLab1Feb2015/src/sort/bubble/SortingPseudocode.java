package sort.bubble;


import java.util.ArrayList;
import java.util.Scanner;

//import org.apache.commons.lang.time.StopWatch;

public class SortingPseudocode {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] numbers = scan.nextLine().replace("[", "").replace("]", "").split(", ");
        int[] numbersArr = new int[numbers.length];
        
        for (int i = 0; i < numbers.length; i++) {
			numbersArr[i] = Integer.parseInt(numbers[i]);
		}
        int jey=0;
      
        
        for (int i = 0; i < numbersArr.length; i++) {
        	int minValue = Integer.MAX_VALUE;
			for (int j = i; j < numbersArr.length; j++) {
				
				if (numbersArr[j] < minValue) {
					minValue = numbersArr[j];
					jey = j;
				}
				
			}
			int currentNum = numbersArr[i];
			numbersArr[i] = minValue;
			numbersArr[jey] = currentNum;
			
		}
        
        
        System.out.print("[");
        for (int i = 0; i < numbersArr.length; i++) {
			if (i < numbersArr.length - 1) {
				System.out.print(numbersArr[i] + ", ");
			}
			else if (i == numbersArr.length - 1) {
				System.out.print(numbersArr[i] + "]");
			}
		}


        //TODO: Parse the numbers and add them to the list

//        StopWatch stopWatch = new StopWatch();
//        stopWatch.start();

        //TODO: Write the sorting algorithm that you use for sorting the List's elements

//        stopWatch.stop();
//        long time = stopWatch.getTime();

        //System.out.println(numbersArr);
//        System.out.println(time/1000.0);
    }
}
