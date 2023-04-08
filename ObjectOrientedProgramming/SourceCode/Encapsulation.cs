namespace DefaultNamespace;

public class Encapsulation
{
    private var AccountName { get; set; }
    private int Value { get; set; }

    private int Add(int value)
    {
        return this.Value + value;
    }

    public int Addition(int value)
    {
        return Add(value);
    }
}