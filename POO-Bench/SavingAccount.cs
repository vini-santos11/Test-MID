namespace POO-Bench;

public class SavingAccount : BankAccount 
{
    private double interestRate = 0.01;

    public SavingAccount(double initialBalance) : base(initialBalance) 
    {
    }

    public override void Deposit(double amount) 
    {
        base.Deposit(amount);
        balance += amount * interestRate;
    }
}