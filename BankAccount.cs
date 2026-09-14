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
