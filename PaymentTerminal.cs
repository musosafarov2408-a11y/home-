public class PaymentTerminal
{
    public void Lunch(PaymentCatd card,double amount)
    {
        if (card.Balance >= amount)
        {
            card.Balance -= amount;
        }
    }
    public void Add(PaymentCatd card,double amount)
    {
        card.AddMoney(amount);
    }

}