namespace DefaultNamespace;
//Passing down the characters of a class to child 
public class Inheritance
{
}

public class SuperClass
    {
        private int CantBeAccessedByChild { get; set; }
        protected int CanBeAccessedByChild { get; set; }
        internal int CanBeAceesedWithinAssembly { get; set; }
        public int AccessedAnyWhere { get; set; }
        
        /* 
Yes, the protected method of a superclass can be overridden by a subclass. If the superclass method is protected, the subclass overridden method can have protected or public (but not default or private) which means the subclass overridden method can not have a weaker access specifier*/
        
    }
    public interface IInterface1
    {
        void Method();
    }

    public interface IInterface2
    {
        void Method();
    }
    public class SubClass: SuperClass,IInterface1,IInterface2
    {
        //multiple inheritance supported not for a class but for interface
        //u can define the method from interface like static and with anyaccess modifiers
        //if tow interface with same methods are inherited then we have ti define the method as 
        //public to make the code error fee else we need to use Interfacename.Methodname
        /*
         public void Method(){}
         */
        void IInterface1.Method()
        {
        }

        void IInterface2.Method()
        {
        }
    }
    