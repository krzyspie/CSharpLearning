using RefReturn;

TestClass obj = new();

// Get reference
ref int result = ref obj.GetZ();
Console.WriteLine(result);

result = 33;

// Get value
int zValue = obj.GetZ();
Console.WriteLine(zValue);


zValue = 44;
Console.WriteLine(zValue);
Console.WriteLine(obj.GetZ());