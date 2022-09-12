namespace Test_Data
{
    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string HouseNumber { get; set; }
        public string PostCode { get; set; }
        public string StreetName { get; set; }
    }

    public class HtmlObject
    {
        public string Html { get; set; }
    }

    public class Person
    {
        public Address Address { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }

        public string FullName
        { get { return FirstName + " " + LastName; } }

        public string Gender { get; set; }
        public string HomePhone { get; set; }
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string NI { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
    }
}