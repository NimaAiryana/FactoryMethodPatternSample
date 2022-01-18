namespace FactoryMethodPatternSample
{
    internal class Foo
    {
        private Foo()
        {
            // await Task.Delay(1000); // you can't use await inside constructor
        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static async Task<Foo> CreateInitializedInstanceAsync()
        {
            var foo = new Foo();
            foo = await foo.InitAsync(); // So that the programmer does not forget to do the initialization, We use the Factory Method here
            return foo;
        }
    }
}
