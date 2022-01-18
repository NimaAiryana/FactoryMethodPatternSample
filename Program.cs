using FactoryMethodPatternSample;

Console.WriteLine("Hello, Factory Method :D");

var initedFoo = await Foo.CreateInitializedInstanceAsync();

var person = Person.Factory.CreatePersonWithTitle("Mr", "Nima", "Airyana");

Console.WriteLine($"Hi, {person.FirstName} {person.LastName} ^_^");
