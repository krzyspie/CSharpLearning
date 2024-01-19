using Deconstructors;

var customer = new Customer("Tim", "Beam", "myemail@email.com", "WallStreet", "Paris", "12345", "Spain", "321654987");

// Deconstruct properties into fileds created before deconstruction
string firstName;
string lastName;
(firstName, lastName) = customer;
Console.WriteLine($"Customer name '{firstName} {lastName}'.");

// Deconstruct properties into fileds created during deconstruction
(string customerFirstName, string customerLastName, string email) = customer;
Console.WriteLine($"Customer name '{customerFirstName} {customerLastName}' with email: '{email}'.");

// By using '_' some properties can be omit during deconstruction
var (_, _, _, address, city, postalCode, country) = customer;
Console.WriteLine($"Customer name '{firstName} {lastName}', " +
    $"address: '{address}', city: '{city}', postal code: '{postalCode}', country: '{country}'.");

// It is also possible mix the variables declaration during deconstruction.
// In this example one variable is created before deconstruction, some are omitted and one variable is declared during the deconstraction.
string phoneNumber;
(_, _, string customerEmail, _, _, _, _, phoneNumber) = customer;
Console.WriteLine($"Customer name '{firstName} {lastName}', with contact information: email '{customerEmail}' phoneNumber '{phoneNumber}'.");