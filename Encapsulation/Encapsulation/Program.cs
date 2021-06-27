using System;

namespace Encapsulation
{
    public class Department
    {
        private string departname;

        // Accessor - One that can access the underlying value
        public string GetDepartname()
        {
            return departname;
        }
        // Mutator - One that can change the underlying value
        public void SetDepartname(string a)
        {
            departname = a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.SetDepartname("\nComputer Science and Engineering");

            Console.WriteLine(department.GetDepartname());
        }
    }
}
