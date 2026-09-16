public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string owner, double balance, double interestRate)
        : base(owner, balance)
    {
        InterestRate = interestRate;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Sparkonto: {Owner}, Saldo: {Balance} kr, Ränta: {InterestRate * 100}%");
    }

    public void ApplyInterest()
    {
        double interest = Balance * InterestRate;
        Balance += interest;
    }
}