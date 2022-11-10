
namespace ClassInheritanceAndComposition.Composition
{
    public class Fish
    {
        Eatting eat = new Eatting();
        Swimming swim = new Swimming();

        public void FishDoing()
        {
            eat.Eat();
            swim.Swim();
        }
    }
}
