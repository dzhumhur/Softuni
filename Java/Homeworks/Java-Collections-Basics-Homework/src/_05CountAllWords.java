import java.util.Scanner;
 
public class _05CountAllWords {
 
        public static void main(String[] args) {
                Scanner sc = new Scanner(System.in);
               
                String input = sc.nextLine();
                String[] strArr = input.split("\\W+");
 
                System.out.println(strArr.length);
        }
}