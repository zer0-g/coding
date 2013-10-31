import java.util.Scanner;
 
public class MyName {
	public static void main(String[] args) {
		// Print "Enter your name: " to suggest that the user should enter their name; then go to the next line.
		System.out.println("Enter your name: ");
		// Define a String variable called "yourName" to hold any text that the user may give us
		String yourName;
 
		// Create our Scanner to read user input from System.in
        Scanner input = new Scanner(System.in);
		// Read the user input and store
        yourName = input.nextLine();
        
		// Print "Your name is: " followed by the user input, then go to the next line.
        System.out.println("Your name is: " + yourName);
		
		// Close the input because we don't need to read from it anymore, as the program is ending.
		input.close(); 
    }
}