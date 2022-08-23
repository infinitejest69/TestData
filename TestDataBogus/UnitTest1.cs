using Bogus;
using TestDataBogus.Models;
using static Bogus.DataSets.Name;

namespace TestDataBogus
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Randomizer.Seed = new Random(667986);
            var testUsers = new Faker<User>()
                .RuleFor(u => u.Gender, f => f.PickRandom<Bogus.DataSets.Name.Gender>())
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName(u.Gender))
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName(u.Gender))
                .RuleFor(u => u.Avatar, f => f.Internet.Avatar())
                .RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(u => u.SomethingUnique, f => $"Value {f.UniqueIndex}")

                //Compound property with context, use the first/last name properties
                .RuleFor(u => u.FullName, (f, u) => u.FirstName + " " + u.LastName)
                //And composability of a complex collection.
                .RuleFor(u => u.Orders, f => testOrders.Generate(3).ToList())
                //Optional: After all rules are applied finish with the following action
                .FinishWith((f, u) =>
                {
                    Console.WriteLine("User Created! Id={0}", u.Id);
                });

            var user = testUsers.Generate();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}