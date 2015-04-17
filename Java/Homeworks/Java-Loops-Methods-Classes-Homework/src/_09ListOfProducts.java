import java.io.File;
import java.io.FileNotFoundException;
import java.util.Map.Entry;
import java.util.Scanner;
import java.util.TreeMap;


public class _09ListOfProducts {

	public static void main(String[] args) {
		
		String fileName = "Input2.txt";
		Scanner fileReader = null;
		TreeMap<Double,String> allProducts = new TreeMap<>();
		
		try {
			fileReader = new Scanner(new File(fileName));
			while (fileReader.hasNextLine()) {
				String currentLine = (fileReader.nextLine());
				String[] currentArray = currentLine.split(" ");
				
				String currentName = currentArray[0];
				double currentPrice = Double.parseDouble(currentArray[1]);
				
				Products product = new Products(currentName, currentPrice);
				allProducts.put(product.getPrice(), product.getName());
				 
			}
			for (Entry<Double, String> values : allProducts.entrySet()) {
				System.out.printf("%.2f %s\n", values.getKey(), values.getValue());
			}
		} catch (FileNotFoundException fnf) {
			System.out.println("Error");
		}
		
	}
}

class Products{
	public String name;
	public double price;
	
	public Products (String name, double price){
		this.name = name;
		this.price = price;
	}
	
	public String getName(){
		return name;
	}
	
	public void setName(String name){
		this.name = name;
	}
	
	public double getPrice(){

		return price;
	}
	
	public void setPrice(double price){

		this.price = price;
	}
	
	
}
