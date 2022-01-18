namespace FactoryMethodPatternSample;

public class Person
{
    public Person(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);

    public string FirstName { get; set; }
    public string LastName { get; set; }

    // for separation of concern and single responsibility principle, this is better inside a factory class
    //public static Person CreateNormalPerson(string firstName, string lastName) => new(firstName, lastName);
    //public static Person CreatePersonWithTitle(string title, string firstName, string lastName) => new($"{title} {firstName}", lastName);

    // for single responsibility principle
    public static class Factory
    {
        public static Person CreateNormalPerson(string firstName, string lastName) => new(firstName, lastName);
        public static Person CreatePersonWithTitle(string title, string firstName, string lastName) => new($"{title} {firstName}", lastName);
    }
}