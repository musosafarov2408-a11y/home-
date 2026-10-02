public class Counter
{
    public int Value {get;set;}
    public Counter(int starValue)
    {
        Value = starValue;
    }
    public Counter()
    {
        Value = 0;
    }
    public void Increase()
    {   
        Value++;   
    }
    public void Decrease()
    {
        Value--;
    }
    public void Increase(int reduce)
    {   
        if (Value >= 0)
        {
            Value+=reduce;   
        }
    }
    public void Decrease(int reduce)
    {
        if (Value >= 0)
        {
            Value-= reduce ;
        }
    }
}