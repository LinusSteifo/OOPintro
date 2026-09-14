<<<<<<< HEAD
public class BankAccount
{
    public string Owner { get; set; }
    private double balance; // privat fält — kan inte nås direkt utifrån klassen

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        this.balance = balance;
    }

    // Publik metod styr HUR pengar sätts in
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Publik metod styr HUR pengar tas ut — hindrar t.ex. negativt saldo
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }

    // Publik metod ger kontrollerad åtkomst till det privata fältet
    public double GetBalance() => balance;
}
=======
// BankAccount.cs är oförändrad (som i main)

public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string owner, double balance, double interestRate)
        : base(owner, balance) // anropar basklassens konstruktor
    {
        InterestRate = interestRate;
    }

    public void ApplyInterest()
    {
        double interest = GetBalance() * InterestRate;
        Deposit(interest);
    }
}
>>>>>>> 1d642d0 (Implementerar inheritance)
