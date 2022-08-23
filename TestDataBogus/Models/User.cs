namespace TestDataBogus.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    internal class Address
    {
        public int City { get; set; }
        public string County { get; set; }

        public int HouseNumber { get; set; }
        public string Postcode { get; set; }
        public string StreetName { get; set; }
    }

    internal class User
    {
        public Address Address { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public string HomePhone { get; set; }
        public int Id { get; set; };
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
    }
}