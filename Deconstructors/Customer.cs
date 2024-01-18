
namespace Deconstructors
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string firstName, string lastName, string email,
            string address, string city, string postalCode, string country, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            City = city;
            PostalCode = postalCode;
            Country = country;
            PhoneNumber = phoneNumber;
        }

        internal void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public void Deconstruct(out string firstName, out string lastName, out string email)
        {
            firstName = FirstName;
            lastName = LastName;
            email = Email;
        }

        public void Deconstruct(out string firstName, out string lastName, out string email,
            out string address, out string city, out string postalCode, out string country)
        {
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            address = Address;
            city = City;
            postalCode = PostalCode;
            country = Country;
        }

        public void Deconstruct(out string firstName, out string lastName, out string email,
            out string address, out string city, out string postalCode, out string country, out string phoneNumber)
        {
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            address = Address;
            city = City;
            postalCode = PostalCode;
            country = Country;
            phoneNumber = PhoneNumber;
        }
    }
}
