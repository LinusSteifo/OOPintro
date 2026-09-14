public class BankAccount
{
    public string Owner { get; set; }
    public double Balance { get; set; }
    private double balance; // privat fält — kan inte nås direkt utifrån klassen

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Konto: {Owner}, Saldo: {Balance} kr");
    }
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