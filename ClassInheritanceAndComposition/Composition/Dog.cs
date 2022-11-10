
namespace ClassInheritanceAndComposition.Composition
{
    public class Dog
    {
        Eatting eat = new Eatting();
        public void DogDoing()
        {
            eat.Eat();
        }
    }
}
