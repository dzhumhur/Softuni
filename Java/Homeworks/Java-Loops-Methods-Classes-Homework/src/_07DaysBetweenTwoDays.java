 import java.util.Scanner;
 import org.joda.time.DateTime;
 import org.joda.time.Days;
 import org.joda.time.LocalDate;
 import org.joda.time.format.DateTimeFormat;
 import org.joda.time.format.DateTimeFormatter;

public class _07DaysBetweenTwoDays {

 public static void main(String[] args) {

	 /*  For the solution this task I used class java.org.joda.*;
	  * You can download from this link http://www.joda.org/joda-time/
	  * And then add joda-time-2.7.jar to project.
	  */
	 
	 Scanner scan = new Scanner(System.in);
	 
	 String firstDateAsString = scan.nextLine();
	 String secondDateAsString = scan.nextLine();
	 
	 DateTimeFormatter date = DateTimeFormat.forPattern("d-MM-yyyy");
	 DateTime firstDate = date.parseDateTime(firstDateAsString);
	 DateTime secondDate = date.parseDateTime(secondDateAsString);
	 int days = Days.daysBetween(new LocalDate(firstDate), 
			 new LocalDate(secondDate)).getDays();
	 
	 System.out.println(days);
   }

 }