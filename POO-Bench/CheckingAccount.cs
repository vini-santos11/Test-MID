namespace POO-Bench;

public class CheckingAccount : BankAccount {
    private double overdraftLimit = 100;

    public CheckingAccount(double initialBalance) : base(initialBalance) 
    {
    }

    public double GetOverdraftLimit() 
    {
        return overdraftLimit;
    }

    public override void Withdraw(double amount) 
    {
        if(balance + overdraftLimit >= amount) {
            balance -= amount;
        } else {
            throw new Exception("Insufficient funds");
        }
    }
}