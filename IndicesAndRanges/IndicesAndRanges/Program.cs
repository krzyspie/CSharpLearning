string[] collection = ["first", "second", "third", "fourth", "fifth", "last"];

var lastElement = collection[^1];
Console.WriteLine(lastElement); // "last"

// var lastElementException = collection[^0]; is equivalent to collection[collection.lenght] and throws exception

var secondToLastElement = collection[^2];
Console.WriteLine(secondToLastElement); // "fifth"


// The index from end operator '^' can be also declared in a variable of Index type.
Index firstElementIndex = ^collection.Length;
var firstElement = collection[firstElementIndex];
Console.WriteLine(firstElement); // "first"


// A range specifies the start and end of a range.
// The start is included in the range but the end isn't included in the range.

string[] twoElements = collection[1..3]; // contains: "second", "third"
string[] allElements = collection[..]; // contains: "first", "second", "third", "fourth", "fifth", "last"
string[] firstThreeElements = collection[..-3]; // contains: "first", "second", "third"
string[] lastThreeElements = collection[3..]; // contains: "fourth", "fifth", "last"
string[] lastTwoElements = collection[^2..]; // contains: "fifth", "last"

DisplayCollectionElements(twoElements);
DisplayCollectionElements(allElements);
DisplayCollectionElements(firstThreeElements);
DisplayCollectionElements(lastThreeElements);
DisplayCollectionElements(lastTwoElements);

// Ranges same as indices can be declared as variable of type Range.
Range middleTwoElementsIndex = 2..4;
string[] middleTwoElements = collection[middleTwoElementsIndex]; // contains: "third", "fourth"
DisplayCollectionElements(middleTwoElements);


//string[] exception = collection[..-3]; // Negative value throws ArgumentOutOfRangeException

static void DisplayCollectionElements(string[] collection)
{
    Console.Write("\n");

    foreach (var item in collection)
	{
		Console.Write($"{item}, ");
	}
    Console.Write("\n");
}