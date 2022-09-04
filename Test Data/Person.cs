namespace Test_Data
{
    public class Person
    {
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
        public string Title { get; set; }
    }
}