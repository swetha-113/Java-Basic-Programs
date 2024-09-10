abstract class BankAccount {
    protected double balance;
 
    public BankAccount(double initialBalance) {
        this.balance = initialBalance;
    }
 
    public abstract void deposit(double amount);
 
    public abstract void withdraw(double amount);
 
    public double getBalance() {
        return balance;
    }
}
 
class SavingsAccount extends BankAccount {
    private double interestRate;
 
    public SavingsAccount(double initialBalance, double interestRate) {
        super(initialBalance);
        this.interestRate = interestRate;
    }
 
    @Override
    public void deposit(double amount) {
        balance += amount;
    }
 
    @Override
    public void withdraw(double amount) {
        if (balance >= amount) {
            balance -= amount;
        } else {
            System.out.println("Insufficient funds.");
        }
    }
 
    public void addInterest() {
        double interest = balance * interestRate / 100;
        balance += interest;
    }
}
 
class CurrentAccount extends BankAccount {
    private double overdraftLimit;
 
    public CurrentAccount(double initialBalance, double overdraftLimit) {
        super(initialBalance);
        this.overdraftLimit = overdraftLimit;
    }
 
    @Override
    public void deposit(double amount) {
        balance += amount;
    }
 
    @Override
    public void withdraw(double amount) {
        if (balance + overdraftLimit >= amount) {
            balance -= amount;
        } else {
            System.out.println("Overdraft limit exceeded.");
        }
    }
}
 
public class BankAccount1{
    public static void main(String[] args) {
        SavingsAccount savingsAccount = new SavingsAccount(1000, 5);
        CurrentAccount currentAccount = new CurrentAccount(500, 200);
 
        savingsAccount.deposit(500);
        savingsAccount.addInterest();
        System.out.println("Savings Account Balance: " + savingsAccount.getBalance());
 
        currentAccount.withdraw(600);
        currentAccount.deposit(300);
        System.out.println("Current Account Balance: " + currentAccount.getBalance());
    }
}
