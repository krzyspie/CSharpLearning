using Deconstructors;

var customer = new Customer("Tim", "Beam", "myemail@email.com", "WallStreet", "Paris", "12345", "Spain", "321654987");

string firstName;
string lastName;
(firstName, lastName) = customer;
Console.WriteLine($"Customer name '{firstName} {lastName}'.");

(string customerFirstName, string customerLastName, string email) = customer;
Console.WriteLine($"Customer name '{customerFirstName} {customerLastName}' with email: '{email}'.");

var (_, _, _, address, city, postalCode, country) = customer;
Console.WriteLine($"Customer name '{firstName} {lastName}', " +
    $"address: '{address}', city: '{city}', postal code: '{postalCode}', country: '{country}'.");

string phoneNumber;
(_, _, string customerEmail, _, _, _, _, phoneNumber) = customer;
Console.WriteLine($"Customer name '{firstName} {lastName}', with contact information: email '{customerEmail}' phoneNumber '{phoneNumber}'.");