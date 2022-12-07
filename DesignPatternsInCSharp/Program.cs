using DesignPatternsInCSharp.Models;

/***
 * Example of Factory Design Pattern (Not applied patterns).
 */
/*string cardType = "MoneyBack";
ICreditCard cardDetails = null;

if (cardType == "MoneyBack")
{
    cardDetails = new MoneyBack();
}
else if (cardType == "Titanium Edge")
{
    cardDetails = new Titanium();
}
else if (cardType == "Platinum")
{
    cardDetails = new Platinum();
}

if (cardDetails != null)
{
    Console.WriteLine("CardType: " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit: " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge: " + cardDetails.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
*/

/***
 * Applied pattern to the above code.
 */

/*ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

if (cardDetails != null)
{
    Console.WriteLine("CardType: " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit: " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge: " + cardDetails.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
*/

/***
 * Applied Factory Method Design Patterns.
 */
/*ICreditCard creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("CardType: " + creditCard.GetCardType());
    Console.WriteLine("CreditLimit: " + creditCard.GetCreditLimit());
    Console.WriteLine("AnnualCharge: " + creditCard.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
Console.WriteLine("-----------------------------------------");

creditCard = new TitaniumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("CardType: " + creditCard.GetCardType());
    Console.WriteLine("CreditLimit: " + creditCard.GetCreditLimit());
    Console.WriteLine("AnnualCharge: " + creditCard.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
*/

/***
 * Abstract Factory Method.
 */

IAnimal animal = null;
AnimalFactory animalFactory = null;
string speakSound = null;

animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
Console.WriteLine("Animal Factory Type : " + animalFactory.GetType().Name);
Console.WriteLine();

animal = animalFactory.GetAnimal("Octopus");
Console.WriteLine("Animal Type : " + animal.GetType().Name);
speakSound = animal.Speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.WriteLine();

Console.WriteLine("--------------------------");
animalFactory = AnimalFactory.CreateAnimalFactory("Land");
Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
Console.WriteLine();

animal = animalFactory.GetAnimal("Lion");
Console.WriteLine("Animal Type : " + animal.GetType().Name);
speakSound = animal.Speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.WriteLine();

animal = animalFactory.GetAnimal("Cat");
Console.WriteLine("Animal Type : " + animal.GetType().Name);
speakSound = animal.Speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);

Console.ReadLine();