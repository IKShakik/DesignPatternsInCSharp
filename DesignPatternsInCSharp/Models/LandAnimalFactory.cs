namespace DesignPatternsInCSharp.Models;

public class LandAnimalFactory : AnimalFactory
{
    public override IAnimal GetAnimal(string animalType)
    {
        if (animalType.Equals("Dog"))
        {
            return new Dog();
        }
        else if (animalType.Equals("Cat"))
        {
            return new Cats();
        }
        else if (animalType.Equals("Lion"))
        {
            return new Lion();
        }
        else
        {
            return null;
        }
    }
}