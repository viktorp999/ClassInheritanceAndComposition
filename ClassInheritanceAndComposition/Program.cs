using System;
using ClassInheritanceAndComposition.Inheritance;
using ClassInheritanceAndComposition.Composition;

namespace ClassInheritanceAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Viktor", "Petrovski", "Developer");
            Dog dog = new Dog();
            Fish fish = new Fish();

            Console.WriteLine("Employee: " + emp.DisplayEmployeeInfo());
            Console.WriteLine();
            Console.WriteLine("Dog is: ");
            dog.DogDoing();
            Console.WriteLine();
            Console.WriteLine("Fish is ");
            fish.FishDoing();
            Console.ReadLine();
        }
    }
}
