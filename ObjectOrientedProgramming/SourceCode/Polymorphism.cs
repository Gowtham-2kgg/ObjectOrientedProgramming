namespace DefaultNamespace;

public class Polymorphism
{
    //Looks same but diferent in behaviour
    //runtime-late binding- operator overriding
    //compile time - early binding - operator overloading
    //also acheived by interface
}

public interface IPolymorphism
{
    void Polymorphiam();
}

public class ExampleOne : IPolymorphism
{
    public void Polymorphian()
    {
        
    }
}
public class ExampleTwo : IPolymorphism
{
    public void Polymorphian()
    {
        
    }
}

public class SuperClassPoly
{
    public void Add(int a, int b)
    {
        a = a + b;
    }

    public void Add(float 1, float b)
    {
        a = a + b;
    }

    public virtual void Sub(int a, int b)
    {
        a = a - b;
    }
}

public class SubClassPoly : SuperClassPoly
{
    public override void Sub(int a, int b)
    {
        base.Sub(a, b);
    }
}
