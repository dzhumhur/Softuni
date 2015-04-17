package InstructionSet;

import java.util.Scanner;

public class _02InstructionSet {
    
    public static void main(String[] args) {
      // Scanner input = new Scanner(System.in);
        Scanner scan = new Scanner(System.in);
        
        String input = scan.nextLine();
        String opCode = scan.nextLine();
       
        String[] array = input.split("[\\s]+");
      
        	
            long result = 0;
            switch (array[0]) {
                case "INC": {
                    long operandOne = Long.parseLong(array[1]);
                    result = ++operandOne;
                    break;
                }
                case "DEC": {
                    long operandOne = Long.parseLong(array[1]);
                    result = --operandOne;
                    break;
                }
                case "ADD": {
                    long operandOne  = Long.parseLong(array[1]);
                    long operandTwo = Long.parseLong(array[2]);
                    result = operandOne + operandTwo;
                    break;
                }
                case "MLA": {
                    long operandOne  = Long.parseLong(array[1]);
                    long operandTwo = Long.parseLong(array[2]);
                    result = (operandOne * operandTwo);
                    break;
                }
                default:
                    break;
            }
            
            
            System.out.println(result);
            
       
    }
}