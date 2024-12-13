public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void Method1()
    {
        //Some code here
    }

    public void Method2()
    {
        //Some code here
        Method1();
    }
}