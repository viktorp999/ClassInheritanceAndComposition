
namespace ClassInheritanceAndComposition.Inheritance
{
    public class Employee : Person
    {
        string job;

        public Employee(string first_name, string last_name, string job) : base(first_name,last_name)
        {
            this.job = job;
        }

        public string DisplayEmployeeInfo()
        {
            return base.DisplayInfo() + " " + job;
        }
    }
}
