namespace POO-Bench;

public class BankAccount 
{
    protected double balance = 0;
    protected int agencyNumber = 0;
    protected int accountNumber = 0;

    public BankAccount(double initialBalance) 
    {
        balance = initialBalance;
    }

    public virtual void Deposit(double amount) 
    {
        balance += amount;
    }

    public virtual void Withdraw(double amount) 
    {
        if(balance >= amount) {
            balance -= amount;
        } else {
            throw new Exception("Insufficient funds");
        }
    }

    public double GetBalance()
    {
        return balance;
    }

    public int GenerateAgencyNumber() {
        Random random = new Random();
        agencyNumber = random.Next(1000, 9999);
        return agencyNumber;
    }

    public int GenerateAccountNumber() {
        Random random = new Random();
        accountNumber = random.Next(10000, 99999);
        return accountNumber;
    }
}