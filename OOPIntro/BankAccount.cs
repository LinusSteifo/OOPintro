public class BankAccount
{
    public string Owner { get; set; }
    public double Balance { get; protected set; }

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Konto: {Owner}, Saldo: {Balance} kr");
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }

    public double GetBalance() => Balance;
}