ublic class BankAccount
{
    public string Owner { get; set; }
    public double Balance { get; set; }

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Konto: {Owner}, Saldo: {Balance} kr");
    }
<<<<<<< HEAD
}
>>>>>>> 1d642d0 (Implementerar inheritance)
=======
}
>>>>>>> bd8d9f0 (inheritance)
