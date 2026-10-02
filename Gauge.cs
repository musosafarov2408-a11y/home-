public class Gauge
{
    public int Value { get; set; }
    public Gauge()
    {
        Value = 0;
    }
    public void Increase()
    {
        if (Value <= 5)
        {
            Value++;
        }
    }
    public void Decrease()
    {
        if (Value > 0)
        {
            Value--;
        }
    }
    public bool Full()
    {
        if (Value == 5)
        {
            return true;
        }
        return false;
    }
}