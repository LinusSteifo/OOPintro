public class CheckingAccount : BankAccount
{
    public CheckingAccount(string owner, double balance) : base(owner, balance) { }

    // MÅSTE implementeras — annars kompilerar det inte
    public override void ApplyMonthlyFee()
    {
        Balance -= 50; // checkingkonto har en fast månadsavgift
        Console.WriteLine($"Månadsavgift dragen. Nytt saldo: {Balance} kr");
    }
}