import java.util.Scanner;
 
public class ReadNumber {
	public static void main(String[] args) {
		// Print "Enter a number: " to suggest that the user should enter a number; then go to the next line.
		System.out.println("Enter a number: ");
		// Define a double variable called "yourNumber" to hold a decimal number that the user may give us
		double yourNumber;
 
		// Create our Scanner to read user input from System.in
        Scanner input = new Scanner(System.in);
		// Read the user input and try to convert it to a double type, then if successful, store it in the "yourNumber" variable we defined earlier
		// if this fails an error will be thrown and the application will exit immediately without running any further code
        yourNumber = input.nextDouble();
        
		// Print the number
		System.out.print(yourNumber);
		// Print " + 1 = "
        System.out.print(" + 1 = ");
		// Print the result of adding 1 to the given number, then go to the next line.
		System.out.println(yourNumber + 1);
		
		// Close the input because we don't need to read from it anymore, as the program is ending.
		input.close(); 
    }
}