namespace DefaultNamespace
{

    public class Abstraction
    {
        //Hiding Implementation Details
        //Showing only High level code
        //Avoiding Details
        //Can be acheived by two things
        //Interface and Abstract class
    }
//Interface - can be a blueprint -- those methods have to be implemented by inheriting class, also
//inheriting class can use any kind of access modifiers
//abstract class- class declared with name abstract (can have abstract method or its not mandatory) but
//can't be instantiated(can have normnal methods also static methods)
//sealed class- can be instantitated but not inherited, cn have static as well as normal methods
//static - can't be instantiated also not interited, can have only static methods and attributes

//if interface and class which is going to be inherited having same class no issue with that
    public interface Interface3
    {
        void HighLight();
        void Originals(int dinosor, int rabbit);
    }

    public abstract class AbsClass
    {
        abstract void KillerMethod(string s);

        public void add(int a, int b)
        {
            a += b;
        }
    }

    public class SubClass1 : AbsClass, Interface3
    {
        //do work
    }
}