using System;

namespace Polymorphism
{
    public class BaseClass
    {
        // The Original PrintMethod() - This will get Hidden by the DerivedHiddenClass
        public virtual void PrintMethod()
        {
            Console.WriteLine("Echo from BaseClass");
        }
    }

    public class DerivedClass : BaseClass
    {
        // Overriden PrintMethod() which will override the PrintMethod() defined in the BaseClass
        public override void PrintMethod()
        {
            // This will invoke the PrintMethod() defined in BaseClass
            // We can achieve this by the "using" keyword. 
            base.PrintMethod();

            Console.WriteLine("\nEcho from DerivedClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // This will invoke the Overriden PrintMethod() defined in the DerivedClass
            BaseClass baseClass = new DerivedClass();
            baseClass.PrintMethod();
        }
    }
}
