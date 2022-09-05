// See https://aka.ms/new-console-template for more information
using Bogus;
using Bogus.Extensions.UnitedKingdom;
using System.Text.Json;

//Randomizer.Seed = new Random(8675309);

//TODO Makes Addresses more UK based
var randomAddress = new Faker<Test_Data.Address>("en_GB")
    .RuleFor(x => x.City, x => x.Address.City())
    .RuleFor(x => x.HouseNumber, x => x.Address.BuildingNumber())
    .RuleFor(x => x.PostCode, x => x.Address.ZipCode("KY## #AW"))
    .RuleFor(x => x.Country, x => x.Address.CountryOfUnitedKingdom())
    .RuleFor(x => x.StreetName, x => x.Address.StreetName());

var RandoPerson = new Faker<Test_Data.Person>("en_GB")
    .RuleFor(x => x.FirstName, x => x.Person.FirstName)
    .RuleFor(x => x.LastName, x => x.Person.LastName)
    .RuleFor(x => x.Email, x => x.Person.Email)
    .RuleFor(x => x.HomePhone, x => x.Phone.PhoneNumberFormat(1))
    .RuleFor(x => x.Title, x => x.Name.Prefix(x.Person.Gender))
    .RuleFor(x => x.JobTitle, x => x.Name.JobTitle())
    .RuleFor(x => x.Gender, x => x.Person.Gender.ToString())
    .RuleFor(x => x.NI, x => x.Finance.Nino())
    .RuleFor(x => x.Address, x => randomAddress.Generate())
    .RuleFor(x => x.MobilePhone, x => x.Phone.PhoneNumber("07#########"))
    .RuleFor(x => x.Id, x => Guid.NewGuid());

var users = RandoPerson.Generate(12);

Console.WriteLine(JsonSerializer.Serialize(users, new JsonSerializerOptions() { WriteIndented = true }));