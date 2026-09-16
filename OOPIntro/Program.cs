var account = new BankAccount("Anna", 1000);
account.ShowInfo();
account.Deposit(250);
account.Withdraw(150);
Console.WriteLine($"Saldo efter transaktioner: {account.GetBalance()} kr");

var savings = new SavingsAccount("Olle", 2000, 0.05);
savings.ApplyInterest();
Console.WriteLine($"Sparkonto efter ränta: {savings.GetBalance()} kr");
