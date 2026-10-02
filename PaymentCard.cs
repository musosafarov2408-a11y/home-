public class PaymentCatd
{
    public double Balance {get;set;}
    public PaymentCatd (double balance)
    {
        Balance = balance;
    }
    public void AddMoney(double amount)
    {
        Balance += amount;
    }
    public void TakeMoney(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
    }
}