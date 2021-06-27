using System;

namespace Inheritance
{
    public class BaseClass
    {
        public void PrintMethod()
        {
            Console.WriteLine("\nEcho from Base Class");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void ChildPrintMethod()
        {
            Console.WriteLine("\nEcho from Child Class");
        }
    }

    public class HiddenClass : BaseClass
    {
        public new void PrintMethod()
        {
            Console.WriteLine("\nEcho from Newly created class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // A derived class member can serve the
            // purpose of calling a BaseClass members
            BaseClass baseClass = new DerivedClass();
            baseClass.PrintMethod();

            // Calling the DerivedClass print method
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ChildPrintMethod();

            // Calling the HiddenClass print method
            HiddenClass hiddenClass = new HiddenClass();
            hiddenClass.PrintMethod();
        }
    }
}
