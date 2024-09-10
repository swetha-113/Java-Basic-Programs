import java.util.Scanner;
 
class Book {
    String title;
    String author;
    double price;
    int copies;
 
    public Book(String title, String author, double price, int copies) {
        this.title = title;
        this.author = author;
        this.price = price;
        this.copies = copies;
    }
 
    public void displayDetails() {
        System.out.println("Title: " + title);
        System.out.println("Author: " + author);
        System.out.println("Price: $" + price);
        System.out.println("Copies available: " + copies);
        System.out.println();
    }
}
 
public class BookstoreInventory {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Book[] books = new Book[3];
 
        for (int i = 0; i < books.length; i++) {
            System.out.println("Enter details for book " + (i + 1));
            System.out.print("Title: ");
            String title = scanner.nextLine();
            System.out.print("Author: ");
            String author = scanner.nextLine();
            System.out.print("Price: ");
            double price = scanner.nextDouble();
            scanner.nextLine(); // Consume the newline character
            System.out.print("Copies available: ");
            int copies = scanner.nextInt();
            scanner.nextLine(); // Consume the newline character
 
            books[i] = new Book(title, author, price, copies);
        }
 
        System.out.println("\nBook Details:");
        for (Book book : books) {
            book.displayDetails();
        }
    }
}
