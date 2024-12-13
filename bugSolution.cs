public class ExampleClass
{
    private int? _value; //Made the value nullable

    public int? Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void Method1()
    {
        //Some code here
        //Check for null before accessing the value
        if (_value.HasValue)
        {
            Console.WriteLine(_value.Value);
        }
        else
        {
            Console.WriteLine("Value is null");
            // Handle the null value appropriately, e.g., throw an exception, assign a default value.
        }
    }

    public void Method2()
    {
        //Some code here
        Method1();
    }
} 