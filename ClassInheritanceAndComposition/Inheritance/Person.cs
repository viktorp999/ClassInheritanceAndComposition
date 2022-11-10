
namespace ClassInheritanceAndComposition.Inheritance
{
    public class Person
    {
        public string first_name;
        public string last_name;

        public Person(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
        }

        public string DisplayInfo()
        {
            return first_name + " " + last_name;
        }
    }
}
