// See https://aka.ms/new-console-template for more information
using Bogus;
using System.Text.Json;

//Randomizer.Seed = new Random(8675309);

var RandoPerson = new Faker<Test_Data.Person>("en_GB")
    .RuleFor(x => x.FirstName, x => x.Person.FirstName)
    .RuleFor(x => x.LastName, x => x.Person.LastName)
    .RuleFor(x => x.Email, x => x.Person.Email)
    .RuleFor(x => x.HomePhone, x => x.Phone.PhoneNumberFormat(1))
    .RuleFor(x => x.Title, x => x.Name.Prefix(x.Person.Gender))
    .RuleFor(x => x.JobTitle, x => x.Name.JobTitle())
    .RuleFor(x => x.Gender, x => x.Person.Gender.ToString())
    .RuleFor(x => x.MobilePhone, x => x.Phone.PhoneNumber("07#########"))
    .RuleFor(x => x.Id, x => Guid.NewGuid());

var users = RandoPerson.Generate(10);
Console.WriteLine(JsonSerializer.Serialize(users, new JsonSerializerOptions() { WriteIndented = true }));